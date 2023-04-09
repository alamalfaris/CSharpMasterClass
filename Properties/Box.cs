using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Box
    {
        //member variable
        private int length;
        //public int width;
        private int height;
        private int volume;

        //constructor
        public Box()
        {

        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        //properties
        public int FrontSurface
        {
            get
            {
                return this.length * this.height;
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length must greater or equal to 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        //public int GetVolume()
        //{
        //    return this.length * this.height * this.width;
        //}

        //member method
        //public void DisplayInfo()
        //{
        //    Console.WriteLine($"This box have length: {length} width: {width} height: {height}");
        //}
    }
}
