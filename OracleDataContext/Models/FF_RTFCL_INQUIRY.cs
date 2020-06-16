using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_RTFCL_INQUIRY
    {
        public FF_RTFCL_INQUIRY()
        {
            FF_RTFCL_INQUIRY_PRODUCT = new HashSet<FF_RTFCL_INQUIRY_PRODUCT>();
        }

        public decimal FF_RTFCL_INQUIRY_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string INQUIRY_NO { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal CARGO_TYPE { get; set; }
        public decimal START_CITY_ID { get; set; }
        public decimal DEST_CITY_ID { get; set; }
        public DateTime? PLAN_DATE { get; set; }
        public decimal? GP20 { get; set; }
        public decimal? GP40 { get; set; }
        public decimal? HQ40 { get; set; }
        public string CARGO_DESC { get; set; }
        public decimal STATUS { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }

        public virtual ICollection<FF_RTFCL_INQUIRY_PRODUCT> FF_RTFCL_INQUIRY_PRODUCT { get; set; }
    }
}
