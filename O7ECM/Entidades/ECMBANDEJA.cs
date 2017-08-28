namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMBANDEJA")]
    public partial class ECMBANDEJA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ECMBANDEJA()
        {
            ECMACCESOS = new HashSet<ECMACCESO>();
            ECMREGLAS = new HashSet<ECMREGLA>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string BANCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string BANCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte BANCODBAN { get; set; }

        [StringLength(100)]
        public string BANNOMBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECMACCESO> ECMACCESOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ECMREGLA> ECMREGLAS { get; set; }
    }
}
