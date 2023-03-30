using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class ValidateUIB
    {
        /// <summary>
        /// Validate the typed control segments
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            Stream ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\PrescriptionRequest_NEWRX.txt");

            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Templates.Ncpdp"))
            {
                while (ncpdpReader.Read())
                {
                    var header = ncpdpReader.Item as UIB;
                    if (header != null)
                    {
                        //  Validate 
                        var headerErrors = header.Validate();
                        //  Pull the sending application from UIB
                        var senderId = header.INTERCHANGESENDER_06.SenderIdentification_01;
                        Debug.WriteLine("Sender ID:");
                        Debug.WriteLine(senderId);
                    }
                }
            }
        }
    }
}
