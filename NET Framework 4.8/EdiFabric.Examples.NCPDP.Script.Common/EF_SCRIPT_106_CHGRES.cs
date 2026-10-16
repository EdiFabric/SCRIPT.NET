namespace EdiFabric.Templates.Script106
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Ncpdp;


    /// <summary>
    // Prescription Change Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("SCRIPT", "CHGRES")]
    public class TSCHGRES : EdiMessage
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Interactive message header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UIH UIH { get; set; }
        /// <summary>
        // Request Segment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        // Response Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual RES RES { get; set; }
        /// <summary>
        // Provider Segment
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(4)]
        public virtual List<PVD> PVD { get; set; }
        /// <summary>
        // Patient Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual PTT PTT { get; set; }
        /// <summary>
        // Drug Segment
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual Loop_DRU_TSCHGRES DRULoop { get; set; }
        /// <summary>
        // Observation Segment
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual OBS OBS { get; set; }
        /// <summary>
        // Interactive message trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual UIT UIT { get; set; }
    }

    /// <summary>
    // Drug Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DRU))]
    public class Loop_DRU_TSCHGRES
    {
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>
        // Drug Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DRU DRU { get; set; }
        /// <summary>
        // Structured Sig Segment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<SIG> SIG { get; set; }
    }
}
