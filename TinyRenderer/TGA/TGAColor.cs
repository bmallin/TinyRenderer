using System.Runtime.InteropServices;

namespace TinyRenderer.TGA
{
    public struct TGAColor
    {
        public byte B;
        public byte G;
        public byte R;
        public byte A;
        public int BytesPerPixel;

        public TGAColor(byte r = 0, byte g = 0, byte b = 0, byte a = 0, int bytesPerPixel = 1)
        {
            R = r;
            G = g;
            B = b;
            A = a;
            BytesPerPixel = bytesPerPixel;
        }

        public byte[] Raw => new[] { B, G, R, A };

        public int Value => B | (G << 8) | (R << 16) | (A << 24);
    }
}
