using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Cooling Design Day
    /// </summary>
    public class CoolingDesignDay
    {
        private TBD.CoolingDesignDay pCoolingDesignDay;

        internal CoolingDesignDay(TBD.CoolingDesignDay CoolingDesignDay)
        {
            pCoolingDesignDay = CoolingDesignDay;
        }

        /// <summary>
        /// TBD Cooling Design Day Description
        /// </summary>
        /// <param name="CoolingDesignDay">Cooling Design Day</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, CoolingDesignDay, Description, coolingdesignday, description, Cooling Design Day, cooling design day
        /// </search>
        public static string Description(CoolingDesignDay CoolingDesignDay)
        {
            return CoolingDesignDay.pCoolingDesignDay.description;
        }

        /// <summary>
        /// TBD Cooling Design Day Name
        /// </summary>
        /// <param name="CoolingDesignDay">Cooling Design Day</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, CoolingDesignDay, Name, coolingdesignday, name, Cooling Design Day, cooling design day
        /// </search>
        public static string Name(CoolingDesignDay CoolingDesignDay)
        {
            return CoolingDesignDay.pCoolingDesignDay.name;
        }

        /// <summary>
        /// TBD Cooling Design Day GUID
        /// </summary>
        /// <param name="CoolingDesignDay">Cooling Design Day</param>
        /// <returns name="GUID">GUID</returns>
        /// <search>
        /// TAS, CoolingDesignDay, GUID, coolingdesignday, guid, Cooling Design Day, cooling design day
        /// </search>
        public static string GUID(CoolingDesignDay CoolingDesignDay)
        {
            return CoolingDesignDay.pCoolingDesignDay.GUID;
        }

        /// <summary>
        /// Gets Design Day from Cooling Design Day
        /// </summary>
        /// <param name="CoolingDesignDay">Cooling Design Day</param>
        /// <param name="Index">Design Day Index</param>
        /// <returns name="DesignDay">Design Day</returns>
        /// <search>
        /// TAS, CoolingDesignDay, Design Day, coolingdesignday, design day, Cooling Design Day, cooling design day, getdesignday, get design day
        /// </search>
        public static DesignDay GetDesignDay(CoolingDesignDay CoolingDesignDay, int Index)
        {
            return new DesignDay(CoolingDesignDay.pCoolingDesignDay.GetDesignDay(Index));
        }

        /// <summary>
        /// Gets Design Days from Cooling Design Day
        /// </summary>
        /// <param name="CoolingDesignDay">Cooling Design Day</param>
        /// <returns name="DesignDays">Design Day List</returns>
        /// <search>
        /// TAS, CoolingDesignDay, Design Day, coolingdesignday, design day, Cooling Design Day, cooling design day, designdays, design days
        /// </search>
        public static List<DesignDay> DesignDays(CoolingDesignDay CoolingDesignDay)
        {
            List<DesignDay> aDesignDayList = new List<DesignDay>();

            int aIndex = 0;
            TBD.DesignDay aDesignDay = CoolingDesignDay.pCoolingDesignDay.GetDesignDay(aIndex);
            while (aDesignDay != null)
            {
                aDesignDayList.Add(new DesignDay(aDesignDay));
                aIndex++;
                aDesignDay = CoolingDesignDay.pCoolingDesignDay.GetDesignDay(aIndex);
            }
            return aDesignDayList;
        }
    }
}
