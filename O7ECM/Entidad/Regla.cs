namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMREGLAS")]
    public partial class Regla
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
        public byte CodigoActividad { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte CodigoTramite { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte CodigoBandeja { get; set; }

        public byte? Tiempo_Dia { get; set; }

        public byte? Tiempo_Hora { get; set; }

        public byte? Tiempo_Minuto { get; set; }

        public virtual Actividades Actividades { get; set; }

        public virtual Bandeja Bandeja { get; set; }

        public virtual Tramite Tramite { get; set; }
    }
}
