using System.Runtime.InteropServices;

namespace TinyRenderer.TGA
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TGAHeader
    {
        public byte IdLength;
        public byte ColorMapType;
        public byte DataTypeCode;
        public short ColorMapOrigin;
        public short ColorMapLength;
        public byte ColorMapDepth;
        public short XOrigin;
        public short YOrigin;
        public short Width;
        public short Height;
        public byte BitsPerPixel;
        public byte ImageDescriptor;
    }
}
