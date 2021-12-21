namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WAREHOUSE")]
    public partial class WAREHOUSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WAREHOUSE()
        {
            IESLIPs = new HashSet<IESLIP>();
            PRODUCTAVAILABLEs = new HashSet<PRODUCTAVAILABLE>();
        }

        [StringLength(1)]
        public string WarehouseID { get; set; }

        [Required]
        [StringLength(1)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIP> IESLIPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTAVAILABLE> PRODUCTAVAILABLEs { get; set; }
    }
}
