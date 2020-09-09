using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class BASE_WAREHOUSE_RELATED
    {
        public decimal ID { get; set; }
        public decimal WAREHOUSE_ID { get; set; }
        public string ARRIVAL_TIME { get; set; }
        public decimal? TOWING_FEE { get; set; }
        public string CURRENCY { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
