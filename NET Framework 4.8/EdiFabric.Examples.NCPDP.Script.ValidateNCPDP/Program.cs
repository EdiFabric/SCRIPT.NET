using EdiFabric.Examples.NCPDP.Script.Common;
using System;

namespace EdiFabric.Examples.NCPDP.Script.ValidateNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialKey.Set(Config.TrialSerialKey, true);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Can't set token"))
                    throw new Exception("Your trial has expired! To continue using EdiFabric SDK you must purchase a plan from https://www.edifabric.com/pricing.html");
            }

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
