using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H72File
{
    /// <summary>
    /// H72 file Parameter
    /// </summary>
    public class H72Parameter
    {
        private string pName;
        private object pValue;

        internal H72Parameter(string Name, string StringValue)
        {
            pName = Name;
            pValue = null;
            if (StringValue != null)
            {
                if (StringValue.StartsWith(@"""") && StringValue.Length > 1)
                    pValue = StringValue.Substring(1, StringValue.Length - 2);
                else
                {
                    if(StringValue.Contains("."))
                    {
                        double aDoubleValue = double.MinValue;
                        if (double.TryParse(StringValue, out aDoubleValue))
                        {
                            pValue = aDoubleValue;
                        }
                    }
                    else 
                    {
                        int aIntValue = int.MinValue;
                        if (int.TryParse(StringValue, out aIntValue))
                            pValue = aIntValue;
                    }
                }

                if(pValue == null)
                {
                    pValue = StringValue;
                }
            }
        }

        internal string Name
        {
            get
            {
                return pName;
            }
        }

        internal object Value
        {
            get
            {
                return pValue;
            }
        }

        /// <summary>
        /// Gets Value of H72 Parameter
        /// </summary>
        /// <param name="H72Parameter">H72 Parameter</param>
        /// <returns name="Value">Parameter value</returns>
        /// <search>
        /// TAS, H72Parameter, H72 Parameter, h72parameter, get value, value, Value, GetValue
        /// </search>
        public static object GetValue(H72Parameter H72Parameter)
        {
            return H72Parameter.pValue;
        }

        /// <summary>
        /// Gets Name of H72 Parameter
        /// </summary>
        /// <param name="H72Parameter">H72 Parameter</param>
        /// <returns name="Name">Parameter Name</returns>
        /// <search>
        /// TAS, H72Parameter, H72 Parameter, h72parameter, get name, name, Name, GetName
        /// </search>
        public static string GetName(H72Parameter H72Parameter)
        {
            return H72Parameter.pName;
        }

        public override string ToString()
        {
            if (pValue is string)
                return string.Format(@"{0}({1} = ""{2}"")", "H72Parameter", pName, pValue);
            else
                return string.Format("{0}({1} = {2})", "H72Parameter", pName, pValue);
        }
    }
}
