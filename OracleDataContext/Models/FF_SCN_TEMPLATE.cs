using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_SCN_TEMPLATE
    {
        public decimal FF_SCN_TEMPLATE_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string TEMPLATE_NAME { get; set; }
        public decimal SHIPPER_ID { get; set; }
        public decimal CONSIGNEE_ID { get; set; }
        public decimal NOTIFIER_ID { get; set; }
        public bool? IS_SAME_CONSIGNEE { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
