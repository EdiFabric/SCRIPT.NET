using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class ValidateCustomNCPDPCodes
    {
        /// <summary>
        /// Validate with custom NCPDP codes, different than the standard NCPDP codes
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set NCPDP codes map where the original code type will be substituted with the partner-specific code type
            Dictionary<Type, Type> codeSetMap = new Dictionary<Type, Type>();
            codeSetMap.Add(typeof(NCPDP_ID_4705), typeof(NCPDP_ID_4705PartnerA));

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();

            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  Validate using NCPDP codes map
                MessageErrorContext errorContext;
                if (!prescriptionRequest.IsValid(out errorContext, new ValidationSettings { DataElementTypeMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  prescription request is valid, handle it downstream
                }
            }
        }

        /// <summary>
        /// Validate with custom NCPDP codes, different than the standard NCPDP codes. Load the codes dynamically at runtime.
        /// </summary>
        public static void Run2()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Set NCPDP codes map where the original code type will be substituted with the partner-specific code type
            var codeSetMap = new Dictionary<string, List<string>>();
            codeSetMap.Add("NCPDP_ID_4705", new List<string> { "AD", "AS", "PARTNERACODE" });

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();

            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  Validate using NCPDP codes map
                MessageErrorContext errorContext;
                if (!prescriptionRequest.IsValid(out errorContext, new ValidationSettings { DataElementCodesMap = codeSetMap }))
                {
                    //  Report it back to the sender, log, etc.
                    var errors = errorContext.Flatten();
                }
                else
                {
                    //  prescription request is valid, handle it downstream
                }
            }
        }
    }

    [Serializable()]
    [DataContract]
    [EdiCodes(",AD,AS,PARTNERACODE,", null)]
    public class NCPDP_ID_4705PartnerA
    {

    }
}
