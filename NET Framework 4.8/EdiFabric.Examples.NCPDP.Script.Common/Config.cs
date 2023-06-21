namespace EdiFabric.Examples.NCPDP.Script.Common
{
    public class Config
    {
#if NET
        public static string TestFilesPath = @"\..\..\..\..\..\Files";
#else
        public static string TestFilesPath = @"\..\..\..\..\Files";
#endif

    }
}
