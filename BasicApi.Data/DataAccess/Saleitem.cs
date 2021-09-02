using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicApi.Data.DataAccess
{
    public partial class Saleitem
    {
        [Key]
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        [StringLength(255)]
        public string ProductName { get; set; }
        [Column(TypeName = "numeric(10,2)")]
        public decimal? ProductPrice { get; set; }
        public int? Quantity { get; set; }
    }
}
