using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class booking_order_rate
    {
        public long BOOKING_ORDER_RATE_ID { get; set; }
        public long BOOKING_ORDER_ID { get; set; }
        public long FF_BOOKING_RATE_ID { get; set; }
        public long CARRIER_ID { get; set; }
        public int RATE_TYPE { get; set; }
        public int? CONTA_PROPERTY { get; set; }
        public string CONTA_SIZE { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public int? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public int CONTA_QTY { get; set; }
        public int? EIR_QTY { get; set; }
        public int TEU { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public string CURRENCY { get; set; }
        public decimal? RATE_COST { get; set; }
        public decimal? RATE_SALES_COST { get; set; }
        public decimal RATE_CUSTOMER { get; set; }
        public decimal? RATE_CUSTOMER_REQUEST { get; set; }
        public decimal? RATE_CUSTOMER_REPLY { get; set; }
        public decimal RATE_FINAL { get; set; }
        public string CARGO_DESC { get; set; }
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
