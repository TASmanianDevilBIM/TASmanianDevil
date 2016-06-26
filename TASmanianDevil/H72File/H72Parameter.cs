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

        internal H72Parameter(string Name)
        {
            pName = Name;
            pValue = null;
        }

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
            set
            {
                pValue = value;
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
        /// Sets Value of H72 Parameter
        /// </summary>
        /// <param name="H72Parameter">H72 Parameter</param>
        /// <param name="Value">H72 Parameter Value</param>
        /// <returns name="H72Parameter">H72 Parameter</returns>
        /// <search>
        /// TAS, H72Parameter, H72 Parameter, h72parameter, set value, value, Value, SetValue
        /// </search>
        public static H72Parameter SetValue(H72Parameter H72Parameter, object Value)
        {
            H72Parameter.pValue = Value;
            return H72Parameter;
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

        internal void AppendStringList(int Index, List<string> StringList)
        {
            string aPrefix = new string(' ', Index*3);
            if (pName.StartsWith("*"))
            {
                StringList.Add(string.Format(@"{0}{1}", aPrefix, pName));
                StringList.Add(string.Format(@"{0}{1}", aPrefix, pValue));
            }
            else
            {
                if (pValue is string)
                    StringList.Add(string.Format(@"{0}{1}=""{2}""", aPrefix, pName, pValue));
                else
                    StringList.Add(string.Format("{0}{1}={2}", aPrefix, pName, pValue));
            }
        }

        public override string ToString()
        {
            if (pName.StartsWith("*"))
            {
                return string.Format(@"{0}({1} {2})", "H72Parameter", pName, pValue);
            }
            else
            {
                if (pValue is string)
                    return string.Format(@"{0}({1} = ""{2}"")", "H72Parameter", pName, pValue);
                else
                    return string.Format("{0}({1} = {2})", "H72Parameter", pName, pValue);
            }

        }
    }
}
