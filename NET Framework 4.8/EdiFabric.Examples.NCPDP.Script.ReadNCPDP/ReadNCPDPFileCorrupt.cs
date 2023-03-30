using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class ReadNCPDPFileCorrupt
    {
        /// <summary>
        /// Reads file with a corrupt interchange header
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequestCorruptHeader.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var readerErrors = ncpdpItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt. Reject it and report back to the sender
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();
            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  No prescription requests
            }
        }

        /// <summary>
        /// Reads file with a corrupt UIH
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequestCorruptUIH.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp", new NcpdpScriptReaderSettings() { ContinueOnError = true }))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var readerErrors = ncpdpItems.OfType<ReaderErrorContext>();
            if (readerErrors.Any())
            {
                //  The stream is corrupt
                Debug.WriteLine(readerErrors.First().Exception.Message);
            }

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();
            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  All valid messages are recovered
            }
        }
    }
}
