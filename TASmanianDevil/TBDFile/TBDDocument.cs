using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBDFile
{
    /// <summary>
    /// TAS TBDDocument
    /// </summary>
    public class TBDDocument : IDisposable
    {
        private TBD.TBDDocument pTBDDocument;
        private bool pSave;

        internal TBDDocument(string FilePath, bool Save)
        {
            pSave = Save;
            pTBDDocument = GetTBDDocument(pSave);
            pTBDDocument.open(FilePath);       
        }

        internal TBDDocument(TBD.TBDDocument TBDDocument, bool Save)
        {
            pSave = Save;
            pTBDDocument = TBDDocument; 
        }

        private static TBD.TBDDocument GetTBDDocument(bool Save)
        {
            TBD.TBDDocument aTBDDocument = null;
            try
            {
                object aObject = System.Runtime.InteropServices.Marshal.GetActiveObject("TBD.Document");
                if (aObject != null && aObject is TAS3D.T3DDocument)
                {
                    aTBDDocument = aObject as TBD.TBDDocument;
                    if (Save)
                        aTBDDocument.save();
                    aTBDDocument.close();
                }
            }
            catch
            {

            }

            if (aTBDDocument == null)
                aTBDDocument = new TBD.TBDDocument();

            return aTBDDocument;
        }

        /// <summary>
        /// End Merge TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, EndMerge, End Merge, endmerge, end merge
        /// </search>
        public static TBDDocument EndMerge(TBDDocument TBDDocument)
        {
            TBDDocument.pTBDDocument.EndMerge();
            return TBDDocument;
        }

        /// <summary>
        /// Imports Shading Data to TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <param name="Path">Path</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, ImportShadingData, Import Shading Data, importshadingdata, import shading data
        /// </search>
        public static TBDDocument ImportShadingData(TBDDocument TBDDocument, string Path)
        {
            TBDDocument.pTBDDocument.ImportShadingData(Path);
            return TBDDocument;
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="FilePath">File Path</param>
        /// <param name="Save">If true file will be saved</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, open tbddocument, opentbddocument
        /// </search>
        public static TBDDocument Open(object FilePath, bool Save = false)
        {
            return new TBDDocument(FilePath.ToString(), Save);
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="Name">Building Name</param>
        /// <param name="Description">Building Description</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, new tbddocument,newtbddocument
        /// </search>
        public static TBDDocument New(string Name, string Description)
        {
            TBD.TBDDocument aTBDDocument = GetTBDDocument(false);
            aTBDDocument.Building.name = Name;
            aTBDDocument.Building.description = Description;
            return new TBDDocument(aTBDDocument, false);
        }

        /// <summary>
        /// Saves TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="TBDDocument">TBD Document</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, save tbddocument, opentbddocument
        /// </search>
        public static int Save(TBDDocument TBDDocument)
        {
            return TBDDocument.pTBDDocument.save();
        }

        /// <summary>
        /// Close TAS TBD Document. READ ME ==============
        /// Option 1 = File will be close when Dynamo is restarted
        /// if you use Dynamo with Revit you need to restart both
        /// Option 2 = when script is done and you confirmed it was saved just 
        /// go to TaskManager and End Process for TBD.exe 
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="integer">integer</returns>
        /// <search>
        /// TAS, TBDDocument, tas, tbddocument, close tbddocument, closebddocument
        /// </search>
        public static int Close(TBDDocument TBDDocument)
        {
            int aResult = TBDDocument.pTBDDocument.close();
            TBDDocument.pTBDDocument = null;
            TBDDocument = null;
            return aResult;
        }

        /// <summary>
        /// Opens TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="Builidng">TAS Building</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, Get Building, tas, tbddocument, tbddocument building
        /// </search>
        public static Building Building(TBDDocument TBDDocument)
        {
            return new Building(TBDDocument.pTBDDocument.Building);
        }

        /// <summary>
        /// TAS TBD Document sizing
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <returns name="Sizing">Sizing</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, sizing, Sizing
        /// </search>
        public static int Sizing(TBDDocument TBDDocument)
        {
            return TBDDocument.pTBDDocument.sizing(0);
        }

        /// <summary>
        /// Simulates TAS TBD Document
        /// </summary>
        /// <param name="TBDDocument">TBD Document</param>
        /// <param name="StartDay">Start Day</param>
        /// <param name="EndDay">EndDay</param>
        /// <param name="AutoViewResults">Auto View Results</param>
        /// <param name="OutputAperture">Output Aperture</param>
        /// <param name="OutputAll">Output All</param>
        /// <param name="Merge">Merge</param>
        /// <param name="TSDPath">TSD File Path</param>
        /// <param name="WeightingFactors">Weighting Factors</param>
        /// <returns name="Integer">Integer</returns>
        /// <search>
        /// TAS, TBDDocument, TBDDocument, Building, Simulate Building, tas, tbddocument, tbddocument building
        /// </search>
        public static int Simulate(TBDDocument TBDDocument, int StartDay, int EndDay, int AutoViewResults, int OutputAperture, int OutputAll, int Merge, string TSDPath, int WeightingFactors)
        {
            return TBDDocument.pTBDDocument.simulate(StartDay, EndDay, AutoViewResults, OutputAperture, OutputAll, Merge, TSDPath, WeightingFactors, 0);
        }

        void IDisposable.Dispose()
        {
            if (pTBDDocument != null)
            {
                if (pSave)
                    pTBDDocument.save();

                pTBDDocument.close();
                pTBDDocument = null;
            }

        }
    }
}
