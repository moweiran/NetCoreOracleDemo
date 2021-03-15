using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class MV_QUERY_FCL_ADVERTISEMENTS
    {
        public decimal SHIPROUTE_AREA_ID { get; set; }
        public decimal? ROW_INDEX { get; set; }
        public decimal FF_ID { get; set; }
        public string COMPANY_CODE { get; set; }
        public string COMPANY_NAME_EN { get; set; }
        public string COMPANY_NAME_CN { get; set; }
        public decimal? LARGEICON_FILE_ID { get; set; }
        public string FILE_PATH { get; set; }
        public bool? IS_CERTIFICATION { get; set; }
        public string COMPANY_DESCRIBE { get; set; }
    }
}
