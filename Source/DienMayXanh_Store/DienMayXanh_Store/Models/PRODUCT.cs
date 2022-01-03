namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Drawing;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            CARTITEMS = new HashSet<CARTITEM>();
            IESLIPDETAILS = new HashSet<IESLIPDETAIL>();
            PRODUCTAVAILABLES = new HashSet<PRODUCTAVAILABLE>();
        }

        [StringLength(30)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(30)]
        public string BrandID { get; set; }

        [Required]
        [StringLength(30)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public decimal Price { get; set; }


        public Image Img
        {
            get
            {
                return Image.FromFile(string.Format(@"..\..\Images\Products\" + ProductID + ".jpg"));
            }
        }

        public virtual BRAND BRAND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARTITEM> CARTITEMS { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIPDETAIL> IESLIPDETAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTAVAILABLE> PRODUCTAVAILABLES { get; set; }
    }
}
