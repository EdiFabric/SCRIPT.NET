using EdiFabric.Examples.NCPDP.Script.Common;
using System;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

            //  Read NCPDP file to the end
            ReadNCPDPFileToEnd.Run();
            ReadNCPDPFileToEndAsync.Run();

            //  Read one item at a time
            ReadNCPDPFileStreaming.Run();
            ReadNCPDPFileStreamingAsync.Run();

            //  Read batches of transactions
            ReadNCPDPFileBatch.Run();

            //  Read using partner-specific template (inherited)
            ReadNCPDPFileWithInheritedTemplate.Run();

            //  Read using dynamic template resolution
            ReadNCPDPFileWithTemplateResolution.RunWithAssemblyFactory();
            ReadNCPDPFileWithTemplateResolution.RunWithTypeFactory();

            //  Read NCPDP file with issues
            ReadNCPDPFileCorrupt.Run();
            ReadNCPDPFileCorrupt.Run2();

            //  Split transactions to repeating loops
            ReadNCPDPFileSplitting.Run();
            ReadNCPDPFileSplitting.RunWithCopy();

            //  Read transaction only
            ReadNCPDPFileTransactionOnly.Run();

            //  Read with custom UIB
            ReadNCPDPFileWithCustomUIB.Run();
        }
    }
}
