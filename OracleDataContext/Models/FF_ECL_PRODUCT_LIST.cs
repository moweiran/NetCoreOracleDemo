using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_ECL_PRODUCT_LIST
    {
        public FF_ECL_PRODUCT_LIST()
        {
            FF_ECL_PRODUCT = new HashSet<FF_ECL_PRODUCT>();
            FF_ECL_PRODUCT_LEVEL = new HashSet<FF_ECL_PRODUCT_LEVEL>();
        }

        public decimal FF_ECL_PRODUCT_LIST_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal FF_COMPANY_ID { get; set; }
        public decimal START_CITY_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public decimal ECL_TYPE { get; set; }
        public decimal CHARGE_UNIT { get; set; }
        public string CHANNEL { get; set; }
        public decimal PRODUCT_QTY { get; set; }
        public string CONTACT_USERID { get; set; }
        public string CONTACT_NAME { get; set; }
        public string CONTACT_TEL { get; set; }
        public string CONTACT_MOBILE { get; set; }
        public string CONTACT_EMAIL { get; set; }
        public string CONTACT_QQ { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public string CONTACT_WECHAT { get; set; }
        public decimal LEVEL_TYPE { get; set; }
        public decimal RATE_IMPORT_TYPE { get; set; }
        public bool? IS_FBA { get; set; }
        public bool? IS_SPECIALLINE { get; set; }
        public bool? IS_EXPRESS { get; set; }
        public bool? IS_PAK { get; set; }
        public string WAREHOUSE_ADDRESS { get; set; }
        public string WAREHOUSE_TEL { get; set; }

        public virtual ICollection<FF_ECL_PRODUCT> FF_ECL_PRODUCT { get; set; }
        public virtual ICollection<FF_ECL_PRODUCT_LEVEL> FF_ECL_PRODUCT_LEVEL { get; set; }
    }
}
