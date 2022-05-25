#include "threadParams.h"
#include <SDKDDKVer.h>
#include <windows.h>
#include <string>
#include <iostream>
#include <fstream>
#include <cstdlib>
#include <vector>

void pixelateCPP(ThreadParameters params)
{
	BYTE* imgOffset = params.ImgByteArrayPtr;

	imgOffset[1]=5;
	/*int rowPadded = (params.ImgWidth * 3 + 3) & (~3);
	int rowPaddedDiff = rowPadded - params.ImgWidth * 3;
	int squareSize = params.SquareSize;
	int middlePixel = squareSize / 2; 
	int currPos = 0;
	int maxY = params.ImgHeight-middlePixel;*/
	//iteration over horizonotal lines
	/*for (int y = 0; y < params.ImgHeight; y++)
	{
		int currY = y - middlePixel;

		BYTE* offset1 = imgOffset + rowPadded * currY;

		if (currY >= 0 && currY < maxY)
		{
			for (int x = 0; x < params.ImgWidth; x++)
			{
				BYTE* offset2 = offset1 + x * 3;
				double linc_b = 0;
				double linc_g = 0;
				double linc_r = 0;


			}
		}

	}*/


}
