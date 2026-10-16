using EdiFabric.Core.Model.Edi;
using EdiFabric.Examples.NCPDP.Script.Common;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.Script106;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace EdiFabric.Examples.NCPDP.Script.JSON
{
    class SerializeToJson
    {
        /// <summary>
        /// Serialize an NCPDP object to Json using Json.NET
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var ncpdpStream = File.OpenRead(Directory.GetCurrentDirectory() + Config.TestFilesPath + @"\PrescriptionRequest_NEWRX.txt");

            List<IEdiItem> ncpdpItems;
            using (var ncpdpReader = new NcpdpScriptReader(ncpdpStream, "EdiFabric.Examples.NCPDP.Script.Common"))
            {
                ncpdpItems = ncpdpReader.ReadToEnd().ToList();
            }

            var transactions = ncpdpItems.OfType<TSNEWRX>();
            foreach (var transaction in transactions)
            {
                var options = new JsonSerializerOptions
                {
                    //TypeInfoResolver = new DefaultJsonTypeInfoResolver
                    //{
                    //    Modifiers =
                    //    {
                    //        typeInfo =>
                    //        {
                    //            if (typeInfo.Kind != JsonTypeInfoKind.Object)
                    //                return;

                    //            foreach (var property in typeInfo.Properties)
                    //            {
                    //                if (property.Name == "Id" )
                    //                {
                    //                    property.ShouldSerialize = (obj, value) => false;
                    //                }
                    //            }
                    //        }
                    //    }
                    //},
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                var json = JsonSerializer.Serialize(transaction, options);
                Debug.WriteLine(json.ToString());
            }
        }
    }
}
