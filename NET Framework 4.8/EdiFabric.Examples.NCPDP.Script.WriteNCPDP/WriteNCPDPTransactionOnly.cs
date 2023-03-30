using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPTransactionOnly
    {
        /// <summary>
        /// Writes to stream without envelopes - no UIB
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpScriptWriter(stream))
                {
                    //  Write the prescription request, no interchange header
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest());
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
