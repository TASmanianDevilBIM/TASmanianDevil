using Autodesk.DesignScript.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSDFile;

namespace Generic
{
    /// <summary>
    /// A Calculations
    /// </summary>
    public static class Calculations
    {
        /// <summary>
        /// Gets TAS Annual Building Result
        /// </summary>
        /// <param name="FilePath">TSD File Path</param>
        /// <param name="TSDZoneArray"> Zone Array</param>
        /// <param name="TSDBuildingArray">Buidling Array</param>
        /// <returns name="ZoneName"> Zone Names</returns>
        /// <returns name="ZoneNumber"> Zone Number</returns>
        /// <returns name="ZoneGUID"> Zone GUID</returns>
        /// <returns name="Indexes">Indexes</returns>
        /// <returns name="AirMovementGains">Air Movement Gains</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, BuildingData, Get Annual Building Result, tas, tsddocument, tsddocument AnnualBuildingResult, annualbuildingresult
        /// </search>
        [MultiReturn(new[] { "ZoneName", "ZoneNumber","GUID", "Indexes", "AirMovementGains", "DryBulbTemp", "ResultantTemp", "InfVentGain", "LightingGain", "EquipmentSensibleGain", "Infiltration", "EquipmentLatentGain", "OccupancyLatentGain", "HumidityRatio", "RelativeHumidity", "OccupantSensibleGain", "MaxLatentIndexList", "MaxLatentList", "MaxBuildingCooling", "MaxBuildingIndexCooling" })]
        public static Dictionary<string, object> GetResults(string FilePath, TSDZoneArray TSDZoneArray, TSDBuildingArray TSDBuildingArray)
        {
            TSDDocument aTSDDocument = new TSDDocument(FilePath, false);
            SimulationData aSimulationData = TSDDocument.SimulationData(aTSDDocument);
            CoolingDesignData aCoolingDesignData = SimulationData.CoolingDesignData(aSimulationData, 0);
            BuildingData aBuildingData = SimulationData.BuildingData(aSimulationData);
            int aCount = BuildingData.ZoneCount(aBuildingData);

            List<float> aFloatList_CoolingProfile = Functions.GetAnnualBuildingResultList(aBuildingData, (TSD.tsdBuildingArray)TSDBuildingArray);
            float aMax_CoolingProfile = float.NaN;
            int aIndex_CoolingProfile = -1;
            if (aFloatList_CoolingProfile.Count > 0)
            {
                aMax_CoolingProfile = aFloatList_CoolingProfile.Max();
                aIndex_CoolingProfile = aFloatList_CoolingProfile.IndexOf(aMax_CoolingProfile);
            }
            List<string> aStringList_ZoneName = new List<string>();
            List<int> aIntList_ZoneNumber = new List<int>();
            List<string> aIntList_ZoneGUID = new List<string>();
            List <ZoneData> aZoneDataList_Cooling = new List<ZoneData>();
            List<ZoneData> aZoneDataList_Building = new List<ZoneData>();
            for (int i = 1; i <= aCount; i++)
            {
                ZoneData aZoneData = CoolingDesignData.GetZoneData(aCoolingDesignData, i);
                aZoneDataList_Cooling.Add(aZoneData);
                aZoneData = BuildingData.GetZoneData(aBuildingData, i);
                aZoneDataList_Building.Add(aZoneData);
                aStringList_ZoneName.Add(ZoneData.Name(aZoneData));
                aIntList_ZoneNumber.Add(ZoneData.Number(aZoneData));
                aIntList_ZoneGUID.Add(ZoneData.GUID(aZoneData));
            }

            List<Tuple<ZoneData, int, float>> aTupleList = new List<Tuple<ZoneData, int, float>>();
            for (int i = 0; i < aCount; i++)
            {
                float aMax_Cooling = float.NaN;
                int aIndex_Cooling = -1;
                Functions.GetMax(aZoneDataList_Cooling[i], out aMax_Cooling, out aIndex_Cooling, (TSD.tsdZoneArray)TSDZoneArray);

                float aMax_Building = float.NaN;
                int aIndex_Building = -1;
                Functions.GetMax(aZoneDataList_Building[i], out aMax_Building, out aIndex_Building, (TSD.tsdZoneArray)TSDZoneArray);

                if (aMax_Cooling > aMax_Building)
                    aTupleList.Add(new Tuple<ZoneData, int, float>(aZoneDataList_Cooling[i], aIndex_Cooling, aMax_Cooling));
                else
                    aTupleList.Add(new Tuple<ZoneData, int, float>(aZoneDataList_Building[i], aIndex_Building, aMax_Building));


            }

            List<int> aIndexList = new List<int>();
            List<float> aAirMovementGainList = new List<float>();
            List<float> aDryBulbTempList = new List<float>();
            List<float> aResultantTemp = new List<float>();
            List<float> aInfVentGain = new List<float>();
            List<float> aLightingGain = new List<float>();
            List<float> aEquipmentSensibleGain = new List<float>();
            List<float> aInfiltration = new List<float>();
            List<float> aEquipmentLatentGain = new List<float>();
            List<float> aOccupancyLatentGain = new List<float>();
            List<float> aHumidityRatio = new List<float>();
            List<float> aRelativeHumidity = new List<float>();
            List<float> aOccupantSensibleGain = new List<float>();
            List<int> aMaxLatentIndexList = new List<int>();
            List<float> aMaxLatentList = new List<float>();


            foreach (Tuple<ZoneData, int, float> aTuple in aTupleList)
            {
                ZoneData aZoneData = aTuple.Item1;
                int aIndex = aTuple.Item2;
                float aMax = aTuple.Item3;

                int aIndex_Latent = -1;
                float aMax_Latent = float.NaN;

                Functions.GetMaxLatent(aZoneData, out aMax_Latent, out aIndex_Latent);
                aMaxLatentIndexList.Add(aIndex_Latent);
                aMaxLatentList.Add(aMax_Latent);

                aIndexList.Add(aIndex);

                float aValue = float.NaN;

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.airMovementGain);
                aAirMovementGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.dryBulbTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + 273.15, 2));
                aDryBulbTempList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.resultantTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + 273.15, 2));
                aResultantTemp.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.infVentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aInfVentGain.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.lightingGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aLightingGain.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.equipmentSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aEquipmentSensibleGain.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.infiltration);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aInfiltration.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.equipmentLatentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aEquipmentLatentGain.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupancyLatentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aOccupancyLatentGain.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.humidityRatio);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aHumidityRatio.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.relativeHumidity);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aRelativeHumidity.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupantSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aOccupantSensibleGain.Add(aValue);
            }

            TSDDocument.Close(aTSDDocument);

            return new Dictionary<string, object>
                {
                    { "ZoneName", aStringList_ZoneName},
                    { "ZoneNumber", aIntList_ZoneNumber},
                    { "ZoneGUID", aIntList_ZoneGUID},
                    { "Indexes", aIndexList},
                    { "AirMovementGains", aAirMovementGainList},
                    { "DryBulbTemp", aDryBulbTempList},
                    { "ResultantTemp", aResultantTemp},
                    { "InfVentGain", aInfVentGain},
                    { "LightingGain", aLightingGain},
                    { "EquipmentSensibleGain", aEquipmentSensibleGain},
                    { "Infiltration", aInfiltration},
                    { "EquipmentLatentGain", aEquipmentLatentGain},
                    { "OccupancyLatentGain", aOccupancyLatentGain},
                    { "HumidityRatio", aHumidityRatio},
                    { "RelativeHumidity", aRelativeHumidity},
                    { "OccupantSensibleGain", aOccupantSensibleGain},
                    { "MaxLatentIndexList", aMaxLatentIndexList},
                    { "MaxLatentList", aMaxLatentList},
                    { "MaxBuildingCooling", aMax_CoolingProfile},
                    { "MaxBuildingIndexCooling", aIndex_CoolingProfile}

                };
        }
    }

    internal static class Functions
    {
        internal static void GetMax(ZoneData ZoneData, out float Max, out int Index, TSD.tsdZoneArray ZoneArray)
        {
            Max = float.NaN;
            Index = -1;
            List<float> aFloatList = GetAnnualZoneResultList(ZoneData, ZoneArray);
            Max = aFloatList.Max();
            Index = aFloatList.IndexOf(Max);
        }

        internal static void GetMaxLatent(ZoneData ZoneData, out float Max, out int Index)
        {
            Max = float.MinValue;
            Index = -1;
            List<float> aFloatList_EquipmentLatentGain = GetAnnualZoneResultList(ZoneData, TSD.tsdZoneArray.equipmentLatentGain);
            List<float> aFloatList_OccupancyLatentGain = GetAnnualZoneResultList(ZoneData, TSD.tsdZoneArray.occupancyLatentGain);
            if (aFloatList_EquipmentLatentGain.Count > 0 && aFloatList_EquipmentLatentGain == aFloatList_OccupancyLatentGain)
            {
                for (int i = 0; i < aFloatList_EquipmentLatentGain.Count; i++)
                {
                    float aSum = aFloatList_EquipmentLatentGain[i] + aFloatList_OccupancyLatentGain[1];
                    if(aSum > Max)
                    {
                        Max = aSum;
                        Index = i;
                    }
                }
            }
        }

        internal static List<float> GetAnnualZoneResultList(ZoneData ZoneData, TSD.tsdZoneArray ZoneArray)
        {
            object aObject = ZoneData.AnnualZoneResult(ZoneData, (int)ZoneArray);
            return GetList(aObject);
        }

        internal static List<float> GetAnnualBuildingResultList(BuildingData aBuildingData, TSD.tsdBuildingArray BuildingArray)
        {
            object aObject = BuildingData.AnnualBuildingResult(aBuildingData, (int)BuildingArray);
            return GetList(aObject);
        }


        internal static List<float> GetList(object Object)
        {
            List<float> aResult = new List<float>();
            if (Object != null)
            {
                IEnumerable aValues = Object as IEnumerable;
                if (aValues != null)
                    aResult = aValues.Cast<float>().ToList();
            }
            return aResult;
        }

        internal static float GetAtIndex(ZoneData ZoneData, int aIndex, TSD.tsdZoneArray ZoneArray)
        {
            List<float> aFloatList = GetAnnualZoneResultList(ZoneData, ZoneArray);
            if (aFloatList.Count > aIndex)
                return aFloatList[aIndex];
            return float.NaN;
        }
    }
}