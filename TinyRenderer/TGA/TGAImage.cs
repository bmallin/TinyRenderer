using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TinyRenderer.TGA
{
    public class TGAImage
    {
        public enum Format
        {
            Greyscale = 1,
            RGB = 3,
            RGBA = 4,
        }

        public TGAImage()
        {
            Data = null;
            Width = 0;
            Height = 0;
            BytesPerPixel = 0;
        }

        public TGAImage(int width, int height, int bytesPerPixel)
        {
            Width = width;
            Height = height;
            BytesPerPixel = bytesPerPixel;

            Data = new byte[Width * Height * BytesPerPixel];

            for (var i = 0; i < Data.Length; i++)
            {
                Data[i] = 0;
            }
        }

        public TGAImage(TGAImage image)
        {
            Width = image.Width;
            Height = image.Height;
            BytesPerPixel = image.BytesPerPixel;

            Data = new byte[Width * Height * BytesPerPixel];

            Buffer.BlockCopy(image.Data, 0, Data, 0, Data.Length);
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public int BytesPerPixel { get; set; }

        public byte[] Data { get; private set; }

        public bool ReadFile(string filePath)
        {
            try
            {
                var header = new TGAHeader();

                using (var file = File.OpenRead(filePath))
                {
                    for (var i = 0; i < file.Length; i++)
                    {
                        file.ReadByte();
                    }
                }
            }
            catch (Exception e)
            {
                
            }
        }

        public bool WriteFile(string fileName, bool rle = true)
        {

        }

        public bool FlipHorizontally()
        {

        }

        public bool FlipVertically()
        {

        }

        public bool Scale(int width, int height)
        {

        }

        public TGAColor Get(int x, int y)
        {

        }

        public bool Set(int x, int y, TGAColor color)
        {

        }

        public void Clear()
        {

        }

        private bool LoadRLEData(Stream stream)
        {

        }

        private bool UnloadRLEData(Stream stream)
        {

        }
    }
}
