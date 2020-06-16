using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class FF_PROT_CONTRAST
    {
        public decimal PROT_CONTRAST_ID { get; set; }
        public string PROT_CONTRAST_CODE { get; set; }
        public string PROT_CONTRAST_NAME { get; set; }
        public decimal FF_ID { get; set; }
        public decimal STATUS { get; set; }
        public bool? IGNORE_AS_VIA { get; set; }
    }
}
