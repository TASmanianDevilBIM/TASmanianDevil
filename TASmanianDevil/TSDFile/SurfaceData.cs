using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSDFile
{
    /// <summary>
    /// TAS Surface Data
    /// </summary>  
    public class SurfaceData
    {
        private TSD.SurfaceData pSurfaceData;

        internal SurfaceData(TSD.SurfaceData SurfaceData)
        {
            pSurfaceData = SurfaceData;
        }

        /// <summary>
        /// Gets Surface Data Area
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <returns name="Area">Surface Data Area</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, SurfaceData, Get Surface Data Area, tas, tsddocument, Surface Data Area, surface data area, surfacedataarea, SurfaceDataArea
        /// </search>
        public static float Area(SurfaceData SurfaceData)
        {
            return SurfaceData.pSurfaceData.area;
        }

        /// <summary>
        /// Gets Surface Data BEName
        /// BE = Building Element
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <returns name="BEName">Surface Data BEName</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, BEName, bename
        /// </search>
        public static string BEName(SurfaceData SurfaceData)
        {
            return SurfaceData.pSurfaceData.BEName;
        }

        /// <summary>
        /// Gets Surface Data BEType
        /// BE = Building Element
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <returns name="BEType">Surface Data BEType</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, BEType, betype
        /// </search>
        public static int BEType(SurfaceData SurfaceData)
        {
            return SurfaceData.pSurfaceData.BEType;
        }

        /// <summary>
        /// Gets Surface Data Orientation
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <returns name="Orientation">Surface Data Orientation</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, Orientation, orientation
        /// </search>
        public static string Orientation(SurfaceData SurfaceData)
        {
            return SurfaceData.pSurfaceData.orientation;
        }

        /// <summary>
        /// Gets Surface Data Number
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <returns name="Number">Surface Data Orientation</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, Number, number
        /// </search>
        public static int Number(SurfaceData SurfaceData)
        {
            return SurfaceData.pSurfaceData.surfaceNumber;
        }

        /// <summary>
        /// Gets Surface Data Annual Surface Result
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <param name="TSDSurfaceArray">TSD Surface Array</param>
        /// <returns name="Result">Surface Data Annual Surface Result</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, GetAnnualSurfaceResult, Get Annual Surface Result, getannualsurfaceresult, get annual surface result
        /// </search>
        public static object GetAnnualSurfaceResult(SurfaceData SurfaceData, TSDSurfaceArray TSDSurfaceArray)
        {
            return SurfaceData.pSurfaceData.GetAnnualSurfaceResult((int)TSDSurfaceArray);
        }

        /// <summary>
        /// Gets Surface Data Daily Result
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <param name="Day">Day</param>
        /// <param name="TSDSurfaceArray">TSD Surface Array</param>
        /// <returns name="Result">Daily Surface Result</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, GetDailySurfaceResult, Get Daily Surface Result, getdailysurfaceresult, get daily surface result
        /// </search>
        public static object GetDailySurfaceResult(SurfaceData SurfaceData, int Day, TSDSurfaceArray TSDSurfaceArray)
        {
            return SurfaceData.pSurfaceData.GetDailySurfaceResult(Day, (int)TSDSurfaceArray);
        }

        /// <summary>
        /// Gets Hourly Surface Result
        /// </summary>
        /// <param name="SurfaceData">Surface Data</param>
        /// <param name="Hour">Hour</param>
        /// <param name="TSDSurfaceArray">TSD Surface Array</param>
        /// <returns name="Result">Hourly Surface Result</returns>
        /// <search>
        /// TAS, TBDDocument, Surface Data, surface data, surfacedata, SurfaceData, GetHourlySurfaceResult, Get Hourly Surface Result, gethourlysurfaceresult, get hourly surface result
        /// </search>
        public static object GetHourlySurfaceResult(SurfaceData SurfaceData, int Hour, TSDSurfaceArray TSDSurfaceArray)
        {
            return SurfaceData.pSurfaceData.GetHourlySurfaceResult(Hour, (int)TSDSurfaceArray);
        }

    }

    /// <summary>
    /// TAS TSD Surface Array
    /// </summary>  
    public enum TSDSurfaceArray
    {
        /// <summary>Internal Temperature</summary>
        InternalTemperature = 1,
        /// <summary>External Temperature</summary>
        ExternalTemperature = 2,
        /// <summary>Internal Solar Gain</summary>
        InternalSolarGain = 3,
        /// <summary>External Solar Gain</summary>
        ExternalSolarGain = 4,
        /// <summary>Aperture Flow In</summary>
        ApertureFlowIn = 5,
        /// <summary>Aperture Flow Out</summary>
        ApertureFlowOut = 6,
        /// <summary>Internal Condensation</summary>
        InternalCondensation = 7,
        /// <summary>External Condensation</summary>
        ExternalCondensation = 8,
        /// <summary>Internal Conduction</summary>
        InternalConduction = 9,
        /// <summary>External Conduction</summary>
        ExternalConduction = 10,
        /// <summary>Aperture Opening</summary>
        ApertureOpening = 11,
        /// <summary>Internal Long Wave</summary>
        InternalLongWave = 12,
        /// <summary>External Long Wave</summary>
        ExternalLongWave = 13,
        /// <summary>Internal Convection</summary>
        InternalConvection = 14,
        /// <summary>External Convection</summary>
        ExternalConvection = 15,
        /// <summary>Inter Condensation</summary>
        InterCondensation = 16
    }
}
   
