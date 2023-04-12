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
    class ReadNCPDPFileSplitting
    {
        /// <summary>
        /// Copy a message and remove unwanted parts.
        /// </summary>
        public static void RunWithCopy()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyRequest.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            var pharmacyRequests = ncpdpItems.OfType<TSREFREQ>();
            var splitPharmacyRequests = new List<TSREFREQ>();

            foreach (var pharmacyRequest in pharmacyRequests)
            {
                foreach (var druLoop in pharmacyRequest.DRULoop)
                {
                    var splitPharmacyRequest = pharmacyRequest.Copy() as TSREFREQ;
                    splitPharmacyRequest.DRULoop.RemoveAll(l => splitPharmacyRequest.DRULoop.IndexOf(l) != pharmacyRequest.DRULoop.IndexOf(druLoop));
                    splitPharmacyRequests.Add(splitPharmacyRequest);
                }
            }

            foreach (var pharmacyRequest in pharmacyRequests)
                Debug.WriteLine(string.Format("Original: Pharmacy Request - DRU parts {0}", pharmacyRequest.DRULoop.Count()));

            foreach (var splitPharmacyRequest in splitPharmacyRequests)
                Debug.WriteLine(string.Format("Split: Pharmacy Request - DRU parts {0}", splitPharmacyRequest.DRULoop.Count()));
        }

        /// <summary>
        /// Split a message into parts (blocks of segments) and read each part individually.
        /// Use to process large transactions with repeating loops.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PharmacyRequest.txt");

            //  The split is driven by setting which class to split by in the template.
            //  Set the class to inherit from EdiItem and the parser will automatically split by it.
            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, (UIB uib, UIH uih) => typeof(TSREFREQSplitter).GetTypeInfo(), new NcpdpScriptReaderSettings { Split = true }))
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();

            //  Find all DRU loops, they are all different ediItems
            var druLoop = ncpdpItems.OfType<TSREFREQSplitter>().Where(m => m.DRULoop != null).SelectMany(m => m.DRULoop);
            Debug.WriteLine(string.Format("PharmacyRequest parts {0}", druLoop.Count()));
        }
    }

    [DataContract]
    [Message("SCRIPT", "REFREQ")]
    public class TSREFREQSplitter : TSREFREQ
    {
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        [Required]
        [Splitter]
        public new List<Loop_DRU_TSREFREQ> DRULoop { get; set; }
    }
}
