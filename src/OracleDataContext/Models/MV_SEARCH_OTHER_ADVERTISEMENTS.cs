using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_SEARCH_OTHER_ADVERTISEMENTS
    {
        public decimal? ROW_INDEX { get; set; }
        public decimal BASE_OTHER_ADVERTISEMENT_ID { get; set; }
        public decimal ADVERTISEMENT_TYPE { get; set; }
        public decimal SHOW_INDEX { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string ADVERTISEMENT_SUBJECT_CN { get; set; }
        public string ADVERTISEMENT_SUBJECT_EN { get; set; }
        public decimal? FILE_CN_ID { get; set; }
        public decimal? FILE_EN_ID { get; set; }
        public decimal? M_BG_FILE_ID { get; set; }
        public decimal? FF_ID { get; set; }
    }
}
