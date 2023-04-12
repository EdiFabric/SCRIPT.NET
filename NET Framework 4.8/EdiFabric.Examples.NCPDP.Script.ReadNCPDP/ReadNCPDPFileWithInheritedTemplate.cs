using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;

namespace EdiFabric.Examples.NCPDP.Script.ReadNCPDP
{
    class ReadNCPDPFileWithInheritedTemplate
    {
        /// <summary>
        /// Reads NCPDP file into a custom, partner-specific template.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, (UIB uib, UIH uih) => typeof(TSNEWRXCustom).GetTypeInfo()))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var prescriptionRequests = ncpdpItems.OfType<TSNEWRXCustom>();
        }
    }

    [Message("SCRIPT", "NEWRX")]
    public class TSNEWRXCustom : TSNEWRX
    {
        [DataMember]
        [ListCount(1)]
        [Pos(3)]
        [Required]
        public new List<PVD> PVD { get; set; }
    }
}
