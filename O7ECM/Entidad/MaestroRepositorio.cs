namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMMAEREPO")]
    public partial class MaestroRepositorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MaestroRepositorio()
        {
            Acceso = new HashSet<Acceso>();
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoRepositorio { get; set; }

        [StringLength(100)]
        public string NombreRepositorio { get; set; }

        [StringLength(20)]
        public string NombreEtiqueta { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string NumeroTelofono { get; set; }

        [StringLength(20)]
        public string NumeroAnexo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acceso> Acceso { get; set; }
    }
}
