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
            var doc = new System.Xml.XmlDocument(); // compliant by default
        }
    }
}
