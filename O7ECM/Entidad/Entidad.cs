namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMENTIDAD")]
    public partial class Entidad
    {
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
        public int CodigoEntidad { get; set; }

        [StringLength(150)]
        public string NombreEntidad { get; set; }

        [StringLength(1)]
        public string TipoEntidad { get; set; }

        [StringLength(100)]
        public string CorreoEntidad { get; set; }
    }
}
