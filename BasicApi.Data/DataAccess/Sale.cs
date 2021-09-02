using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class Sale
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal? SubTotal { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal? Total { get; set; }
        public int? PayementType { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Sale")]
        public virtual User User { get; set; }
    }
}
