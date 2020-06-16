﻿using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public partial class BOOKING_ORDER_CONTAINER
    {
        public decimal BOOKING_ORDER_CONTAINER_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal MAIN_BOOKING_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public decimal CARGO_PROPERTY { get; set; }
        public decimal CONTA_PROPERTY { get; set; }
        public string CONTA_SIZETYPE_CODE { get; set; }
        public string CONTA_SIZE { get; set; }
        public string CONTAINER_NO { get; set; }
        public string SEAL_NO { get; set; }
        public decimal? PACKAGE_NUM { get; set; }
        public string PACKAGE_UNIT { get; set; }
        public decimal? WEIGHT { get; set; }
        public decimal? VGM_WEIGHT { get; set; }
        public decimal? VOUME { get; set; }
        public string CARGO_DESC { get; set; }
        public string MARK { get; set; }
        public decimal DATA_SOURCE { get; set; }
        public decimal? TC_CONTAINER_ID { get; set; }
        public string BOOKING_NO { get; set; }
        public bool? DELETE_MARK { get; set; }
        public decimal? MODIFY_USERID { get; set; }
        public string MODIFY_FULLNAME { get; set; }
        public decimal? MODIFY_COMPANYID { get; set; }
        public DateTime MODIFY_DATETIME { get; set; }
        public decimal? CREATE_USERID { get; set; }
        public string CREATE_FULLNAME { get; set; }
        public decimal? CREATE_COMPANYID { get; set; }
        public DateTime CREATE_DATETIME { get; set; }
        public decimal? DANGEROU_LEVEL_ID { get; set; }
        public string DANGEROU_LEVEL_CODE { get; set; }
        public decimal? CONTA_WEIGHT { get; set; }
        public decimal? VGM_TYPE { get; set; }
        public DateTime? VGM_DATE { get; set; }
        public string SUBMIT_FULLNAME { get; set; }
        public DateTime? SUBMIT_DATE { get; set; }
        public string CONFIRM_FULLNAME { get; set; }
        public DateTime? CONFIRM_DATE { get; set; }
        public decimal? VGM_STATUS { get; set; }
        public DateTime? DELETE_DATE { get; set; }
        public decimal? TEU { get; set; }
        public decimal? PRESALE_ORDER_ID { get; set; }

        public virtual BOOKING_ORDER BOOKING_ORDER_ { get; set; }
    }
}
