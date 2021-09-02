using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Deleted { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Customer")]
        public virtual User User { get; set; }
    }
}
