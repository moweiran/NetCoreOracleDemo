using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CONTRACT_DETAIL
    {
        public CONTRACT_DETAIL()
        {
            CONTRACT_SURCHARGE = new HashSet<CONTRACT_SURCHARGE>();
        }

        public decimal CONTRACT_DETAIL_ID { get; set; }
        public decimal CONTRACT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? ORIGIN_CITY_ID { get; set; }
        public decimal? POL_CITY_ID { get; set; }
        public decimal? POD_CITY_ID { get; set; }
        public decimal? PFD_CITY_ID { get; set; }
        public string CARGO_TYPE_CODE { get; set; }
        public string CARGO_TYPE_ENAME { get; set; }
        public string CARGO_TYPE_CNAME { get; set; }
        public string FREIGHT_CLAUSE_CODE { get; set; }
        public decimal GP20 { get; set; }
        public decimal GP40 { get; set; }
        public decimal HQ40 { get; set; }
        public decimal GP45 { get; set; }
        public string CURRENCY { get; set; }
        public string REMARK { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal ORIGIN_ID { get; set; }
        public decimal POL_ID { get; set; }
        public decimal POD_ID { get; set; }
        public decimal PFD_ID { get; set; }
        public bool? DELETE_MARK { get; set; }

        public virtual CONTRACT CONTRACT { get; set; }
        public virtual ICollection<CONTRACT_SURCHARGE> CONTRACT_SURCHARGE { get; set; }
    }
}
