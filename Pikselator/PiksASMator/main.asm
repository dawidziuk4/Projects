.586
.xmm 

.MODEL FLAT, STDCALL


OPTION CASEMAP:NONE

INCLUDE C:\masm32\include\windows.inc 



.data
		

		 three dw 3
		 two dw 2
		
.CODE


DllEntry PROC hInstDLL:HINSTANCE, reason:DWORD, reserved1:DWORD

mov	eax, TRUE 
ret

DllEntry ENDP

PixelateASM PROC byteArray: PTR BYTE, PixelateWidth: DWORD,ImageWidth: DWORD, ImageHeight: DWORD,rowPadded: DWORD, startingY: DWORD ,threadHeight: DWORD
		LOCAL x : DWORD				;y iterator
		LOCAL y : DWORD				;x iterator
		LOCAL offset1 : DWORD		;offset to row
		LOCAL offset2 : DWORD		;offset to pixel
		LOCAL halfPxWidth : DWORD
		LOCAL imgOffset : DWORD
		LOCAL offsetSourceRow: DWORD
		LOCAL offsetSourcePixel: DWORD
		LOCAL new_b: BYTE
		LOCAL new_g: BYTE
		LOCAL new_r: BYTE

		mov imgOffset, 54
		mov new_b, 0
		mov new_g, 0
		mov new_r, 0
		mov eax, threadHeight		
		mov ebx, ImageHeight
		mov offsetSourceRow, 0
		mov offsetSourcePixel, 0
@loop:								
		cmp eax, ebx			;\ 
		jl @exit				;\
		dec eax					;	while loop for decrementing threadHeight
		mov threadHeight, eax	;/
		jmp @loop				;/
@exit:
		mov eax, startingY		;prepare for Y forloop
		mov y, eax
								;/
@yLoop:
		mov ebx, threadHeight
		mov eax, y				;\
		cmp eax, ebx			;	checking if y < threadHeight
		jg @exitY				;/

		mov eax, rowPadded		;\
		mul y					;\
		add eax, imgOffset		;	calculating offset1
		mov offset1, eax		;/

		mov x, 0
@xLoop:
		mov eax, x				;|\
		mov ebx, ImageWidth		;|\
		cmp eax, ebx			;| checking if x < ImageWidth
		jg @exitX				;|/
		mov eax, x				;\
		mul three				;\
		add eax, offset1		; calculating offset2
		mov offset2, eax		;/

		
		mov eax, PixelateWidth	;\
		div two					; calculating half of PixelateWidth
		mov halfPxWidth, eax	;/
		mov eax, threadHeight	;\
		sub eax, halfPxWidth	;\
		mov ebx, eax			;\
		mov eax, y				; checking if y < threadHeight - PixelateWidth/2
		cmp eax, ebx			;/
		jg @exitIfY				;/
		mov eax, y				;\
		cmp eax, 0				;\
		jz @skip				;\
		mov eax, y
		mov edx,0				; checking if y == 0 or y % PixelateWidth==0
		div PixelateWidth		;/
		mov eax, edx			;/
		cmp eax, 0				;/
		jnz @exitIfY			;/
@skip:
		mov eax, halfPxWidth	;\
		add eax, y				;\
		mul rowPadded			;	calculating offsetSourceRow
		add eax, imgOffset		;/
		mov offsetSourceRow, eax;/
@exitIfY:
		mov ebx, ImageWidth		;\
		sub ebx, halfPxWidth	;\
		mov eax, x				;\
		cmp eax, ebx			;\
		jg @exitIfX				;\
		mov eax, x				;\
		cmp eax, 0				;	checking if x < ImageWidth - PixelateWidth / 2 && x % PixelateWidth == 0
		jz @skip2				;/
		mov edx, 0				;/
		mov eax, x				;/
		div PixelateWidth		;/
		mov eax, edx			;/
		cmp eax, 0				;/
		jnz @exitIfX			;/
@skip2:
		mov eax, halfPxWidth		;\
		add eax, x					;\
		mul three					;	calculating offsetSourcePixel
		add eax, offsetSourceRow	;/
		mov offsetSourcePixel, eax	;/

		mov esi, byteArray			;\ calulating pointer to offSetSourcePixel
		add esi, offsetSourcePixel	;/
		movd XMM1, dword ptr [esi]	
		punpcklbw XMM1, XMM0			;unpack low-order bytes ...00 rr gg bb         -> ...0000 00rr 00gg 00bb 
        punpcklwd XMM1, XMM0			;unpack low-order words	...0000 00rr 00gg 00bb -> 00000000 000000rr 000000gg 000000bb


@exitIfX:	
		mov esi, byteArray
		add esi, offset2
										; APPLYING NEW COLORS TO BYTE RRAY	
        pextrw eax, XMM1, 0             ; Extract blue color
        cwd                             ; Convert to double
        cdq                             ; Convert to quad
        mov byte ptr [esi], al		
        inc esi                         
        pextrw eax, XMM1, 2             ; Extract green color
        cwd                             
        cdq                                           
        mov byte ptr [esi], al  
		inc esi               	 
		pextrw  eax, XMM1, 4             ; Extract red color
		cwd                              ; convert to doublword
		cdq                              ; conver to quadword     
		mov byte ptr [esi], al  
        inc esi                  
		
		inc x
		jmp @xLoop
@exitX:
		inc y
		jmp @yLoop		
@exitY:
		
		ret
PixelateASM endp
END DllEntry