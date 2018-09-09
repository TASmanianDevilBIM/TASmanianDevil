using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Building Data
    /// </summary>  
    public class BuildingData
    {
        private TSD.BuildingData pBuildingData;

        internal BuildingData(TSD.BuildingData BuildingData)
        {
            pBuildingData = BuildingData;
        }

        /// <summary>
        /// Gets TAS Annual Building Result
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="TSDBuildingArray">TSD Building Array</param>
        /// <returns name="Data">TAS Data</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Annual Building Result, tas, tsddocument, tsddocument AnnualBuildingResult, annualbuildingresult
        /// </search>
        public static object AnnualBuildingResult(BuildingData BuildingData, TSDBuildingArray TSDBuildingArray)
        {
            return BuildingData.pBuildingData.GetAnnualBuildingResult((int)TSDBuildingArray);
        }

        /// <summary>
        /// Gets TAS Annual Building Result
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="Index">TSD Data Index</param>
        /// <returns name="Data">TAS Data</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Annual Building Result, tas, tsddocument, tsddocument AnnualBuildingResult, annualbuildingresult
        /// </search>
        public static object AnnualBuildingResult(BuildingData BuildingData, int Index)
        {
            return BuildingData.pBuildingData.GetAnnualBuildingResult(Index);
        }

        /// <summary>
        /// Gets GUID of Building Result
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <returns name="GUID">GUID</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Building Result GUID, tas, tsddocument, tsddocument GUID
        /// </search>
        public static string GUID(BuildingData BuildingData)
        {
            return BuildingData.pBuildingData.GUID;
        }

        /// <summary>
        /// Gets zone data from Building Data  (starting from 1)
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="Index">Index</param>
        /// <returns name="ZoneData">Zone Data</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Zone Data, getzonedata, GetZoneData
        /// </search>
        public static ZoneData GetZoneData(BuildingData BuildingData, int Index)
        {
            return new ZoneData(BuildingData.pBuildingData.GetZoneData(Index));
        }

        /// <summary>
        /// Gets Zones Data
        /// </summary>
        /// <param name="BuildingData">TSD Building Design Data</param>
        /// <returns name="ZonesData">Zones Data</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Building Data ZoneData, tas, tsddocument, buildingdata, ZonesData, zonesdata, Zones Data, zones data
        /// </search>
        public static List<ZoneData> ZonesData(BuildingData BuildingData)
        {
            List<ZoneData> aResult = new List<ZoneData>();

            int aIndex = 1;
            TSD.ZoneData aZoneData = BuildingData.pBuildingData.GetZoneData(aIndex);
            while (aZoneData != null)
            {
                aResult.Add(new ZoneData(aZoneData));
                aIndex++;
                aZoneData = BuildingData.pBuildingData.GetZoneData(aIndex);
            }

            return aResult;
        }

        /// <summary>
        /// Gets number of zones fro the building data
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <returns name="Count">Zone count</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Building Result Zone Count, tas, tsddocument, tsddocument zone count, zonecount, ZoneCount
        /// </search>
        public static int ZoneCount(BuildingData BuildingData)
        {
            return BuildingData.pBuildingData.zoneCount;
        }

        /// <summary>
        /// Gets Hourly Building Result
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="Hour">Hour</param>
        /// <param name="TSDBuildingArray">TSD Building Array</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Building Result GUID, tas, tsddocument, tsddocument GUID
        /// </search>
        public static float HourlyBuildingResult(BuildingData BuildingData, int Hour, TSDBuildingArray TSDBuildingArray)
        {
            return BuildingData.pBuildingData.GetHourlyBuildingResult(Hour, (int)TSDBuildingArray);
        }

        /// <summary>
        /// Gets peak zone gains
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, Get Peak Zone Gains, tas, tsddocument, tsddocument, GetPeakZoneGains, Get Peak Zone Gains
        /// </search>
        public static object GetPeakZoneGains(BuildingData BuildingData, TSDZoneArray TSDZoneArray)
        {
            return BuildingData.pBuildingData.GetPeakZoneGains(new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZonesData">TSD Zones Data</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(BuildingData BuildingData, TSDZoneArray TSDZoneArray, IEnumerable<ZoneData> ZonesData)
        {
            string[] aGuids = new string[ZonesData.Count()];
            for (int i = 0; i < aGuids.Length; i++)
                aGuids[i] = ZoneData.GUID(ZonesData.ElementAt(i));

            return BuildingData.pBuildingData.GetPeakZoneGroupGain(aGuids, new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gain
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroup">TSD Zone Data Group</param>
        /// <returns name="Values">Values</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, tas, tsddocument, tsddocument, GetPeakZoneGroupGain, Get Peak Zone Group Gain
        /// </search>
        public static float GetPeakZoneGroupGain(BuildingData BuildingData, TSDZoneArray TSDZoneArray, ZoneDataGroup ZoneDataGroup)
        {
            List<ZoneData> aZoneDataList = ZoneDataGroup.GetZonesData(ZoneDataGroup);
            return BuildingData.pBuildingData.GetPeakZoneGroupGain(aZoneDataList.ConvertAll(x => ZoneData.GUID(x)).ToArray(), new TSDZoneArray[] { TSDZoneArray });
        }

        /// <summary>
        /// Get Peak Zone Group Gains
        /// </summary>
        /// <param name="BuildingData">TSD Building Data</param>
        /// <param name="TSDZoneArray">TSD Zone Array</param>
        /// <param name="ZoneDataGroups">TSD Zone Data Groups</param>
        /// <returns name="ZoneDataGroupNames">Zone Data Group Names</returns>
        /// <returns name="Gains">Sum of gains</returns>
        /// <returns name="Indexes">Indexes</returns>
        /// <search>
        /// TAS, TSDDocument, TSDDocument, BuildingData, tas, tsddocument, tsddocument, GetPeakZoneGroupGains, Get Peak Zone Group Gains
        /// </search>
        [MultiReturn(new[] { "ZoneDataGroupNames", "Gains", "Indexes" })]
        public static Dictionary<string, object> GetPeakZoneGroupGains(BuildingData BuildingData, TSDZoneArray TSDZoneArray, List<ZoneDataGroup> ZoneDataGroups)
        {
            List<string> aValues = new List<string>();
            foreach (ZoneDataGroup aZoneDataGroup in ZoneDataGroups)
            {
                string aValue = ZoneDataGroup.Name(aZoneDataGroup);
                foreach (ZoneData aZoneData in ZoneDataGroup.GetZonesData(aZoneDataGroup))
                    aValue += ":" + ZoneData.GUID(aZoneData);

                aValues.Add(aValue);
            }

            object[,] aResults = BuildingData.pBuildingData.GetPeakZoneGroupGains(aValues.ToArray(), new TSDZoneArray[] { TSDZoneArray }) as object[,];
            List<List<object>> aListList = new List<List<object>>();
            for(int i = 0; i < aResults.GetLength(0); i++)
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

    /// <summary>
    /// TAS TSD Building Array
    /// </summary>  
    public enum TSDBuildingArray
    {
        /// <summary>External Humidity</summary>
        ExternalHumidity = 1,
        /// <summary>External Temperature</summary>
        ExternalTemperature = 2,
        /// <summary>Global Radiation</summary>
        GlobalRadiation = 3,
        /// <summary>Diffuse Radiation</summary>
        DiffuseRadiation = 4,
        /// <summary>Wind Speed</summary>
        WindSpeed = 5,
        /// <summary>Wind Direction</summary>
        WindDirection = 6,
        /// <summary>Heating Profile</summary>
        HeatingProfile = 7,
        /// <summary>Cooling Profile</summary>
        CoolingProfile = 8,
        /// <summary>Addition Profile</summary>
        AdditionProfile = 9,
        /// <summary>Removal Profile</summary>
        RemovalProfile = 10,
        /// <summary>Cloud Cover</summary>
        CloudCover = 11
    }
}
