using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pikselator.Models
{
    [StructLayout(LayoutKind.Sequential)]
    class ParametersOfImageComputing
    {
        public int ImgWidth;
        public int ImgHeight;
        public int NumOfParts;
        public int SquareSize;
        public unsafe byte* ImgByteArrayPtr;

         public override unsafe string ToString()
        {
            return string.Format(

                                 "Width: {1}; " +
                                 "Height: {2}; " +
                                 "NumOfParts: {3};" +
                                 "ImgPtr: {4}; " +
                                 "SquareSize: {5}; " +
                                 ImgWidth,
                                 ImgHeight,
                                 NumOfParts,
                                 new IntPtr(ImgByteArrayPtr).ToInt32(),
                                 SquareSize
                                 );
        }
        

    }
}
