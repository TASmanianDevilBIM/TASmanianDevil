using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Aperture Type
    /// </summary>
    public class ApertureType
    {
        internal TBD.ApertureType pApertureType;

        internal ApertureType(TBD.ApertureType ApertureType)
        {
            pApertureType = ApertureType;
        }

        /// <summary>
        /// TAS Aperture Type Name
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, ApertureType, Name, name, Aperture Type
        /// </search>
        public static string Name(ApertureType ApertureType)
        {
            return ApertureType.pApertureType.name;
        }

        /// <summary>
        /// Sets Aperture Type Name
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <param name="Name">Name</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, ApertureType, Name, name, Aperture Type, SetName
        /// </search>
        public static ApertureType SetName(ApertureType ApertureType, string Name)
        {
            ApertureType.pApertureType.name = Name;
            return ApertureType;
        }

        /// <summary>
        /// TAS Aperture Type Description
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, ApertureType, Description, Description, Aperture Type
        /// </search>
        public static string Description(ApertureType ApertureType)
        {
            return ApertureType.pApertureType.description;
        }

        /// <summary>
        /// Sets Aperture Type Description
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <param name="Description">Aperture Type Description</param>
        /// <returns name="ApertureType">ApertureType</returns>
        /// <search>
        /// TAS, ApertureType, Description, Description, Aperture Type, SetDescription
        /// </search>
        public static ApertureType SetDescription(ApertureType ApertureType, string Description)
        {
            ApertureType.pApertureType.description = Description;
            return ApertureType; 
        }

        /// <summary>
        /// Gets Day Type of Aperture Type 
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <param name="Index">dayType Index</param>
        /// <returns name="DayType">Day Type</returns>
        /// <search>
        /// TAS, ApertureType, DayType, Day Type, Aperture Type, GetDayType
        /// </search>
        public static DayType GetDayType(ApertureType ApertureType, int Index)
        {
            return new DayType(ApertureType.pApertureType.GetDayType(Index));
        }

        /// <summary>
        /// Gets Aperture Type Profile
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, ApertureType, Profile, Profile, Aperture Type, GetProfile
        /// </search>
        public static Profile GetProfile(ApertureType ApertureType)
        {
            return new Profile(ApertureType.pApertureType.GetProfile());
        }

        /// <summary>
        /// Sets Day Type for Aperture Type
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <param name="DayType">Day Type</param>
        /// <param name="Add">Add Day Type</param>
        /// <returns name="Value">Value</returns>
        /// <search>
        /// TAS, ApertureType, DayType, Day Type, Aperture Type, SetDayType
        /// </search>
        public static int SetDayType(ApertureType ApertureType, DayType DayType, bool Add)
        {
            return ApertureType.pApertureType.SetDayType(DayType.pDayType, Add);
        }

        /// <summary>
        /// TAS Aperture Type Sheltered
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <returns name="Sheltered">Aperture Type Sheltered</returns>
        /// <search>
        /// TAS, ApertureType, Sheltered, sheltered, Aperture Type
        /// </search>
        public static int Sheltered(ApertureType ApertureType)
        {
            return ApertureType.pApertureType.sheltered;
        }

        /// <summary>
        /// Sets Aperture Type Sheltered
        /// </summary>
        /// <param name="ApertureType">Aperture Type</param>
        /// <param name="Value">Aperture Type Sheltered Value</param>
        /// <returns name="ApertureType">Aperture Type</returns>
        /// <search>
        /// TAS, ApertureType, Sheltered, sheltered, Aperture Type, SetSheltered
        /// </search>
        public static ApertureType SetSheltered(ApertureType ApertureType, int Value)
        {
            ApertureType.pApertureType.sheltered = Value;
            return ApertureType; 
        }
    }
}
