namespace EdiFabric.Examples.NCPDP.Script.WriteNCPDP
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialKey.Set(Common.SerialKey.Get());

            //  Write NCPDP to stream and then to string or file
            WriteNCPDPToStream.Run();
            WriteNCPDPToStreamAsync.Run();

            //  Write NCPDP directly to file
            WriteNCPDPToFile.Run();

            //  Write NCPDP with custom delimiters 
            WriteNCPDPWithCustomDelimiters.Run();

            //  Write NCPDP with postfix (such as new line) after each segment
            WriteNCPDPWithNewLines.Run();

            //  Write batches
            WriteNCPDPBatch.Run1();
            WriteNCPDPBatch.Run2();

            //  Retain trailing data element delimiters for empty data elements
            WriteNCPDPWithEmptyDataElements.Run();

            //  Write transaction only
            WriteNCPDPTransactionOnly.Run();

            //  Turn auto-trailers off
            WriteNCPDPWithoutAutoTrailers.Run();
        }
    }
}
