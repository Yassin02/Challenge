using Challenge.Compute;
using Challenge.Serialization;
using System.Web.Services;

namespace Challenge
{
    /// <summary>
    /// Summary description for ChallengeWebService
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ChallengeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            return FibonacciSequence.Calculate(n);
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            return SerializeXML.XmlToJson(xml);
        }
    }
}
