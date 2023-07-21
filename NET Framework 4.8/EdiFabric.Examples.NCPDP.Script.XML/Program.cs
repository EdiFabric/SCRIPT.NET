using EdiFabric.Examples.NCPDP.Script.Common;

namespace EdiFabric.Examples.NCPDP.Script.XML
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Serialize to XML
            SerializeToXml.WithXmlSerializer();
            SerializeToXml.WithDataContractSerializer();

            //  Deserialize from XML
            DeserializeFromXml.WithXmlSerializer();
            DeserializeFromXml.WithDataContractSerializer();
        }
    }
}
