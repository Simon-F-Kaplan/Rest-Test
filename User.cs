using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace RestTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class User : IUser
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "getData/{value}")]
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        [WebInvoke(Method = "Get", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{id}")]
        public string GetUser(string id)
        {
            return string.Format("User Id: {0}", id);
        }

        [WebInvoke(Method = "Get", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{id}")]
        public string GetUsers(string id)
        {
            var ser = new System.Web.Script.Serialization.JavaScriptSerializer();
            return ser.Serialize("");

        }

        [WebInvoke(Method = "Get", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{detail}")]
        public string ValidateUser(string detail)
        {
            var ser = new System.Web.Script.Serialization.JavaScriptSerializer();
            var result = ser.Deserialize<string>(detail);
            return Enums.ValidationStatus.Valid.ToString();
        }

    }
}
