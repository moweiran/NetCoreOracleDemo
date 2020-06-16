using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_LCL_INQUIRY_PRODUCT
    {
        public decimal FF_LCL_INQUIRY_PRODUCT_ID { get; set; }
        public decimal LCL_PRODUCT_ID { get; set; }
        public decimal FF_LCL_INQUIRY_ID { get; set; }
        public bool? IS_RATERULE { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_USERNAME { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
