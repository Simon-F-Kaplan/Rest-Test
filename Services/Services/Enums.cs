using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class Enums
    {
        public enum ValidationStatus
        {
            /// <summary>
            /// Invalid credential format supplied
            /// </summary>
            Invalid = 0,
            /// <summary>
            /// Valid credential and validation passed
            /// </summary>
            Valid = 1,
            /// <summary>
            /// Valid credential and validation failed
            /// </summary>
            ValidationFailed = 2
        }
    }
}

