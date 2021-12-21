namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            RECIEPTs = new HashSet<RECIEPT>();
        }

        [StringLength(1)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(1)]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Address { get; set; }

        [Required]
        [StringLength(1)]
        public string Phone { get; set; }

        public bool Gender { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIEPT> RECIEPTs { get; set; }
    }
}
