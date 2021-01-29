using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPBatch
    {
        /// <summary>
        /// Batch multiple messages in the same interchange .
        /// </summary>
        public static void Run1()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpScriptWriter(stream))
                {
                    //  Write the transmission header
                    writer.Write(SegmentBuilders.BuildInterchangeHeader("1"));

                    //  Write the prescription request 1
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest("1"));

                    //  Write the prescription request 2
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest("2"));

                    //...
                }

                Debug.Write(stream.LoadToString());
            }
        }

        /// <summary>
        /// Batch multiple interchanges in the same stream.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpScriptWriter(stream))
                {
                    //  Write transmission header 1
                    writer.Write(SegmentBuilders.BuildInterchangeHeader("1"));

                    //  Write the prescription request 
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest("1"));

                    //  Write transmission header 2
                    writer.Write(SegmentBuilders.BuildInterchangeHeader("1"));

                    //  Write the prescription request
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest("1"));

                    //...
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
