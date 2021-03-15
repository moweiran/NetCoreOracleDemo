using System;
using System.Collections.Generic;

#nullable disable

namespace MySqlDataContext.NewShip
{
    public partial class presale_rate_main
    {
        public long PRESALE_RATE_MAIN_ID { get; set; }
        public long PRESALE_MAIN_LIST_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public long CARRIER_COMPANY_ID { get; set; }
        public long ROUTE_ID { get; set; }
        public string ROUTE_CODE { get; set; }
        public long WEEK_ID { get; set; }
        public long MAIN_PRODUCT_ID { get; set; }
        public long POL_ID { get; set; }
        public long? VIA_ID { get; set; }
        public long POD_ID { get; set; }
        public string CURRENCY { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public int CURRENT_LEVEL { get; set; }
        public decimal? CURRENT_GP20 { get; set; }
        public decimal? CURRENT_GP40 { get; set; }
        public decimal? CURRENT_HQ40 { get; set; }
        public decimal? CURRENT_GP45 { get; set; }
        public string REMARK { get; set; }
        public int STATUS { get; set; }
        public bool DELETE_MARK { get; set; }
        public long? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public long? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
    }
}
