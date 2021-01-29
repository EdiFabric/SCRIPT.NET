using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Writers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPWithEmptyDataElements
    {
        /// <summary>
        /// Write transactions with whitespace.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var prescriptionRequest = SegmentBuilders.BuildPrescriptionRequest();

            //  Initialize some properties with blanks
            prescriptionRequest.PVD[0].I016_09 = new I016();
            prescriptionRequest.PVD[0].I016_09.CommunicationNumber_01 = "";

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpScriptWriter(stream, new NcpdpScriptWriterSettings() { PreserveWhitespace = true }))
                {
                    //  Write the interchange header
                    writer.Write(SegmentBuilders.BuildInterchangeHeader());
                    //  Write the prescription request
                    writer.Write(prescriptionRequest);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
