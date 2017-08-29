namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMTRAMITE")]
    public partial class Tramite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tramite()
        {
            Regla = new HashSet<Regla>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CodigoCompania { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CodigoSucursal { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte CodigoTramite { get; set; }

        [StringLength(100)]
        public string DescripcionTramite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Regla> Regla { get; set; }
    }
}
