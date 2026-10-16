namespace EdiFabric.Templates.Script106
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi.Edifact;


    /// <summary>
    // Allergy Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ALG")]
    public class ALG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // No Known Allergies
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("7999", typeof(NCPDP_ID_7999))]
        [Pos(1)]
        public virtual string NoKnownAllergies_01 { get; set; }
        /// <summary>
        // Source of Information
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("8000", typeof(NCPDP_ID_8000))]
        [Pos(2)]
        public virtual string SourceofInformation_02 { get; set; }
        /// <summary>
        // Adverse Event Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<S036> S036_03 { get; set; }
        /// <summary>
        // Adverse Event Type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual S037 S037_04 { get; set; }
        /// <summary>
        // Drug - Product Coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual S038 S038_05 { get; set; }
        /// <summary>
        // Reaction Coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual S039 S039_06 { get; set; }
        /// <summary>
        // Severity Coded
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual S040 S040_07 { get; set; }
    }

    /// <summary>
    // Coordination of Benefits Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("COO")]
    public class COO
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual I001 I001_01 { get; set; }
        /// <summary>
        // Party Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string PartyName_02 { get; set; }
        /// <summary>
        // Service Type Coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual I011 I011_03 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual I001 I001_04 { get; set; }
        /// <summary>
        // Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual I002 I002_05 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string ReferenceNumber_06 { get; set; }
        /// <summary>
        // Party Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PartyName_07 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual I004 I004_08 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(9)]
        public virtual List<I006> I006_09 { get; set; }
        /// <summary>
        // Insurance Type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4703", typeof(NCPDP_ID_4703))]
        [Pos(10)]
        public virtual string InsuranceType_10 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual I004 I004_11 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual I001 I001_12 { get; set; }
        /// <summary>
        // Condition/Response
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4711", typeof(NCPDP_ID_4711))]
        [Pos(13)]
        public virtual string ConditionResponse_13 { get; set; }
        /// <summary>
        // Patient Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("7886", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string PatientIdentifier_14 { get; set; }
        /// <summary>
        // Communication Number
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual I016 I016_15 { get; set; }
    }

    /// <summary>
    // Diagnosis Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIA")]
    public class DIA
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Source of Information
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("8000", typeof(NCPDP_ID_8000))]
        [Pos(1)]
        public virtual string SourceofInformation_01 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<I006> I006_02 { get; set; }
        /// <summary>
        // Problem Type
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual S041 S041_03 { get; set; }
        /// <summary>
        // Problem Name Coded
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<S042> S042_04 { get; set; }
    }

    /// <summary>
    // Drug Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DRU")]
    public class DRU
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Drug
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual I013 I013_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<I009> I009_02 { get; set; }
        /// <summary>
        // Directions
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual I014 I014_03 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<I006> I006_04 { get; set; }
        /// <summary>
        // Product/Service Substitution
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4457", typeof(NCPDP_ID_4457))]
        [Pos(5)]
        public virtual string ProductServiceSubstitution_05 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<I009> I009_06 { get; set; }
        /// <summary>
        // Diagnosis
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<I015> I015_07 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual I001 I001_08 { get; set; }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual List<string> FreeText_09 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Drug Use Evaluation
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<S018> S018_10 { get; set; }
        /// <summary>
        // Drug Coverage Status Code
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [StringLength(2, 2)]
        [DataElement("7885", typeof(NCPDP_ID_7885))]
        [Pos(11)]
        public virtual List<string> DrugCoverageStatusCode_11 
        {
            get { return _stringList2; }
            set { _stringList2 = value; }
        }

        private List<string> _stringList2 { get; set; }
        public virtual string StringList2
        {
            get
            {
                if (_stringList2 != null)
                    return string.Join("^", _stringList2);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList2 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Prior Authorization Status
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7891", typeof(NCPDP_ID_7891))]
        [Pos(12)]
        public virtual string PriorAuthorizationStatus_12 { get; set; }
        /// <summary>
        // Do Not Fill/Profile Flag
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7892", typeof(NCPDP_ID_7892))]
        [Pos(13)]
        public virtual string DoNotFillProfileFlag_13 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual I006 I006_14 { get; set; }
        /// <summary>
        // Time Zone
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual E034 E034_15 { get; set; }
        /// <summary>
        // Needed No Later Than Reason
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7894", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string NeededNoLaterThanReason_16 { get; set; }
    }

    /// <summary>
    // Observation Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OBS")]
    public class OBS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Observation
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(1)]
        public virtual List<S017> S017_01 { get; set; }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> FreeText_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
    }

    /// <summary>
    // Patient Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTT")]
    public class PTT
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Individivual Relationship
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9701", typeof(NCPDP_ID_9701))]
        [Pos(1)]
        public virtual string IndividivualRelationship_01 { get; set; }
        /// <summary>
        // Century Date
        /// </summary>
        [DataMember]
        [StringLength(8, 8)]
        [DataElement("2700", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CenturyDate_02 { get; set; }
        /// <summary>
        // Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual I002 I002_03 { get; set; }
        /// <summary>
        // Gender
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("9703", typeof(NCPDP_ID_9703))]
        [Pos(4)]
        public virtual string Gender_04 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<I001> I001_05 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual I004 I004_06 { get; set; }
        /// <summary>
        // Communication Number
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual I016 I016_07 { get; set; }
        /// <summary>
        // Location
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual S020 S020_08 { get; set; }
    }

    /// <summary>
    // Provider Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PVD")]
    public class PVD
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Provider Coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4705", typeof(NCPDP_ID_4705))]
        [Pos(1)]
        public virtual string ProviderCoded_01 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<I001> I001_02 { get; set; }
        /// <summary>
        // Health Care Service Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual I012 I012_03 { get; set; }
        /// <summary>
        // Provider Specialty
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual I007 I007_04 { get; set; }
        /// <summary>
        // Name
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual I002 I002_05 { get; set; }
        /// <summary>
        // Postcode Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PostcodeIdentification_06 { get; set; }
        /// <summary>
        // Party Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string PartyName_07 { get; set; }
        /// <summary>
        // Address
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual I004 I004_08 { get; set; }
        /// <summary>
        // Communication Number
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual I016 I016_09 { get; set; }
        /// <summary>
        // Name
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual I002 I002_10 { get; set; }
    }

    /// <summary>
    // Request Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REQ")]
    public class REQ
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Message Function
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4343", typeof(NCPDP_ID_4343))]
        [Pos(1)]
        public virtual string MessageFunction_01 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReferenceNumber_03 { get; set; }
        /// <summary>
        // Sender identification - level two
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("0008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string Senderidentificationleveltwo_04 { get; set; }
        /// <summary>
        // Sender identification - level two
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("0008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string Senderidentificationleveltwo_05 { get; set; }
        /// <summary>
        // Change of Prescription Status Flag
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7893", typeof(NCPDP_ID_7893))]
        [Pos(6)]
        public virtual string ChangeofPrescriptionStatusFlag_06 { get; set; }
        /// <summary>
        // Date
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual I006 I006_07 { get; set; }
    }

    /// <summary>
    // Response Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RES")]
    public class RES
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Message Function
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4343", typeof(NCPDP_ID_4343))]
        [Pos(1)]
        public virtual string MessageFunction_01 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> CodeListQualifier_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReferenceNumber_03 { get; set; }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string FreeText_04 { get; set; }
    }

    /// <summary>
    // Structured Sig Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SIG")]
    public class SIG
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Repeating Sig
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S022 S022_01 { get; set; }
        /// <summary>
        // Code System Composite
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual S023 S023_02 { get; set; }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual S024 S024_03 { get; set; }
        /// <summary>
        // Dose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual S025 S025_04 { get; set; }
        /// <summary>
        // Dose Calculation
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual S026 S026_05 { get; set; }
        /// <summary>
        // Vehicle
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual S027 S027_06 { get; set; }
        /// <summary>
        // Route of Administration
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual S028 S028_07 { get; set; }
        /// <summary>
        // Site of Administration
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual S029 S029_08 { get; set; }
        /// <summary>
        // Timing
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual S030 S030_09 { get; set; }
        /// <summary>
        // Duration
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual S031 S031_10 { get; set; }
        /// <summary>
        // Maximum Dose Restriction
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual S033 S033_11 { get; set; }
        /// <summary>
        // Indication
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual S034 S034_12 { get; set; }
        /// <summary>
        // Stop
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual S035 S035_13 { get; set; }
    }

    /// <summary>
    // Source Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SRC")]
    public class SRC
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Source
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual S021 S021_01 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ReferenceNumber_02 { get; set; }
        /// <summary>
        // Fill Number
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7897", typeof(EDIFACT_N))]
        [Pos(3)]
        public virtual string FillNumber_03 { get; set; }
    }

    /// <summary>
    // Status Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STS")]
    public class STS
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Status Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("9015", typeof(NCPDP_ID_9015))]
        [Pos(1)]
        public virtual string StatusType_01 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual List<string> CodeListQualifier_02 
        {
            get { return _stringList1; }
            set { _stringList1 = value; }
        }

        private List<string> _stringList1 { get; set; }
        public virtual string StringList1
        {
            get
            {
                if (_stringList1 != null)
                    return string.Join("^", _stringList1);

                return null;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _stringList1 = value.Split('^').ToList();
            }
        }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string FreeText_03 { get; set; }
    }
}
