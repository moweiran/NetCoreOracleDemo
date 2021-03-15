using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class ORDER_EIR_APPLY
    {
        public ORDER_EIR_APPLY()
        {
            ORDER_EIR = new HashSet<ORDER_EIR>();
        }

        public decimal ORDER_EIR_APPLY_ID { get; set; }
        public decimal ORDER_ID { get; set; }
        public decimal TRANSPORT_TYPE { get; set; }
        public decimal BUSINESS_TYPE { get; set; }
        public decimal FF_ID { get; set; }
        public string FF_CONTACT { get; set; }
        public string FF_CONTACT_PHONE { get; set; }
        public decimal? TRAILER_COMPANY_ID { get; set; }
        public string TRAILER_CONTACT { get; set; }
        public string TRAILER_CONTACT_PHONE { get; set; }
        public decimal? PRICE_TO_CUSTOMER_DETAIL_ID { get; set; }
        public decimal? TC_TRAILER_ORDER_ID { get; set; }
        public string CARRIER_CODE { get; set; }
        public string BOOKING_NO { get; set; }
        public decimal? CITY_ID { get; set; }
        public decimal? PORT_ID { get; set; }
        public decimal? SCHEDULE_ID { get; set; }
        public string VESSEL_NAME { get; set; }
        public string VOYAGE { get; set; }
        public decimal? LOC_PICK_ID { get; set; }
        public decimal? LOC_RETURN_ID { get; set; }
        public decimal? LOC_LOAD_DISCHARGE_ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string CUSTOMER_CONTACT { get; set; }
        public string CUSTOMER_CONTACT_PHONE { get; set; }
        public string FACTORY_CONTACT { get; set; }
        public string FACTORY_CONTACT_PHONE { get; set; }
        public DateTime? ARRIVE_FACTORY_TIME { get; set; }
        public decimal? SPEND_LOAD_DISCHARGE { get; set; }
        public string ADDRESS { get; set; }
        public bool? NEED_DRIVER_LICENSE { get; set; }
        public bool? IS_TRANSFER_CUSTOM { get; set; }
        public string LOC_CUSTOM { get; set; }
        public DateTime? COMMIT_TIME { get; set; }
        public decimal STATUS { get; set; }
        public decimal? TEU { get; set; }
        public string CONTA_DESC { get; set; }
        public string REMARK { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? LOC_LOAD_CITY_ID { get; set; }

        public virtual ICollection<ORDER_EIR> ORDER_EIR { get; set; }
    }
}
