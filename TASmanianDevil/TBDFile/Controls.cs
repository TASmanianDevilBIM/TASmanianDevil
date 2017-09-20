using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS TBD Controls
    /// </summary>
    public class Controls
    {
        internal TBD.Controls pControls;

        internal Controls(TBD.Controls Controls)
        {
            pControls = Controls;
        }

        /// <summary>
        /// Gets advanced start (24hr clock) of TAS Controls [1-24]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="AdvancedStart">Advanced Start [1-24]</returns>
        /// <search>
        /// TAS, Controls, controls, AdvancedStart, Advanced Start, advancedstart
        /// </search>
        public static int AdvancedStart(Controls Controls)
        {
            return Controls.pControls.advancedStart;
        }

        /// <summary>
        /// Sets advanced start (24hr clock) of TAS Controls [1-24]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="AdvancedStart">Advanced Start [1-24]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, AdvancedStart, Advanced Start, advancedstart, setadvancedstart, SetAdvancedStart
        /// </search>
        public static Controls SetAdvancedStart(Controls Controls, int AdvancedStart)
        {
            Controls.pControls.advancedStart = AdvancedStart;
            return Controls;
        }

        /// <summary>
        /// Gets External Authority of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="ExtAuthority">External Authority [0-1]</returns>
        /// <search>
        /// TAS, Controls, controls, ExtAuthority, Ext Authority, extauthority, ext authority, External Authority
        /// </search>
        public static float ExtAuthority(Controls Controls)
        {
            return Controls.pControls.extAuthority;
        }

        /// <summary>
        /// Sets External Authority of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="ExtAuthority">External Authority [0-1]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, ExtAuthority, Ext Authority, extauthority, ext authority, setextauthority, SetExtAuthority, External Authority
        /// </search>
        public static Controls SetExtAuthority(Controls Controls, float ExtAuthority)
        {
            Controls.pControls.extAuthority = ExtAuthority;
            return Controls;
        }

        /// <summary>
        /// Gets External Frost Protection Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="ExtFPLoadFactor">External Frost Protection Load Factor [0-1]</returns>
        /// <search>
        /// TAS, Controls, controls, ExtFPLoadFactor, Ext FP Load Factor, extfploadfactor, External Frost Protection
        /// </search>
        public static float ExtFPLoadFactor(Controls Controls)
        {
            return Controls.pControls.extFPLoadFactor;
        }

        /// <summary>
        /// Sets External Frost Protection Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="ExtFPLoadFactor">External Frost Protection Load Factor [0-1]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, ExtFPLoadFactor, Ext FP Load Factor, extfploadfactor, setextfploadfactor, SetExtFPLoadFactor, External Frost Protection
        /// </search>
        public static Controls SetExtFPLoadFactor(Controls Controls, float ExtFPLoadFactor)
        {
            Controls.pControls.extFPLoadFactor = ExtFPLoadFactor;
            return Controls;
        }

        /// <summary>
        /// Gets Ext FP Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="Value">Ext FP Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, Ext FP Temperature, ExtFPTemperature, extpfptemperature
        /// </search>
        public static float ExtFPTemperature(Controls Controls)
        {
            return Controls.pControls.extFPTemp;
        }

        /// <summary>
        /// Sets Ext FP Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="ExtFPTemperature">Ext FP Temperature</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, Ext FP Temperature, ExtFPTemperature, extpfptemperature, setextpfptemperature, SetExtFPTemperature
        /// </search>
        public static Controls SetExtFPTemperature(Controls Controls, float ExtFPTemperature)
        {
            Controls.pControls.extFPTemp = ExtFPTemperature;
            return Controls;
        }

        /// <summary>
        /// Gets FP OS Control Zone of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="FPOSControlZone">FP OS Control Zone</returns>
        /// <search>
        /// TAS, Controls, controls, FPOSControlZone, fposcontrolzone, FP OS Control Zone
        /// </search>
        public static int FPOSControlZone(Controls Controls)
        {
            return Controls.pControls.FPOSControlZone;
        }

        /// <summary>
        /// Sets FP OS Control Zone of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="FPOSControlZone">FP OS Control Zone</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, FPOSControlZone, fposcontrolzone, FP OS Control Zone, setfposcontrolzone, SetFPOSControlZone
        /// </search>
        public static Controls SetFPOSControlZone(Controls Controls, int FPOSControlZone)
        {
            Controls.pControls.FPOSControlZone = FPOSControlZone;
            return Controls;
        }

        /// <summary>
        /// Gets Infiltration Coefficient of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="InfiltrationCoefficient">Infiltration Coefficient</returns>
        /// <search>
        /// TAS, Controls, controls, InfiltrationCoefficient, Infiltration Coefficient, infiltrationcoefficient, infiltration coefficient
        /// </search>
        public static float InfiltrationCoefficient(Controls Controls)
        {
            return Controls.pControls.infiltrationCoefficient;
        }

        /// <summary>
        /// Sets Infiltration Coefficient of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="InfiltrationCoefficient">Infiltration Coefficient</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, InfiltrationCoefficient, Infiltration Coefficient, infiltrationcoefficient, infiltration coefficient, SetInfiltrationCoefficient, Set Infiltration Coefficient, setinfiltrationcoefficient, set infiltration coefficient
        /// </search>
        public static Controls SetInfiltrationCoefficient(Controls Controls, float InfiltrationCoefficient)
        {
            Controls.pControls.infiltrationCoefficient = InfiltrationCoefficient;
            return Controls;
        }

        /// <summary>
        /// Gets Internal Frost Protection Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="IntFPLoadFactor">Internal Frost Protection Load Factor [0-1]</returns>
        /// <search>
        /// TAS, Controls, controls, IntFPLoadFactor, Int FP Load Factor, intfploadfactor, int fp load factor, Internal Frost Protection Load Factor
        /// </search>
        public static float IntFPLoadFactor(Controls Controls)
        {
            return Controls.pControls.intFPLoadFactor;
        }

        /// <summary>
        /// Sets Internal Frost Protection Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="IntFPLoadFactor">Internal Frost Protection Load Factor [0-1]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, IntFPLoadFactor, Int FP Load Factor, intfploadfactor, int fp load factor, Internal Frost Protection Load Factor, SetIntFPLoadFactor
        /// </search>
        public static Controls SetIntFPLoadFactor(Controls Controls, float IntFPLoadFactor)
        {
            Controls.pControls.intFPLoadFactor = IntFPLoadFactor;
            return Controls;
        }

        /// <summary>
        /// Gets int FP Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="IntFPTemperature">Int FP Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, IntFPTemperature, intfptemperature, Int FP Temperature, Int FP Temp
        /// </search>
        public static float IntFPTemperature(Controls Controls)
        {
            return Controls.pControls.intFPTemp;
        }

        /// <summary>
        /// Sets int FP Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="IntFPTemperature">Int FP Temperature</param>
        /// <returns name="IntFPTemperature">Int FP Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, IntFPTemperature, intfptemperature, Int FP Temperature, Int FP Temp, SetIntFPTemperature, setintfptemperature, Set Int FP Temperature, Set Int FP Temp
        /// </search>
        public static Controls SetIntFPTemperature(Controls Controls, float IntFPTemperature)
        {
            Controls.pControls.intFPTemp = IntFPTemperature;
            return Controls;
        }

        /// <summary>
        /// Gets Lower Authority Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="Value">Lower Authority Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, LowerAuthorityTemperature, Lower Authority Temperature, lowerauthoritytemperature, lower authority temperature
        /// </search>
        public static float LowerAuthorityTemp(Controls Controls)
        {
            return Controls.pControls.lowerAuthorityTemp;
        }

        /// <summary>
        /// Sets Lower Authority Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="LowerAuthorityTemperature">Lower Authority Temperature</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, LowerAuthorityTemperature, Lower Authority Temperature, lowerauthoritytemperature, lower authority temperature, SetLowerAuthorityTemperature, Set Lower Authority Temperature, setlowerauthoritytemperature, set lower authority temperature
        /// </search>
        public static Controls SetLowerAuthorityTemp(Controls Controls, float LowerAuthorityTemperature)
        {
            Controls.pControls.lowerAuthorityTemp = LowerAuthorityTemperature;
            return Controls;
        }

        /// <summary>
        /// Gets Master Control Zone of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="MasterControlZone">Master Control Zone</returns>
        /// <search>
        /// TAS, Controls, controls, MasterControlZone, Master Control Zone, mastercontrolzone
        /// </search>
        public static int MasterControlZone(Controls Controls)
        {
            return Controls.pControls.masterControlZone;
        }

        /// <summary>
        /// Sets Master Control Zone of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="MasterControlZone">Master Control Zone</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, MasterControlZone, Master Control Zone, mastercontrolzone
        /// </search>
        public static Controls SetMasterControlZone(Controls Controls, int MasterControlZone)
        {
            Controls.pControls.masterControlZone = MasterControlZone;
            return Controls;
        }

        /// <summary>
        /// Gets Night Setback Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="Value">Night Setback Load Factor [0-1]</returns>
        /// <search>
        /// TAS, Controls, controls, NightSetbackLoadFactor, Night Setback Load Factor, nightsetbackloadfactor
        /// </search>
        public static float NightSetbackLoadFactor(Controls Controls)
        {
            return Controls.pControls.nightSetbackLoadFactor;
        }

        /// <summary>
        /// Sets Night Setback Load Factor [0-1] of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="NightSetbackLoadFactor">Night Setback Load Factor [0-1]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, NightSetbackLoadFactor, Night Setback Load Factor, nightsetbackloadfactor, Set NightSetbackLoadFactor, Set Night Setback Load Factor, setnightsetbackloadfactor
        /// </search>
        public static Controls SetNightSetbackLoadFactor(Controls Controls, float NightSetbackLoadFactor)
        {
            Controls.pControls.nightSetbackLoadFactor = NightSetbackLoadFactor;
            return Controls;
        }

        /// <summary>
        /// Gets Night Setback Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="Value">Night Setback Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, NightSetbackTemperature, Night Setback Temperature, NightSetbackTemp, nightsetbacktemperature, night setback temperature
        /// </search>
        public static float NightSetbackTemperature(Controls Controls)
        {
            return Controls.pControls.nightSetbackTemp;
        }

        /// <summary>
        /// Sets Night Setback Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="NightSetbackTemperature">Night Setback Temperature</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, NightSetbackTemperature, Night Setback Temperature, NightSetbackTemp, nightsetbacktemperature, night setback temperature
        /// </search>
        public static Controls SetNightSetbackTemperature(Controls Controls, float NightSetbackTemperature)
        {
            Controls.pControls.nightSetbackTemp = NightSetbackTemperature;
            return Controls;
        }

        /// <summary>
        /// Gets Control Mode of TAS Controls (1 - Optimum Start, 0 - Frost Protection)
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="OptStartFlag">Opt Start Flag</returns>
        /// <search>
        /// TAS, Controls, controls, OptStartFlag, Opt Start Flag, optstartflag
        /// </search>
        public static int OptStartFlag(Controls Controls)
        {
            return Controls.pControls.optStartFlag;
        }

        /// <summary>
        /// Sets Control Mode of TAS Controls (1 - Optimum Start, 0 - Frost Protection)
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="OptStartFlag">Set Opt Start Flag</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, OptStartFlag, Opt Start Flag, optstartflag, SetOptStartFlag, Set Opt Start Flag, setoptstartflag
        /// </search>
        public static Controls SetOptStartFlag(Controls Controls, int OptStartFlag)
        {
            Controls.pControls.optStartFlag = OptStartFlag;
            return Controls;
        }

        /// <summary>
        /// Gets Oprimum Start Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="OSLoadFactor">Oprimum Start Load Factor [0-1]</returns>
        /// <search>
        /// TAS, Controls, controls, OSLoadFactor, OS Load Factor, osloadfactor, Oprimum Start
        /// </search>
        public static float OSLoadFactor(Controls Controls)
        {
            return Controls.pControls.OSLoadFactor;
        }

        /// <summary>
        /// Sets Optimum Start Load Factor of TAS Controls [0-1]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="OSLoadFactor">Oprimum Start Load Factor [0-1]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, OSLoadFactor, OS Load Factor, osloadfactor, SetOSLoadFactor, Set OS Load Factor, setosloadfactor, Oprimum Start
        /// </search>
        public static Controls SetOSLoadFactor(Controls Controls, float OSLoadFactor)
        {
            Controls.pControls.OSLoadFactor = OSLoadFactor;
            return Controls;
        }

        /// <summary>
        /// Gets Preheat Start (24hr clock) of TAS Controls [1-24]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="PreheatStart">Preheat Start [1-24]</returns>
        /// <search>
        /// TAS, Controls, controls, PreheatStart, Preheat Start, preheatstart, preheat start
        /// </search>
        public static int PreheatStart(Controls Controls)
        {
            return Controls.pControls.preheatStart;
        }

        /// <summary>
        /// Sets Preheat Start (24hr clock) of TAS Controls [1-24]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="PreheatStart">Preheat Start [1-24]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, PreheatStart, Preheat Start, preheatstart, preheat start
        /// </search>
        public static Controls SetPreheatStart(Controls Controls, int PreheatStart)
        {
            Controls.pControls.preheatStart = PreheatStart;
            return Controls;
        }

        /// <summary>
        /// Gets Setpoint Elevation of TAS Controls [°C]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="SetpointElevation">Setpoint Elevation [°C]</returns>
        /// <search>
        /// TAS, Controls, controls, SetpointElevation, Setpoint Elevation, setpointelevation, setpoint elevation
        /// </search>
        public static float SetpointElevation(Controls Controls)
        {
            return Controls.pControls.setpointElevation;
        }

        /// <summary>
        /// Sets Setpoint Elevation of TAS Controls [°C]
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="SetpointElevation">Setpoint Elevation [°C]</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, SetpointElevation, Setpoint Elevation, setpointelevation, setpoint elevation, SetSetpointElevation, Set Setpoint Elevation, setsetpointelevation, set setpoint elevation
        /// </search>
        public static Controls SetSetpointElevation(Controls Controls, float SetpointElevation)
        {
            Controls.pControls.setpointElevation = SetpointElevation;
            return Controls;
        }

        /// <summary>
        /// Gets Upper Authority Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <returns name="Value">Upper Authority Temperature</returns>
        /// <search>
        /// TAS, Controls, controls, UpperAuthorityTemperature, Upper Authority Temperature, upperauthoritytemperature, upper authority temperature
        /// </search>
        public static float UpperAuthorityTemperature(Controls Controls)
        {
            return Controls.pControls.upperAuthorityTemp;
        }

        /// <summary>
        /// Sets Upper Authority Temperature of TAS Controls
        /// </summary>
        /// <param name="Controls">TAS Controls</param>
        /// <param name="UpperAuthorityTemperature">Upper Authority Temperature</param>
        /// <returns name="Controls">Controls</returns>
        /// <search>
        /// TAS, Controls, controls, UpperAuthorityTemperature, Upper Authority Temperature, upperauthoritytemperature, upper authority temperature
        /// </search>
        public static Controls SetUpperAuthorityTemperature(Controls Controls, float UpperAuthorityTemperature)
        {
            Controls.pControls.upperAuthorityTemp = UpperAuthorityTemperature;
            return Controls;
        }
    }
}
