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
        /// Gets in formated way TAS Annual Building Result from TSD file and recalculate to Revit units to allow direct connection to Space parameters. Connect Zone, Building array and sorting will be performed according to connected parameters.
        /// </summary>
        /// <param name="FilePath">Connect Path.TSD File Path</param>
        /// <param name="TSDZoneArray"> Zone Array parameter - peak hour and value will be given based on this parameter all remaing values will be take at this hour</param>
        /// <param name="TSDBuildingArray">Buidling Array - peak building data bassed on given parameter</param>
        /// <returns name="ZoneName"> Zone Names</returns>
        /// <returns name="ZoneNumber"> Zone Number- recalculated if space removed from middle</returns>
        /// <returns name="ZoneGUID"> TAS internal Zone GUID - never changes</returns>
        /// <returns name="Indexes">Indexes of Hour 1-8760</returns>
        /// <returns name="HeatingLoad">The total sensible heating demand for the zone. It is measured in Watts*10.7639104167097</returns>
        /// <returns name="CoolingLoad">The total sensible cooling demand for the zone. It is measured in Watts*10.7639104167097</returns>
        /// <returns name="DryBulbTemp">The zone's dry-bulb air temperature, measured in degrees Celsius + 273.15</returns>
        /// <returns name="ResultantTemp">Resultant Temp An average of the dry-bulb temperature and the mean radiant temperature. It is displayed in degrees Celsius+ 273.15</returns>
        /// <returns name="SolarGain">The sum of the surface solar gains for all the surfaces facing into the zone.  It is measured in Watts*10.7639104167097</returns>
        /// <returns name="AirMovementGains">Air Movement Gains, Represents heat gained via inter-zone air flows, arising from specified Air Movement flows and Aperture flows. It is measured in Watts*10.7639104167097</returns>
        /// <returns name="InfVentGain">Represents the heat gained (or, if negative, lost) by the zone due to the exchange of air between the zone and the external environment. This air exchange may arise from air flows specified under Infiltration or Ventilation in the Internal Conditions, from specified Air Movement, or from Aperture Flows. It is measured in Watts *10.7639104167097</returns>
        /// <returns name="OccupantSensibleGain">This is the sensible power input from the occupants. It includes both radiant and convective portions, it is measured in Watts*10.7639104167097</returns>
        /// <returns name="LightingGain">This is the sensible power input from the lights.It includes both radiant and convective portions It is measured in Watts*10.7639104167097</returns>
        /// <returns name="EquipmentSensibleGain">This is the sensible power input from the equipment .It includes both radiant and convective portions It is measured in Watts*10.7639104167097</returns>
        /// <returns name="Infiltration">The fresh air infiltration (leakage) into the zone, expressed in kilograms per second</returns>
        /// <returns name="BuildingHeatTransfer">Represents the sum of heat gains from two sources:1-Heat entering the zone from a link, null link or internal building component. 2-Heat released into the zone which has been temporarily stored in the air (positive when the air temperature is falling, negative when it is rising). The building heat transfer is measured in Watts*10.7639104167097</returns>
        /// <returns name="ExternalConductionOpaque">This is the heat gained through the inside surfaces of opaque components exposed to the outside or touching the ground. It is measured in Watts*10.7639104167097</returns>
        /// <returns name="ExternalConductionGlazing">This is the heat gained through the inside surfaces of exposed transparent components. It is measured in Watts*10.7639104167097</returns>
        /// <returns name="EquipmentLatentGain">This is the latent load from the equipment, it is measured in Watts*10.7639104167097</returns>
        /// <returns name="OccupancyLatentGain">This is the latent load from the occupants, it is measured in Watts*10.7639104167097</returns>
        /// <returns name="HumidityRatio">The zone's humidity measured in grams of water per kilogram of air</returns>
        /// <returns name="RelativeHumidity">The zone's relative humidity. It is displayed as a percentage</returns>
        /// <returns name="MaxLatentIndexList">The zone's max latent (OccupancyLatentGain+EquipmentLatentGain) hour Index</returns>
        /// <returns name="MaxLatentList">The zone's max latent load from the occupants and equipment, it is measured in Watts*10.7639104167097</returns>
        /// <returns name="MaxBuildingLoad">The total load  over all outputted zones in the building, irrespective of output selection. It is displayed in Watts*10.7639104167097</returns>
        /// <returns name="MaxBuildingIndex">The Index Hour 1-8760 for total load  over all outputted zones in the building</returns>
        /// 
        /// <search>
        /// TAS, TBDDocument, TBDDocument, BuildingData, Get Annual Building Result, tas, tsddocument, tsddocument AnnualBuildingResult, annualbuildingresult
        /// </search>
        [MultiReturn(new[] { "ZoneName", "ZoneNumber","GUID", "Indexes", "HeatingLoad", "CoolingLoad",  "DryBulbTemp", "ResultantTemp", "SolarGain", "AirMovementGains", "InfVentGain", "LightingGain", "EquipmentSensibleGain", "Infiltration", "BuildingHeatTransfer", "ExternalConductionOpaque", "ExternalConductionGlazing", "OccupantSensibleGain", "EquipmentLatentGain", "OccupancyLatentGain", "HumidityRatio", "RelativeHumidity", "MaxLatentIndexList", "MaxLatentList", "MaxBuildingCooling", "MaxBuildingIndexCooling" })]
        public static Dictionary<string, object> GetResults_RevitUnits(string FilePath, TSDZoneArray TSDZoneArray, TSDBuildingArray TSDBuildingArray)
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
            List<float> aHeatingLoadList = new List<float>();
            List<float> aCoolingLoadList = new List<float>();
            List<float> aDryBulbTempList = new List<float>();
            List<float> aResultantTempList = new List<float>();
            List<float> aSolarGainList = new List<float>();
            List<float> aAirMovementGainList = new List<float>();
            List<float> aInfVentGainList = new List<float>();
            List<float> aOccupantSensibleGainList = new List<float>();
            List<float> aLightingGainList = new List<float>();
            List<float> aEquipmentSensibleGainList = new List<float>();
            List<float> aInfiltrationList = new List<float>();
            List<float> aBuildingHeatTransferList = new List<float>();
            List<float> aExternalConductionOpaqueList = new List<float>();
            List<float> aExternalConductionGlazingList = new List<float>();
            List<float> aEquipmentLatentGainList = new List<float>();
            List<float> aOccupancyLatentGainList = new List<float>();
            List<float> aHumidityRatioList = new List<float>();
            List<float> aRelativeHumidityList = new List<float>();
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

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.heatingLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aHeatingLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.coolingLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aCoolingLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.dryBulbTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + 273.15, 2));
                aDryBulbTempList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.resultantTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + 273.15, 2));
                aResultantTempList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.solarGain);
                aValue = Convert.ToSingle(Math.Round(aValue + 273.15, 2));
                aSolarGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.airMovementGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aAirMovementGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.infVentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aInfVentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupantSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aOccupantSensibleGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.lightingGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aLightingGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.equipmentSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aEquipmentSensibleGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.infiltration);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aInfiltrationList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.buildingHeatTransfer);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aBuildingHeatTransferList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.externalConductionOpaque);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aExternalConductionOpaqueList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.externalConductionGlazing);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aExternalConductionGlazingList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.equipmentLatentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aEquipmentLatentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupancyLatentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 10.7639104167097, 2));
                aOccupancyLatentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.humidityRatio);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aHumidityRatioList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.relativeHumidity);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aRelativeHumidityList.Add(aValue);


            }

            TSDDocument.Close(aTSDDocument);

            return new Dictionary<string, object>
                {
                    { "ZoneName", aStringList_ZoneName},
                    { "ZoneNumber", aIntList_ZoneNumber},
                    { "ZoneGUID", aIntList_ZoneGUID},
                    { "Indexes", aIndexList},
                    { "HeatingLoad", aHeatingLoadList},
                    { "CoolingLoad", aCoolingLoadList},
                    { "DryBulbTemp", aDryBulbTempList},
                    { "ResultantTemp", aResultantTempList},
                    { "SolarGain", aSolarGainList},
                    { "AirMovementGains", aAirMovementGainList},
                    { "InfVentGain", aInfVentGainList},
                    { "OccupantSensibleGain", aOccupantSensibleGainList},
                    { "LightingGain", aLightingGainList},
                    { "EquipmentSensibleGain", aEquipmentSensibleGainList},
                    { "Infiltration", aInfiltrationList},
                    { "BuildingHeatTransfer", aBuildingHeatTransferList},
                    { "ExternalConductionOpaque", aExternalConductionOpaqueList},
                    { "ExternalConductionGlazing", aExternalConductionGlazingList},
                    { "EquipmentLatentGain", aEquipmentLatentGainList},
                    { "OccupancyLatentGain", aOccupancyLatentGainList},
                    { "HumidityRatio", aHumidityRatioList},
                    { "RelativeHumidity", aRelativeHumidityList},
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