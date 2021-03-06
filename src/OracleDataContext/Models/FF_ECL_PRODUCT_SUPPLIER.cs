﻿using System;
using System.Collections.Generic;

namespace OracleDataContext.Models
{
    public partial class FF_ECL_PRODUCT_SUPPLIER
    {
        public FF_ECL_PRODUCT_SUPPLIER()
        {
            FF_ECL_PRODUCT_SUPPLIER_RULE = new HashSet<FF_ECL_PRODUCT_SUPPLIER_RULE>();
        }

        public decimal FF_ECL_PRODUCT_SUPPLIER_ID { get; set; }
        public decimal FF_ECL_PRODUCT_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal SUPPLIER_ID { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }

        public virtual ICollection<FF_ECL_PRODUCT_SUPPLIER_RULE> FF_ECL_PRODUCT_SUPPLIER_RULE { get; set; }
    }
}
