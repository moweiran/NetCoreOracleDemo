using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_HSCODE
    {
        public decimal BASE_HSCODE_ID { get; set; }
        public decimal HSCATEGORY_ID { get; set; }
        public string HSCODE { get; set; }
        public string HSNAME { get; set; }
        public string DECLARATION { get; set; }
        public string UNIT1 { get; set; }
        public string UNIT2 { get; set; }
        public string IMPORT_TAX_MFN { get; set; }
        public string IMPORT_TAX_GENERAL { get; set; }
        public string IMPORT_TAX_TEMPORARY { get; set; }
        public string CONSUMPTION_TAX { get; set; }
        public string EXPORT_TAX { get; set; }
        public string EXPORT_REBATE_TAX { get; set; }
        public string VAT { get; set; }
        public string CUSTOMS_SUPERVISION { get; set; }
        public string INSPECTION_CATEGORY { get; set; }
        public string COMMODITY_DESC { get; set; }
        public string COMMODITY_ENAME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
    }
}
