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
    // Refill Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("SCRIPT", "REFREQ")]
    public class TSREFREQ : EdiMessage
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
        // Provider Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual PVD PVD { get; set; }
        /// <summary>
        // Provider Segment
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<PVD> PVD2 { get; set; }
        /// <summary>
        // Patient Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual PTT PTT { get; set; }
        /// <summary>
        // Coordination of Benefits Segment
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<COO> COO { get; set; }
        /// <summary>
        // Drug Segment
        /// </summary>
        [DataMember]
        [Splitter]
        [Required]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<Loop_DRU_TSREFREQ> DRULoop { get; set; }
        /// <summary>
        // Observation Segment
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual OBS OBS { get; set; }
        /// <summary>
        // Interactive message trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual UIT UIT { get; set; }
    }

    /// <summary>
    // Drug Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DRU))]
    public class Loop_DRU_TSREFREQ
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
