using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Readers;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace EdiFabric.Examples.NCPDP.Script.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Translator Demo 

            //  Supported versions/transactions are:
            //  NCPDP SCRIPT 10.6, all classes that begin with TS in namespace EdiFabric.Templates.Ncpdp

            //  If you need a different NCPDP version or transaction, please contact us at https://support.edifabric.com/hc/en-us/requests/new, EdiFabric supports all versions and transactions for NCPDP.

            TokenFileCache.Set();

            Translate_NCPDP_106();
        }

        public static void Translate_NCPDP_106()
        {
            //  Change the path to point to your own file to test with
            var path = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ediItems;
            using (var reader = new NcpdpScriptReader(path, "EdiFabric.Templates.Ncpdp"))
                ediItems = reader.ReadToEnd().ToList();

            foreach (var message in ediItems.OfType<EdiMessage>())
            {
                if (!message.HasErrors)
                {
                    //  Message was successfully parsed

                    MessageErrorContext mec;
                    if (message.IsValid(out mec))
                    {
                        //  Message was successfully validated
                    }
                    else
                    {
                        //  Message failed validation with the following validation issues:
                        var validationIssues = mec.Flatten();
                    }
                }
                else
                {
                    //  Message was partially parsed with errors
                }
            }

        }   //  Add a breakpoint here, run in debug mode and inspect ediItems
    }
}
