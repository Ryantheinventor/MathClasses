using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;


        public Colour()
        {
            colour = 0;
        }

        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            //(00000000)(00000000)(00000000)(00000000)
            //[red][green][blue][alpha]
            UInt32 rValue = (UInt32)red << 24;
            UInt32 gValue = (UInt32)green << 16;
            UInt32 bValue = (UInt32)blue << 8;
            UInt32 aValue = (UInt32)alpha;
            colour = 0;
            //add color values into 32bit int
            colour |= rValue;
            colour |= gValue;
            colour |= bValue;
            colour |= aValue;
        }

        //resets respective color byte to 00000000 inserts new byte into that area
        #region SetRGBA
        public void SetRed(byte red)
        {
            
            colour = colour & 0x00ffffff;
            
            colour |= (UInt32)red << 24;
        }
        public void SetGreen(byte green)
        {
            //resets red byte to 00000000
            colour = colour & 0xff00ffff;
            //inserts new red byte
            colour |= (UInt32)green << 16;
        }
        public void SetBlue(byte blue)
        {
            colour = colour & 0xffff00ff;
            colour |= (UInt32)blue << 8;
        }

        public void SetAlpha(byte alpha)
        {
            colour = colour & 0xffffff00;
            colour |= (UInt32)alpha;
        }
        #endregion

        //pulls respective color byte out of the 32bit color and returns as a byte
        #region GetRGBA
        public byte GetRed()
        {
            return (byte)((colour & 0xff000000) >> 24);
        }

        public byte GetGreen()
        {
            return (byte)((colour & 0x00ff0000) >> 16);
        }

        public byte GetBlue()
        {
            return (byte)((colour & 0x0000ff00) >> 8);
        }

        public byte GetAlpha()
        {
            return (byte)((colour & 0x000000ff));
        }
        #endregion
    }
}
