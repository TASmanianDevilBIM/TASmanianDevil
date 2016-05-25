using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Thermostat
    /// </summary>
    public class Thermostat
    {
        private TBD.Thermostat pThermostat;

        internal Thermostat(TBD.Thermostat Thermostat)
        {
            pThermostat = Thermostat;
        }

        /// <summary>
        /// TAS Thermostat Control Range
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="ControlRange">Control Range</returns>
        /// <search>
        /// TAS, Thermostat, ControlRange, Control Range, thermostat, controlrange, control range
        /// </search>
        public static float ControlRange(Thermostat Thermostat)
        {
            return Thermostat.pThermostat.controlRange;
        }

        /// <summary>
        /// Set TAS Thermostat Control Range
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <param name="Value">Control Range Value</param>
        /// <returns name="Thermostat">Thermostat</returns>
        /// <search>
        /// TAS, Thermostat, ControlRange, Control Range, thermostat, controlrange, control range, SetControlRange
        /// </search>
        public static Thermostat SetControlRange(Thermostat Thermostat, float Value)
        {
            Thermostat.pThermostat.controlRange = Value;
            return Thermostat;
        }

        /// <summary>
        /// TAS Thermostat Description
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="Description">Description</returns>
        /// <search>
        /// TAS, Thermostat, Description, thermostat, description
        /// </search>
        public static string Description(Thermostat Thermostat)
        {
            return Thermostat.pThermostat.description;
        }

        /// <summary>
        /// TAS Thermostat Name
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Thermostat, Name, thermostat, name
        /// </search>
        public static string Name(Thermostat Thermostat)
        {
            return Thermostat.pThermostat.name;
        }

        /// <summary>
        /// Sets TAS Thermostat Name
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <param name="Name">Name</param>
        /// <returns name="Thermostat">Thermostat</returns>
        /// <search>
        /// TAS, Thermostat, Name, thermostat, name
        /// </search>
        public static Thermostat SetName(Thermostat Thermostat, string Name)
        {
            Thermostat.pThermostat.name = Name;
            return Thermostat;
        }

        /// <summary>
        /// TAS Thermostat Proportional Control
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="ProportionalControl">Proportional Control</returns>
        /// <search>
        /// TAS, Thermostat, ProportionalControl, thermostat, proportionalcontrol, Proportional Control, proportional control
        /// </search>
        public static int ProportionalControl(Thermostat Thermostat)
        {
            return Thermostat.pThermostat.proportionalControl;
        }

        /// <summary>
        /// Sets TAS Thermostat Proportional Control
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <param name="Value">Proportional Control Value</param>
        /// <returns name="Thermostat">Thermostat</returns>
        /// <search>
        /// TAS, Thermostat, ProportionalControl, thermostat, proportionalcontrol, Proportional Control, proportional control, SetProportionalControl
        /// </search>
        public static Thermostat SetProportionalControl(Thermostat Thermostat, int Value)
        {
            Thermostat.pThermostat.proportionalControl = Value;
            return Thermostat;
        }

        /// <summary>
        /// TAS Thermostat Radiant Proportion
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="RadiantProportion">Radiant Proportion</returns>
        /// <search>
        /// TAS, Thermostat, RadiantProportion, thermostat, radiantproportion, Radiant Proportion, radiant proportion
        /// </search>
        public static float RadiantProportion(Thermostat Thermostat)
        {
            return Thermostat.pThermostat.radiantProportion;
        }

        /// <summary>
        /// TAS Thermostat Radiant Proportion
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <param name="Value">Radiant Proportion Value</param>
        /// <returns name="Thermostat">Thermostat</returns>
        /// <search>
        /// TAS, Thermostat, RadiantProportion, thermostat, radiantproportion, Radiant Proportion, radiant proportion, SetRadiantProportion
        /// </search>
        public static Thermostat SetRadiantProportion(Thermostat Thermostat, float Value)
        {
            Thermostat.pThermostat.radiantProportion = Value;
            return Thermostat;
        }

        /// <summary>
        /// TAS Thermostat Profile
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <param name="Index">Profile Index</param>
        /// <returns name="Profile">Profile</returns>
        /// <search>
        /// TAS, Thermostat, Profile, thermostat, profile, GetProfile
        /// </search>
        public static Profile GetProfile(Thermostat Thermostat, int Index)
        {
            return new Profile(Thermostat.pThermostat.GetProfile(Index));
        }

        /// <summary>
        /// Gets TAS Thermostat Profiles
        /// </summary>
        /// <param name="Thermostat">Thermostat</param>
        /// <returns name="Profiles">Profile List</returns>
        /// <search>
        /// TAS, Thermostat, Profiles, profiles, thermostat
        /// </search>
        public static List<Profile> Profiles(Thermostat Thermostat)
        {
            List<Profile> aProfileList = new List<Profile>();

            int aIndex = 1;
            TBD.profile aProfile = Thermostat.pThermostat.GetProfile(aIndex);
            while (aProfile != null)
            {
                aProfileList.Add(new Profile(aProfile));
                aIndex++;
                aProfile = Thermostat.pThermostat.GetProfile(aIndex);
            }
            return aProfileList;
        }

    }
}
