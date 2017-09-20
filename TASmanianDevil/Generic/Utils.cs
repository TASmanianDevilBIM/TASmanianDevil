
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.DesignScript.Runtime;
using System.Drawing;

namespace Generic
{
    [IsVisibleInDynamoLibrary(false)]
    public static class Utils
    {
        //public static uint ColorToUIntRGB(DSCore.Color Color)
        //{ColorToUInt
        //    return (uint)((Color.Alpha << 24) | (Color.Red << 16) |
        //      (Color.Green << 8) | (Color.Blue << 0));
        //}

        //public static DSCore.Color UIntRGBToColor(uint UInt)
        //{
        //    byte a = (byte)(UInt >> 24);
        //    byte r = (byte)(UInt >> 16);
        //    byte g = (byte)(UInt >> 8);
        //    byte b = (byte)(UInt >> 0);
        //    return DSCore.Color.ByARGB(a, r, g, b);
        //}

        // From .net/dynamo to a colour set back into Tas
        public static uint ColorToUIntRGB(DSCore.Color Color)
        {
            return (uint)((Color.Blue << 16) | (Color.Green << 8) | (Color.Red << 0));
        }

        // From Tas to display in .net/dynamo
        public static DSCore.Color UIntRGBToColor(uint UInt)
        {
            byte b = (byte)(UInt >> 16);
            byte g = (byte)(UInt >> 8);
            byte r = (byte)(UInt >> 0);
            return DSCore.Color.ByARGB(255, r, g, b);
        }


    }
}
