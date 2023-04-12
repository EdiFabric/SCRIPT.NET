using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.XML
{
    class DeserializeFromXml
    {
        /// <summary>
        /// De-serialize to an NCPDP object from XML using XmlSerializer
        /// </summary>
        public static void WithXmlSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.Deserialize<TSNEWRX>();
        }

        /// <summary>
        /// De-serialize to an NCPDP object from XML using DataContractSerializer
        /// </summary>
        public static void WithDataContractSerializer()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX2.xml");

            var xml = XElement.Load(ediStream);
            var transaction = xml.DeserializeDataContract<TSNEWRX>();
        }
    }
}
