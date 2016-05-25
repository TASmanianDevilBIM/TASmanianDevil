using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3DFile
{
    /// <summary>
    /// TAS T3DDocument
    /// </summary>
    public class T3DDocument : IDisposable
    {
        private TAS3D.T3DDocument pT3DDocument;
        private bool pSave;

        internal T3DDocument(string FilePath, bool Save)
        {
            pSave = Save;
            pT3DDocument = GetT3DDocument(pSave);
            pT3DDocument.Open(FilePath);
        }

        private T3DDocument(TAS3D.T3DDocument T3DDocument, bool Save)
        {
            pSave = Save;
            pT3DDocument = T3DDocument;
        }

        private static TAS3D.T3DDocument GetT3DDocument(bool Save)
        {
            TAS3D.T3DDocument aT3DDocument = null;
            try
            {
                object aObject = System.Runtime.InteropServices.Marshal.GetActiveObject("TAS3D.T3DDocument");
                if (aObject != null && aObject is TAS3D.T3DDocument)
                {
                    aT3DDocument = aObject as TAS3D.T3DDocument;
                    if (Save && !string.IsNullOrEmpty(aT3DDocument.filePath))
                        aT3DDocument.Save(aT3DDocument.filePath);
                    aT3DDocument.Close();
                }
            }
            catch
            {

            }

            if(aT3DDocument == null)
                aT3DDocument = new TAS3D.T3DDocument();

            return aT3DDocument;
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="Save">If true file will be saved</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, T3DDocument, tas, t3ddocument, open t3ddocument, opent3ddocument
        /// </search>
        public static T3DDocument Open(object FilePath, bool Save = false)
        {
            return new T3DDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Saves TAS T3D Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, T3DDocument, tas, t3ddocument, save t3ddocument, savet3ddocument
        /// </search>
        public static bool Save(T3DDocument T3DDocument, object FilePath)
        {
            return T3DDocument.pT3DDocument.Save(FilePath.ToString());
        }

        /// <summary>
        /// Closes TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, close t3ddocument, closet3ddocument
        /// </search>
        public static bool Close(T3DDocument T3DDocument)
        {
            T3DDocument.pT3DDocument.Close();
            T3DDocument.pT3DDocument = null;
            T3DDocument = null;
            return true;
        }

        /// <summary>
        /// TAS T3D Document Current Ground Lux
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Value">Current Ground Lux</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, Current Ground Lux, CurrentGroundLux, GetCurrentGroundLux
        /// </search>
        public static double GetCurrentGroundLux(T3DDocument T3DDocument)
        {
            return T3DDocument.pT3DDocument.GetCurrentGroundLux();
        }

        /// <summary>
        /// Gets TAS T3D Document Current Lux Results
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Values">Current Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, Current Ground Lux, GetCurrentLuxResults, Get Current Lux Results, getcurrentluxresults
        /// </search>
        public static object GetCurrentLuxResults(T3DDocument T3DDocument, Zone Zone)
        {
            return T3DDocument.pT3DDocument.GetCurrentLuxResults(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Factor
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Current Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetDaylightFactor, Get Daylight Factor, getdaylightfactor
        /// </search>
        public static double GetDaylightFactor(T3DDocument T3DDocument, Zone Zone)
        {
            return T3DDocument.pT3DDocument.GetDaylightFactor(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Ground Lux
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Ground Lux</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetGroundLux, Get Ground Lux, getgroundlux
        /// </search>
        public static double GetGroundLux(T3DDocument T3DDocument, Zone Zone)
        {
            return T3DDocument.pT3DDocument.GetGroundLux(Zone.pZone);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Calculation
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Result">DaylightCalculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightCalculation, Daylight Calculation, daylight calculation
        /// </search>
        public static bool DaylightCalculation(T3DDocument T3DDocument)
        {
            return T3DDocument.pT3DDocument.DaylightCalculation(0);
        }

        /// <summary>
        /// Gets TAS T3D Document Daylight Calculation
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="InitialiseZones">Initialise Zones</param>
        /// <param name="IncludeAllZones">Include All Zones</param>
        /// <param name="Update3DModel">Update 3D Model</param>
        /// <returns name="Result">DaylightCalculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightCalculation, Daylight Calculation, daylight calculation
        /// </search>
        public static bool DaylightCalculation(T3DDocument T3DDocument, int InitialiseZones, int IncludeAllZones, int Update3DModel)
        {
            return T3DDocument.pT3DDocument.DaylightInitCalculation(InitialiseZones, IncludeAllZones, Update3DModel, 0);
        }

        /// <summary>
        /// Daylight Saves Calculation to TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Result">Daylight Save Calculation</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, DaylightSaveCalculation, Daylight Save Calculation, daylightsavecalculation
        /// </search>
        public static bool DaylightSaveCalculation(T3DDocument T3DDocument)
        {
            return T3DDocument.pT3DDocument.DaylightSaveCalculation();
        }

        /// <summary>
        /// Gets TAS T3D Document Lux Results
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="Zone">Zone</param>
        /// <returns name="Value">Lux Results</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, GetLuxResults, Get Lux Results, getluxresults
        /// </search>
        public static object GetLuxResults(T3DDocument T3DDocument, Zone Zone)
        {
            return T3DDocument.pT3DDocument.GetLuxResults(Zone.pZone);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, t3ddocument, new t3ddocument, newt3ddocument
        /// </search>
        public static T3DDocument New(string Name, string Description)
        {
            TAS3D.T3DDocument aT3DDocument = GetT3DDocument(false);
            aT3DDocument.Building.name = Name;
            aT3DDocument.Building.description = Description;
            return new T3DDocument(aT3DDocument, false);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <param name="FilePath">File Path</param>
        /// <returns name="T3DDocument">T3D Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, new tbddocument, newtbddocument
        /// </search>
        public static T3DDocument New(string FilePath, string Name, string Description)
        {
            TAS3D.T3DDocument aT3DDocument = GetT3DDocument(true);
            aT3DDocument.Building.name = Name;
            aT3DDocument.Building.description = Description;
            aT3DDocument.filePath = FilePath;
            return new T3DDocument(aT3DDocument, true);
        }

        /// <summary>
        /// Exports TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="DayFirst">Day First</param>
        /// <param name="DayLast">Day Last</param>
        /// <param name="DayStep">Day Step</param>
        /// <param name="ZoneSets">Zone Sets</param>
        /// <param name="Merge">Merge</param>
        /// <param name="IncludeExternalZones">Include External Zones</param>
        /// <param name="OutputPath">Output Path</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, export t3ddocument, exportt3ddocument
        /// </search>
        public static bool Export(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, int IncludeExternalZones, string OutputPath)
        {
            return T3DDocument.pT3DDocument.Export(DayFirst, DayLast, DayStep, ZoneSets, Merge, IncludeExternalZones, OutputPath, 0);
        }

        /// <summary>
        /// Exports TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <param name="DayFirst">Day First</param>
        /// <param name="DayLast">Day Last</param>
        /// <param name="DayStep">Day Step</param>
        /// <param name="ZoneSets">Zone Sets</param>
        /// <param name="Merge">Merge</param>
        /// <param name="IncludeExternalZones">Include External Zones</param>
        /// <param name="OutputPath">Output Path</param>
        /// <param name="AutoAssignConstructions">Auto Assign Constructions</param>
        /// <param name="AutoAssignsICs">Auto Assigns Internal Conditions</param>
        /// <returns name="Boolean">Boolean</returns>
        /// <search>
        /// TAS, T3DDocument, tas, T3Ddocument, export t3ddocument, exportt3ddocument
        /// </search>
        public static bool ExportNew(T3DDocument T3DDocument, int DayFirst, int DayLast, int DayStep, int ZoneSets, int Merge, int IncludeExternalZones, string OutputPath, int AutoAssignConstructions, int AutoAssignsICs)
        {
            return T3DDocument.pT3DDocument.ExportNew(DayFirst, DayLast, DayStep, ZoneSets, Merge, IncludeExternalZones, OutputPath, AutoAssignConstructions, AutoAssignsICs, 0);
        }

        /// <summary>
        /// Opens TAS T3D Document
        /// </summary>
        /// <param name="T3DDocument">T3D Document</param>
        /// <returns name="Building">TAS Building</returns>
        /// <search>
        /// TAS, T3DDocument, T3DDocument, Building, Get Building, tas, t3ddocument, t3ddocument building
        /// </search>
        public static Building Building(T3DDocument T3DDocument)
        {
            return new Building(T3DDocument.pT3DDocument.Building);
        }

        void IDisposable.Dispose()
        {
            if (pT3DDocument != null)
            {
                if (pSave && pT3DDocument.filePath != null)
                    pT3DDocument.Save(pT3DDocument.filePath);

                pT3DDocument.Close();
                pT3DDocument = null;
            }

        }
    }
}
