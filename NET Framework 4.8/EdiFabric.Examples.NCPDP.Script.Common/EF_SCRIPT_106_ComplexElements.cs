namespace EdiFabric.Templates.Script106
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi.Edifact;


    /// <summary>
    // Time Zone
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("E034")]
    public class E034
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Time Zone Identifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2029", typeof(NCPDP_ID_2029))]
        [Pos(1)]
        public virtual string TimeZoneIdentifier_01 { get; set; }
        /// <summary>
        // Time Zone Difference Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("2116", typeof(EDIFACT_N))]
        [Pos(2)]
        public virtual string TimeZoneDifferenceQuantity_02 { get; set; }
    }

    /// <summary>
    // Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I001")]
    public class I001
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ReferenceNumber_01 { get; set; }
        /// <summary>
        // Reference Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(NCPDP_ID_1153))]
        [Pos(2)]
        public virtual string ReferenceQualifier_02 { get; set; }
    }

    /// <summary>
    // Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I002")]
    public class I002
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Party Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string PartyName_01 { get; set; }
        /// <summary>
        // First Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3702", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FirstName_02 { get; set; }
        /// <summary>
        // Middle Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3704", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string MiddleName_03 { get; set; }
        /// <summary>
        // Name Suffix
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("3706", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string NameSuffix_04 { get; set; }
        /// <summary>
        // Name Prefix
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("3708", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string NamePrefix_05 { get; set; }
    }

    /// <summary>
    // Address
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I004")]
    public class I004
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Street and Number/P.O. Box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string StreetandNumberPOBox_01 { get; set; }
        /// <summary>
        // City Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CityName_02 { get; set; }
        /// <summary>
        // Country Sub-entity Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(NCPDP_ID_3229))]
        [Pos(3)]
        public virtual string CountrySubentityIdentification_03 { get; set; }
        /// <summary>
        // Postcode Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string PostcodeIdentification_04 { get; set; }
        /// <summary>
        // Place/Location Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3227", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PlaceLocationQualifier_05 { get; set; }
        /// <summary>
        // Place/Location
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string PlaceLocation_06 { get; set; }
    }

    /// <summary>
    // Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I006")]
    public class I006
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Date/Time/Period Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2005", typeof(NCPDP_ID_2005))]
        [Pos(1)]
        public virtual string DateTimePeriodQualifier_01 { get; set; }
        /// <summary>
        // Date/Time Period
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DateTimePeriod_02 { get; set; }
        /// <summary>
        // Date/Time/Period Format qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2379", typeof(NCPDP_ID_2379))]
        [Pos(3)]
        public virtual string DateTimePeriodFormatqualifier_03 { get; set; }
    }

    /// <summary>
    // Provider Specialty
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I007")]
    public class I007
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Agency Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("4709", typeof(NCPDP_ID_4709))]
        [Pos(1)]
        public virtual string AgencyQualifier_01 { get; set; }
        /// <summary>
        // Provider Specialty
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("4707", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ProviderSpecialty_02 { get; set; }
        /// <summary>
        // Provider Specialty code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("7990", typeof(NCPDP_ID_7990))]
        [Pos(3)]
        public virtual string ProviderSpecialtycode_03 { get; set; }
    }

    /// <summary>
    // Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I009")]
    public class I009
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Quantity Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6063", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string QuantityQualifier_01 { get; set; }
        /// <summary>
        // Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("6060", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Quantity_02 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CodeListQualifier_03 { get; set; }
        /// <summary>
        // Source Code List
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7991", typeof(NCPDP_ID_7991))]
        [Pos(4)]
        public virtual string SourceCodeList_04 { get; set; }
        /// <summary>
        // Potency Unit Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7994", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string PotencyUnitCode_05 { get; set; }
    }

    /// <summary>
    // Service Type Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I011")]
    public class I011
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(1)]
        public virtual string ServiceType_01 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(2)]
        public virtual string ServiceType_02 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(3)]
        public virtual string ServiceType_03 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(4)]
        public virtual string ServiceType_04 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(5)]
        public virtual string ServiceType_05 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(6)]
        public virtual string ServiceType_06 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(7)]
        public virtual string ServiceType_07 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(8)]
        public virtual string ServiceType_08 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(9)]
        public virtual string ServiceType_09 { get; set; }
        /// <summary>
        // Service Type
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7701", typeof(NCPDP_ID_7701))]
        [Pos(10)]
        public virtual string ServiceType_10 { get; set; }
    }

    /// <summary>
    // Health Care Service Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I012")]
    public class I012
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Facility Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7707", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FacilityCodeQualifier_01 { get; set; }
        /// <summary>
        // Facility Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7704", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FacilityCodeValue_02 { get; set; }
        /// <summary>
        // Claim Frequency Type
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7709", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ClaimFrequencyType_03 { get; set; }
    }

    /// <summary>
    // Drug
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I013")]
    public class I013
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("7009", typeof(NCPDP_ID_7009))]
        [Pos(1)]
        public virtual string ItemDescriptionIdentification_01 { get; set; }
        /// <summary>
        // Item Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ItemDescription_02 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(3)]
        public virtual string ItemNumber_03 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(4)]
        public virtual string CodeListResponsibleAgency_04 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CodeListQualifier_05 { get; set; }
        /// <summary>
        // Free Text
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string FreeText_06 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string CodeListQualifier_07 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string ReferenceNumber_08 { get; set; }
        /// <summary>
        // Reference Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(NCPDP_ID_1153))]
        [Pos(9)]
        public virtual string ReferenceQualifier_09 { get; set; }
        /// <summary>
        // Item Description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string ItemDescription_10 { get; set; }
        /// <summary>
        // Item Description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string ItemDescription_11 { get; set; }
        /// <summary>
        // Item Description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string ItemDescription_12 { get; set; }
        /// <summary>
        // Source Code List
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7991", typeof(NCPDP_ID_7991))]
        [Pos(13)]
        public virtual string SourceCodeList_13 { get; set; }
        /// <summary>
        // Item Form Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7992", typeof(EDIFACT_AN))]
        [Pos(14)]
        public virtual string ItemFormCode_14 { get; set; }
        /// <summary>
        // Source Code List
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7991", typeof(NCPDP_ID_7991))]
        [Pos(15)]
        public virtual string SourceCodeList_15 { get; set; }
        /// <summary>
        // Item Strength Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7993", typeof(EDIFACT_AN))]
        [Pos(16)]
        public virtual string ItemStrengthCode_16 { get; set; }
        /// <summary>
        // DEA Schedule
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7996", typeof(EDIFACT_AN))]
        [Pos(17)]
        public virtual string DEASchedule_17 { get; set; }
    }

    /// <summary>
    // Directions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I014")]
    public class I014
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Dosage Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("7879", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DosageIdentification_01 { get; set; }
        /// <summary>
        // Dosage
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7878", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Dosage_02 { get; set; }
        /// <summary>
        // Dosage
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("7878", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Dosage_03 { get; set; }
    }

    /// <summary>
    // Diagnosis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I015")]
    public class I015
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Clinical Information Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6810", typeof(NCPDP_ID_6810))]
        [Pos(1)]
        public virtual string ClinicalInformationQualifier_01 { get; set; }
        /// <summary>
        // Clinical Information
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 17)]
        [DataElement("6813", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string ClinicalInformation_02 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string CodeListQualifier_03 { get; set; }
        /// <summary>
        // Clinical Information
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("6813", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string ClinicalInformation_04 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string CodeListQualifier_05 { get; set; }
    }

    /// <summary>
    // Communication Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("I016")]
    public class I016
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Communication Number
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string CommunicationNumber_01 { get; set; }
        /// <summary>
        // Code List Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("1131", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string CodeListQualifier_02 { get; set; }
    }

    /// <summary>
    // Observation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S017")]
    public class S017
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Measurement Dimension
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("6311", typeof(NCPDP_ID_6311))]
        [Pos(1)]
        public virtual string MeasurementDimension_01 { get; set; }
        /// <summary>
        // Measurement Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MeasurementValue_02 { get; set; }
        /// <summary>
        // Measurement Unit qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string MeasurementUnitqualifier_03 { get; set; }
        /// <summary>
        // Date/Time Period
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DateTimePeriod_04 { get; set; }
        /// <summary>
        // Date/Time/Period Format qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2379", typeof(NCPDP_ID_2379))]
        [Pos(5)]
        public virtual string DateTimePeriodFormatqualifier_05 { get; set; }
        /// <summary>
        // Measurement Data Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7887", typeof(NCPDP_ID_7887))]
        [Pos(6)]
        public virtual string MeasurementDataQualifier_06 { get; set; }
        /// <summary>
        // Source Code List
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("7991", typeof(NCPDP_ID_7991))]
        [Pos(7)]
        public virtual string SourceCodeList_07 { get; set; }
        /// <summary>
        // Measurement Unit Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7995", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string MeasurementUnitCode_08 { get; set; }
    }

    /// <summary>
    // Drug Use Evaluation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S018")]
    public class S018
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // DUE Reason For Service Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("7880", typeof(NCPDP_ID_7880))]
        [Pos(1)]
        public virtual string DUEReasonForServiceCode_01 { get; set; }
        /// <summary>
        // DUE Professional Service Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("7881", typeof(NCPDP_ID_7881))]
        [Pos(2)]
        public virtual string DUEProfessionalServiceCode_02 { get; set; }
        /// <summary>
        // DUE Result Of Service Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("7882", typeof(NCPDP_ID_7882))]
        [Pos(3)]
        public virtual string DUEResultOfServiceCode_03 { get; set; }
        /// <summary>
        // DUE Co-Agent ID
        /// </summary>
        [DataMember]
        [StringLength(1, 19)]
        [DataElement("7883", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DUECoAgentID_04 { get; set; }
        /// <summary>
        // DUE Co-Agent ID Qualifier
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("7884", typeof(NCPDP_ID_7884))]
        [Pos(5)]
        public virtual string DUECoAgentIDQualifier_05 { get; set; }
        /// <summary>
        // DUE Clinical Significance Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7997", typeof(NCPDP_ID_7997))]
        [Pos(6)]
        public virtual string DUEClinicalSignificanceCode_06 { get; set; }
        /// <summary>
        // DUE Acknowledgement Reason
        /// </summary>
        [DataMember]
        [StringLength(1, 100)]
        [DataElement("7998", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string DUEAcknowledgementReason_07 { get; set; }
    }

    /// <summary>
    // Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S020")]
    public class S020
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Facility Unit
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7888", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string FacilityUnit_01 { get; set; }
        /// <summary>
        // Room
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("7889", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string Room_02 { get; set; }
        /// <summary>
        // Bed
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("7890", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string Bed_03 { get; set; }
    }

    /// <summary>
    // Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S021")]
    public class S021
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Source Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("7895", typeof(NCPDP_ID_7895))]
        [Pos(1)]
        public virtual string SourceQualifier_01 { get; set; }
        /// <summary>
        // Source Description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7896", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SourceDescription_02 { get; set; }
        /// <summary>
        // Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string ReferenceNumber_03 { get; set; }
        /// <summary>
        // Reference Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("1153", typeof(NCPDP_ID_1153))]
        [Pos(4)]
        public virtual string ReferenceQualifier_04 { get; set; }
    }

    /// <summary>
    // Repeating Sig
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S022")]
    public class S022
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Sig Sequence Position Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("7898", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string SigSequencePositionNumber_01 { get; set; }
        /// <summary>
        // Multiple SIG Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7899", typeof(NCPDP_ID_7899))]
        [Pos(2)]
        public virtual string MultipleSIGModifier_02 { get; set; }
    }

    /// <summary>
    // Code System Composite
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S023")]
    public class S023
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // SNOMED Version
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("7900", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SNOMEDVersion_01 { get; set; }
        /// <summary>
        // FMT Version
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("7901", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string FMTVersion_02 { get; set; }
    }

    /// <summary>
    // Free Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S024")]
    public class S024
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Sig Free Text String Indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("7902", typeof(NCPDP_ID_7902))]
        [Pos(1)]
        public virtual string SigFreeTextStringIndicator_01 { get; set; }
        /// <summary>
        // Sig Free Text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 140)]
        [DataElement("7989", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string SigFreeText_02 { get; set; }
    }

    /// <summary>
    // Dose
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S025")]
    public class S025
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Dose Composite Indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("7903", typeof(NCPDP_ID_7903))]
        [Pos(1)]
        public virtual string DoseCompositeIndicator_01 { get; set; }
        /// <summary>
        // Dose Delivery Method Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7904", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DoseDeliveryMethodText_02 { get; set; }
        /// <summary>
        // Dose Delivery Method Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7905", typeof(NCPDP_ID_7905))]
        [Pos(3)]
        public virtual string DoseDeliveryMethodCodeQualifier_03 { get; set; }
        /// <summary>
        // Dose Delivery Method Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7906", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DoseDeliveryMethodCode_04 { get; set; }
        /// <summary>
        // Dose Delivery Method Modifier Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7907", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string DoseDeliveryMethodModifierText_05 { get; set; }
        /// <summary>
        // Dose Delivery Method Modifier Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7908", typeof(NCPDP_ID_7908))]
        [Pos(6)]
        public virtual string DoseDeliveryMethodModifierCodeQualifier_06 { get; set; }
        /// <summary>
        // Dose Delivery Method Modifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7909", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string DoseDeliveryMethodModifierCode_07 { get; set; }
        /// <summary>
        // Dose Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7910", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string DoseQuantity_08 { get; set; }
        /// <summary>
        // Dose Form Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7911", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string DoseFormText_09 { get; set; }
        /// <summary>
        // Dose Form Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7912", typeof(NCPDP_ID_7912))]
        [Pos(10)]
        public virtual string DoseFormCodeQualifier_10 { get; set; }
        /// <summary>
        // Dose Form Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7913", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string DoseFormCode_11 { get; set; }
        /// <summary>
        // Dose Range Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7914", typeof(NCPDP_ID_7914))]
        [Pos(12)]
        public virtual string DoseRangeModifier_12 { get; set; }
    }

    /// <summary>
    // Dose Calculation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S026")]
    public class S026
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Dosing Basis Numeric Value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7915", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string DosingBasisNumericValue_01 { get; set; }
        /// <summary>
        // Dosing Basis Unit of Measure Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7916", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DosingBasisUnitofMeasureText_02 { get; set; }
        /// <summary>
        // Dosing Basis Unit of Measure Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7917", typeof(NCPDP_ID_7917))]
        [Pos(3)]
        public virtual string DosingBasisUnitofMeasureCodeQualifier_03 { get; set; }
        /// <summary>
        // Dosing Basis Unit of Measure Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7918", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DosingBasisUnitofMeasureCode_04 { get; set; }
        /// <summary>
        // Body Metric Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("7919", typeof(NCPDP_ID_7919))]
        [Pos(5)]
        public virtual string BodyMetricQualifier_05 { get; set; }
        /// <summary>
        // Body Metric Value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7920", typeof(EDIFACT_N))]
        [Pos(6)]
        public virtual string BodyMetricValue_06 { get; set; }
        /// <summary>
        // Calculated Dose Numeric
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7921", typeof(EDIFACT_N))]
        [Pos(7)]
        public virtual string CalculatedDoseNumeric_07 { get; set; }
        /// <summary>
        // Calculated Dose Unit of Measure Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7922", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string CalculatedDoseUnitofMeasureText_08 { get; set; }
        /// <summary>
        // Calculated Dose Unit of Measure Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7923", typeof(NCPDP_ID_7923))]
        [Pos(9)]
        public virtual string CalculatedDoseUnitofMeasureCodeQualifier_09 { get; set; }
        /// <summary>
        // Calculated Dose Unit of Measure Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7924", typeof(EDIFACT_AN))]
        [Pos(10)]
        public virtual string CalculatedDoseUnitofMeasureCode_10 { get; set; }
        /// <summary>
        // Dosing Basis Range Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7925", typeof(NCPDP_ID_7925))]
        [Pos(11)]
        public virtual string DosingBasisRangeModifier_11 { get; set; }
    }

    /// <summary>
    // Vehicle
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S027")]
    public class S027
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Vehicle Name
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7926", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string VehicleName_01 { get; set; }
        /// <summary>
        // Vehicle Name Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7927", typeof(NCPDP_ID_7927))]
        [Pos(2)]
        public virtual string VehicleNameCodeQualifier_02 { get; set; }
        /// <summary>
        // Vehicle Name Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7928", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string VehicleNameCode_03 { get; set; }
        /// <summary>
        // Vehicle Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7929", typeof(EDIFACT_N))]
        [Pos(4)]
        public virtual string VehicleQuantity_04 { get; set; }
        /// <summary>
        // Vehicle Unit Of Measure Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7930", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string VehicleUnitOfMeasureText_05 { get; set; }
        /// <summary>
        // Vehicle Unit Of Measure Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7931", typeof(NCPDP_ID_7931))]
        [Pos(6)]
        public virtual string VehicleUnitOfMeasureCodeQualifier_06 { get; set; }
        /// <summary>
        // Vehicle Unit Of Measure Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7932", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string VehicleUnitOfMeasureCode_07 { get; set; }
        /// <summary>
        // Multiple Vehicle Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7933", typeof(NCPDP_ID_7933))]
        [Pos(8)]
        public virtual string MultipleVehicleModifier_08 { get; set; }
    }

    /// <summary>
    // Route of Administration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S028")]
    public class S028
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Route of Administration Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7934", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string RouteofAdministrationText_01 { get; set; }
        /// <summary>
        // Route of Administration Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7935", typeof(NCPDP_ID_7935))]
        [Pos(2)]
        public virtual string RouteofAdministrationCodeQualifier_02 { get; set; }
        /// <summary>
        // Route of Administration Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7936", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string RouteofAdministrationCode_03 { get; set; }
        /// <summary>
        // Multiple Route of Administration Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7937", typeof(NCPDP_ID_7937))]
        [Pos(4)]
        public virtual string MultipleRouteofAdministrationModifier_04 { get; set; }
    }

    /// <summary>
    // Site of Administration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S029")]
    public class S029
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Site of Administration Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7938", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string SiteofAdministrationText_01 { get; set; }
        /// <summary>
        // Site of Administration Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7939", typeof(NCPDP_ID_7939))]
        [Pos(2)]
        public virtual string SiteofAdministrationCodeQualifier_02 { get; set; }
        /// <summary>
        // Site of Administration Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7940", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string SiteofAdministrationCode_03 { get; set; }
        /// <summary>
        // Multiple Site of Administration Timing Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7941", typeof(NCPDP_ID_7941))]
        [Pos(4)]
        public virtual string MultipleSiteofAdministrationTimingModifier_04 { get; set; }
    }

    /// <summary>
    // Timing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S030")]
    public class S030
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Administration Timing Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7942", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string AdministrationTimingText_01 { get; set; }
        /// <summary>
        // Administration Timing Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7943", typeof(NCPDP_ID_7943))]
        [Pos(2)]
        public virtual string AdministrationTimingCodeQualifier_02 { get; set; }
        /// <summary>
        // Administration Timing Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7944", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string AdministrationTimingCode_03 { get; set; }
        /// <summary>
        // Multiple Administration Timing Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7945", typeof(NCPDP_ID_7945))]
        [Pos(4)]
        public virtual string MultipleAdministrationTimingModifier_04 { get; set; }
        /// <summary>
        // Rate of Administration
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("7946", typeof(EDIFACT_AN))]
        [Pos(5)]
        public virtual string RateofAdministration_05 { get; set; }
        /// <summary>
        // Rate Unit of Measure Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7947", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string RateUnitofMeasureText_06 { get; set; }
        /// <summary>
        // Rate Unit of Measure Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7948", typeof(NCPDP_ID_7948))]
        [Pos(7)]
        public virtual string RateUnitofMeasureCodeQualifier_07 { get; set; }
        /// <summary>
        // Rate Unit of Measure Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7949", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string RateUnitofMeasureCode_08 { get; set; }
        /// <summary>
        // Time Period Basis Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7950", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string TimePeriodBasisText_09 { get; set; }
        /// <summary>
        // Time Period Basis Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7951", typeof(NCPDP_ID_7951))]
        [Pos(10)]
        public virtual string TimePeriodBasisCodeQualifier_10 { get; set; }
        /// <summary>
        // Time Period Basis Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7952", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string TimePeriodBasisCode_11 { get; set; }
        /// <summary>
        // Frequency Numeric Value
        /// </summary>
        [DataMember]
        [StringLength(1, 11)]
        [DataElement("7953", typeof(EDIFACT_AN))]
        [Pos(12)]
        public virtual string FrequencyNumericValue_12 { get; set; }
        /// <summary>
        // Frequency Units Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7954", typeof(EDIFACT_AN))]
        [Pos(13)]
        public virtual string FrequencyUnitsText_13 { get; set; }
        /// <summary>
        // Frequency Units Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7955", typeof(NCPDP_ID_7955))]
        [Pos(14)]
        public virtual string FrequencyUnitsCodeQualifier_14 { get; set; }
        /// <summary>
        // Frequency Units Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7956", typeof(EDIFACT_AN))]
        [Pos(15)]
        public virtual string FrequencyUnitsCode_15 { get; set; }
        /// <summary>
        // Variable Frequency Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7957", typeof(NCPDP_ID_7957))]
        [Pos(16)]
        public virtual string VariableFrequencyModifier_16 { get; set; }
        /// <summary>
        // Interval Numeric Value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7958", typeof(EDIFACT_N))]
        [Pos(17)]
        public virtual string IntervalNumericValue_17 { get; set; }
        /// <summary>
        // Interval Units Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7959", typeof(EDIFACT_AN))]
        [Pos(18)]
        public virtual string IntervalUnitsText_18 { get; set; }
        /// <summary>
        // Interval Units Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7960", typeof(NCPDP_ID_7960))]
        [Pos(19)]
        public virtual string IntervalUnitsCodeQualifier_19 { get; set; }
        /// <summary>
        // Interval Units Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7961", typeof(EDIFACT_AN))]
        [Pos(20)]
        public virtual string IntervalUnitsCode_20 { get; set; }
        /// <summary>
        // Variable Interval Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7962", typeof(NCPDP_ID_7962))]
        [Pos(21)]
        public virtual string VariableIntervalModifier_21 { get; set; }
    }

    /// <summary>
    // Duration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S031")]
    public class S031
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Duration Numeric Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 11)]
        [DataElement("7963", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string DurationNumericValue_01 { get; set; }
        /// <summary>
        // Duration Text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 50)]
        [DataElement("7964", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DurationText_02 { get; set; }
        /// <summary>
        // Duration Text Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("7965", typeof(NCPDP_ID_7965))]
        [Pos(3)]
        public virtual string DurationTextCodeQualifier_03 { get; set; }
        /// <summary>
        // Duration Text Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("7966", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string DurationTextCode_04 { get; set; }
    }

    /// <summary>
    // Maximum Dose Restriction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S033")]
    public class S033
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Maximum Dose Restriction Numeric Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("7967", typeof(EDIFACT_N))]
        [Pos(1)]
        public virtual string MaximumDoseRestrictionNumericValue_01 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Units Text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 50)]
        [DataElement("7968", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string MaximumDoseRestrictionUnitsText_02 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("7969", typeof(NCPDP_ID_7969))]
        [Pos(3)]
        public virtual string MaximumDoseRestrictionCodeQualifier_03 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Units Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("7970", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string MaximumDoseRestrictionUnitsCode_04 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Variable Numeric Value
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7971", typeof(EDIFACT_N))]
        [Pos(5)]
        public virtual string MaximumDoseRestrictionVariableNumericValue_05 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Variable Units Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7972", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string MaximumDoseRestrictionVariableUnitsText_06 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Variable Units Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7973", typeof(NCPDP_ID_7973))]
        [Pos(7)]
        public virtual string MaximumDoseRestrictionVariableUnitsCodeQualifier_07 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Variable Units Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7974", typeof(EDIFACT_AN))]
        [Pos(8)]
        public virtual string MaximumDoseRestrictionVariableUnitsCode_08 { get; set; }
        /// <summary>
        // Maximum Dose Restriction Variable Duration Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7975", typeof(NCPDP_ID_7975))]
        [Pos(9)]
        public virtual string MaximumDoseRestrictionVariableDurationModifier_09 { get; set; }
    }

    /// <summary>
    // Indication
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S034")]
    public class S034
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Indication Precursor Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7976", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string IndicationPrecursorText_01 { get; set; }
        /// <summary>
        // Indication Precursor Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7977", typeof(NCPDP_ID_7977))]
        [Pos(2)]
        public virtual string IndicationPrecursorCodeQualifier_02 { get; set; }
        /// <summary>
        // Indication Precursor Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("7978", typeof(EDIFACT_AN))]
        [Pos(3)]
        public virtual string IndicationPrecursorCode_03 { get; set; }
        /// <summary>
        // Indication Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7979", typeof(EDIFACT_AN))]
        [Pos(4)]
        public virtual string IndicationText_04 { get; set; }
        /// <summary>
        // Indication Text Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7980", typeof(NCPDP_ID_7980))]
        [Pos(5)]
        public virtual string IndicationTextCodeQualifier_05 { get; set; }
        /// <summary>
        // Indication Text Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7981", typeof(EDIFACT_AN))]
        [Pos(6)]
        public virtual string IndicationTextCode_06 { get; set; }
        /// <summary>
        // Indication Value Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7982", typeof(EDIFACT_AN))]
        [Pos(7)]
        public virtual string IndicationValueText_07 { get; set; }
        /// <summary>
        // Indication Value Unit
        /// </summary>
        [DataMember]
        [StringLength(1, 18)]
        [DataElement("7983", typeof(EDIFACT_N))]
        [Pos(8)]
        public virtual string IndicationValueUnit_08 { get; set; }
        /// <summary>
        // Indication Value Unit of Measure Text
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7984", typeof(EDIFACT_AN))]
        [Pos(9)]
        public virtual string IndicationValueUnitofMeasureText_09 { get; set; }
        /// <summary>
        // Indication Value Unit of Measure Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("7985", typeof(NCPDP_ID_7985))]
        [Pos(10)]
        public virtual string IndicationValueUnitofMeasureCodeQualifier_10 { get; set; }
        /// <summary>
        // Indication Value Unit of Measure Code
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("7986", typeof(EDIFACT_AN))]
        [Pos(11)]
        public virtual string IndicationValueUnitofMeasureCode_11 { get; set; }
        /// <summary>
        // Indication Variable Modifier
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("7987", typeof(NCPDP_ID_7987))]
        [Pos(12)]
        public virtual string IndicationVariableModifier_12 { get; set; }
    }

    /// <summary>
    // Stop
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S035")]
    public class S035
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Stop Indicator
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1)]
        [DataElement("7988", typeof(NCPDP_ID_7988))]
        [Pos(1)]
        public virtual string StopIndicator_01 { get; set; }
    }

    /// <summary>
    // Adverse Event Date
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S036")]
    public class S036
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Date/Time/Period Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("2005", typeof(NCPDP_ID_2005))]
        [Pos(1)]
        public virtual string DateTimePeriodQualifier_01 { get; set; }
        /// <summary>
        // Date/Time Period
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public virtual string DateTimePeriod_02 { get; set; }
        /// <summary>
        // Date/Time/Period Format qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("2379", typeof(NCPDP_ID_2379))]
        [Pos(3)]
        public virtual string DateTimePeriodFormatqualifier_03 { get; set; }
    }

    /// <summary>
    // Adverse Event Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S037")]
    public class S037
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    /// <summary>
    // Drug - Product Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S038")]
    public class S038
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    /// <summary>
    // Reaction Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S039")]
    public class S039
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    /// <summary>
    // Severity Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S040")]
    public class S040
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    /// <summary>
    // Problem Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S041")]
    public class S041
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }

    /// <summary>
    // Problem Name Coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("S042")]
    public class S042
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Item Description Long
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 255)]
        [DataElement("8001", typeof(EDIFACT_AN))]
        [Pos(1)]
        public virtual string ItemDescriptionLong_01 { get; set; }
        /// <summary>
        // Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(NCPDP_ID_7140))]
        [Pos(2)]
        public virtual string ItemNumber_02 { get; set; }
        /// <summary>
        // Code List Responsible Agency
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("3055", typeof(NCPDP_ID_3055))]
        [Pos(3)]
        public virtual string CodeListResponsibleAgency_03 { get; set; }
    }
}
