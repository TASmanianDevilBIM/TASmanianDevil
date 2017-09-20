using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Day Type
    /// </summary>
    public class DayType
    {
        internal TBD.dayType pDayType;

        internal DayType(TBD.dayType DayType)
        {
            pDayType = DayType;
        }

        /// <summary>
        /// TAS Design Day Color
        /// </summary>
        /// <param name="DayType">Day Type</param>
        /// <returns name="Color">Color</returns>
        /// <search>
        /// TAS, DayType, Day Type, Colour, Color, DayTypeColour, daytypecolour, color, colour
        /// </search>
        public static DSCore.Color Color(DayType DayType)
        {
            return Generic.Utils.UIntRGBToColor( DayType.pDayType.color);
        }

        /// <summary>
        /// TAS Design Day Daylight Adjustment
        /// </summary>
        /// <param name="DayType">Day Type</param>
        /// <returns name="DaylightAdjustment">Daylight Adjustment</returns>
        /// <search>
        /// TAS, DayType, Day Type, DaylightAdjustment, DayTypeDaylightAdjustment, daytypedaylightadjustment, daylightadjustment
        /// </search>
        public static int DaylightAdjustment(DayType DayType)
        {
            return DayType.pDayType.daylightAdjustment;
        }

        /// <summary>
        /// TAS Design Day description
        /// </summary>
        /// <param name="DayType">Day Type</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, DayType, Day Type, Description, DayTypeDescription, daytypedescription, description
        /// </search>
        public static string Description(DayType DayType)
        {
            return DayType.pDayType.description;
        }

        /// <summary>
        /// TAS Design Day End Break
        /// </summary>
        /// <param name="DayType">Day Type</param>
        /// <returns name="EndBreak">End Break</returns>
        /// <search>
        /// TAS, DayType, Day Type, EndBreak, DayTypeDescription, daytypeendbreak, endbreak, End Break
        /// </search>
        public static int EndBreak(DayType DayType)
        {
            return DayType.pDayType.endBreak;
        }

        /// <summary>
        /// TAS Design Day Name
        /// </summary>
        /// <param name="DayType">Day Type</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, DayType, Day Type, Name, DayTypeDescription, daytypename, name
        /// </search>
        public static string Name(DayType DayType)
        {
            return DayType.pDayType.name;
        }
    }
}
