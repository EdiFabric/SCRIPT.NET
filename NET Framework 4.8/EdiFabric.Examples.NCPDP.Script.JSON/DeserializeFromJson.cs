using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Templates.Script106;
namespace EdiFabric.Examples.NCPDP.Script.JSON
{
    class DeserializeFromJson
    {
        /// <summary>
        /// De-serialize to an NCPDP object from Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.json");
            var transaction = Newtonsoft.Json.JsonConvert.DeserializeObject<TSNEWRX>(ncpdpStream.LoadToString());
        }
    }
}
