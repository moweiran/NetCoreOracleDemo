using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ORDER_PROFIT
    {
        public FF_ORDER_PROFIT()
        {
            FF_ORDER_PROFIT_DETAIL = new HashSet<FF_ORDER_PROFIT_DETAIL>();
        }

        public decimal FF_ORDER_PROFIT_ID { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? BILL_LIST_ID { get; set; }
        public decimal? COMPANY_ID { get; set; }
        public decimal? COMPANY_TYPE { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }

        public virtual ICollection<FF_ORDER_PROFIT_DETAIL> FF_ORDER_PROFIT_DETAIL { get; set; }
    }
}
