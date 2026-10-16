namespace EdiFabric.Templates.Script106
{
    using System;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;


    /// <summary>
    // Syntax identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",KECA,UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOK,UNOL,UNOQ,UNOW,UNOX," +
            "UNOY,UNOZ,")]
    public class NCPDP_ID_0001
    {
    }

    /// <summary>
    // Syntax version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,")]
    public class NCPDP_ID_0002
    {
    }

    /// <summary>
    // Level one identification code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,M,P,ZZZ,")]
    public class NCPDP_ID_0007
    {
    }

    /// <summary>
    // Test indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",...,1,")]
    public class NCPDP_ID_0035
    {
    }

    /// <summary>
    // Controlling agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,CC,CE,EC,ED,EE,EN,ER,EU,EW,EX,IA,KE,LI,OD,RI,RT,UN,")]
    public class NCPDP_ID_0051
    {
    }

    /// <summary>
    // Message function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CANRES,CANRX,CENSUS,CHGRES,ERROR,GETMSG,NEWRX,PASCHG,REFREQ,REFRES,RESUPP,RXCHG," +
            "RXFILL,RXHREQ,RXHRES,STATUS,VERIFY,")]
    public class NCPDP_ID_0326
    {
    }

    /// <summary>
    // Message type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",SCRIPT,")]
    public class NCPDP_ID_0329
    {
    }

    /// <summary>
    // Reference Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0B,1C,1D,1E,1G,1J,1M,2U,94,ADI,BO,C1,D3,DH,EA,EJ,G1,HI,HPI,IP,NC,NF,PD,SY,WI,ZZ," +
            "ZZZ,")]
    public class NCPDP_ID_1153
    {
    }

    /// <summary>
    // Date/Time/Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",06,07,35,36,74,85,BE,LD,PE,RD,SD,ZDS,")]
    public class NCPDP_ID_2005
    {
    }

    /// <summary>
    // Time Zone Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",UT,")]
    public class NCPDP_ID_2029
    {
    }

    /// <summary>
    // Date/Time/Period Format qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",10,101,102,103,104,105,106,107,108,109,110,2,201,202,203,204,205,3,301,302,303,304,305,306,4,401,402,404,405,406,5,501,502,503,6,600,601,602,603,604,608,609,610,613,614,615,616,7,701,702,703,704,705,706,707,708,709,710,713,715,716,717,718,719,720,8,801,802,803,804,805,806,807,808,809,810,811,812,813,814,9,")]
    public class NCPDP_ID_2379
    {
    }

    /// <summary>
    // Code List Responsible Agency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABF,DX,IR,LD,MF,ND,NH,RT,RX,UN,UP,")]
    public class NCPDP_ID_3055
    {
    }

    /// <summary>
    // Country Sub-entity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,56,57,58,59,AB,AK,AL,AR,AS,AZ,BC,CA,CO,CT,DC,DE,FL,FM,GA,GU,HI,IA,ID,IL,IN,KS,KY,LA,MA,MB,MD,ME,MH,MI,MN,MO,MP,MS,MT,NB,NC,ND,NE,NF,NH,NJ,NM,NS,NT,NU,NV,NY,OH,OK,ON,OR,PA,PE,PR,PW,QC,RI,SC,SD,SK,TN,TX,UT,VA,VI,VT,WA,WI,WV,WY,YT,")]
    public class NCPDP_ID_3229
    {
    }

    /// <summary>
    // Message Function
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AC,C,C1,C2,C3,CS,CT,D1,D2,D3,D4,DC,FS,G,IO,IS,LC,LG,LR,LT,OI,P,PA,PC,RA,RC,RO," +
            "T,TC,")]
    public class NCPDP_ID_4343
    {
    }

    /// <summary>
    // Product/Service Substitution
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,7,8,")]
    public class NCPDP_ID_4457
    {
    }

    /// <summary>
    // Insurance Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,PP,S,T,U,")]
    public class NCPDP_ID_4703
    {
    }

    /// <summary>
    // Provider Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AS,AT,BI,BS,CO,CV,H,HH,LA,ON,OP,OR,OT,P1,P2,PC,PE,PT,PU,R,RF,RP,SB,SK,SU,")]
    public class NCPDP_ID_4705
    {
    }

    /// <summary>
    // Agency Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,")]
    public class NCPDP_ID_4709
    {
    }

    /// <summary>
    // Condition/Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,X,Y,Z,")]
    public class NCPDP_ID_4711
    {
    }

    /// <summary>
    // Measurement Dimension
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",HT,WG,ZZD,ZZS,")]
    public class NCPDP_ID_6311
    {
    }

    /// <summary>
    // Clinical Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_6810
    {
    }

    /// <summary>
    // Item Description Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,P,R,")]
    public class NCPDP_ID_7009
    {
    }

    /// <summary>
    // Item Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",...,235719002,248536006,282291009,404684003,409586006,414285001,416098002,418038" +
            "007,418471000,418799008,419199007,419511003,420134006,55607006,59037007,64572001" +
            ",")]
    public class NCPDP_ID_7140
    {
    }

    /// <summary>
    // Service Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,")]
    public class NCPDP_ID_7701
    {
    }

    /// <summary>
    // DUE Reason For Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AN,AR,AT,CD,CH,CS,DA,DC,DD,DF,DI,DL,DM,DR,DS,ED,ER,EX,HD,IC,ID,LD,LK,LR,MC,MN" +
            ",MS,MX,NA,NC,ND,NF,NN,NP,NR,NS,OH,PA,PC,PG,PH,PN,PP,PR,PS,RE,RF,SC,SD,SE,SF,SR,S" +
            "X,TD,TN,TP,UD,")]
    public class NCPDP_ID_7880
    {
    }

    /// <summary>
    // DUE Professional Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,AS,CC,DE,DP,FE,GP,M0,MA,MB,MP,MR,P0,PA,PE,PH,PM,PT,R0,RT,SC,SW,TC,TH,ZZ,")]
    public class NCPDP_ID_7881
    {
    }

    /// <summary>
    // DUE Result Of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,2A,2B,3A,3B,3C,3D,3E,3F,3G,3H,3J,3K,3M,3N,4A,")]
    public class NCPDP_ID_7882
    {
    }

    /// <summary>
    // DUE Co-Agent ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",02,03,04,07,08,09,11,12,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32" +
            ",33,37,99,")]
    public class NCPDP_ID_7884
    {
    }

    /// <summary>
    // Drug Coverage Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,DC,NF,NR,PA,PR,ST,UN,")]
    public class NCPDP_ID_7885
    {
    }

    /// <summary>
    // Measurement Data Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class NCPDP_ID_7887
    {
    }

    /// <summary>
    // Prior Authorization Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,F,N,R,")]
    public class NCPDP_ID_7891
    {
    }

    /// <summary>
    // Do Not Fill/Profile Flag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class NCPDP_ID_7892
    {
    }

    /// <summary>
    // Change of Prescription Status Flag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,")]
    public class NCPDP_ID_7893
    {
    }

    /// <summary>
    // Source Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P2,PC,PY,")]
    public class NCPDP_ID_7895
    {
    }

    /// <summary>
    // Multiple SIG Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,THEN,")]
    public class NCPDP_ID_7899
    {
    }

    /// <summary>
    // Sig Free Text String Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class NCPDP_ID_7902
    {
    }

    /// <summary>
    // Dose Composite Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class NCPDP_ID_7903
    {
    }

    /// <summary>
    // Dose Delivery Method Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7905
    {
    }

    /// <summary>
    // Dose Delivery Method Modifier Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7908
    {
    }

    /// <summary>
    // Dose Form Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7912
    {
    }

    /// <summary>
    // Dose Range Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",OR,TO,")]
    public class NCPDP_ID_7914
    {
    }

    /// <summary>
    // Dosing Basis Unit of Measure Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7917
    {
    }

    /// <summary>
    // Body Metric Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7919
    {
    }

    /// <summary>
    // Calculated Dose Unit of Measure Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7923
    {
    }

    /// <summary>
    // Dosing Basis Range Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",OR,TO,")]
    public class NCPDP_ID_7925
    {
    }

    /// <summary>
    // Vehicle Name Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7927
    {
    }

    /// <summary>
    // Vehicle Unit Of Measure Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7931
    {
    }

    /// <summary>
    // Multiple Vehicle Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,")]
    public class NCPDP_ID_7933
    {
    }

    /// <summary>
    // Route of Administration Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7935
    {
    }

    /// <summary>
    // Multiple Route of Administration Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,")]
    public class NCPDP_ID_7937
    {
    }

    /// <summary>
    // Site of Administration Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7939
    {
    }

    /// <summary>
    // Multiple Site of Administration Timing Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,NOT,OR,")]
    public class NCPDP_ID_7941
    {
    }

    /// <summary>
    // Administration Timing Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7943
    {
    }

    /// <summary>
    // Multiple Administration Timing Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,")]
    public class NCPDP_ID_7945
    {
    }

    /// <summary>
    // Rate Unit of Measure Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7948
    {
    }

    /// <summary>
    // Time Period Basis Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7951
    {
    }

    /// <summary>
    // Frequency Units Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7955
    {
    }

    /// <summary>
    // Variable Frequency Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,TO,")]
    public class NCPDP_ID_7957
    {
    }

    /// <summary>
    // Interval Units Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7960
    {
    }

    /// <summary>
    // Variable Interval Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,TO,")]
    public class NCPDP_ID_7962
    {
    }

    /// <summary>
    // Duration Text Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7965
    {
    }

    /// <summary>
    // Maximum Dose Restriction Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7969
    {
    }

    /// <summary>
    // Maximum Dose Restriction Variable Units Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7973
    {
    }

    /// <summary>
    // Maximum Dose Restriction Variable Duration Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,")]
    public class NCPDP_ID_7975
    {
    }

    /// <summary>
    // Indication Precursor Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7977
    {
    }

    /// <summary>
    // Indication Text Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7980
    {
    }

    /// <summary>
    // Indication Value Unit of Measure Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class NCPDP_ID_7985
    {
    }

    /// <summary>
    // Indication Variable Modifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AND,OR,TO,")]
    public class NCPDP_ID_7987
    {
    }

    /// <summary>
    // Stop Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class NCPDP_ID_7988
    {
    }

    /// <summary>
    // Provider Specialty code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",101Y00000X,101YA0400X,101YM0800X,101YP1600X,101YP2500X,101YS0200X,102L00000X,102" +
            "X00000X,103G00000X,103GC0700X,103K00000X,103T00000X,103TA0400X,103TA0700X,103TB0" +
            "200X,103TC0700X,103TC1900X,103TC2200X,103TE1000X,103TE1100X,103TF0000X,103TF0200" +
            "X,103TH0004X,103TH0100X,103TM1700X,103TM1800X,103TP0016X,103TP0814X,103TP2700X,1" +
            "03TP2701X,103TR0400X,103TS0200X,103TW0100X,104100000X,1041C0700X,1041S0200X,106H" +
            "00000X,111N00000X,111NI0013X,111NI0900X,111NN0400X,111NN1001X,111NP0017X,111NR02" +
            "00X,111NR0400X,111NS0005X,111NT0100X,111NX0100X,111NX0800X,122300000X,1223D0001X" +
            ",1223E0200X,1223G0001X,1223P0106X,1223P0221X,1223P0300X,1223P0700X,1223S0112X,12" +
            "23X0008X,1223X0400X,122400000X,124Q00000X,126800000X,126900000X,132700000X,133N0" +
            "0000X,133NN1002X,133V00000X,133VN1004X,133VN1005X,133VN1006X,136A00000X,146D0000" +
            "0X,146L00000X,146M00000X,146N00000X,152W00000X,152WC0802X,152WL0500X,152WP0200X," +
            "152WS0006X,152WV0400X,152WX0102X,156F00000X,156FC0800X,156FC0801X,156FX1100X,156" +
            "FX1101X,156FX1201X,156FX1202X,156FX1700X,156FX1800X,156FX1900X,163W00000X,163WA0" +
            "400X,163WA2000X,163WC0200X,163WC0400X,163WC1400X,163WC1500X,163WC1600X,163WC2100" +
            "X,163WC3500X,163WD0400X,163WD1100X,163WE0003X,163WE0900X,163WF0300X,163WG0000X,1" +
            "63WG0100X,163WG0600X,163WH0200X,163WH0500X,163WH1000X,163WI0500X,163WI0600X,163W" +
            "L0100X,163WM0102X,163WM0705X,163WM1400X,163WN0002X,163WN0003X,163WN0300X,163WN08" +
            "00X,163WN1003X,163WP0000X,163WP0200X,163WP0218X,163WP0807X,163WP0808X,163WP0809X" +
            ",163WP1700X,163WP2201X,163WR0006X,163WR0400X,163WR1000X,163WS0121X,163WS0200X,16" +
            "3WU0100X,163WW0000X,163WW0101X,163WX0002X,163WX0003X,163WX0106X,163WX0200X,163WX" +
            "0601X,163WX0800X,163WX1100X,163WX1500X,164W00000X,164X00000X,167G00000X,17010000" +
            "0X,170300000X,171000000X,1710I1002X,1710I1003X,171100000X,171M00000X,171R00000X," +
            "171W00000X,171WH0202X,171WV0202X,172A00000X,172M00000X,172P00000X,172V00000X,173" +
            "000000X,173C00000X,173F00000X,174400000X,1744G0900X,1744P3200X,1744R1102X,1744R1" +
            "103X,174H00000X,174M00000X,174MM1900X,175F00000X,175L00000X,175M00000X,176B00000" +
            "X,176P00000X,177F00000X,183500000X,1835G0000X,1835G0303X,1835N0905X,1835N1003X,1" +
            "835P0018X,1835P1200X,1835P1300X,1835X0200X,183700000X,193200000X,193400000X,202C" +
            "00000X,202K00000X,204C00000X,204D00000X,204E00000X,204F00000X,207K00000X,207KA02" +
            "00X,207KI0005X,207L00000X,207LA0401X,207LC0200X,207LH0002X,207LP2900X,207LP3000X" +
            ",207N00000X,207ND0101X,207ND0900X,207NI0002X,207NP0225X,207NS0135X,207P00000X,20" +
            "7PE0004X,207PE0005X,207PH0002X,207PP0204X,207PS0010X,207PT0002X,207Q00000X,207QA" +
            "0000X,207QA0401X,207QA0505X,207QB0002X,207QG0300X,207QH0002X,207QS0010X,207QS120" +
            "1X,207R00000X,207RA0000X,207RA0201X,207RA0401X,207RB0002X,207RC0000X,207RC0001X," +
            "207RC0200X,207RE0101X,207RG0100X,207RG0300X,207RH0000X,207RH0002X,207RH0003X,207" +
            "RI0001X,207RI0008X,207RI0011X,207RI0200X,207RM1200X,207RN0300X,207RP1001X,207RR0" +
            "500X,207RS0010X,207RS0012X,207RT0003X,207RX0202X,207SC0300X,207SG0201X,207SG0202" +
            "X,207SG0203X,207SG0205X,207SM0001X,207T00000X,207U00000X,207UN0901X,207UN0902X,2" +
            "07UN0903X,207V00000X,207VB0002X,207VC0200X,207VE0102X,207VG0400X,207VH0002X,207V" +
            "M0101X,207VX0000X,207VX0201X,207W00000X,207X00000X,207XP3100X,207XS0106X,207XS01" +
            "14X,207XS0117X,207XX0004X,207XX0005X,207XX0801X,207Y00000X,207YP0228X,207YS0012X" +
            ",207YS0123X,207YX0007X,207YX0602X,207YX0901X,207YX0905X,207ZB0001X,207ZC0006X,20" +
            "7ZC0500X,207ZD0900X,207ZF0201X,207ZH0000X,207ZI0100X,207ZM0300X,207ZN0500X,207ZP" +
            "0007X,207ZP0101X,207ZP0102X,207ZP0104X,207ZP0105X,207ZP0213X,208000000X,2080A000" +
            "0X,2080C0008X,2080H0002X,2080I0007X,2080N0001X,2080P0006X,2080P0008X,2080P0201X," +
            "2080P0202X,2080P0203X,2080P0204X,2080P0205X,2080P0206X,2080P0207X,2080P0208X,208" +
            "0P0210X,2080P0214X,2080P0216X,2080S0010X,2080S0012X,2080T0002X,2080T0004X,208100" +
            "000X,2081H0002X,2081N0008X,2081P0004X,2081P0010X,2081P2900X,2081S0010X,208200000" +
            "X,2082S0099X,2082S0105X,2083A0100X,2083P0011X,2083P0500X,2083P0901X,2083S0010X,2" +
            "083T0002X,2083X0100X,2084A0401X,2084B0002X,2084D0003X,2084F0202X,2084H0002X,2084" +
            "N0008X,2084N0400X,2084N0402X,2084N0600X,2084P0005X,2084P0015X,2084P0800X,2084P08" +
            "02X,2084P0804X,2084P0805X,2084P2900X,2084S0010X,2084S0012X,2084V0102X,2085B0100X" +
            ",2085D0003X,2085H0002X,2085N0700X,2085N0904X,2085P0229X,2085R0001X,2085R0202X,20" +
            "85R0203X,2085R0204X,2085R0205X,2085U0001X,208600000X,2086H0002X,2086S0102X,2086S" +
            "0105X,2086S0120X,2086S0122X,2086S0127X,2086S0129X,2086X0206X,208800000X,2088P023" +
            "1X,208C00000X,208D00000X,208G00000X,208M00000X,208U00000X,208VP0000X,208VP0014X," +
            "209800000X,211D00000X,213E00000X,213EG0000X,213EP0504X,213EP1101X,213ER0200X,213" +
            "ES0000X,213ES0103X,213ES0131X,221700000X,222Q00000X,222Z00000X,224P00000X,224Z00" +
            "000X,224ZE0001X,224ZF0002X,224ZL0004X,224ZR0403X,225000000X,225100000X,2251C2600" +
            "X,2251E1200X,2251E1300X,2251G0304X,2251H1200X,2251H1300X,2251N0400X,2251P0200X,2" +
            "251S0007X,2251X0800X,225200000X,225400000X,225500000X,2255A2300X,2255R0406X,2256" +
            "00000X,225700000X,225800000X,225A00000X,225B00000X,225C00000X,225CA2400X,225CA25" +
            "00X,225CX0006X,225X00000X,225XE0001X,225XE1200X,225XF0002X,225XG0600X,225XH1200X" +
            ",225XH1300X,225XL0004X,225XM0800X,225XN1300X,225XP0019X,225XP0200X,225XR0403X,22" +
            "6300000X,227800000X,2278C0205X,2278E0002X,2278E1000X,2278G0305X,2278G1100X,2278H" +
            "0200X,2278P1004X,2278P1005X,2278P1006X,2278P3800X,2278P3900X,2278P4000X,2278S150" +
            "0X,227900000X,2279C0205X,2279E0002X,2279E1000X,2279G0305X,2279G1100X,2279H0200X," +
            "2279P1004X,2279P1005X,2279P1006X,2279P3800X,2279P3900X,2279P4000X,2279S1500X,229" +
            "N00000X,231H00000X,231HA2400X,231HA2500X,235500000X,2355A2700X,2355S0801X,235Z00" +
            "000X,237600000X,237700000X,242T00000X,243U00000X,246Q00000X,246QB0000X,246QC1000" +
            "X,246QC2700X,246QH0000X,246QH0401X,246QH0600X,246QI0000X,246QL0900X,246QL0901X,2" +
            "46QM0706X,246QM0900X,246R00000X,246RH0600X,246RM2200X,246RP1900X,246W00000X,246X" +
            "00000X,246XC2901X,246XC2903X,246XS1301X,246Y00000X,246YC3301X,246YC3302X,246YR16" +
            "00X,246Z00000X,246ZA2600X,246ZB0301X,246ZB0302X,246ZB0500X,246ZB0600X,246ZC0007X" +
            ",246ZE0500X,246ZE0600X,246ZG0701X,246ZG1000X,246ZI1000X,246ZN0300X,246ZS0400X,24" +
            "7000000X,2470A2800X,247100000X,2471B0102X,2471C1101X,2471C1106X,2471C3401X,2471C" +
            "3402X,2471M1202X,2471M2300X,2471N0900X,2471Q0001X,2471R0002X,2471S1302X,2471V010" +
            "5X,2471V0106X,247200000X,2472B0301X,2472D0500X,2472E0500X,2472R0900X,2472V0600X," +
            "247ZC0005X,251300000X,251B00000X,251C00000X,251E00000X,251F00000X,251G00000X,251" +
            "J00000X,251K00000X,251S00000X,251T00000X,251V00000X,251X00000X,252Y00000X,253J00" +
            "000X,253Z00000X,261Q00000X,261QA0005X,261QA0006X,261QA0600X,261QA0900X,261QA1903" +
            "X,261QA3000X,261QB0400X,261QC0050X,261QC1500X,261QC1800X,261QD0000X,261QD1600X,2" +
            "61QE0002X,261QE0700X,261QE0800X,261QF0050X,261QF0400X,261QG0250X,261QH0100X,261Q" +
            "H0700X,261QI0500X,261QL0400X,261QM0801X,261QM0850X,261QM0855X,261QM1000X,261QM11" +
            "00X,261QM1101X,261QM1102X,261QM1103X,261QM1200X,261QM1300X,261QM2500X,261QM2800X" +
            ",261QM3000X,261QP0904X,261QP0905X,261QP1100X,261QP2000X,261QP2300X,261QP2400X,26" +
            "1QP3300X,261QR0200X,261QR0206X,261QR0207X,261QR0208X,261QR0400X,261QR0401X,261QR" +
            "0404X,261QR0405X,261QR0800X,261QR1100X,261QR1300X,261QS0112X,261QS0132X,261QS100" +
            "0X,261QS1200X,261QU0200X,261QV0200X,261QX0100X,261QX0200X,261QX0203X,273100000X," +
            "273R00000X,273Y00000X,275N00000X,276400000X,281P00000X,281PC2000X,282E00000X,282" +
            "J00000X,282N00000X,282NC0060X,282NC2000X,282NR1301X,282NW0100X,283Q00000X,283X00" +
            "000X,283XC2000X,284300000X,286500000X,2865C1500X,2865M2000X,2865X1600X,287300000" +
            "X,291900000X,291U00000X,292200000X,293D00000X,302F00000X,302R00000X,305R00000X,3" +
            "05S00000X,310400000X,3104A0625X,3104A0630X,310500000X,311500000X,311Z00000X,311Z" +
            "A0620X,313M00000X,314000000X,3140N1450X,315D00000X,315P00000X,317400000X,3206000" +
            "00X,320700000X,320800000X,320900000X,322D00000X,323P00000X,324500000X,3245S0500X" +
            ",331L00000X,332000000X,332100000X,332800000X,332900000X,332B00000X,332BC3200X,33" +
            "2BD1200X,332BN1400X,332BP3500X,332BX2000X,332G00000X,332H00000X,332S00000X,332U0" +
            "0000X,333300000X,333600000X,3336C0002X,3336C0003X,3336C0004X,3336H0001X,3336I001" +
            "2X,3336L0003X,3336M0002X,3336M0003X,3336N0007X,3336S0011X,335E00000X,335U00000X," +
            "335V00000X,341600000X,3416A0800X,3416L0300X,3416S0300X,341800000X,3418M1110X,341" +
            "8M1120X,3418M1130X,343800000X,343900000X,344600000X,344800000X,347B00000X,347C00" +
            "000X,347D00000X,347E00000X,363A00000X,363AM0700X,363AS0400X,363L00000X,363LA2100" +
            "X,363LA2200X,363LC0200X,363LC1500X,363LF0000X,363LG0600X,363LN0000X,363LN0005X,3" +
            "63LP0200X,363LP0222X,363LP0808X,363LP1700X,363LP2300X,363LS0200X,363LW0102X,363L" +
            "X0001X,363LX0106X,364S00000X,364SA2100X,364SA2200X,364SC0200X,364SC1501X,364SC23" +
            "00X,364SE0003X,364SE1400X,364SF0001X,364SG0600X,364SH0200X,364SH1100X,364SI0800X" +
            ",364SL0600X,364SM0705X,364SN0000X,364SN0800X,364SP0200X,364SP0807X,364SP0808X,36" +
            "4SP0809X,364SP0810X,364SP0811X,364SP0812X,364SP0813X,364SP1700X,364SP2800X,364SR" +
            "0400X,364SS0200X,364ST0500X,364SW0102X,364SX0106X,364SX0200X,364SX0204X,36750000" +
            "0X,367A00000X,367H00000X,372500000X,372600000X,373H00000X,374700000X,3747A0650X," +
            "3747P1801X,374J00000X,374K00000X,374T00000X,374U00000X,376G00000X,376J00000X,376" +
            "K00000X,385H00000X,385HR2050X,385HR2055X,385HR2060X,385HR2065X,390200000X,")]
    public class NCPDP_ID_7990
    {
    }

    /// <summary>
    // Source Code List
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,")]
    public class NCPDP_ID_7991
    {
    }

    /// <summary>
    // DUE Clinical Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class NCPDP_ID_7997
    {
    }

    /// <summary>
    // No Known Allergies
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class NCPDP_ID_7999
    {
    }

    /// <summary>
    // Source of Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class NCPDP_ID_8000
    {
    }

    /// <summary>
    // Individivual Relationship
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class NCPDP_ID_9701
    {
    }

    /// <summary>
    // Gender
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,U,")]
    public class NCPDP_ID_9703
    {
    }

    /// <summary>
    // Status Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",000,001,002,003,005,010,600,601,602,900,")]
    public class NCPDP_ID_9015
    {
    }
}