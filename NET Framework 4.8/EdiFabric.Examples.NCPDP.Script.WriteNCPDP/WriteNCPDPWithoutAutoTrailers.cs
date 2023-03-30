using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPWithoutAutoTrailers
    {
        /// <summary>
        /// Write without auto trailers
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set AutoTrailers to false
                using (var writer = new NcpdpScriptWriter(stream, new NcpdpScriptWriterSettings { AutoTrailers = false }))
                {
                    //  Write the interchange header
                    writer.Write(SegmentBuilders.BuildInterchangeHeader());
                    //  Write the prescription request
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest());
                    //  trailers need to be manually written  
                }

                using (var writer = new StreamWriter(stream))
                {
                    var uiz = new UIZ
                    {
                        InterchangeControlCount_02 = "1"
                    };

                    writer.Write(uiz.ToEdi(Separators.NcpdpScript));
                    writer.Flush();

                    Debug.Write(stream.LoadToString());
                }
            }
        }
    }
}
