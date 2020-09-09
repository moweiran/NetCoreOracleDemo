using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class DEMAND_AIR
    {
        public decimal DEMAND_AIR_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal DEMAND_SOURCE { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public decimal? RECEIPT_COUNTRY_ID { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal? RECEIPT_DOOR_ID { get; set; }
        public string RECEIPT_ADDRESS { get; set; }
        public string RECEIPT_CONTACTS { get; set; }
        public string RECEIPT_TEL { get; set; }
        public decimal? DELIVERY_COUNTRY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public decimal? DELIVERY_DOOR_ID { get; set; }
        public string DELIVERY_ADDRESS { get; set; }
        public string DELIVERY_CONTACTS { get; set; }
        public string DELIVERY_TEL { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal? QTY { get; set; }
        public string UNIT { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? VOLUME { get; set; }
        public decimal? LENGTHS { get; set; }
        public decimal? WDITH { get; set; }
        public decimal? HEIGHT { get; set; }
        public bool? OUT_TRUCK { get; set; }
        public bool? OUT_CUSTOMS { get; set; }
        public bool? OUT_INSPECTION { get; set; }
        public bool? OUT_INSURANCE { get; set; }
        public bool? OUT_AMS { get; set; }
        public bool? OUT_PACK { get; set; }
        public bool? IN_TRUCK { get; set; }
        public bool? IN_CUSTOMS { get; set; }
        public string REMARK { get; set; }
        public bool? VALID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
