using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_APPEND_PROPERTY_INSTANCE
    {
        public decimal PROPERTY_INSTANCE_ID { get; set; }
        public decimal? PROPERTY_ID { get; set; }
        public string PROPERTY_INSTANCE_VALUE { get; set; }
        public string PROPERTY_INSTANCE_KEY { get; set; }
    }
}
