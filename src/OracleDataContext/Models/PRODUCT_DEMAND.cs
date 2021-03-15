using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class PRODUCT_DEMAND
    {
        public PRODUCT_DEMAND()
        {
            PRODUCT_DEMAND_SUPPLIER = new HashSet<PRODUCT_DEMAND_SUPPLIER>();
        }

        public decimal PRODUCT_DEMAND_ID { get; set; }
        public decimal DEMAND_SOURCE { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_SHORTNAME { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string TRANS_TYPE_ENAME { get; set; }
        public decimal RECEIPT_CITY_ID { get; set; }
        public decimal DELIVERY_CITY_ID { get; set; }
        public string CARGO_PROPERTY { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal CONTA_UNIT { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public decimal? GP45 { get; set; }
        public string REMARK { get; set; }
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
        public decimal? RECEIPT_DOOR_ID { get; set; }
        public decimal? RECEIPT_COUNTRY_ID { get; set; }
        public decimal? DELIVERY_DOOR_ID { get; set; }
        public decimal? DELIVERY_COUNTRY_ID { get; set; }
        public bool? VALID { get; set; }
        public decimal CUSTOMER_TYPE { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public bool? OUT_TRUCK { get; set; }
        public bool? OUT_CUSTOMS { get; set; }
        public bool? OUT_VGM { get; set; }
        public bool? OUT_FUMIGATION { get; set; }
        public bool? OUT_INSPECTION { get; set; }
        public bool? OUT_INSURANCE { get; set; }
        public bool? OUT_AMS { get; set; }
        public bool? OUT_ENS { get; set; }
        public bool? IN_TRUCK { get; set; }
        public bool? IN_CUSTOMS { get; set; }
        public string RECEIPT_ADDRESS { get; set; }
        public string RECEIPT_CONTACTS { get; set; }
        public string RECEIPT_TEL { get; set; }
        public string DELIVERY_ADDRESS { get; set; }
        public string DELIVERY_CONTACTS { get; set; }
        public string DELIVERY_TEL { get; set; }
        public bool? OUT_ISF { get; set; }
        public bool? OUT_VAT { get; set; }
        public bool? OUT_PERMIT { get; set; }
        public bool? OUT_PURCHASE { get; set; }
        public bool? IN_INSPECTION { get; set; }
        public bool? IN_TAX { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }

        public virtual ICollection<PRODUCT_DEMAND_SUPPLIER> PRODUCT_DEMAND_SUPPLIER { get; set; }
    }
}
