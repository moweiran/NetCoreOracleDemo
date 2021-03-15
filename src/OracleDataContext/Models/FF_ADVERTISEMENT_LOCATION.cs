using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_ADVERTISEMENT_LOCATION
    {
        public decimal FF_ADVERTISEMENT_LOCATION_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? CARRIER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal PRICE { get; set; }
        public decimal DAYS { get; set; }
        public decimal AMOUNT { get; set; }
        public string REMARK { get; set; }
        public decimal STATUS { get; set; }
        public DateTime? EFFECTIVE_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? CONTACTS_ID { get; set; }
        public string CONTACTS_NAME { get; set; }
        public string CONTACTS_TEL { get; set; }
        public string CONTACTS_EMAIL { get; set; }
        public string CONTACTS_MOBILE { get; set; }
    }
}
