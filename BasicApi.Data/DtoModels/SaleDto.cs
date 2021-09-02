using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApi.Data.DtoModels
{
    public class SaleDto
    {
        public int? CustomerId { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public int? PayementType { get; set; }
    }
}
