using System;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Generic
{
    /// <summary>
    /// Excel Tools
    /// </summary>
    public static class Excel
    {
        /// <summary>
        /// Runs Excel Macro
        /// </summary>
        /// <param name="Path">Path to the excel file</param>
        /// <param name="MacroName">Macro Name</param>
        /// <param name="Close">Close after run</param>
        /// <returns name="Result">Result</returns>
        /// <search>
        /// Excel, runmacro, RunMacro, Run Macro, run macro
        /// </search>
        public static bool RunMacro(string Path, string MacroName, bool Close)
        {
            Application aApplication = null;
            bool aCloseApplication = true;
            bool aResult = false;

            try
            {
                aApplication = (Application)Marshal.GetActiveObject("Excel.Application");
                aCloseApplication = false;
            }
            catch (COMException aCOMException)
            {
                aApplication = new Application();
                aApplication.Visible = false;
            }

            if (aApplication != null)
            {
                aApplication.ScreenUpdating = false;

                Workbook aWorkbook = null;
                Worksheet aWorksheet = null;
                bool aCloseWorkbook = true;

                try
                {
                    if (IsEdited(aApplication))
                    {
                        throw new Exception("Excel is in cell edit mode. Please stop editing cell and run import again");
                    }
                    else
                    {
                        for (int i = 0; i < aApplication.Workbooks.Count; i++)
                            if (aApplication.Workbooks[i + 1].FullName == Path)
                            {
                                aWorkbook = aApplication.Workbooks[i + 1];
                                aCloseWorkbook = false;
                                break;
                            }

                        if (aWorkbook == null)
                            aWorkbook = aApplication.Workbooks.Open(Path);

                        object[] aArguments = new object[] { string.Format("{0}!{1}", System.IO.Path.GetFileName(Path), MacroName) };
                        aApplication.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, aApplication, aArguments);
                        aResult = true;
                    }
                }
                finally
                {
                    if (aWorksheet != null)
                    {
                        Marshal.ReleaseComObject(aWorksheet);
                    }

                    if (aWorkbook != null)
                    {
                        if (aCloseWorkbook)
                            aWorkbook.Close(true);

                        Marshal.ReleaseComObject(aWorkbook);
                    }

                    aApplication.ScreenUpdating = true;

                    if (aCloseApplication || Close)
                        aApplication.Quit();

                    Marshal.ReleaseComObject(aApplication);
                }
            }
            return aResult;
        }

        private static bool IsEdited(Application Application)
        {
            if (!Application.Interactive)
                return false;

            try
            {
                Application.Interactive = false;
                Application.Interactive = true;
            }
            catch
            {
                return true;
            }

            return false;
        }
    }
}
