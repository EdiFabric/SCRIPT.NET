using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class ReadNCPDPFileWithTemplateResolution
    {
        /// <summary>
        /// Reads the NCPDP stream from start to end using assembly factory. Allows you to dynamically specify a separate assembly to be used for parsing.
        /// </summary>
        public static void RunWithAssemblyFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, AssemblyFactory))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();
        }

        public static Assembly AssemblyFactory(MessageContext messageContext)
        {
            if (messageContext.Version == "010006")
                return Assembly.Load("EdiFabric.Templates.Ncpdp");

            throw new Exception(string.Format("Version {0} is not supported.", messageContext.Version));
        }

        /// <summary>
        /// Reads the NCPDP stream from start to end using type factory. Allows you to dynamically specify the exact template to be used for parsing.
        /// </summary>
        public static void RunWithTypeFactory()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, TypeFactory))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRX>();
        }

        static TypeInfo TypeFactory(UIB interchangeHeader, UIH messageHeader)
        {
            if (messageHeader.MESSAGEIDENTIFIER_01.MessageVersionNumber_02 == "010" && messageHeader.MESSAGEIDENTIFIER_01.MessageReleaseNumber_03 == "006")
            {
                if (messageHeader.MESSAGEIDENTIFIER_01.MessageFunction_04 == "NEWRX")
                    return typeof(TSNEWRX).GetTypeInfo();
            }

            throw new Exception("Message is not supported.");
        }
    }
}
