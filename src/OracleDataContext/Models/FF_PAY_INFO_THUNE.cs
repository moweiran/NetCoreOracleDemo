using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class FF_PAY_INFO_THUNE
    {
        public decimal FF_PAY_INFO_THUNES_ID { get; set; }
        public decimal THUNES_PAYMENT_ID { get; set; }
        public string PARTNER_PAYMENT_ID { get; set; }
        public string PAYER_INDENTIFIER { get; set; }
        public string MODE { get; set; }
        public string STATUS_ID { get; set; }
        public string STATUS_MESSAGE { get; set; }
        public string PAYER_TRANSACTION_REFERENCE { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public DateTime? COLLECTION_DATE { get; set; }
        public DateTime? EXPIRATION_DATE { get; set; }
        public decimal? FX_RATE { get; set; }
        public string PARTNER_PAYMENT_CODE { get; set; }
        public string PURPOSE_OF_REMITTANCE { get; set; }
        public string DOCUMENT_REFERENCE_NUMBER { get; set; }
        public string CALLBACK_URL { get; set; }
        public string ADDITINAL_INFORMATION_1 { get; set; }
        public string ADDITINAL_INFORMATION_2 { get; set; }
        public string ADDITINAL_INFORMATION_3 { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public bool? DELETE_MARK { get; set; }
        public string SOURCE_COUNTRY { get; set; }
        public string SOURCE_CURRENCY { get; set; }
        public decimal? SOURCE_AMOUNT { get; set; }
        public string DESTINATION_COUNTRY { get; set; }
        public string DESTINATION_CURRENCY { get; set; }
        public decimal? DESTINATION_AMOUNT { get; set; }
        public string BANK_ACCOUNT_NUMBER { get; set; }
        public decimal? PAYMENT_FEE { get; set; }
    }
}
