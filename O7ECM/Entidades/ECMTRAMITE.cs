namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMTRAMITE")]
    public partial class ECMTRAMITE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECMTRAMITE()
        {
            ECMREGLAS = new HashSet<ECMREGLA>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string TRACODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string TRACODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte TRATIPTRA { get; set; }

        [StringLength(100)]
        public string TRADESTRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECMREGLA> ECMREGLAS { get; set; }
    }
}
