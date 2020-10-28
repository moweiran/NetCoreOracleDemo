using System;
using System.Collections.Generic;

namespace PomeloMySqlDataContext.Models
{
    public partial class ship_week
    {
        public long WEEK_ID { get; set; }
        public string YEAR_NO { get; set; }
        public string WEEK_NO { get; set; }
        public DateTime WEEK_BEGIN_DATE { get; set; }
        public DateTime WEEK_END_DATE { get; set; }
    }
}
