using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Surface Output Spec
    /// </summary>
    public class SurfaceOutputSpec
    {
        internal TBD.SurfaceOutputSpec pSurfaceOutputSpec;

        internal SurfaceOutputSpec(TBD.SurfaceOutputSpec SurfaceOutputSpec)
        {
            pSurfaceOutputSpec = SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Conduction
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="Conduction">Conduction</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Conduction, conduction
        /// </search>
        public static bool Conduction(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.conduction == 1;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Conduction
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="Conduction">Conduction for Surface Output Specification</param>
        /// <returns name="SurfaceOutputSpec">Surface Output Specification</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Conduction, conduction, setconduction, SetConduction
        /// </search>
        public static SurfaceOutputSpec SetConduction(SurfaceOutputSpec SurfaceOutputSpec, bool Conduction)
        {
            int aValue = 0;
            if (Conduction)
                aValue = 1;
            SurfaceOutputSpec.pSurfaceOutputSpec.conduction = aValue;
            return SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Dry Bulb Temperature
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="Value">Dry Bulb Temperature Value</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Dry Bulb Temp, DryBulbTemp, DryBulbTemperature
        /// </search>
        public static bool DryBulbTemperature(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.dryBulbTemp == 1;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Dry Bulb Temperature
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="DryBulbTemperature">Dry Bulb Temperature</param>
        /// <returns name="SurfaceOutputSpec">SurfaceOutputSpec</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Dry Bulb Temp, DryBulbTemp, DryBulbTemperature, SetDryBulbTemperature, Set Dry Bulb Temperature
        /// </search>
        public static SurfaceOutputSpec SetDryBulbTemperature(SurfaceOutputSpec SurfaceOutputSpec, bool DryBulbTemperature)
        {
            int aValue = 0;
            if (DryBulbTemperature)
                aValue = 1;

            SurfaceOutputSpec.pSurfaceOutputSpec.dryBulbTemp = aValue;
            return SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Aperture Data
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="ApertureData">Aperture Data</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Aperture Data, ApertureData, aperturedata
        /// </search>
        public static bool ApertureData(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.apertureData == 1;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Aperture Data
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="ApertureData">Aperture Data</param>
        /// <returns name="SurfaceOutputSpec">Surface Output Specification</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Aperture Data, ApertureData, aperturedata, setaperturedata, SetApertureData
        /// </search>
        public static SurfaceOutputSpec SetApertureData(SurfaceOutputSpec SurfaceOutputSpec, bool ApertureData)
        {
            int aValue = 0;
            if (ApertureData)
                aValue = 1;

            SurfaceOutputSpec.pSurfaceOutputSpec.apertureData = aValue;
            return SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Condensation
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="Condensation">Condensation</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Condensation, condensation
        /// </search>
        public static bool Condensation(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.condensation == 1;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Condensation
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="Condensation">Surface Output Specification Condensation</param>
        /// <returns name="SurfaceOutputSpec">SurfaceOutputSpec</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Condensation, condensation, SetCondensation, setcondensation
        /// </search>
        public static SurfaceOutputSpec SetCondensation(SurfaceOutputSpec SurfaceOutputSpec, bool Condensation)
        {
            int aValue = 0;
            if (Condensation)
                aValue = 1;

            SurfaceOutputSpec.pSurfaceOutputSpec.condensation = aValue;
            return SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Name
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Name, name
        /// </search>
        public static string Name(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.name;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Name
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="Name">Surface Output Specification Name</param>
        /// <returns name="SurfaceOutputSpec">Surface Output Specification</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Name, name, setname, SetName
        /// </search>
        public static SurfaceOutputSpec SetName(SurfaceOutputSpec SurfaceOutputSpec, string Name)
        {
            SurfaceOutputSpec.pSurfaceOutputSpec.name = Name;
            return SurfaceOutputSpec;
        }

        /// <summary>
        /// Gets TAS Surface Output Specification Solar Gain
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <returns name="SolarGain">Solar Gain</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Solar Gain, SolarGain, solargain
        /// </search>
        public static bool SolarGain(SurfaceOutputSpec SurfaceOutputSpec)
        {
            return SurfaceOutputSpec.pSurfaceOutputSpec.solarGain == 1;
        }

        /// <summary>
        /// Sets TAS Surface Output Specification Solar Gain
        /// </summary>
        /// <param name="SurfaceOutputSpec">Surface Output Specification</param>
        /// <param name="SolarGain">Solar Gain</param>
        /// <returns name="SurfaceOutputSpec">Surface Output Specification</returns>
        /// <search>
        /// TAS, SurfaceOutputSpec, SurfaceOutputSpecification, Surface Output Spec, Surface Output Specification Solar Gain, SolarGain, solargain, SetSolarGain, setsolargain
        /// </search>
        public static SurfaceOutputSpec SetSolarGain(SurfaceOutputSpec SurfaceOutputSpec, bool SolarGain)
        {
            int aValue = 0;
            if (SolarGain)
                aValue = 1;

            SurfaceOutputSpec.pSurfaceOutputSpec.solarGain = aValue;
            return SurfaceOutputSpec;
        }
    }
}
