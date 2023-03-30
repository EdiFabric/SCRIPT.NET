using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class WriteNCPDPWithCustomDelimiters
    {
        /// <summary>
        /// Write with custom separators, by default it uses the standard separators.
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
                    //  Set a custom segment separator.
                    var separators = Separators.NcpdpScript;
                    separators.Segment = '|';

                    //  Write the interchange header
                    writer.Write(SegmentBuilders.BuildInterchangeHeader(), separators);
                    //  Write the prescription request
                    writer.Write(SegmentBuilders.BuildPrescriptionRequest());
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
