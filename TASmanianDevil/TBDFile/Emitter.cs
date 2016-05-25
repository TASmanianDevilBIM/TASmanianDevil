using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS Emitter
    /// </summary>
    public class Emitter
    {
        private TBD.Emitter pEmitter;

        internal Emitter(TBD.Emitter Emitter)
        {
            pEmitter = Emitter;
        }

        /// <summary>
        /// TAS Emitter Air Con
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="AirCon">Air Con</returns>
        /// <search>
        /// TAS, Emitter, emitter, AirCon, aircon, air con, Air Con
        /// </search>
        public static int AirCon(Emitter Emitter)
        {
            return Emitter.pEmitter.airCon;
        }

        /// <summary>
        /// Sets TAS Emitter Air Con
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">Air Con Value</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, AirCon, aircon, air con, Air Con, SetAirCon
        /// </search>
        public static Emitter SetAirCon(Emitter Emitter, int Value)
        {
            Emitter.pEmitter.airCon = Value;
            return Emitter;
        }

        /// <summary>
        /// TAS Emitter Description
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Description">Emitter Description</returns>
        /// <search>
        /// TAS, Emitter, emitter, Description, description
        /// </search>
        public static string Description(Emitter Emitter)
        {
            return Emitter.pEmitter.description;
        }

        /// <summary>
        /// Sets TAS Emitter Description
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Description">Description</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, Description, description, SetDescription
        /// </search>
        public static Emitter SetDescription(Emitter Emitter, string Description)
        {
            Emitter.pEmitter.description = Description;
            return Emitter;
        }

        /// <summary>
        /// TAS Emitter Design Delta T
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="DesignDeltaT">Design Delta T</returns>
        /// <search>
        /// TAS, Emitter, emitter, DesignDeltaT, designdeltat, Design Delta T
        /// </search>
        public static float DesignDeltaT(Emitter Emitter)
        {
            return Emitter.pEmitter.designDeltaT;
        }

        /// <summary>
        /// Sets TAS Emitter Design Delta T
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">Design Delta T Value</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, DesignDeltaT, designdeltat, Design Delta T, SetDesignDeltaT
        /// </search>
        public static Emitter SetDesignDeltaT(Emitter Emitter, float Value)
        {
            Emitter.pEmitter.designDeltaT = Value;
            return Emitter;  
        }

        /// <summary>
        /// TAS Emitter Max Outside Temperature
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Temperature">Max Outside Temperature</returns>
        /// <search>
        /// TAS, Emitter, emitter, MaxOutsideTemperature, maxoutsidetemperature, Max Outside Temperature, max outside temperature
        /// </search>
        public static float MaxOutsideTemperature(Emitter Emitter)
        {
            return Emitter.pEmitter.maxOutsideTemp;
        }

        /// <summary>
        /// Sets TAS Emitter Max Outside Temperature
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">Max Outside Temperature Value</param>
        /// <returns name="Temperature">Max Outside Temperature</returns>
        /// <search>
        /// TAS, Emitter, emitter, MaxOutsideTemperature, maxoutsidetemperature, Max Outside Temperature, max outside temperature, SetMaxOutsideTemperature
        /// </search>
        public static Emitter SetMaxOutsideTemperature(Emitter Emitter, float Value)
        {
            Emitter.pEmitter.maxOutsideTemp = Value;
            return Emitter;
        }

        /// <summary>
        /// TAS Emitter Name
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Emitter, emitter, Name, name
        /// </search>
        public static string Name(Emitter Emitter)
        {
            return Emitter.pEmitter.name;
        }

        /// <summary>
        /// Sets TAS Emitter Name
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Name">Name</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, Name, name, SetName
        /// </search>
        public static Emitter SetName(Emitter Emitter, string Name)
        {
            Emitter.pEmitter.name = Name;
            return Emitter;
        }

        /// <summary>
        /// TAS Emitter Off Outside Temperature
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Temperature">Off Outside Temperature</returns>
        /// <search>
        /// TAS, Emitter, emitter, OffOutsideTemperature, offoutsidetemperature, Off Outside Temperature, offoutsidetemperature
        /// </search>
        public static float OffOutsideTemperature(Emitter Emitter)
        {
            return Emitter.pEmitter.offOutsideTemp;
        }

        /// <summary>
        /// Sets TAS Emitter Off Outside Temperature
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">Off Outside Temperature Value</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, OffOutsideTemperature, offoutsidetemperature, Off Outside Temperature, offoutsidetemperature, SetOffOutsideTemperature
        /// </search>
        public static Emitter SetOffOutsideTemperature(Emitter Emitter, float Value)
        {
            Emitter.pEmitter.offOutsideTemp = Value;
            return Emitter; 
        }

        /// <summary>
        /// TAS Emitter Radiant Proportion
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="RadiantProportion">Radiant Proportion</returns>
        /// <search>
        /// TAS, Emitter, emitter, RadiantProportion, radiantproportion, Radiant Proportion, radiant proportion
        /// </search>
        public static float RadiantProportion(Emitter Emitter)
        {
            return Emitter.pEmitter.radiantProportion;
        }

        /// <summary>
        /// Sets TAS Emitter Radiant Proportion
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">Radiant Proportion Value</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, RadiantProportion, radiantproportion, Radiant Proportion, radiant proportion, SetRadiantProportion
        /// </search>
        public static Emitter SetRadiantProportion(Emitter Emitter, float Value)
        {
            Emitter.pEmitter.radiantProportion = Value;
            return Emitter;
        }

        /// <summary>
        /// TAS Emitter View Coefficient
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Coefficient">View Coefficient</returns>
        /// <search>
        /// TAS, Emitter, emitter, ViewCoefficient, viewcoefficient, view coefficient, View Coefficient
        /// </search>
        public static float ViewCoefficient(Emitter Emitter)
        {
            return Emitter.pEmitter.viewCoefficient;
        }

        /// <summary>
        /// Set TAS Emitter View Coefficient
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="Value">View Coefficient Value</param>
        /// <returns name="Coefficient">View Coefficient</returns>
        /// <search>
        /// TAS, Emitter, emitter, ViewCoefficient, viewcoefficient, view coefficient, View Coefficient, SetViewCoefficient
        /// </search>
        public static Emitter SetViewCoefficient(Emitter Emitter, float Value)
        {
            Emitter.pEmitter.viewCoefficient = Value;
            return Emitter;  
        }

        /// <summary>
        /// TAS Emitter Type
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <returns name="Name">Name</returns>
        /// <search>
        /// TAS, Emitter, emitter, Type, type, EmitterType
        /// </search>
        public static EmitterTypes EmitterType(Emitter Emitter)
        {
            return (EmitterTypes)(int)Emitter.pEmitter.emitterType;
        }

        /// <summary>
        /// Sets TAS Emitter Emitter Type
        /// </summary>
        /// <param name="Emitter">Emitter</param>
        /// <param name="EmitterType">Emitter Type</param>
        /// <returns name="Emitter">Emitter</returns>
        /// <search>
        /// TAS, Emitter, emitter, Name, name, SetEmitterType
        /// </search>
        public static Emitter SetEmitterType(Emitter Emitter, EmitterTypes EmitterType)
        {
            Emitter.pEmitter.emitterType = (TBD.EmitterTypes)(int)EmitterType;
            return Emitter;
        }
    }

    /// <summary>
    /// TAS TBD Emitter Types
    /// </summary>  
    public enum EmitterTypes
    {
        /// <summary>Cooling</summary>
        Cooling = 0,
        /// <summary>Heating</summary>
        Heating = 1,
        /// <summary>Compensated Cooling</summary>
        CompensatedCooling = 2,
        /// <summary>Compensated Heating</summary>
        CompensatedHeating = 3
    }
}
