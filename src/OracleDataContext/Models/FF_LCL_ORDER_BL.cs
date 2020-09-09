using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_LCL_ORDER_BL
    {
        public decimal LCL_ORDER_BL_ID { get; set; }
        public decimal LCL_ORDER_ID { get; set; }
        public decimal MAIN_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal? MAIN_BL_ID { get; set; }
        public string BL_TYPE { get; set; }
        public string BL_NO { get; set; }
        public string TRANS_TYPE_CODE { get; set; }
        public string PPCC { get; set; }
        public decimal? ISSUE_USERID { get; set; }
        public DateTime? ISSUE_DATE { get; set; }
        public decimal? ISSUE_CITY_ID { get; set; }
        public string ORIGINAL_NO { get; set; }
        public decimal? SHIPPER_ID { get; set; }
        public string SHIPPER_DESC { get; set; }
        public decimal? CONSIGNEE_ID { get; set; }
        public string CONSIGNEE_DESC { get; set; }
        public decimal? NOTIFIER_ID { get; set; }
        public string NOTIFIER_DESC { get; set; }
        public decimal? AGENCY_ID { get; set; }
        public string AGENCY_DESC { get; set; }
        public string PRE_VESSEL_NAME { get; set; }
        public string PRE_VOYAGE { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public decimal? RECEIPT_ID { get; set; }
        public decimal? POL_ID { get; set; }
        public DateTime? POL_ETD { get; set; }
        public decimal? POD_ID { get; set; }
        public DateTime? POD_ETA { get; set; }
        public decimal? DELIVERY_ID { get; set; }
        public decimal? FINALDESTINATION_ID { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARKS { get; set; }
        public decimal? PICS { get; set; }
        public string PICS_UNIT { get; set; }
        public decimal? WEIGHT { get; set; }
        public string WEIGHT_UNIT { get; set; }
        public decimal? CBM { get; set; }
        public string CONTA_DESC { get; set; }
        public string TOTAL_DESC { get; set; }
        public string BL_REMARK { get; set; }
        public decimal? STATUS { get; set; }
        public decimal? RELEASE_USERID { get; set; }
        public string RELEASE_FULLNAME { get; set; }
        public DateTime? RELEASE_DATE { get; set; }
        public string RELEASE_REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? FORWARDING_AGENCY_ID { get; set; }
        public string FORWARDING_AGENCY_DESC { get; set; }
        public string BL_RECEIPT_NAME { get; set; }
        public string BL_POL_NAME { get; set; }
        public string BL_POD_NAME { get; set; }
        public string BL_DELIVERY_NAME { get; set; }
        public string PAYABLE_AT { get; set; }
    }
}
