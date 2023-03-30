using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPWithNewLines
    {
        /// <summary>
        /// Write with segment postfix.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                using (var writer = new NcpdpScriptWriter(stream, new NcpdpScriptWriterSettings() { Postfix = Environment.NewLine }))
                {
                    //  Write the interchange header
                    writer.Write(SegmentBuilders.BuildInterchangeHeader());
                    //  Write the prescription request
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest());
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
