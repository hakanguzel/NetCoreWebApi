using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class Paymenttype
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
