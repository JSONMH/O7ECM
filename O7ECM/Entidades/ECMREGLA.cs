namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMREGLAS")]
    public partial class ECMREGLA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string REGCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string REGCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte REGCODACT { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte REGCODTRA { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte REGCODBAN { get; set; }

        public byte? TIEMPO_DD { get; set; }

        public byte? TIEMPO_HH { get; set; }

        public byte? TIEMPO_MM { get; set; }

        public virtual ECMACTIVID ECMACTIVID { get; set; }

        public virtual ECMBANDEJA ECMBANDEJA { get; set; }

        public virtual ECMTRAMITE ECMTRAMITE { get; set; }
    }
}
