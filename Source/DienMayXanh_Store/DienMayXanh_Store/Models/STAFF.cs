namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STAFF")]
    public partial class STAFF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STAFF()
        {
            IESLIPs = new HashSet<IESLIP>();
            RECIEPTs = new HashSet<RECIEPT>();
        }

        [StringLength(1)]
        public string StaffID { get; set; }

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

        [Required]
        [StringLength(1)]
        public string Position { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIP> IESLIPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIEPT> RECIEPTs { get; set; }

        public virtual STAFF STAFF1 { get; set; }

        public virtual STAFF STAFF2 { get; set; }
    }
}
