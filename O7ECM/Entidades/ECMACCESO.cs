namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMACCESOS")]
    public partial class ECMACCESO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ACCCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ACCCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ACCCODUSR { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACCCODREP { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte ACCCODBAN { get; set; }

        [StringLength(1)]
        public string ACCNIVACC { get; set; }

        public virtual ECMBANDEJA ECMBANDEJA { get; set; }

        public virtual ECMMAEREPO ECMMAEREPO { get; set; }
    }
}
