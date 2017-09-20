using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS General Details
    /// </summary>
    public class GeneralDetails
    {
        internal TBD.GeneralDetails pGeneralDetails;

        internal GeneralDetails(TBD.GeneralDetails GeneralDetails)
        {
            pGeneralDetails = GeneralDetails;
        }

        /// <summary>
        /// Gets TAS General Details Terrain Type
        /// </summary>
        /// <param name="GeneralDetails">TAS General Details</param>
        /// <returns name="TerrainType">Terrain Type</returns>
        /// <search>
        /// TAS, Building, GeneralDetails, General Details, TerrainType, Terrain Type, generaldetails, general details, terraintype, terrain type
        /// </search>
        public static TerrainType TerrainType(GeneralDetails GeneralDetails)
        {
            return (TerrainType)(int)GeneralDetails.pGeneralDetails.TerrainType;
        }

        /// <summary>
        /// Sets TAS General Details Terrain Type
        /// </summary>
        /// <param name="GeneralDetails">TAS General Details</param>
        /// <param name="TerrainType">Terrain Type</param>
        /// <returns name="GeneralDetails">General Details</returns>
        /// <search>
        /// TAS, Building, GeneralDetails, General Details, TerrainType, Terrain Type, generaldetails, general details, terraintype, terrain type, setterraintype, set terrain type, SetTerrainType, Set Terrain Type
        /// </search>
        public static GeneralDetails SetTerrainType(GeneralDetails GeneralDetails, TerrainType TerrainType)
        {
            GeneralDetails.pGeneralDetails.TerrainType = (TBD.TerrainType)(int)TerrainType;
            return GeneralDetails;
        }

    }

    /// <summary>
    /// TAS TBD Terrain Type
    /// </summary>  
    public enum TerrainType
    {
        /// <summary>City</summary>
        City = 3,
        /// <summary>Flat Profile</summary>
        FlatProfile = 4,
        /// <summary>Open</summary>
        Open = 0,
        /// <summary>Rural</summary>
        Rural = 1,
        /// <summary>Twon</summary>
        Town = 2
    }
}
