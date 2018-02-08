using Autodesk.DesignScript.Runtime;
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
        public static List<ZoneData> ZonesData(CoolingDesignData CoolingDesignData)
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

        /// <summary>
        /// Gets peak zone gains
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, CoolingDesignData, Get Peak Zone Gains, tas, tsddocument, tsddocument, GetPeakZoneGains, Get Peak Zone Gains
        /// </search>
        public static object GetPeakZoneGains(CoolingDesignData CoolingDesignData, TSDZoneArray TSDZoneArray)
        {
            return CoolingDesignData.pCoolingDesignData.GetPeakZoneGains(new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZonesData">TSD Zones Data</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, CoolingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(CoolingDesignData CoolingDesignData, TSDZoneArray TSDZoneArray, IEnumerable<ZoneData> ZonesData)
        {
            string[] aGuids = new string[ZonesData.Count()];
            for (int i = 0; i < aGuids.Length; i++)
                aGuids[i] = ZoneData.GUID(ZonesData.ElementAt(i));

            return CoolingDesignData.pCoolingDesignData.GetPeakZoneGroupGain(aGuids, new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroup">TSD Zone Data Group</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, CoolingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(CoolingDesignData CoolingDesignData, TSDZoneArray TSDZoneArray, ZoneDataGroup ZoneDataGroup)
        {
            List<ZoneData> aZoneDataList = ZoneDataGroup.GetZonesData(ZoneDataGroup);
            return CoolingDesignData.pCoolingDesignData.GetPeakZoneGroupGain(aZoneDataList.ConvertAll(x => ZoneData.GUID(x)).ToArray(), new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gains
        /// </summary>
        /// <param name="CoolingDesignData">TSD Cooling Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroups">TSD Zone Data Groups</param>
        /// <returns name="ZoneDataGroupNames">Zone Data Group Names</returns>
        /// <returns name="Gains">Sum of gains</returns>
        /// <returns name="Indexes">Indexes</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, CoolingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGains, Get Peak Zone Group Gains
        /// </search>
        [MultiReturn(new[] { "ZoneDataGroupNames", "Gains", "Indexes" })]
        public static Dictionary<string, object> GetPeakZoneGroupGains(CoolingDesignData CoolingDesignData, TSDZoneArray TSDZoneArray, List<ZoneDataGroup> ZoneDataGroups)
        {
            List<string> aValues = new List<string>();
            foreach (ZoneDataGroup aZoneDataGroup in ZoneDataGroups)
            {
                string aValue = ZoneDataGroup.Name(aZoneDataGroup);
                foreach (ZoneData aZoneData in ZoneDataGroup.GetZonesData(aZoneDataGroup))
                    aValue += ":" + ZoneData.GUID(aZoneData);

                aValues.Add(aValue);
            }

            object[,] aResults = CoolingDesignData.pCoolingDesignData.GetPeakZoneGroupGains(aValues.ToArray(), new TSDZoneArray[] { TSDZoneArray }) as object[,];
            List<List<object>> aListList = new List<List<object>>();
            for (int i = 0; i < aResults.GetLength(0); i++)
            {
                List<object> aList = new List<object>();
                for (int j = 0; j < aResults.GetLength(1); j++)
                    aList.Add(aResults[i, j]);
                aListList.Add(aList);
            }

            return new Dictionary<string, object>
            {
                { "ZoneDataGroupNames", aListList[0]},
                { "Gains", aListList[1]},
                { "Indexes", aListList[2]}
            };
        }
    }
}
