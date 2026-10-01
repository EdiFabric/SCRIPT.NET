using EdiFabric.Examples.NCPDP.Script.Common;
using System;

namespace EdiFabric.Examples.NCPDP.Script.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
