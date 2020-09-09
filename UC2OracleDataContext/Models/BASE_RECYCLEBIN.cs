using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_RECYCLEBIN
    {
        public decimal RECYCLEBIN_ID { get; set; }
        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public string RECYCLEBIN_NAME { get; set; }
        public string RECYCLEBIN_DATABASE { get; set; }
        public string RECYCLEBIN_TABLE { get; set; }
        public string RECYCLEBIN_FIELD_KEY { get; set; }
        public string RECYCLEBIN_FIELD_VALUE { get; set; }
        public string RECYCLEBIN_REMARK { get; set; }
        public string CREATE_USERNAME { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime? CREATE_DATE { get; set; }
    }
}
