namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMMAEREPO")]
    public partial class ECMMAEREPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECMMAEREPO()
        {
            ECMACCESOS = new HashSet<ECMACCESO>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string REPCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string REPCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REPCODREP { get; set; }

        [StringLength(100)]
        public string REPNOMREP { get; set; }

        [StringLength(20)]
        public string REPNOMETI { get; set; }

        [StringLength(150)]
        public string REPDIRREP { get; set; }

        [StringLength(20)]
        public string REPTELREP { get; set; }

        [StringLength(20)]
        public string REPANEREP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECMACCESO> ECMACCESOS { get; set; }
    }
}
