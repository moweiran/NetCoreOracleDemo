using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_BILL_SAP
    {
        public decimal ID { get; set; }
        public decimal FF_BILL_ID { get; set; }
        public string SAP_PAYMENT_TERMS { get; set; }
        public string SAP_BILLING_TYPE { get; set; }
        public string SAP_CONTRACT_NO { get; set; }
        public string SAP_CUSTOMER_NO { get; set; }
        public string SAP_MATERIAL_NUMBER { get; set; }
        public string SAP_ITEM_NO { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? FF_BILL_LIST_ID { get; set; }
    }
}
