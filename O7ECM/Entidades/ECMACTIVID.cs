namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMACTIVID")]
    public partial class ECMACTIVID
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECMACTIVID()
        {
            ECMREGLAS = new HashSet<ECMREGLA>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ACTCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ACTCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ACTCODACT { get; set; }

        [StringLength(200)]
        public string ACTDESACT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECMREGLA> ECMREGLAS { get; set; }
    }
}
