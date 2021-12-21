namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            CARTITEMs = new HashSet<CARTITEM>();
            IESLIPDETAILs = new HashSet<IESLIPDETAIL>();
            PRODUCTAVAILABLEs = new HashSet<PRODUCTAVAILABLE>();
        }

        [StringLength(1)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(1)]
        public string BrandID { get; set; }

        [Required]
        [StringLength(1)]
        public string CategoryID { get; set; }

        [Required]
        [StringLength(1)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public virtual BRAND BRAND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARTITEM> CARTITEMs { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IESLIPDETAIL> IESLIPDETAILs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTAVAILABLE> PRODUCTAVAILABLEs { get; set; }
    }
}
