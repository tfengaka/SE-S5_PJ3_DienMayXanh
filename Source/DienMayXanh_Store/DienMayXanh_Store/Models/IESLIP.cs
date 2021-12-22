namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IESLIP")]
    public partial class IESLIP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IESLIP()
        {
            IESLIPDETAILs = new HashSet<IESLIPDETAIL>();
        }

        [StringLength(30)]
        public string IESlipID { get; set; }

        public DateTime CreateAt { get; set; }

        public decimal TotalPrice { get; set; }

        [Required]
        [StringLength(30)]
        public string StaffID { get; set; }

        [Required]
        [StringLength(30)]
        public string WarehouseID { get; set; }

        public virtual STAFF STAFF { get; set; }

        public virtual WAREHOUSE WAREHOUSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIPDETAIL> IESLIPDETAILs { get; set; }
    }
}
