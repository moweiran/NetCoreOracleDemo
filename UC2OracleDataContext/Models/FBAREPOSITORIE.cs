using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class FBAREPOSITORIE
    {
        public decimal FBAREPOSID { get; set; }
        public string FBAREPOSCODE { get; set; }
        public decimal COUNTRYID { get; set; }
        public string COUNTRY { get; set; }
        public decimal? PROVINCEID { get; set; }
        public string PROVINCENAME { get; set; }
        public string PROVINCESHORTNAME { get; set; }
        public string ADDRESS { get; set; }
        public string ZIPCODE { get; set; }
        public DateTime? CREATE_DATE { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public bool DELETE_MARK { get; set; }
        public DateTime? MODIFT_DATE { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
    }
}
