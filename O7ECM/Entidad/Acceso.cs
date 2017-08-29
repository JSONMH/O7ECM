namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMACCESOS")]
    public partial class Acceso
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
        [StringLength(10)]
        public string CodigoUsuario { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigorepositorio { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte Codigobandeja { get; set; }

        [StringLength(1)]
        public string NivelAcceso { get; set; }

        public virtual Bandeja Bandeja { get; set; }

        public virtual MaestroRepositorio MestroRepositorio { get; set; }
    }
}
