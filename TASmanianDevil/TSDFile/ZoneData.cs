using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Zone Data
    /// </summary>  
    public class ZoneData
    {
        private TSD.ZoneData pZoneData;

        internal ZoneData(TSD.ZoneData ZoneData)
        {
            pZoneData = ZoneData;
        }

        /// <summary>
        /// Gets TAS Annual Zone Result
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <param name="TSDZoneArray">TSDZoneArray</param>
        /// <returns name="Data">TAS Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Annual Zone Result, tas, tsddocument, tsddocument AnnualZoneResult, annualzoneresult
        /// </search>
        public static object GetAnnualZoneResult(ZoneData ZoneData, TSDZoneArray TSDZoneArray)
        {
            return ZoneData.pZoneData.GetAnnualZoneResult((int)TSDZoneArray);
        }

        /// <summary>
        /// Gets TAS Annual Zone Result
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <param name="Index">TSD Data Index</param>
        /// <returns name="Data">TAS Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Annual Zone Result, tas, tsddocument, tsddocument AnnualZoneResult, annualzoneresult
        /// </search>
        public static object GetAnnualZoneResult(ZoneData ZoneData, int Index)
        {
            return ZoneData.pZoneData.GetAnnualZoneResult(Index);
        }

        /// <summary>
        /// Gets TAS Zone Data Floor Area
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="FloorArea">Floor Area</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, FloorArea, Floor Area,
        /// </search>
        public static float FloorArea(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.floorArea;
        }

        /// <summary>
        /// Gets TAS Annual Zone Result
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="Name">TAS Zone Data Name</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Zone Name, tas, tsddocument, tsddocument Zone Name, zonename
        /// </search>
        public static string Name(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.name;
        }

        /// <summary>
        /// Gets TAS Annual Zone Data Number
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="Number">TAS Zone Data Number</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Zone Number, tas, tsddocument, tsddocument Zone Number, zonenumber
        /// </search>
        public static int Number(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.zoneNumber;
        }

        /// <summary>
        /// Gets TAS Annual Zone Data GUID
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="GUID">TAS Zone Data GUID</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Zone GUID, tas, tsddocument, tsddocument Zone GUID, zoneguid, guid
        /// </search>
        public static string GUID(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.zoneGUID;
        }

        /// <summary>
        /// Gets TAS Annual Zone Convective Common Ratio
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="Ratio">TAS Zone Data Convective Common Ratio</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Zone Convective Common Ratio, tas, tsddocument, tsddocument zone convective common ratio, ConvectiveCommonRatio, convectivecommonratio
        /// </search>
        public static float ConvectiveCommonRatio(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.convectiveCommonRatio;
        }

        /// <summary>
        /// Gets TAS Annual Zone Description
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="Description">TAS Zone Data Descriprion</returns>
        /// <search>
        /// TAS, tas, TBDDocument, tbddocument, ZoneData, zonedata, Zone Data, zone data, Description, description
        /// </search>
        public static string Description(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.description;
        }

        /// <summary>
        /// Gets TAS Zone Data Conv Weighting Factors
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <returns name="Factors">TAS Zone Data Conv Weighting Factors</returns>
        /// <search>
        /// TAS, tas, TBDDocument, tbddocument, ZoneData, zonedata, GetConvWeightingFactors, getconvweightingfactors, Get Conv Weighting Factors, get conv weighting factors
        /// </search>
        public static object GetConvWeightingFactors(ZoneData ZoneData)
        {
            return ZoneData.pZoneData.GetConvWeightingFactors();
        }

        /// <summary>
        /// Gets Daily Zone Results for Zone Data
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <param name="Day">Day</param>
        /// <param name="Index">Index</param>
        /// <returns name="Result">Daily Zone Result for Zone Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, tas, tsddocument, GetDailyZoneResult, Get Daily Zone Result, get daily zone result, get daily zone result
        /// </search>
        public static object GetDailyZoneResult(ZoneData ZoneData, int Day, int Index)
        {
            return ZoneData.pZoneData.GetDailyZoneResult(Day, Index);
        }

        /// <summary>
        /// Gets Hourly Zone Results for Zone Data
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <param name="Hour">Hour</param>
        /// <param name="Index">Index</param>
        /// <returns name="Result">Hourly Zone Result for Zone Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, tas, tsddocument, GetHourlyZoneResult, Get Hourly Zone Result, get hourly zone result, get hourly zone result
        /// </search>
        public static float GetHourlyZoneResult(ZoneData ZoneData, int Hour, int Index)
        {
            return ZoneData.pZoneData.GetHourlyZoneResult(Hour, Index);
        }

        /// <summary>
        /// Gets Surface Data from Zone Data
        /// </summary>
        /// <param name="ZoneData">TSD Zone Data</param>
        /// <param name="Index">Surface Index</param>
        /// <returns name="SurfaceData">Surface Data</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, ZoneData, Get Zone Surface Data, tas, tsddocument, tsddocument Zone SurfaceData, SurfaceData, surfacedata, surface data
        /// </search>
        public static SurfaceData GetSurfaceData(ZoneData ZoneData, int Index)
        {
            return new SurfaceData(ZoneData.pZoneData.GetSurfaceData(Index));
        }

        /// <summary>
        /// Gets Surfaces Data for Zone Data
        /// </summary>
        /// <param name="ZoneData">TAS Zone Data</param>
        /// <returns name="SurfaceData">Surface Data List</returns>
        /// <search>
        /// TAS, Surface Data, Zone Data, zonedata, zone data, surfacedata, surface data
        /// </search>
        public static List<SurfaceData> SurfaceData(ZoneData ZoneData)
        {
            List<SurfaceData> aSurfaceDataList = new List<SurfaceData>();

            int aIndex = 1;
            TSD.SurfaceData aSurfaceData = ZoneData.pZoneData.GetSurfaceData(aIndex);
            while (aSurfaceData != null)
            {
                aSurfaceDataList.Add(new SurfaceData(aSurfaceData));
                aIndex++;
                aSurfaceData = ZoneData.pZoneData.GetSurfaceData(aIndex);
            }
            return aSurfaceDataList;
        }
    }

    /// <summary>
    /// TAS TSD Zone Array
    /// </summary>  
    public enum TSDZoneArray
    {
        /// <summary>Dry Bulb Temperature</summary>
        DryBulbTemp = 1,
        /// <summary>MR Temperature</summary>
        MRTemp = 2,
        /// <summary>Resultant Temperature</summary>
        ResultantTemp = 3,
        /// <summary>Sensible Load</summary>
        SensibleLoad = 4,
        /// <summary>Heating Load</summary>
        HeatingLoad = 5,
        /// <summary>Cooling Load</summary>
        CoolingLoad = 6,
        /// <summary>Solar Gain</summary>
        SolarGain = 7,
        /// <summary>Lighting Gain</summary>
        LightingGain = 8,
        /// <summary>Inf Vent Gain</summary>
        InfVentGain = 9,
        /// <summary>Air Movement Gain</summary>
        AirMovementGain = 10,
        /// <summary>Building Heat Transfer</summary>
        BuildingHeatTransfer = 11,
        /// <summary>External Conduction Opaque</summary>
        ExternalConductionOpaque = 12,
        /// <summary>External Conduction Glazing</summary>
        ExternalConductionGlazing = 13,
        /// <summary>Occupant Sensible Gain</summary>
        OccupantSensibleGain = 14,
        /// <summary>Equipment Sensible Gain</summary>
        EquipmentSensibleGain = 15,
        /// <summary>Humidity Ratio</summary>
        HumidityRatio = 16,
        /// <summary>Relative Humidity</summary>
        RelativeHumidity = 17,
        /// <summary>Occupancy Latent Gain</summary>
        OccupancyLatentGain = 18,
        /// <summary>Equipment Latent Gain</summary>
        EquipmentLatentGain = 19,
        /// <summary>Latent Load</summary>
        LatentLoad = 20,
        /// <summary>Latent Removal Load</summary>
        LatentRemovalLoad = 21,
        /// <summary>Latent Addition Load</summary>
        LatentAdditionLoad = 22,
        /// <summary>Vapour Pressure</summary>
        VapourPressure = 23,
        /// <summary>Pollutant</summary>
        Pollutant = 24,
        /// <summary>Pressure</summary>
        Pressure = 25,
        /// <summary>Infiltration</summary>
        Infiltration = 26,
        /// <summary>Ventilation</summary>
        Ventilation = 27,
        /// <summary>Zone Aperture Flow In</summary>
        ZoneApertureFlowIn = 28,
        /// <summary>Zone Aperture Flow Out</summary>
        ZoneApertureFlowOut = 29,
        /// <summary>Izam In</summary>
        IzamIn = 30,
        /// <summary>Izam Out</summary>
        IzamOut = 31
    }
}
