using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class ECL_PACK_CONTAINER_2_ORDER
    {
        public decimal ECL_PACK_CONTAINER_ID { get; set; }
        public decimal ECL_ORDER_ID { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }

        public virtual ECL_PACK_CONTAINER ECL_PACK_CONTAINER { get; set; }
    }
}
