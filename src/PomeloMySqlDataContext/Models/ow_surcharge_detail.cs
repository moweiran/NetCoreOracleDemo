using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class ow_surcharge_detail
    {
        public long OW_SURCHARGE_DETAIL_ID { get; set; }
        public long OW_SURCHARGE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CONTA_SIZETYPE { get; set; }
        public decimal BEGIN_WEIGHT { get; set; }
        public decimal END_WEIGHT { get; set; }
        public decimal? SURCHARGE_AMOUNT { get; set; }
        public string REMARK { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
