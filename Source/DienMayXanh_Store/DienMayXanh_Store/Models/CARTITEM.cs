namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARTITEM")]
    public partial class CARTITEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string RecieptID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ProductID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Quantity { get; set; }

        public decimal SubTotal { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }

        public virtual RECIEPT RECIEPT { get; set; }
    }
}
