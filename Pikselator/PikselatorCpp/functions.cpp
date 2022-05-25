#define function _declspec(dllexport)
#include <Windows.h>
extern "C" {
	int _stdcall PixelateASM(unsigned char* bytesArray, int PixelateWidth, int ImageWidth, int ImageHeight,int rowPadded, int startingY, int threadHeight);

	function void pixelateASM(unsigned char* bytesArray, int PixelateWidth, int ImageWidth, int ImageHeight, int rowPadded, int startingY, int threadHeight)
	{
		PixelateASM(bytesArray,  PixelateWidth,  ImageWidth,  ImageHeight, rowPadded, startingY,  threadHeight);
	}
	
}