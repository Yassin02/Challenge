using Newtonsoft.Json;
using System;
using System.Xml;

namespace Challenge.Serialization
{
    public static class SerializeXML
    {
        public static string XmlToJson(string xml)
        {
            if (String.IsNullOrWhiteSpace(xml))
                throw new ArgumentNullException("xml");

            XmlDocument xmlDocument = new XmlDocument();
            try
            {
                xmlDocument.LoadXml(xml);
            }
            catch (XmlException)
            {
                throw;
            }

            string jsonText = JsonConvert.SerializeXmlNode(xmlDocument);

            return jsonText;
        }
    }
}