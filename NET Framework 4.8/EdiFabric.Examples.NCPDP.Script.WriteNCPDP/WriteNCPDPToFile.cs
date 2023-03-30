using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPToFile
    {
        /// <summary>
        /// Generate and write NCPDP document to a file
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var writer = new NcpdpScriptWriter(@"C:\Test\Output.txt", false))
            {
                //  Write the transmission header
                writer.Write(SegmentBuilders.BuildInterchangeHeader());
                //  Write the prescription request
                writer.Write(SegmentBuilders.BuildPrescriptionRequest());
            }
        }
    }
}
