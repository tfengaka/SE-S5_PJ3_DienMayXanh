namespace DienMayXanh_Store.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(30)]
        public string StaffID { get; set; }

        [Required]
        [StringLength(30)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string Permission { get; set; }

        public virtual STAFF STAFF { get; set; }
    }
}
