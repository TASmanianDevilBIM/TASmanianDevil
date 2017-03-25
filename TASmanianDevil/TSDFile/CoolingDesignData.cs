using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Cooling Design Data
    /// </summary>
    public class CoolingDesignData
    {
        private TSD.CoolingDesignData pCoolingDesignData;

        internal CoolingDesignData(TSD.CoolingDesignData CoolingDesignData)
        {
            pCoolingDesignData = CoolingDesignData;
        }

        /// <summary>
        /// Gets TAS Cooling Design Data Description
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <returns name="Description">TAS Cooling Design Data Description</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data Description, tas, tsddocument, CoolingDesignData, coolingdesigndata
        /// </search>
        public static string Description(CoolingDesignData CoolingDesignData)
        {
            return CoolingDesignData.pCoolingDesignData.description;
        }

        /// <summary>
        /// Gets TAS Cooling Design Data Name
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <returns name="Name">TAS Cooling Design Data Name</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data Name, tas, tsddocument, CoolingDesignData, coolingdesigndata
        /// </search>
        public static string Name(CoolingDesignData CoolingDesignData)
        {
            return CoolingDesignData.pCoolingDesignData.name;
        }

        /// <summary>
        /// Gets TAS Cooling Design Data GUID
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <returns name="Name">TAS Cooling Design Data GUID</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data GUID, tas, tsddocument, CoolingDesignData, coolingdesigndata
        /// </search>
        public static string GUID(CoolingDesignData CoolingDesignData)
        {
            return CoolingDesignData.pCoolingDesignData.GUID;
        }

        /// <summary>
        /// Gets TAS Cooling Design Data First Day
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <returns name="FirstDay">TAS Cooling Design Data First Day</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data First Day, tas, tsddocument, CoolingDesignData, coolingdesigndata, FirstDay, firstday
        /// </search>
        public static int FirstDay(CoolingDesignData CoolingDesignData)
        {
            return CoolingDesignData.pCoolingDesignData.firstDay;
        }

        /// <summary>
        /// Gets Zone Data
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <param name="Index">Index</param>
        /// <returns name="ZoneData">Zone Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data ZoneData, tas, tsddocument, CoolingDesignData, coolingdesigndata, ZoneData, zonedata, Zone Data, zone data
        /// </search>
        public static ZoneData GetZoneData(CoolingDesignData CoolingDesignData, int Index = 1)
        {
            return  new ZoneData(CoolingDesignData.pCoolingDesignData.GetZoneData(Index));
        }

        /// <summary>
        /// Gets Zones Data
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <returns name="ZonesData">Zones Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, CoolingDesignData, Get Cooling Design Data ZoneData, tas, tsddocument, CoolingDesignData, coolingdesigndata, ZonesData, zonesdata, Zones Data, zones data
        /// </search>
        public static List<ZoneData> GetZonesData(CoolingDesignData CoolingDesignData)
        {
            List<ZoneData> aResult = new List<ZoneData>();

            int aIndex = 1;
            TSD.ZoneData aZoneData = CoolingDesignData.pCoolingDesignData.GetZoneData(aIndex);
            while (aZoneData != null)
            {
                aResult.Add(new ZoneData(aZoneData));
                aIndex++;
                aZoneData = CoolingDesignData.pCoolingDesignData.GetZoneData(aIndex);
            }

            return aResult;
        }
    }
}
