using Challenge.Compute;
using Challenge.Serialization;
using log4net;
using System;
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

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        public int Fibonacci(int n)
        {
            // Uncomment for the WaitingForm test
            //Thread.Sleep(2000);
            log.Info(String.Format("In : Fibonacci : n = {0}", n));
            int result = 0;
            try
            {
                result = FibonacciSequence.Calculate(n);
            }
            catch (Exception ex)
            {
                log.Error("Exception : Fibonacci : " + ex.Message);
            }
            return result;
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            log.Info(String.Format("In : XmlToJson : xml = {0}", xml));
            // Uncomment for the WaitingForm test
            //Thread.Sleep(2000);
            string result = String.Empty;
            try
            {
                result = SerializeXML.XmlToJson(xml);
            }
            catch (Exception ex)
            {
                log.Error("Exception : XmlToJson : " + ex.Message);
                return "Bad Xml format";
            }
            finally
            {
                log.Info("Out : XmlToJson");
            }

            return result;
        }
    }
}
