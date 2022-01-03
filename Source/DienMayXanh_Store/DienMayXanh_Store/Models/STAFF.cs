namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;
    using System.IO;

    [Table("STAFF")]
    public partial class STAFF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STAFF()
        {
            IESLIPs = new HashSet<IESLIP>();
            RECIEPTs = new HashSet<RECIEPT>();
        }

        [StringLength(30)]
        public string StaffID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone { get; set; }

        public bool Gender { get; set; }

        [Required]
        [StringLength(30)]
        public string Position { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIP> IESLIPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECIEPT> RECIEPTs { get; set; }


        public Image Avatar
        {
            get
            {
                string path = string.Format(@"..\..\Images\" + StaffID + ".png");
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                    {
                        return Image.FromFile(path);
                    }
                }
                return null;
            }
        }

    }
}
