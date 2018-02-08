using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Heating Design Data
    /// </summary>
    public class HeatingDesignData
    {
        private TSD.HeatingDesignData pHeatingDesignData;

        internal HeatingDesignData(TSD.HeatingDesignData HeatingDesignData)
        {
            pHeatingDesignData = HeatingDesignData;
        }

        /// <summary>
        /// Gets TAS Heating Design Data Description
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <returns name="Description">TAS Heating Design Data Description</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data Description, tas, tsddocument, HeatingDesignData, HeatingDesignData
        /// </search>
        public static string Description(HeatingDesignData HeatingDesignData)
        {
            return HeatingDesignData.pHeatingDesignData.description;
        }

        /// <summary>
        /// Gets TAS Heating Design Data Name
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <returns name="Name">TAS Heating Design Data Name</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data Name, tas, tsddocument, HeatingDesignData, HeatingDesignData
        /// </search>
        public static string Name(HeatingDesignData HeatingDesignData)
        {
            return HeatingDesignData.pHeatingDesignData.name;
        }

        /// <summary>
        /// Gets TAS Heating Design Data GUID
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <returns name="Name">TAS Heating Design Data GUID</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data GUID, tas, tsddocument, HeatingDesignData, HeatingDesignData
        /// </search>
        public static string GUID(HeatingDesignData HeatingDesignData)
        {
            return HeatingDesignData.pHeatingDesignData.GUID;
        }

        /// <summary>
        /// Gets TAS Heating Design Data First Day
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <returns name="FirstDay">TAS Heating Design Data First Day</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data First Day, tas, tsddocument, HeatingDesignData, HeatingDesignData, FirstDay, firstday
        /// </search>
        public static int FirstDay(HeatingDesignData HeatingDesignData)
        {
            return HeatingDesignData.pHeatingDesignData.firstDay;
        }

        /// <summary>
        /// Gets Zone Data
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <param name="Index">Index</param>
        /// <returns name="ZoneData">Zone Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data ZoneData, tas, tsddocument, HeatingDesignData, HeatingDesignData, ZoneData, zonedata, Zone Data, zone data
        /// </search>
        public static ZoneData GetZoneData(HeatingDesignData HeatingDesignData, int Index)
        {
            return new ZoneData(HeatingDesignData.pHeatingDesignData.GetZoneData(Index));
        }

        /// <summary>
        /// Gets Zones Data
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <returns name="ZonesData">Zones Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, HeatingDesignData, Get Heating Design Data ZoneData, tas, tsddocument, heatingdesigndata, ZonesData, zonesdata, Zones Data, zones data
        /// </search>
        public static List<ZoneData> ZonesData(HeatingDesignData HeatingDesignData)
        {
            List<ZoneData> aResult = new List<ZoneData>();

            int aIndex = 1;
            TSD.ZoneData aZoneData = HeatingDesignData.pHeatingDesignData.GetZoneData(aIndex);
            while (aZoneData != null)
            {
                aResult.Add(new ZoneData(aZoneData));
                aIndex++;
                aZoneData = HeatingDesignData.pHeatingDesignData.GetZoneData(aIndex);
            }

            return aResult;
        }

        /// <summary>
        /// Gets peak zone gains
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, HeatingDesignData, Get Peak Zone Gains, tas, tsddocument, tsddocument, GetPeakZoneGains, Get Peak Zone Gains
        /// </search>
        public static object GetPeakZoneGains(HeatingDesignData HeatingDesignData, TSDZoneArray TSDZoneArray)
        {
            return HeatingDesignData.pHeatingDesignData.GetPeakZoneGains(new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="HeatingDesignData">TSD HeatingDesignData</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZonesData">TSD Zones Data</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, HeatingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(HeatingDesignData HeatingDesignData, TSDZoneArray TSDZoneArray, IEnumerable<ZoneData> ZonesData)
        {
            string[] aGuids = new string[ZonesData.Count()];
            for (int i = 0; i < aGuids.Length; i++)
                aGuids[i] = ZoneData.GUID(ZonesData.ElementAt(i));

            return HeatingDesignData.pHeatingDesignData.GetPeakZoneGroupGain(aGuids, new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroup">TSD Zone Data Group</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, HeatingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(HeatingDesignData HeatingDesignData, TSDZoneArray TSDZoneArray, ZoneDataGroup ZoneDataGroup)
        {
            List<ZoneData> aZoneDataList = ZoneDataGroup.GetZonesData(ZoneDataGroup);
            return HeatingDesignData.pHeatingDesignData.GetPeakZoneGroupGain(aZoneDataList.ConvertAll(x => ZoneData.GUID(x)).ToArray(), new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gains
        /// </summary>
        /// <param name="HeatingDesignData">TSD Heating Design Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroups">TSD Zone Data Groups</param>
        /// <returns name="ZoneDataGroupNames">Zone Data Group Names</returns>
        /// <returns name="Gains">Sum of gains</returns>
        /// <returns name="Indexes">Indexes</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, HeatingDesignData, tas, tsddocument, tsddocument, GetPeakZoneGroupGains, Get Peak Zone Group Gains
        /// </search>
        [MultiReturn(new[] { "ZoneDataGroupNames", "Gains", "Indexes" })]
        public static Dictionary<string, object> GetPeakZoneGroupGains(HeatingDesignData HeatingDesignData, TSDZoneArray TSDZoneArray, List<ZoneDataGroup> ZoneDataGroups)
        {
            List<string> aValues = new List<string>();
            foreach (ZoneDataGroup aZoneDataGroup in ZoneDataGroups)
            {
                string aValue = ZoneDataGroup.Name(aZoneDataGroup);
                foreach (ZoneData aZoneData in ZoneDataGroup.GetZonesData(aZoneDataGroup))
                    aValue += ":" + ZoneData.GUID(aZoneData);

                aValues.Add(aValue);
            }

            object[,] aResults = HeatingDesignData.pHeatingDesignData.GetPeakZoneGroupGains(aValues.ToArray(), new TSDZoneArray[] { TSDZoneArray }) as object[,];
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
