using Challenge.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml;

namespace Challenge.Tests
{
    [TestClass]
    public class SerializingXMLTest
    {
        [TestMethod]
        [ExpectedException(typeof(XmlException))]
        public void Should_Pass_BadXMLFormatReturnedExpected()
        {
            SerializeXML.XmlToJson("<foo>hello</bar>");
        }

        [TestMethod]
        public void Should_Pass_ExcpectedResults()
        {
            string expected = "{\"foo\":\"bar\"}";
            string result = SerializeXML.XmlToJson("<foo>bar</foo>");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Should_Pass_ExpectedExceptionIsRaised()
        { 
            SerializeXML.XmlToJson(String.Empty);
        }
    }
}
