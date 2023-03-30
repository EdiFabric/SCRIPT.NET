using EdiFabric.Core.Model.Edi.Ncpdp;
using EdiFabric.Templates.Script106;
using System;
using System.Collections.Generic;

namespace EdiFabric.Examples.NCPDP.Script.Common
{
    public class SegmentBuilders
    {
        /// <summary>
        /// Build UIB
        /// </summary>
        /// <returns></returns>
        public static UIB BuildInterchangeHeader(string refNumber = "1234567", string senderId = "SENDER1", string senderQalifier = "Q1", string senderPass = "PASSWORD1", string receiverId = "RECEIVER2", string receiverQalifier = "Q2")
        {
            var result = new UIB
            {
                SYNTAXIDENTIFIER_01 = new S001
                {
                    //  Syntax Identifier
                    SyntaxIdentifier_01 = "UNOA",
                    //  Syntax Version Number
                    SyntaxVersionNumber_02 = "0"
                },
                TRANSACTIONREFERENCE_03 = new S303
                {
                    TransactionControlReference_01 = refNumber
                },
                INTERCHANGESENDER_06 = new S002
                {
                    //  Interchange sender identification
                    SenderIdentification_01 = senderId,
                    //  Identification code qualifier
                    IdentificationCodeQualifier_02 = senderQalifier,
                    //  Interchange sender password
                    SenderIdentification_03 = senderPass
                },
                INTERCHANGERECIPIENT_07 = new S003
                {
                    //  Interchange recipient identification
                    RecipientIdentification_01 = receiverId,
                    //  Identification code qualifier
                    IdentificationCodeQualifier_02 = receiverQalifier
                },
                DATEANDTIME_08 = new S300
                {
                    //  Date
                    Date_01 = DateTime.Now.Date.ToString("yyyyMMdd"),
                    //  Time
                    Time_02 = DateTime.Now.TimeOfDay.ToString("hhmmss")
                }
            };

            return result;
        }

        /// <summary>
        /// Build New Prescription Request
        /// </summary>
        /// <returns></returns>
        public static TSNEWRX BuildPrescriptionRequest(string tranRefNumber = "123")
        {
            var result = new TSNEWRX();

            //  UIH Segment
            result.UIH = new UIH();
            result.UIH.MESSAGEIDENTIFIER_01 = new S306();
            result.UIH.MESSAGEIDENTIFIER_01.MessageType_01 = "SCRIPT";
            result.UIH.MESSAGEIDENTIFIER_01.MessageVersionNumber_02 = "010";
            result.UIH.MESSAGEIDENTIFIER_01.MessageReleaseNumber_03 = "006";
            result.UIH.MESSAGEIDENTIFIER_01.MessageFunction_04 = "NEWRX";
            result.UIH.MessageReferenceNumber_02 = tranRefNumber;
            result.UIH.DATEANDTIME_05 = new S300();
            result.UIH.DATEANDTIME_05.Date_01 = "19971001";
            result.UIH.DATEANDTIME_05.Time_02 = "081322";

            //  Repeatable PVD Segments
            result.PVD = new List<PVD>();

            //  PVD Segment 1
            var pvd1 = new PVD();
            pvd1.ProviderCoded_01 = "P1";

            pvd1.I001_02 = new List<I001>();

            var i0011 = new I001();
            i0011.ReferenceNumber_01 = "7701630";
            i0011.ReferenceQualifier_02 = "D3";
            pvd1.I001_02.Add(i0011);

            pvd1.PartyName_07 = "MAIN STREET PHARMACY";
            pvd1.I016_09 = new I016();
            pvd1.I016_09.CommunicationNumber_01 = "6152205656";
            pvd1.I016_09.CodeListQualifier_02 = "TE";
            result.PVD.Add(pvd1);

            //  PVD Segment 2
            var pvd2 = new PVD();
            pvd2.ProviderCoded_01 = "PC";

            pvd2.I001_02 = new List<I001>();

            var i0012 = new I001();
            i0012.ReferenceNumber_01 = "6666666";
            i0012.ReferenceQualifier_02 = "0B";
            pvd2.I001_02.Add(i0012);

            pvd2.I002_05 = new I002();
            pvd2.I002_05.PartyName_01 = "JONES";
            pvd2.I002_05.FirstName_02 = "MARK";

            pvd2.I016_09 = new I016();
            pvd2.I016_09.CommunicationNumber_01 = "6152219800";
            pvd2.I016_09.CodeListQualifier_02 = "TE";
            result.PVD.Add(pvd2);

            //  PTT Segment
            result.PTT = new PTT();
            result.PTT.CenturyDate_02 = "19541225";
            result.PTT.I002_03 = new I002();
            result.PTT.I002_03.PartyName_01 = "SMITH";
            result.PTT.I002_03.FirstName_02 = "MARY";

            result.PTT.Gender_04 = "F";
            result.PTT.I001_05 = new List<I001>();

            var i0013 = new I001();
            i0013.ReferenceNumber_01 = "333445555";
            i0013.ReferenceQualifier_02 = "SY";
            result.PTT.I001_05.Add(i0013);

            //  BEGIN DRU LOOP
            result.DRULoop = new Loop_DRU_TSNEWRX();

            result.DRULoop.DRU = new DRU();
            result.DRULoop.DRU.I013_01 = new I013();
            result.DRULoop.DRU.I013_01.ItemDescriptionIdentification_01 = "P";
            result.DRULoop.DRU.I013_01.ItemDescription_02 = "CALAN SR 240MG";
            result.DRULoop.DRU.I013_01.FreeText_06 = "240";
            result.DRULoop.DRU.I013_01.SourceCodeList_13 = "AA";
            result.DRULoop.DRU.I013_01.ItemFormCode_14 = "C42998";
            result.DRULoop.DRU.I013_01.SourceCodeList_15 = "AB";
            result.DRULoop.DRU.I013_01.ItemStrengthCode_16 = "C28253";

            result.DRULoop.DRU.I009_02 = new List<I009>();
            var i0091 = new I009();
            i0091.Quantity_02 = "60";
            i0091.CodeListQualifier_03 = "38";
            i0091.SourceCodeList_04 = "AC";
            i0091.PotencyUnitCode_05 = "C48542";
            result.DRULoop.DRU.I009_02.Add(i0091);

            result.DRULoop.DRU.I014_03 = new I014();
            result.DRULoop.DRU.I014_03.Dosage_02 = "1 TID -TAKE ONE TABLET TWO TIMES A DAY UNTILGONE";

            result.DRULoop.DRU.I006_04 = new List<I006>();

            var i0061 = new I006();
            i0061.DateTimePeriodQualifier_01 = "85";
            i0061.DateTimePeriod_02 = "19971001";
            i0061.DateTimePeriodFormatqualifier_03 = "102";
            result.DRULoop.DRU.I006_04.Add(i0061);

            var i0062 = new I006();
            i0062.DateTimePeriodQualifier_01 = "ZDS";
            i0062.DateTimePeriod_02 = "30";
            i0062.DateTimePeriodFormatqualifier_03 = "804";
            result.DRULoop.DRU.I006_04.Add(i0062);

            result.DRULoop.DRU.ProductServiceSubstitution_05 = "0";
            result.DRULoop.DRU.I009_06 = new List<I009>();
            var i0092 = new I009();
            i0092.QuantityQualifier_01 = "R";
            i0092.Quantity_02 = "1";
            result.DRULoop.DRU.I009_06.Add(i0092);

            //  END DRU LOOP

            return result;
        }

    }
}
