using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal? Price { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Product")]
        public virtual User User { get; set; }
    }
}
