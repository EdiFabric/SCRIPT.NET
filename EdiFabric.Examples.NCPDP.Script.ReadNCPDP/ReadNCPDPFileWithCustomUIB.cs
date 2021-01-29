using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class ReadNCPDPFileWithCustomUIB
    {
        /// <summary>
        /// Read with custom header.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            //  Use the base NcpdpScriptReaderBase instead of NcpdpScriptReader
            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReaderBase<UIBCustom, UIG>(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var customHeaders = ncpdpItems.OfType<UIBCustom>();
        }
    }

    public class UIBCustom : UIB
    {
    }
}
