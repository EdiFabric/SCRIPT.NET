using EdiFabric.Examples.NCPDP.Script.Common;

namespace EdiFabric.Examples.NCPDP.Script.JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Config.TrialSerialKey);

            //  Serialize to JSON
            SerializeToJson.Run();

            //  Deserialize from JSON
            DeserializeFromJson.Run();
        }
    }
}
