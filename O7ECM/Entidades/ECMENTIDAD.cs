namespace O7ECM.Code
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ECM01.ECMENTIDAD")]
    public partial class ECMENTIDAD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ENTCODCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ENTCODSUC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ENTCODENT { get; set; }

        [StringLength(150)]
        public string ENTNOMENT { get; set; }

        [StringLength(1)]
        public string ENTTIPENT { get; set; }

        [StringLength(100)]
        public string ENTMAILENT { get; set; }
    }
}
