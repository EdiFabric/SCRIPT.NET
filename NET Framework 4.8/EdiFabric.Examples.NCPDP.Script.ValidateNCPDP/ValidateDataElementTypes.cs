using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;


namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class ValidateDataElementTypes
    {
        /// <summary>
        /// Validate data element data type using the default NCPDP code set. These aren't validated by default and need to be explicitly requested.
        /// Use the built-in EDIFACT data element syntax sets.
        /// </summary>
        public static void Unoa()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();

            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!prescriptionRequest.IsValid(out errorContext, new ValidationSettings { SyntaxSet = new Unoa() }))
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
        /// Validate data element data type using the default NCPDP code set. These aren't validated by default and need to be explicitly requested.
        /// Use the built-in EDIFACT data element syntax sets.
        /// </summary>
        public static void Unob()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();

            foreach (var prescriptionRequest in prescriptionRequests)
            {
                //  Validate
                MessageErrorContext errorContext;
                if (!prescriptionRequest.IsValid(out errorContext, new ValidationSettings { SyntaxSet = new Unob() }))
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
}
