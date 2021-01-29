﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class ReadNCPDPFileStreaming
    {
        /// <summary>
        /// Reads prescription requests batched up in the same interchange.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  1.  Load to a stream 
            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequests_NEWRX.txt");

            //  2.  Read multiple transactions batched up in the same interchange
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                while (ncpdpReader.Read())
                {
                    //  Process prescription request if no parsing errors
                    var pr = ncpdpReader.Item as TSNEWRX;
                    if (pr != null && !pr.HasErrors)
                        ProcessPrescriptionRequest(ncpdpReader.CurrentInterchangeHeader, pr);
                }
            }
        }

        private static void ProcessPrescriptionRequest(UIB uib, TSNEWRX prescriptionRequest)
        {
            //  Do something with the prescription request
        }
    }
}
