using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class User
    {
        public User()
        {
            Customer = new HashSet<Customer>();
            Product = new HashSet<Product>();
            Sale = new HashSet<Sale>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Deleted { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Customer> Customer { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Product> Product { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Sale> Sale { get; set; }
    }
}
