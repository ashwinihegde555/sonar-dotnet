using System.IO;
using System.Xml;

namespace NetFramework4
{
    class XmlDocumentTest
    {
        protected void XmlDocument_1(XmlUrlResolver xmlUrlResolver)
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = xmlUrlResolver; // Noncompliant
        }

        protected void XmlDocument_2()
        {
            var doc = new System.Xml.XmlDocument(); // Noncompliant before 4.5.2
        }

        // System.Xml.XmlDocument
        protected void XmlDocument_3(XmlSecureResolver xmlSecureResolver)
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = xmlSecureResolver;
        }

        protected void XmlDocument_1()
        {
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
        }
    }
}
