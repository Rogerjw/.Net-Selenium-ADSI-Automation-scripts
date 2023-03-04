using ADSAutomation.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADSAutomation.Base
{
    internal static class Constants
    {
        public static readonly string BaseUrl = PropertyReader.GetPropertyValue("baseUrl");        
    }
}
