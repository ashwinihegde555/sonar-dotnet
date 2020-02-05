using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Tests.Diagnostics
{
    class NoncompliantTests
    {

    }

    /// <summary>
    ///  These are not testing the APIs per se, but other test combinations
    /// </summary>
    class VariousUnsafeCombinations
    {

    }

    class CompliantTests
    {
        public void LINQXDocumentSafe_MemoryStream(object sender, EventArgs e)
        {
            bool expectedSafe = true;

            XDocument xdocument = XDocument.Load(new MemoryStream(Encoding.ASCII.GetBytes(xmlText)));
            //XDocument xdocument = XDocument.Load(appPath + "resources/xxetestuser.xml");

            try
            {
                // parsing the XML
                StringBuilder sb = new StringBuilder();
                foreach (var element in xdocument.Elements())
                {
                    sb.Append(element.ToString());
                }

                // testing the result
                if (sb.ToString().Contains("SUCCESSFUL"))
                    PrintResults(expectedSafe, false, sb.ToString());   // unsafe: successful XXE injection
                else
                    PrintResults(expectedSafe, true, sb.ToString());    // safe: empty or unparsed XML
            }
            catch (Exception ex)
            {
                PrintResults(expectedSafe, true, ex);   // safe: exception thrown when parsing XML
            }
        }

    }

}
