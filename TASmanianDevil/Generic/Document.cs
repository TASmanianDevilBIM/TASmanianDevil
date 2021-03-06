﻿using System;
using Autodesk.DesignScript.Runtime;

namespace Generic
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class Document : IDisposable
    {
        private static object pObject;

        private static string pFilePath;
        private static bool pSave;
        private static bool pClosed;

        internal Document(string FilePath, bool Save)
        {
            Dynamo.Events.ExecutionEvents.GraphPostExecution -= ExecutionEvents_GraphPostExecution;
            Dynamo.Events.ExecutionEvents.GraphPostExecution += ExecutionEvents_GraphPostExecution;

            pFilePath = FilePath;
            pSave = Save;
            GetDocument();
        }

        private void GetDocument()
        {
            pObject = null;
            try
            {
                object aObject = System.Runtime.InteropServices.Marshal.GetActiveObject(ActiveObjectName);
                while (aObject != null)
                {
                    if (pSave)
                        Save();
                    Close();
                }
            }
            catch (Exception e)
            {
                string aText = e.Message;
            }

            Create();

            if (!string.IsNullOrEmpty(pFilePath) && System.IO.File.Exists(pFilePath))
                Open();

            pClosed = false;
        }
      
        protected abstract string ActiveObjectName
        {
            get;
        }

        protected abstract void Create();

        protected abstract void Save();

        protected abstract void Close();

        protected abstract void Open();

        protected static object Object
        {
            get
            {
                return pObject;
            }
            set
            {
                pObject = value;
            }
        }

        protected static string FilePath
        {
            get
            {
                return pFilePath;
            }
        }

        private void Release()
        {
            if (pObject != null)
            {
                if (!pClosed)
                {
                    if (pSave)
                        Save();

                    Close();
                    pClosed = true;
                }

                int aCount = 0;
                do
                {
                    aCount = System.Runtime.InteropServices.Marshal.FinalReleaseComObject(pObject);
                }
                while (aCount > 0);

                pObject = null;
            }
        }

        public void Dispose()
        {
            Release();
        }

        private void ExecutionEvents_GraphPostExecution(Dynamo.Session.IExecutionSession IExecutionSession)
        {
            Dynamo.Events.ExecutionEvents.GraphPostExecution -= ExecutionEvents_GraphPostExecution;
            Release();
        }
    }
}
