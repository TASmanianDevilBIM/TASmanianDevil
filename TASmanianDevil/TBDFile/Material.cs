using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Material
    /// </summary>
    public class Material
    {
        private TBD.material pMaterial;

        internal Material(TBD.material Material)
        {
            pMaterial = Material;
        }

        /// <summary>
        /// TAS Material Description
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Description">Material Description</returns>
        /// <search>
        /// TAS, Material, material, Description, description
        /// </search>
        public static string Description(Material Material)
        {
            return Material.pMaterial.description;
        }

        /// <summary>
        /// Set TAS Material Description
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Description">Material Description</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Description, description, SetDescription, Set Description, setdescription, set description
        /// </search>
        public static Material SetDescription(Material Material, string Description)
        {
            Material.pMaterial.description = Description;
            return Material;
        }

        /// <summary>
        /// TAS Material Conductivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Conductivity">Material Conductivity</returns>
        /// <search>
        /// TAS, Material, material, Conductivity, conductivity
        /// </search>
        public static float Conductivity(Material Material)
        {
            return Material.pMaterial.conductivity;
        }

        /// <summary>
        /// Sets TAS Material Conductivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Conductivity">Material Conductivity</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Conductivity, conductivity, SetConductivity, Set Conductivity, setconductivity, set conductivity
        /// </search>
        public static Material SetConductivity(Material Material, float Conductivity)
        {
            Material.pMaterial.conductivity = Conductivity;
            return Material;
        }

        /// <summary>
        /// TAS Material Convection Coefficient
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="ConvectionCoefficient">Material Convection Coefficient</returns>
        /// <search>
        /// TAS, Material, material, ConvectionCoefficient, convectioncoefficient, Convection Coefficient, convection coefficient
        /// </search>
        public static float ConvectionCoefficient(Material Material)
        {
            return Material.pMaterial.convectionCoefficient;
        }

        /// <summary>
        /// TAS Material Density
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Density">Material Density</returns>
        /// <search>
        /// TAS, Material, material, Density, density
        /// </search>
        public static float Density(Material Material)
        {
            return Material.pMaterial.density;
        }

        /// <summary>
        /// Sets TAS Material Density
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Density">Material Density</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Density, density, SetDensity, Set Density, setdensity, set density
        /// </search>
        public static Material SetDensity(Material Material, float Density)
        {
            Material.pMaterial.density = Density;
            return Material;
        }

        /// <summary>
        /// TAS Material External Emissivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="ExternalEmissivity">Material External Emissivity</returns>
        /// <search>
        /// TAS, Material, material, External Emissivity, external emissivity, externalemissivity, ExternalEmissivity
        /// </search>
        public static float ExternalEmissivity(Material Material)
        {
            return Material.pMaterial.externalEmissivity;
        }

        /// <summary>
        /// Sets TAS Material External Emissivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material External Emissivity</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, External Emissivity, external emissivity, externalemissivity, ExternalEmissivity, SetExternalEmissivity, setexternalemissivity, Set External Emissivity, set external emissivity
        /// </search>
        public static Material SetExternalEmissivity(Material Material, float Value)
        {
            Material.pMaterial.externalEmissivity = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material External Light Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Reflectance">External Light Reflectance</returns>
        /// <search>
        /// TAS, Material, material, ExternalLightReflectance, externallightreflectance, External Light Reflectance, external light reflectance
        /// </search>
        public static float ExternalLightReflectance(Material Material)
        {
            return Material.pMaterial.externalLightReflectance;
        }

        /// <summary>
        /// Sets TAS Material External Light Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">External Light Reflectance</param>
        /// <returns name="Material">material</returns>
        /// <search>
        /// TAS, Material, material, ExternalLightReflectance, externallightreflectance, External Light Reflectance, external light reflectance, SetExternalLightReflectance, Set External Light Reflectance, set external light reflectance, setexternallightreflectance
        /// </search>
        public static Material SetExternalLightReflectance(Material Material, float Value)
        {
            Material.pMaterial.externalLightReflectance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material External Solar Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Reflectance">Material External Solar Reflectance</returns>
        /// <search>
        /// TAS, Material, material, ExternalSolarReflectance, externalsolarreflectance, External Solar Reflectance, external solar reflectance
        /// </search>
        public static float ExternalSolarReflectance(Material Material)
        {
            return Material.pMaterial.externalSolarReflectance;
        }

        /// <summary>
        /// Sets TAS Material External Solar Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material External Solar Reflectance</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, ExternalSolarReflectance, externalsolarreflectance, External Solar Reflectance, external solar reflectance, SetExternalSolarReflectance, setexternalsolarreflectance, set external solar reflectance, Set External Solar Reflectance
        /// </search>
        public static Material SetExternalSolarReflectance(Material Material, float Value)
        {
            Material.pMaterial.externalSolarReflectance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Internal Emissivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="InternalEmissivity">Material Internal Emissivity</returns>
        /// <search>
        /// TAS, Material, material, InternalEmissivity, internalemissivity, Internal Emissivity, internal emissivity
        /// </search>
        public static float InternalEmissivity(Material Material)
        {
            return Material.pMaterial.internalEmissivity;
        }

        /// <summary>
        /// Sets TAS Material Internal Emissivity
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Internal Emissivity</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, InternalEmissivity, internalemissivity, Internal Emissivity, internal emissivity, SetInternalEmissivity, setinternalemissivity, Set Internal Emissivity, set internal emissivity
        /// </search>
        public static Material SetInternalEmissivity(Material Material, float Value)
        {
            Material.pMaterial.internalEmissivity = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Internal Light Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Reflectance">Material Internal Light Reflectance</returns>
        /// <search>
        /// TAS, Material, material, InternalLightReflectance, internallightreflectance, Internal Light Reflectance, internal light reflectance
        /// </search>
        public static float InternalLightReflectance(Material Material)
        {
            return Material.pMaterial.internalLightReflectance;
        }

        /// <summary>
        /// Sets TAS Material Internal Light Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Internal Light Reflectance</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, InternalLightReflectance, internallightreflectance, Internal Light Reflectance, internal light reflectance, SetInternalLightReflectance, setinternallightreflectance, SetInternalLightReflectance, Set Internal Light Reflectance
        /// </search>
        public static Material SetInternalLightReflectance(Material Material, float Value)
        {
            Material.pMaterial.internalLightReflectance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Internal Solar Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Reflectance">Material Internal Solar Reflectance</returns>
        /// <search>
        /// TAS, Material, material, InternalSolarReflectance, internalsolarreflectance, Internal Solar Reflectance, internal solar reflectance
        /// </search>
        public static float InternalSolarReflectance(Material Material)
        {
            return Material.pMaterial.internalSolarReflectance;
        }

        /// <summary>
        /// Sets TAS Material Internal Solar Reflectance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Internal Solar Reflectance</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, InternalSolarReflectance, internalsolarreflectance, Internal Solar Reflectance, internal solar reflectance, SetInternalSolarReflectance, Set Internal Solar Reflectance, setinternalsolarreflectance, set internal solar reflectance
        /// </search>
        public static Material SetInternalSolarReflectance(Material Material, float Value)
        {
            Material.pMaterial.internalSolarReflectance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material is Blind
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Blind">Is Material Blind</returns>
        /// <search>
        /// TAS, Material, material, IsBlind, isblind, Is Blind, is blind
        /// </search>
        public static int IsBlind(Material Material)
        {
            return Material.pMaterial.isBlind;
        }

        /// <summary>
        /// Sets TAS Material is Blind
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="IsBlind">Is Material Blind</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, IsBlind, isblind, Is Blind, is blind, SetIsBlind, setisblind
        /// </search>
        public static Material SetIsBlind(Material Material, int IsBlind)
        {
            Material.pMaterial.isBlind = IsBlind;
            return Material;
        }

        /// <summary>
        /// TAS Material Light Transmittance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="LightTransmittance">Material Light Transmittance</returns>
        /// <search>
        /// TAS, Material, material, LightTransmittance, lighttransmittance, Light Transmittance, light transmittance
        /// </search>
        public static float LightTransmittance(Material Material)
        {
            return Material.pMaterial.lightTransmittance;
        }

        /// <summary>
        /// Sets TAS Material Light Transmittance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Light Transmittance</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, LightTransmittance, lighttransmittance, Light Transmittance, light transmittance, SetLightTransmittance, Set Light Transmittance, setlighttransmittance, set light transmittance
        /// </search>
        public static Material SetLightTransmittance(Material Material, float Value)
        {
            Material.pMaterial.lightTransmittance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Name
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Name">Material Name</returns>
        /// <search>
        /// TAS, Material, material, Name, name
        /// </search>
        public static string Name(Material Material)
        {
            return Material.pMaterial.name;
        }

        /// <summary>
        /// Sets TAS Material Name
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Name">Material Name</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Name, name, SetName, Set Name, setname, set name
        /// </search>
        public static Material SetName(Material Material, string Name)
        {
            Material.pMaterial.name = Name;
            return Material;
        }

        /// <summary>
        /// TAS Material Solar Transmittance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="SolarTransmittance">Material Solar Transmittance</returns>
        /// <search>
        /// TAS, Material, material, SolarTransmittance, solartransmittance, Solar Transmittance, solartransmittance
        /// </search>
        public static float SolarTransmittance(Material Material)
        {
            return Material.pMaterial.solarTransmittance;
        }

        /// <summary>
        /// Sets TAS Material Solar Transmittance
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Solar Transmittance Value</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, SolarTransmittance, solartransmittance, Solar Transmittance, solartransmittance, SetSolarTransmittance, Set Solar Transmittance, setsolartransmittance, set solar transmittance
        /// </search>
        public static Material SetSolarTransmittance(Material Material, float Value)
        {
            Material.pMaterial.solarTransmittance = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Specific Heat
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="SpecificHeat">Material Specific Heat</returns>
        /// <search>
        /// TAS, Material, material, SpecificHeat, specificheat, Specific Heat, specific heat
        /// </search>
        public static float SpecificHeat(Material Material)
        {
            return Material.pMaterial.specificHeat;
        }

        /// <summary>
        /// Sets TAS Material Specific Heat
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="SpecificHeat">Material Specific Heat</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, SpecificHeat, specificheat, Specific Heat, specific heat
        /// </search>
        public static Material SetSpecificHeat(Material Material, float SpecificHeat)
        {
            Material.pMaterial.specificHeat = SpecificHeat;
            return Material;
        }

        /// <summary>
        /// TAS Material Type
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="MaterialTypes">Material Type</returns>
        /// <search>
        /// TAS, Material, material, Type, type
        /// </search>
        public static MaterialTypes Type(Material Material)
        {
            return (MaterialTypes)(int)Material.pMaterial.type;
        }

        /// <summary>
        /// Sets TAS Material Type
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="MaterialTypes">Material Type</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Type, type, SetType, settype, Set Type, set type
        /// </search>
        public static Material SetType(Material Material, MaterialTypes MaterialTypes)
        {
            Material.pMaterial.type = (int)MaterialTypes;
            return Material;
        }

        /// <summary>
        /// TAS Material Vapour Diffusion Factor
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Factor">Material Vapour Diffusion Factor</returns>
        /// <search>
        /// TAS, Material, material, VapourDiffusionFactor, vapourdiffusionfactor, Vapour Diffusion Factor, vapour diffusion factor
        /// </search>
        public static float VapourDiffusionFactor(Material Material)
        {
            return Material.pMaterial.vapourDiffusionFactor;
        }

        /// <summary>
        /// Sets TAS Material Vapour Diffusion Factor
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Value">Material Vapour Diffusion Factor</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, VapourDiffusionFactor, vapourdiffusionfactor, Vapour Diffusion Factor, vapour diffusion factor, SetVapourDiffusionFactor, Set Vapour Diffusion Factor, set vapour diffusion factor
        /// </search>
        public static Material SetVapourDiffusionFactor(Material Material, float Value)
        {
            Material.pMaterial.vapourDiffusionFactor = Value;
            return Material;
        }

        /// <summary>
        /// TAS Material Width [m]
        /// </summary>
        /// <param name="Material">Material</param>
        /// <returns name="Width">Material Width [m]</returns>
        /// <search>
        /// TAS, Material, material, Width, width
        /// </search>
        public static float Width(Material Material)
        {
            return Material.pMaterial.width;
        }

        /// <summary>
        /// Sets TAS Material Width [m]
        /// </summary>
        /// <param name="Material">Material</param>
        /// <param name="Width">Material Width [m]</param>
        /// <returns name="Material">Material</returns>
        /// <search>
        /// TAS, Material, material, Width, width, SetWidth, setwidth, set width, Set Width
        /// </search>
        public static Material SetWidth(Material Material, float Width)
        {
            Material.pMaterial.width = Width;
            return Material;
        }
    }

    /// <summary>
    /// TAS Material Types
    /// </summary>
    public enum MaterialTypes
    {
        /// <summary>Gas Layer</summary>
        GasLayer = 4,
        /// <summary>Opaque Layer</summary>
        OpaqueLayer = 2,
        /// <summary>Opaque Material</summary>
        OpaqueMaterial = 1,
        /// <summary>Transaprent Layer</summary>
        TransaprentLayer = 3,
    }
}
