﻿using EdiFabric.Examples.NCPDP.Script.Common;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Validate custom NCPDP codes
            ValidateCustomNCPDPCodes.Run();
            ValidateCustomNCPDPCodes.Run2();

            //  Validate transactions 
            ValidateNCPDPTransations.Run();

            //  Validate transactions with custom code
            ValidateNCPDPTransationsWithCustomCode.Run();

            //  Validate data element alpha and alphanumeric data types
            ValidateDataElementTypes.Unoa();
            ValidateDataElementTypes.Unob();

            //  Validate control segment TransmissionHeader
            ValidateUIB.Run();

            //  Validate async
            ValidateNCPDPTransationsAsync.Run();

            //  Validate before writing
            ValidateEDITransationsBeforeWrite.Run();
        }
    }
}
