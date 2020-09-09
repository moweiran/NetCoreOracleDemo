using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class BASE_APPLICATIONS
    {
        public BASE_APPLICATIONS()
        {
            BASE_MODULE = new HashSet<BASE_MODULE>();
        }

        public decimal APPLICATION_ID { get; set; }
        public string APPLICATION_KEY { get; set; }
        public string APPLICATION_CODE { get; set; }
        public string APPLICATION_NAME { get; set; }
        public string ICON { get; set; }
        public string DESCRIPTION { get; set; }
        public string URL { get; set; }
        public string IP { get; set; }
        public decimal? BINDING { get; set; }
        public decimal? SEQUENCE { get; set; }

        public virtual ICollection<BASE_MODULE> BASE_MODULE { get; set; }
    }
}
