using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Construction
    /// </summary>
    public class Construction
    {
        internal TBD.Construction pConstruction;

        internal Construction(TBD.Construction Construction)
        {
            pConstruction = Construction;
        }

        /// <summary>
        /// Gets TAS Construction description
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Description">Construction description</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Description, builidng, construction, get construction description 
        /// </search>
        public static string Description(Construction Construction)
        {
            return Construction.pConstruction.description;
        }

        /// <summary>
        /// Gets TAS Construction Additional Heat Transfer
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="AdditionalHeatTransfer">Additional Heat Transfer</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Additional Heat Transfer, builidng, construction, get construction additional heat transfer, AdditionalHeatTransfer, additionalheattransfer
        /// </search>
        public static float AdditionalHeatTransfer(Construction Construction)
        {
            return Construction.pConstruction.additionalHeatTransfer;
        }

        /// <summary>
        /// Gets TAS Construction conductance
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Conductance">Construction conductance</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Conductance, builidng, construction, get construction conductance 
        /// </search>
        public static float Conductance(Construction Construction)
        {
            return Construction.pConstruction.conductance;
        }

        /// <summary>
        /// Gets TAS Construction External Blind
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="ExternalBlind">External Blind</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction External Blind, builidng, construction, get construction external blind, ExternalBlind, externalblind
        /// </search>
        public static int ExternalBlind(Construction Construction)
        {
            return Construction.pConstruction.externalBlind;
        }

        /// <summary>
        /// Gets TAS Construction External Emissivity
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Emissivity">External Emissivity</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction External Emissivity, builidng, construction, get construction external emissivity, ExternalEmissivity, externalemissivity
        /// </search>
        public static float ExternalEmissivity(Construction Construction)
        {
            return Construction.pConstruction.externalEmissivity;
        }

        /// <summary>
        /// Gets TAS Construction External Solar Absorptance for External Surface
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Absorptance">External Solar Absorptance for External Surface</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction External Solar Absorptance External Surface, builidng, construction, get construction external solar absorptance external surface,  ExternalSolarAbsorptanceExtSurf, externalsolarabsorptanceextsurf, ExternalSolarAbsorptanceExternalSurface, externalsolarabsorptanceexternalsurface, 
        /// </search>
        public static float ExternalSolarAbsorptanceExtSurf(Construction Construction)
        {
            return Construction.pConstruction.externalSolarAbsorptanceExtSurf;
        }

        /// <summary>
        /// Gets TAS Construction External Solar Absorptance for Internal Surface
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Absorptance">External Solar Absorptance for Internal Surface</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction External Solar Absorptance Internal Surface, builidng, construction, get construction external solar absorptance for internal surface, ExternalSolarAbsorptanceIntSurf, ExternalSolarAbsorptanceInternalSurface, externalsolarabsorptanceintsurf, externalsolarabsorptanceinternalsurface
        /// </search>
        public static float ExternalSolarAbsorptanceIntSurf(Construction Construction)
        {
            return Construction.pConstruction.externalSolarAbsorptanceIntSurf;
        }

        /// <summary>
        /// Gets TAS Construction FFactor
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="FFactor">Construction FFactor</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction FFactor, builidng, construction, get construction ffactor , FFactor, ffactor
        /// </search>
        public static float FFactor(Construction Construction)
        {
            return Construction.pConstruction.FFactor;
        }

        /// <summary>
        /// Gets TAS Construction GUID
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="GUID">Construction GUID</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction GUID, builidng, construction, get construction guid 
        /// </search>
        public static string GUID(Construction Construction)
        {
            return Construction.pConstruction.GUID;
        }

        /// <summary>
        /// Gets TAS Construction Internal Blind
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="InternalBlind">Construction Internal Blind</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Internal Blind, builidng, construction, get construction internal blind, InternalBlind, internalblind 
        /// </search>
        public static int InternalBlind(Construction Construction)
        {
            return Construction.pConstruction.internalBlind;
        }

        /// <summary>
        /// Gets TAS Construction Internal Emissivity
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Emissity">Construction Internal Emissivity</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Internal Emissivity, builidng, construction, get construction internal emissivity, InternalEmissivity, internalemissivity
        /// </search>
        public static float InternalEmissivity(Construction Construction)
        {
            return Construction.pConstruction.internalEmissivity;
        }

        /// <summary>
        /// Gets TAS Construction Internal Solar Absorptance for External Surface
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Absorptance">Construction Absorptance</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Internal Solar Absorptance External Surface, builidng, construction, get construction internal solar absorptance external surface, InternalSolarAbsorptanceExtSurf, InternalSolarAbsorptanceExternalSurface, internalsolarabsorptanceextsurf, internalsolarabsorptanceexternalsurface
        /// </search>
        public static float InternalSolarAbsorptanceExtSurf(Construction Construction)
        {
            return Construction.pConstruction.internalSolarAbsorptanceExtSurf;
        }

        /// <summary>
        /// Gets TAS Construction Internal Solar Absorptance for Internal Surface
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Absorptance">Construction Internal Solar Absorptance for Internal Surface</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Internal Solar Absorptance Internal Surface, builidng, construction, get construction internal solar absorptance internal surface, InternalSolarAbsorptanceIntSurf, InternalSolarAbsorptanceInternalSurface, internalsolarabsorptanceintsurf, internalsolarabsorptanceinternalsurface
        /// </search>
        public static float InternalSolarAbsorptanceIntSurf(Construction Construction)
        {
            return Construction.pConstruction.internalSolarAbsorptanceIntSurf;
        }

        /// <summary>
        /// Gets TAS Construction Light Reflectance
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="LightReflectance">Construction Light Reflectance/returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Light Reflectance, builidng, construction, get construction light reflectance, LightReflectance, lightreflectance
        /// </search>
        public static float LightReflectance(Construction Construction)
        {
            return Construction.pConstruction.lightReflectance;
        }

        /// <summary>
        /// Gets TAS Construction Light Transmittance
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="LightTransmittance">Construction Light Transmittance</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Light Transmittance, builidng, construction, get construction light transmittance, LightTransmittance, lighttransmittance
        /// </search>
        public static float LightTransmittance(Construction Construction)
        {
            return Construction.pConstruction.lightTransmittance;
        }

        /// <summary>
        /// Gets TAS Construction GUID
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <param name="Index">Material Contruction Index</param>
        /// <returns name="Width">Construction Material Width</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Material Width, builidng, construction, get construction material width, MaterialWidth, materialwidth
        /// </search>
        public static float MaterialWidth(Construction Construction, int Index)
        {
            return Construction.pConstruction.materialWidth[Index];
        }

        /// <summary>
        /// Gets TAS Construction Name
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Name">Construction Name</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Name, builidng, construction, get construction name 
        /// </search>
        public static string Name(Construction Construction)
        {
            return Construction.pConstruction.name;
        }

        /// <summary>
        /// Gets TAS Construction Solar Transmittance
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="SolarTransmittance">Solar Transmittance</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Solar Transmittance, builidng, construction, get construction solar transmittance, SolarTransmittance, solartransmittance
        /// </search>
        public static float SolarTransmittance(Construction Construction)
        {
            return Construction.pConstruction.solarTransmittance;
        }

        /// <summary>
        /// Gets TAS Construction Time Constant
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="TimeConstant">Construction Time Constant</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Time Constant, builidng, construction, get construction time constant, TimeConstant, timeconstant
        /// </search>
        public static float TimeConstant(Construction Construction)
        {
            return Construction.pConstruction.timeConstant;
        }

        /// <summary>
        /// Gets TAS Construction Type
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="ConstructionType">Construction Type</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Construction Type, builidng, construction, get construction construction type, ConstructionType, constructiontype
        /// </search>
        public static ConstructionTypes ConstructionType(Construction Construction)
        {
            return (ConstructionTypes)(int)Construction.pConstruction.type;
        }

        /// <summary>
        /// Gets TAS Construction Material
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <param name="Index">Material Index</param>
        /// <returns name="Name">Construction Name</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Material, builidng, construction, get construction material 
        /// </search>
        public static Material GetMaterial(Construction Construction, int Index)
        {
            return new Material(Construction.pConstruction.materials(Index));
        }

        /// <summary>
        /// Gets TAS Construction Materials
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Materials">Construction Materials</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Materials, builidng, construction, get construction materials
        /// </search>
        public static List<Material> Materials(Construction Construction)
        {
            List<Material> aMaterialList = new List<Material>();

            int aIndex = 1;
            TBD.material aMaterial = Construction.pConstruction.materials(aIndex);
            while (aMaterial != null)
            {
                aMaterialList.Add(new Material(aMaterial));
                aIndex++;
                aMaterial = Construction.pConstruction.materials(aIndex);
            }
            return aMaterialList;
        }

        /// <summary>
        /// Gets TAS Construction U Value
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Name">Construction U Value</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction U Value, builidng, construction, get construction u, uvalue, UValue 
        /// </search>
        public static object U(Construction Construction)
        {
            return Construction.pConstruction.GetUValue();
        }

        /// <summary>
        /// Gets Glazing Values for Construction
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <returns name="Values">Construction Glazing Values</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Glazing Values, builidng, construction, get construction glazing values, GetGlazingValues, getglazingvalues
        /// </search>
        public static object GetGlazingValues(Construction Construction)
        {
            return Construction.pConstruction.GetGlazingValues();
        }

        /// <summary>
        /// Gets TAS Construction Name
        /// </summary>
        /// <param name="Construction">TAS Construction</param>
        /// <param name="TIn">TIn</param>
        /// <param name="TOut">TOut</param>
        /// <param name="RhIn">RhIn</param>
        /// <param name="RhOut">RhOut</param>
        /// <param name="RIn">RIn</param>
        /// <param name="ROut">ROut</param>
        /// <param name="BucketArray">BucketArray</param>
        /// <returns name="CondAnalysis">Construction Cond Analysis</returns>
        /// <search>
        /// TAS, Builidng, Construction, Get Construction Name, builidng, construction, get construction name 
        /// </search>
        public static object GetCondAnalysis(Construction Construction, float TIn, float TOut, float RhIn, float RhOut, float RIn, float ROut, string BucketArray)
        {
            return Construction.pConstruction.GetCondAnalysis(TIn, TOut, RhIn, RhOut, RIn, ROut, BucketArray);
        }
    }

    /// <summary>
    /// TAS TBD Construction Types
    /// </summary>  
    public enum ConstructionTypes
    {
        /// <summary>Opaque Construction</summary>
        Opaque = 1,
        /// <summary>Transparent Construction</summary>
        Transparent = 2
    }
}
