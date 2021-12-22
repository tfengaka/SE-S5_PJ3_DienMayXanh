namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IESLIPDETAIL")]
    public partial class IESLIPDETAIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string IESlipID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ProductID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Quantity { get; set; }

        public virtual IESLIP IESLIP { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }
    }
}
