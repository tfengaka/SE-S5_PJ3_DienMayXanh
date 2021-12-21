namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RECIEPT")]
    public partial class RECIEPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RECIEPT()
        {
            CARTITEMs = new HashSet<CARTITEM>();
        }

        [StringLength(1)]
        public string RecieptID { get; set; }

        [Required]
        [StringLength(1)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(1)]
        public string StaffID { get; set; }

        [Required]
        [StringLength(1)]
        public string PaymentMethod { get; set; }

        public DateTime CreateAt { get; set; }

        public decimal Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARTITEM> CARTITEMs { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual STAFF STAFF { get; set; }
    }
}
