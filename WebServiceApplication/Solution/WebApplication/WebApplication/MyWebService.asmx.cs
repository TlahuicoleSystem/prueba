using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for MyWebService
    /// </summary>
    [WebService(Namespace = "http://jomich.com/example/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {

      

        [WebMethod]
        public double sumar(double value1, double value2)
        {
            return value1 + value2;
        }

        [WebMethod]
        public double restar(double value1, double value2)
        {
            return value1 - value2;
        }

        [WebMethod]
        public double mul(double value1, double value2)
        {
            return value1 * value2;
        }

        [WebMethod]
        public double div(double value1, double value2)
        {
            return value1 / value2;
        }

        [WebMethod]
        public double potencia(double value1, double value2)
        {
            double res = Math.Pow(value1, value2);
            return res;
        }

        [WebMethod]
        public double raiz(double value1)
        {
            double res = Math.Sqrt(value1);
            return res;
        }
    }
}
