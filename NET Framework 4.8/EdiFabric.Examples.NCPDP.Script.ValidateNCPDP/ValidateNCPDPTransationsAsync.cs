using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class ValidateNCPDPTransationsAsync
    {
        /// <summary>
        /// Validate NCPDP transactions from file async
        /// </summary>
        public static async void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();

            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  Validate
                Tuple<bool, MessageErrorContext> result = await prescriptionRequest.IsValidAsync();
                if (!result.Item1)
                {
                    //  Report it back to the sender, log, etc.
                    var errors = result.Item2.Flatten();
                }
                else
                {
                    //  prescription request is valid, handle it downstream
                }
            }
        }
    }
}
