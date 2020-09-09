using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class ECL_PACK_CONTAINER
    {
        public ECL_PACK_CONTAINER()
        {
            ECL_PACK_CONTAINER_2_ORDER = new HashSet<ECL_PACK_CONTAINER_2_ORDER>();
        }

        public decimal ECL_PACK_CONTAINER_ID { get; set; }
        public string PACK_NO { get; set; }
        public int? STATUS { get; set; }
        public int? COUNT { get; set; }
        public decimal? FF_ID { get; set; }
        public DateTime? CREATE_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }

        public virtual ICollection<ECL_PACK_CONTAINER_2_ORDER> ECL_PACK_CONTAINER_2_ORDER { get; set; }
    }
}
