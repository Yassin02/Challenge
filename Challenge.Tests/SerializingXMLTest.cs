using Challenge.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge.Tests
{
    [TestClass]
    public class SerializingXMLTest
    {
        [TestMethod]
        public void Should_Pass_BadXMLFormatReturnedExpected()
        {
            string expected = "Bad Xml format";
            string result = SerializeXML.XmlToJson("<foo>hello</bar>");
            Assert.AreEqual(expected, result);
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
