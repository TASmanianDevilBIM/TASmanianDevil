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
    /// Data Type
    /// </summary>
    public enum DataType
    {
        /// <summary>Building Data</summary>
        BuildingData,
        /// <summary>Cooling Design Data</summary>
        CoolingDesignData,
        /// <summary>Heating Design Data</summary>
        HeatingDesignData,
    }

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
        /// <param name="ConvertUnits">Convert to Revit Internal units</param>
        /// <param name="BuildingDataOnly">Building Data Only</param>
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
        /// <returns name="LatentAdditionLoad">Latent Addition Load</returns>
        /// <returns name="LatentLoad">Latent Load</returns>
        /// <returns name="LatentRemovalLoad">Latent Removal Load</returns>
        /// <returns name="MaxBuildingLoad">The total load  over all outputted zones in the building, irrespective of output selection. It is displayed in Watts*10.7639104167097</returns>
        /// <returns name="MaxBuildingIndex">The Index Hour 1-8760 for total load  over all outputted zones in the building</returns>
        /// <returns name="DataType">Data Type for Max Value</returns>
        /// 
        /// <search>
        /// TAS, TBDDocument, TBDDocument, BuildingData, Get Annual Building Result, tas, tsddocument, tsddocument AnnualBuildingResult, annualbuildingresult
        /// </search>
        [MultiReturn(new[] { "ZoneName", "ZoneNumber", "ZoneGUID", "Indexes", "HeatingLoad", "CoolingLoad", "DryBulbTemp", "ResultantTemp", "SolarGain", "AirMovementGains", "InfVentGain", "OccupantSensibleGain", "LightingGain", "EquipmentSensibleGain", "Infiltration", "BuildingHeatTransfer", "ExternalConductionOpaque", "ExternalConductionGlazing", "EquipmentLatentGain", "OccupancyLatentGain", "HumidityRatio", "RelativeHumidity", "LatentAdditionLoad", "LatentLoad", "LatentRemovalLoad", "MaxBuildingCooling", "MaxBuildingIndexCooling", "DataType" })]
        public static Dictionary<string, object> GetZoneResults(string FilePath, TSDZoneArray TSDZoneArray, TSDBuildingArray TSDBuildingArray, bool ConvertUnits = false, bool BuildingDataOnly = false)
        {

            double aTempertureConversion = 273.15;
            double aPowerConversion = 10.7639104167097;

            if (!ConvertUnits)
            {
                aTempertureConversion = 0;
                aPowerConversion = 1;
            }

            TSDDocument aTSDDocument = new TSDDocument(FilePath, false);
            SimulationData aSimulationData = TSDDocument.SimulationData(aTSDDocument);
            CoolingDesignData aCoolingDesignData = SimulationData.CoolingDesignData(aSimulationData, 0);
            BuildingData aBuildingData = SimulationData.BuildingData(aSimulationData);
            int aCount = BuildingData.ZoneCount(aBuildingData);

            List<float> aFloatList_CoolingProfile = Functions.GetAnnualBuildingResultList(aBuildingData, (TSD.tsdBuildingArray)TSDBuildingArray);
            float aMax_CoolingProfile = float.NaN;
            int aIndex_CoolingProfile = 0;
            if (aFloatList_CoolingProfile.Count > 0)
            {
                aMax_CoolingProfile = aFloatList_CoolingProfile.Max();
                aIndex_CoolingProfile = aFloatList_CoolingProfile.IndexOf(aMax_CoolingProfile);
            }

            List<string> aStringList_ZoneName = new List<string>();
            List<int> aIntList_ZoneNumber = new List<int>();
            List<string> aIntList_ZoneGUID = new List<string>();
            List<ZoneData> aZoneDataList_Cooling = new List<ZoneData>();
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

            List<Tuple<ZoneData, int, float, DataType>> aTupleList = new List<Tuple<ZoneData, int, float, DataType>>();
            for (int i = 0; i < aCount; i++)
            {
                float aMax_Building = float.MinValue;
                int aIndex_Building = -1;
                Functions.GetMax(aZoneDataList_Building[i], out aMax_Building, out aIndex_Building, (TSD.tsdZoneArray)TSDZoneArray);

                if (BuildingDataOnly)
                {
                    aTupleList.Add(new Tuple<ZoneData, int, float, DataType>(aZoneDataList_Building[i], aIndex_Building, aMax_Building, DataType.BuildingData));
                }
                else
                {
                    float aMax_Cooling = float.MinValue;
                    int aIndex_Cooling = -1;
                    Functions.GetMax(aZoneDataList_Cooling[i], out aMax_Cooling, out aIndex_Cooling, (TSD.tsdZoneArray)TSDZoneArray);

                    if (aMax_Cooling > aMax_Building)
                        aTupleList.Add(new Tuple<ZoneData, int, float, DataType>(aZoneDataList_Cooling[i], aIndex_Cooling, aMax_Cooling, DataType.CoolingDesignData));
                    else
                        aTupleList.Add(new Tuple<ZoneData, int, float, DataType>(aZoneDataList_Building[i], aIndex_Building, aMax_Building, DataType.BuildingData));
                }
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
            List<float> aLatentAdditionLoadList = new List<float>();
            List<float> aLatentRemovalLoadList = new List<float>();
            List<float> aLatentLoadList = new List<float>();

            List<DataType> aDataTypeList = new List<DataType>();


            foreach (Tuple<ZoneData, int, float, DataType> aTuple in aTupleList)
            {
                ZoneData aZoneData = aTuple.Item1;
                int aIndex = aTuple.Item2;
                float aMax = aTuple.Item3;

                aDataTypeList.Add(aTuple.Item4);

                aIndexList.Add(aIndex);

                float aValue = float.NaN;

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.heatingLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aHeatingLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.coolingLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aCoolingLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.dryBulbTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + aTempertureConversion, 2));
                aDryBulbTempList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.resultantTemp);
                aValue = Convert.ToSingle(Math.Round(aValue + aTempertureConversion, 2));
                aResultantTempList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.solarGain);
                aValue = Convert.ToSingle(Math.Round(aValue + aTempertureConversion, 2));
                aSolarGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.airMovementGain);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aAirMovementGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.infVentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aInfVentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupantSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aOccupantSensibleGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.lightingGain);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aLightingGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.equipmentSensibleGain);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
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
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aEquipmentLatentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.occupancyLatentGain);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aOccupancyLatentGainList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.humidityRatio);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aHumidityRatioList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.relativeHumidity);
                aValue = Convert.ToSingle(Math.Round(aValue * 1, 2));
                aRelativeHumidityList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.latentAdditionLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aLatentAdditionLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.latentLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aLatentLoadList.Add(aValue);

                aValue = Functions.GetAtIndex(aZoneData, aIndex, TSD.tsdZoneArray.latentRemovalLoad);
                aValue = Convert.ToSingle(Math.Round(aValue * aPowerConversion, 2));
                aLatentRemovalLoadList.Add(aValue);
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
                    { "LatentAdditionLoad", aLatentAdditionLoadList},
                    { "LatentLoad", aLatentLoadList},
                    { "LatentRemovalLoad", aLatentRemovalLoadList},
                    { "MaxBuildingCooling", aMax_CoolingProfile},
                    { "MaxBuildingIndexCooling", aIndex_CoolingProfile},
                    { "DataType", aDataTypeList}
            };
        }

        [MultiReturn(new[] { "TSDBuildingArray", "BuildingResult", "BuildingIndex",
            "ZoneDataGroup",
            "Max_CoolingLoad", "LatentLoad_CoolingLoad", "Index_CoolingLoad", "Max_HumidityRatio_Local_CoolingLoad", "ZoneData_HumidityRatio_Max_CoolingLoad", "Infiltration_CoolingLoad", "ExternalTemperature_CoolingLoad", "ExternalHumidity_CoolingLoad" ,
            "Max_HeatingLoad", "LatentLoad_HeatingLoad", "Index_HeatingLoad", "Min_HumidityRatio_Local_HeatingLoad", "ZoneData_HumidityRatio_Min_HeatingLoad", "Infiltration_HeatingLoad", "ExternalTemperature_HeatingLoad", "ExternalHumidity_HeatingLoad",
            "Max_LatentRemovalLoad", "CoolingLoad_LatentRemovalLoad", "LatentLoad_LatentRemovalLoad", "Index_LatentRemovalLoad", "Max_HumidityRatio_Local_LatentRemovalLoad", "ZoneData_HumidityRatio_Max_LatentRemovalLoad","Infiltration_LatentRemovalLoad", "ExternalTemperature_LatentRemovalLoad", "ExternalHumidity_LatentRemovalLoad",
            "Max_LatentAdditionLoad", "HeatingLoad_LatentAdditionLoad", "LatentLoad_LatentAdditionLoad", "Index_LatentAdditionLoad", "Min_HumidityRatio_Local_LatentAdditionLoad", "ZoneData_HumidityRatio_Min_LatentAdditionLoad", "Infiltration_LatentAdditionLoad", "ExternalTemperature_LatentAdditionLoad", "ExternalHumidity_LatentAdditionLoad",
            "Sum_Max_CoolingLoad", "Sum_Index_CoolingLoad","aExternalTemperature_CoolingLoad", "aExternalHumidity_CoolingLoad", "Sum_Max_HeatingLoad", "Sum_Index_HeatingLoad", "aExternalTemperature_HeatingLoad","aExternalHumidity_HeatingLoad", "Sum_Max_LatentRemovalLoad", "Sum_Index_LatentRemovalLoad", "aExternalTemperature_LatentRemovalLoad","aExternalHumidity_LatentRemovalLoad", "Sum_Max_LatentAdditionLoad", "Sum_Index_LatentAdditionLoad","aExternalTemperature_LatentAdditionalLoad","aExternalHumidity_LatentAdditionalLoad"})]
        public static Dictionary<string, object> GetGroupResults(BuildingData BuildingData, List<ZoneDataGroup> ZoneDataGroups, bool ConvertUnits = false)
        {
            float aTempertureConversion = 273.15f;
            float aPowerConversion = 10.7639104167097f;

            if (!ConvertUnits)
            {
                aTempertureConversion = 0;
                aPowerConversion = 1;
            }

            List<Tuple<TSD.tsdBuildingArray, float, int>> aTupleList_Building = new List<Tuple<TSD.tsdBuildingArray, float, int>>();
            int aIndex = -1;
            float aMax = float.NaN;
            float aMin = float.NaN;
            TSD.tsdBuildingArray aTSDBuildingArray;

            aTSDBuildingArray = TSD.tsdBuildingArray.coolingProfile;
            Functions.GetMaxBuildingResults(BuildingData, aTSDBuildingArray, out aMax, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMax * aPowerConversion, aIndex));

            aTSDBuildingArray = TSD.tsdBuildingArray.heatingProfile;
            Functions.GetMaxBuildingResults(BuildingData, aTSDBuildingArray, out aMax, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMax * aPowerConversion, aIndex));


            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            Functions.GetMinBuildingResults(BuildingData, aTSDBuildingArray, out aMin, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMin + aTempertureConversion, aIndex));

            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aMinHumidity = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aIndex];
            //Functions.GetMaxBuildingResults(BuildingData, aTSDBuildingArray, out aMax, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMinHumidity, aIndex));

            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            Functions.GetMaxBuildingResults(BuildingData, aTSDBuildingArray, out aMax, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMax + aTempertureConversion, aIndex));

            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aMaxHumidity = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aIndex];
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMaxHumidity, aIndex));

            aTSDBuildingArray = TSD.tsdBuildingArray.globalRadiation;
            Functions.GetMaxBuildingResults(BuildingData, aTSDBuildingArray, out aMax, out aIndex);
            aTupleList_Building.Add(new Tuple<TSD.tsdBuildingArray, float, int>(aTSDBuildingArray, aMax * aPowerConversion, aIndex));

            List<float> aSum_CoolingLoad = new List<float>();
            List<float> aSum_HeatingLoad = new List<float>();
            List<float> aSum_LatentRemovalLoad = new List<float>();
            List<float> aSum_LatentAdditionalLoad = new List<float>();
            for (int i = 0; i < 8760; i++)
            {
                aSum_CoolingLoad.Add(0);
                aSum_HeatingLoad.Add(0);
                aSum_LatentAdditionalLoad.Add(0);
                aSum_LatentRemovalLoad.Add(0);
            }

            List<Tuple<int, ZoneData, List<float>>> aTupleList_CoolingLoad = new List<Tuple<int, ZoneData, List<float>>>();
            List<Tuple<int, ZoneData, List<float>>> aTupleList_HeatingLoad = new List<Tuple<int, ZoneData, List<float>>>();
            List<Tuple<int, ZoneData, List<float>>> aTupleList_LatentRemovalLoad = new List<Tuple<int, ZoneData, List<float>>>();
            List<Tuple<int, ZoneData, List<float>>> aTupleList_LatentAdditionLoad = new List<Tuple<int, ZoneData, List<float>>>();
            foreach (ZoneDataGroup aZoneDataGroup in ZoneDataGroups)
            {
                List<ZoneData> aZoneDataList = ZoneDataGroup.GetZonesData(aZoneDataGroup);
                List<float> aResultList;

                float aMax_HumidityRatio_Local;
                ZoneData aZoneData_HumidityRatio_Max;

                float aMin_HumidityRatio_Local;
                ZoneData aZoneData_HumidityRatio_Min;

                float aCalc;

                List<float> aValueList;

                //CoolingLoad
                aValueList = new List<float>();
                aResultList = Functions.GetAnnualZoneResultList(aZoneDataList, TSD.tsdZoneArray.coolingLoad);
                Functions.AddValues(aSum_CoolingLoad, aResultList);
                aCalc = aResultList.Max();
                aValueList.Add(aCalc * aPowerConversion);
                int aIndex_CoolingLoad = aResultList.IndexOf(aCalc);
                aValueList.Add((Functions.GetAtIndex(aZoneDataList, aIndex_CoolingLoad, TSD.tsdZoneArray.occupancyLatentGain) + Functions.GetAtIndex(aZoneDataList, aIndex_CoolingLoad, TSD.tsdZoneArray.equipmentLatentGain)) * aPowerConversion);
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_CoolingLoad, TSD.tsdZoneArray.infiltration));
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalTemperature)[aIndex_CoolingLoad] + aTempertureConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalHumidity)[aIndex_CoolingLoad]);
                Functions.GetMax(aZoneDataList, aIndex_CoolingLoad, out aMax_HumidityRatio_Local, out aZoneData_HumidityRatio_Max, TSD.tsdZoneArray.humidityRatio);
                aValueList.Add(aMax_HumidityRatio_Local);
                aTupleList_CoolingLoad.Add(new Tuple<int, ZoneData, List<float>>(aIndex_CoolingLoad, aZoneData_HumidityRatio_Max, aValueList));

                //HeatingLoad
                aValueList = new List<float>();
                aResultList = Functions.GetAnnualZoneResultList(aZoneDataList, TSD.tsdZoneArray.heatingLoad);
                Functions.AddValues(aSum_HeatingLoad, aResultList);
                aCalc = aResultList.Max();
                aValueList.Add(aCalc * aPowerConversion);
                int aIndex_HeatingLoad = aResultList.IndexOf(aCalc);
                aValueList.Add((Functions.GetAtIndex(aZoneDataList, aIndex_HeatingLoad, TSD.tsdZoneArray.occupancyLatentGain) + Functions.GetAtIndex(aZoneDataList, aIndex_HeatingLoad, TSD.tsdZoneArray.equipmentLatentGain)) * aPowerConversion);
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_HeatingLoad, TSD.tsdZoneArray.infiltration));
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalTemperature)[aIndex_HeatingLoad] + aTempertureConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalHumidity)[aIndex_HeatingLoad]);
                Functions.GetMin(aZoneDataList, aIndex_HeatingLoad, out aMin_HumidityRatio_Local, out aZoneData_HumidityRatio_Min, TSD.tsdZoneArray.humidityRatio);
                aValueList.Add(aMin_HumidityRatio_Local);
                aTupleList_HeatingLoad.Add(new Tuple<int, ZoneData, List<float>>(aIndex_HeatingLoad, aZoneData_HumidityRatio_Min, aValueList));

                //LatentRemovalLoad
                aValueList = new List<float>();
                aResultList = Functions.GetAnnualZoneResultList(aZoneDataList, TSD.tsdZoneArray.latentRemovalLoad);
                Functions.AddValues(aSum_LatentRemovalLoad, aResultList);
                aCalc = aResultList.Max();
                aValueList.Add(aCalc * aPowerConversion);
                int aIndex_LatentRemovalLoad = aResultList.IndexOf(aCalc);
                aValueList.Add((Functions.GetAtIndex(aZoneDataList, aIndex_LatentRemovalLoad, TSD.tsdZoneArray.occupancyLatentGain) + Functions.GetAtIndex(aZoneDataList, aIndex_LatentRemovalLoad, TSD.tsdZoneArray.equipmentLatentGain)) * aPowerConversion);
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_LatentRemovalLoad, TSD.tsdZoneArray.infiltration));
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_LatentRemovalLoad, TSD.tsdZoneArray.coolingLoad) * aPowerConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalTemperature)[aIndex_LatentRemovalLoad] + aTempertureConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalHumidity)[aIndex_LatentRemovalLoad]);
                Functions.GetMax(aZoneDataList, aIndex_LatentRemovalLoad, out aMax_HumidityRatio_Local, out aZoneData_HumidityRatio_Max, TSD.tsdZoneArray.humidityRatio);
                aValueList.Add(aMax_HumidityRatio_Local);
                aTupleList_LatentRemovalLoad.Add(new Tuple<int, ZoneData, List<float>>(aIndex_LatentRemovalLoad, aZoneData_HumidityRatio_Max, aValueList));

                //LatentAdditionLoad
                aValueList = new List<float>();
                aResultList = Functions.GetAnnualZoneResultList(aZoneDataList, TSD.tsdZoneArray.latentAdditionLoad);
                Functions.AddValues(aSum_LatentAdditionalLoad, aResultList);
                aCalc = aResultList.Max();
                aValueList.Add(aCalc * aPowerConversion);
                int aIndex_LatentAdditionLoad = aResultList.IndexOf(aCalc);
                aValueList.Add((Functions.GetAtIndex(aZoneDataList, aIndex_LatentAdditionLoad, TSD.tsdZoneArray.occupancyLatentGain) + Functions.GetAtIndex(aZoneDataList, aIndex_LatentAdditionLoad, TSD.tsdZoneArray.equipmentLatentGain) * aPowerConversion));
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_LatentAdditionLoad, TSD.tsdZoneArray.infiltration));
                aValueList.Add(Functions.GetAtIndex(aZoneDataList, aIndex_LatentAdditionLoad, TSD.tsdZoneArray.heatingLoad) * aPowerConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalTemperature)[aIndex_LatentAdditionLoad] + aTempertureConversion);
                aValueList.Add(Functions.GetAnnualBuildingResultList(BuildingData, TSD.tsdBuildingArray.externalHumidity)[aIndex_LatentAdditionLoad]);
                Functions.GetMin(aZoneDataList, aIndex_LatentAdditionLoad, out aMin_HumidityRatio_Local, out aZoneData_HumidityRatio_Min, TSD.tsdZoneArray.humidityRatio);
                aValueList.Add(aMin_HumidityRatio_Local);
                aTupleList_LatentAdditionLoad.Add(new Tuple<int, ZoneData, List<float>>(aIndex_LatentAdditionLoad, aZoneData_HumidityRatio_Min, aValueList));
            }

            float aSum_Max_CoolingLoad = aSum_CoolingLoad.Max();
            int aSum_Index_CoolingLoad = aSum_CoolingLoad.IndexOf(aSum_Max_CoolingLoad);
            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            float aExternalTemperature_CoolingLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_CoolingLoad];
            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aExternalHumidity_CoolingLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_CoolingLoad];

            float aSum_Max_HeatingLoad = aSum_HeatingLoad.Max();
            int aSum_Index_HeatingLoad = aSum_HeatingLoad.IndexOf(aSum_Max_HeatingLoad);
            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            float aExternalTemperature_HeatingLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_HeatingLoad];
            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aExternalHumidity_HeatingLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_HeatingLoad];

            float aSum_Max_LatentRemovalLoad = aSum_LatentRemovalLoad.Max();
            int aSum_Index_LatentRemovalLoad = aSum_LatentRemovalLoad.IndexOf(aSum_Max_LatentRemovalLoad);
            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            float aExternalTemperature_LatentRemovalLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_LatentRemovalLoad];
            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aExternalHumidity_LatentRemovalLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_LatentRemovalLoad];

            float aSum_Max_LatentAdditionalLoad = aSum_LatentAdditionalLoad.Max();
            int aSum_Index_LatentAdditionalLoad = aSum_LatentAdditionalLoad.IndexOf(aSum_Max_LatentAdditionalLoad);
            aTSDBuildingArray = TSD.tsdBuildingArray.externalTemperature;
            float aExternalTemperature_LatentAdditionalLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_LatentAdditionalLoad];
            aTSDBuildingArray = TSD.tsdBuildingArray.externalHumidity;
            float aExternalHumidity_LatentAdditionalLoad = Functions.GetAnnualBuildingResultList(BuildingData, aTSDBuildingArray)[aSum_Index_LatentAdditionalLoad];

            return new Dictionary<string, object>
            {
                { "TSDBuildingArray", aTupleList_Building.ConvertAll(x => x.Item1)},
                { "BuildingResult", aTupleList_Building.ConvertAll(x => x.Item2)},
                { "BuildingIndex", aTupleList_Building.ConvertAll(x => x.Item3)},

                { "ZoneDataGroup", ZoneDataGroups},

                { "Max_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[0])},
                { "LatentLoad_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[1])},
                { "Index_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item1)},
                { "Max_HumidityRatio_Local_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[5])},
                { "ZoneData_HumidityRatio_Max_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item2)},
                { "Infiltration_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[2])},
                { "ExternalTemperature_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[3])},
                { "ExternalHumidity_CoolingLoad", aTupleList_CoolingLoad.ConvertAll(x => x.Item3[4])},

                { "Max_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[0])},
                { "LatentLoad_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[1])},
                { "Index_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item1)},
                { "Min_HumidityRatio_Local_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[5])},
                { "ZoneData_HumidityRatio_Min_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item2)},
                { "Infiltration_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[2])},
                { "ExternalTemperature_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[3])},
                { "ExternalHumidity_HeatingLoad", aTupleList_HeatingLoad.ConvertAll(x => x.Item3[4])},

                { "Max_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[0])},
                { "CoolingLoad_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[3])},
                { "LatentLoad_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[1])},
                { "Index_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item1)},
                { "Max_HumidityRatio_Local_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[6])},
                { "ZoneData_HumidityRatio_Max_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item2)},
                { "Infiltration_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[2])},
                { "ExternalTemperature_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[4])},
                { "ExternalHumidity_LatentRemovalLoad", aTupleList_LatentRemovalLoad.ConvertAll(x => x.Item3[5])},

                { "Max_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[0])},
                { "HeatingLoad_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[3])},
                { "LatentLoad_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[1])},
                { "Index_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item1)},
                { "Min_HumidityRatio_Local_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[6])},
                { "ZoneData_HumidityRatio_Min_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item2)},
                { "Infiltration_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[2])},
                { "ExternalTemperature_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[4])},
                { "ExternalHumidity_LatentAdditionLoad", aTupleList_LatentAdditionLoad.ConvertAll(x => x.Item3[5])},

                { "Sum_Max_CoolingLoad", aSum_Max_CoolingLoad},
                { "Sum_Index_CoolingLoad", aSum_Index_CoolingLoad},
                { "aExternalTemperature_CoolingLoad", aExternalTemperature_CoolingLoad},
                { "aExternalHumidity_CoolingLoad", aExternalHumidity_CoolingLoad},

                { "Sum_Max_HeatingLoad", aSum_Max_HeatingLoad},
                { "Sum_Index_HeatingLoad", aSum_Index_HeatingLoad},
                { "aExternalTemperature_HeatingLoad", aExternalTemperature_HeatingLoad},
                { "aExternalHumidity_HeatingLoad", aExternalHumidity_HeatingLoad},

                { "Sum_Max_LatentRemovalLoad", aSum_Max_LatentRemovalLoad},
                { "Sum_Index_LatentRemovalLoad", aSum_Index_LatentRemovalLoad},
                { "aExternalTemperature_LatentRemovalLoad", aExternalTemperature_LatentRemovalLoad},
                { "aExternalHumidity_LatentRemovalLoad", aExternalHumidity_LatentRemovalLoad},


                { "Sum_Max_LatentAdditionLoad", aSum_Max_LatentAdditionalLoad},
                { "Sum_Index_LatentAdditionLoad", aSum_Index_LatentAdditionalLoad},
                { "aExternalTemperature_LatentAdditionalLoad", aExternalTemperature_LatentAdditionalLoad},
                { "aExternalHumidity_LatentAdditionalLoad", aExternalHumidity_LatentAdditionalLoad},
            };
        }

        [MultiReturn(new[] { "TSDBuildingArray", "BuildingResult", "BuildingIndex",
            "ZoneDataGroup",
            "Max_CoolingLoad", "LatentLoad_CoolingLoad", "Index_CoolingLoad", "Max_HumidityRatio_Local_CoolingLoad", "ZoneData_HumidityRatio_Max_CoolingLoad", "Infiltration_CoolingLoad", "ExternalTemperature_CoolingLoad", "ExternalHumidity_CoolingLoad" ,
            "Max_HeatingLoad", "LatentLoad_HeatingLoad", "Index_HeatingLoad", "Min_HumidityRatio_Local_HeatingLoad", "ZoneData_HumidityRatio_Min_HeatingLoad", "Infiltration_HeatingLoad", "ExternalTemperature_HeatingLoad", "ExternalHumidity_HeatingLoad",
            "Max_LatentRemovalLoad", "CoolingLoad_LatentRemovalLoad", "LatentLoad_LatentRemovalLoad", "Index_LatentRemovalLoad", "Max_HumidityRatio_Local_LatentRemovalLoad", "ZoneData_HumidityRatio_Max_LatentRemovalLoad","Infiltration_LatentRemovalLoad", "ExternalTemperature_LatentRemovalLoad", "ExternalHumidity_LatentRemovalLoad",
            "Max_LatentAdditionLoad", "HeatingLoad_LatentAdditionLoad", "LatentLoad_LatentAdditionLoad", "Index_LatentAdditionLoad", "Min_HumidityRatio_Local_LatentAdditionLoad", "ZoneData_HumidityRatio_Min_LatentAdditionLoad", "Infiltration_LatentAdditionLoad", "ExternalTemperature_LatentAdditionLoad", "ExternalHumidity_LatentAdditionLoad",
            "Sum_Max_CoolingLoad", "Sum_Index_CoolingLoad","aExternalTemperature_CoolingLoad", "aExternalHumidity_CoolingLoad", "Sum_Max_HeatingLoad", "Sum_Index_HeatingLoad", "aExternalTemperature_HeatingLoad","aExternalHumidity_HeatingLoad", "Sum_Max_LatentRemovalLoad", "Sum_Index_LatentRemovalLoad", "aExternalTemperature_LatentRemovalLoad","aExternalHumidity_LatentRemovalLoad", "Sum_Max_LatentAdditionLoad", "Sum_Index_LatentAdditionLoad","aExternalTemperature_LatentAdditionalLoad","aExternalHumidity_LatentAdditionalLoad"})]
        public static Dictionary<string, object> GetGroupResults(string FilePath, bool ConvertUnits = false)
        {
            TSDDocument aTSDDocument = new TSDDocument(FilePath, false);

            SimulationData aSimulationData = TSDDocument.SimulationData(aTSDDocument);
            BuildingData aBuildingData = SimulationData.BuildingData(aSimulationData);
            List<ZoneDataGroup> aZoneDataGroupList = SimulationData.GetZoneDataGroups(aSimulationData);

            return GetGroupResults(aBuildingData, aZoneDataGroupList, ConvertUnits);
        }

        [MultiReturn(new[] { "Day", "Hour", "String" })]
        public static Dictionary<string, object> GetDay(int Hour)
        {
            double aValue = Hour * 0.04166667;

            int aDay = (int)aValue + 1;
            int aHour = (int)((aValue - Math.Truncate(aValue)) * 24) + 1;

            return new Dictionary<string, object>
            {
                { "Day", aDay},
                { "Hour", aHour},
                { "String", string.Format("{0}d {1}h", aDay.ToString(), aHour.ToString())}
            };
        }

        public static DateTime GetDateTime(int Year, int Hours)
        {
            return new DateTime(Year, 1, 1).AddHours(Hours + 1);
        }

        [MultiReturn(new[] { "GUIDs", "Hours", "HoursAbv" })]
        public static Dictionary<string, object> GetOverheating(BuildingData BuildingData, List<float> TemperatureList)
        {
            List<string> aGUIDList = new List<string>();
            List<float> aHourList = new List<float>();
            List<List<float>> aHourAbvList = new List<List<float>>();
            
            List<ZoneData> ZoneDataList = BuildingData.GetZonesData(BuildingData);

            foreach (ZoneData aZoneData in ZoneDataList)
            {
                List<float> aValueList;

                aValueList = Functions.GetList(ZoneData.GetAnnualZoneResult(aZoneData, TSDZoneArray.OccupantSensibleGain));
                List<int> aIndexList = new List<int>();
                for (int i = 0; i < aValueList.Count; i++)
                    if (aValueList[i] > 0)
                        aIndexList.Add(i);

                aHourList.Add(aIndexList.Count);
                aGUIDList.Add(ZoneData.GUID(aZoneData));
                aHourAbvList.Add(new List<float>());

                aValueList = Functions.GetList(ZoneData.GetAnnualZoneResult(aZoneData, TSDZoneArray.ResultantTemp));
                foreach (float aTemperature in TemperatureList)
                {
                    int aCount = 0;
                    foreach (int aIndex in aIndexList)
                        if (aValueList[aIndex] > aTemperature)
                            aCount++;
                    aHourAbvList.Last().Add(aCount);
                }
            }

            return new Dictionary<string, object>
            {
                { "GUIDs", aGUIDList},
                { "Hours", aHourList},
                { "HoursAbv", aHourAbvList}

            };

        }
    }

    internal static class Functions
    {
        internal static void GetMax(ZoneData ZoneData, out float Max, out int Index, TSD.tsdZoneArray ZoneArray)
        {
            if(ZoneData == null)
            {
                Max = float.MinValue;
                Index = -1;
                return;
            }

            Max = float.NaN;
            List<float> aFloatList = GetAnnualZoneResultList(ZoneData, ZoneArray);
            Max = aFloatList.Max();
            Index = aFloatList.IndexOf(Max);
        }

        internal static void GetMax(List<ZoneData> ZoneDataList, out float Max, out int Index, out ZoneData ZoneData, TSD.tsdZoneArray ZoneArray)
        {
            Max = float.MinValue;
            Index = -1;
            ZoneData = null;

            for (int i=0; i< ZoneDataList.Count; i++)
            {
                List<float> aResultList = GetAnnualZoneResultList(ZoneDataList[i], ZoneArray);
                float aMax = aResultList.Max();
                if(aMax > Max)
                {
                    Max = aMax;
                    Index = aResultList.IndexOf(aMax);
                    ZoneData = ZoneDataList[i];
                }   
            }
        }

        internal static void GetMax(List<ZoneData> ZoneDataList, int Index, out float Max, out ZoneData ZoneData, TSD.tsdZoneArray ZoneArray)
        {
            Max = float.MinValue;
            ZoneData = null;

            for (int i = 0; i < ZoneDataList.Count; i++)
            {
                List<float> aResultList = GetAnnualZoneResultList(ZoneDataList[i], ZoneArray);
                float aMax = aResultList[Index];
                if (aMax > Max)
                {
                    Max = aMax;
                    ZoneData = ZoneDataList[i];
                }
            }
        }

        internal static void GetMin(List<ZoneData> ZoneDataList, int Index, out float Min, out ZoneData ZoneData, TSD.tsdZoneArray ZoneArray)
        {
            Min = float.MaxValue;
            ZoneData = null;

            for (int i = 0; i < ZoneDataList.Count; i++)
            {
                List<float> aResultList = GetAnnualZoneResultList(ZoneDataList[i], ZoneArray);
                float aMin = aResultList[Index];
                if (aMin < Min)
                {
                    Min = aMin;
                    ZoneData = ZoneDataList[i];
                }
            }
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
            object aObject = ZoneData.GetAnnualZoneResult(ZoneData, (int)ZoneArray);
            return GetList(aObject);
        }

        internal static List<float> GetAnnualZoneResultList(List<ZoneData> ZoneDataList, TSD.tsdZoneArray ZoneArray)
        {
            if(ZoneDataList.Count < 1)
                return null;

            List<float> aResultList = GetAnnualZoneResultList(ZoneDataList.First(), ZoneArray);
            for (int i = 0; i < aResultList.Count; i++)
                if (aResultList[i] < 0)
                    aResultList[i] = 0;

            for (int i = 1; i < ZoneDataList.Count; i++)
            {
                List<float> aResultList_Temp = GetAnnualZoneResultList(ZoneDataList[i], ZoneArray);
                for (int j = 0; j < aResultList_Temp.Count; j++)
                    if (aResultList_Temp[j] > 0)
                        aResultList[j] += aResultList_Temp[j];
            }

            return aResultList;
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

        internal static float GetAtIndex(ZoneData ZoneData, int Index, TSD.tsdZoneArray ZoneArray)
        {
            List<float> aFloatList = GetAnnualZoneResultList(ZoneData, ZoneArray);
            if (aFloatList.Count > Index)
                return aFloatList[Index];
            return float.NaN;
        }

        internal static float GetAtIndex(List<ZoneData> ZoneDataList, int Index, TSD.tsdZoneArray ZoneArray)
        {
            float aResult = 0;
            foreach(ZoneData aZoneData in ZoneDataList)
            {
                List<float> aResutList = GetAnnualZoneResultList(aZoneData, ZoneArray);
                if (aResutList[Index] > 0)
                    aResult += aResutList[Index];

            }
            return aResult;
        }

        internal static void GetMaxBuildingResults(BuildingData BuildingData, TSD.tsdBuildingArray TSDBuildingArray, out float Max, out int Index)
        {
            List<float> aFloatList = GetAnnualBuildingResultList(BuildingData, TSDBuildingArray);
            Max = float.NaN;
            Index = -1;
            if (aFloatList.Count > 0)
            {
                Max = aFloatList.Max();
                Index = aFloatList.IndexOf(Max);
            }
        }

        internal static void GetMinBuildingResults(BuildingData BuildingData, TSD.tsdBuildingArray TSDBuildingArray, out float Min, out int Index)
        {
            List<float> aFloatList = GetAnnualBuildingResultList(BuildingData, TSDBuildingArray);
            Min = float.NaN;
            Index = -1;
            if (aFloatList.Count > 0)
            {
                Min = aFloatList.Min();
                Index = aFloatList.IndexOf(Min);
            }
        }

        internal static void AddValues(List<float> ListFloat, List<float> ListFloatToAdd)
        {
            for (int i = 0; i < ListFloat.Count; i++)
                ListFloat[i] += ListFloatToAdd[i];
        }
    }
}