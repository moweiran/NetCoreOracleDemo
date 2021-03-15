using System;
using System.Collections.Generic;

#nullable disable

namespace OracleDataContext.Models
{
    public partial class CALISTA_FREIGHT_BOOKING
    {
        public decimal CALISTA_FREIGHT_BOOKING_ID { get; set; }
        public decimal BOOKING_ORDER_ID { get; set; }
        public decimal FF_ID { get; set; }
        public string FREIGHTBOOKINGID { get; set; }
        public string SHIPMENTTYPE { get; set; }
        public string FORWARDHUBSCHEME { get; set; }
        public string FORWARDHUBUSERGROUP { get; set; }
        public string FORWARDHUBOUTBOUNDREFNO { get; set; }
        public string VOYAGEID { get; set; }
        public string CARRIERPARTYID { get; set; }
        public string VESSELNAME { get; set; }
        public string VOYAGENO { get; set; }
        public string INTVOYAGENO { get; set; }
        public string POLCODE { get; set; }
        public string PODCODE { get; set; }
        public DateTime POLETA { get; set; }
        public DateTime? POLETD { get; set; }
        public DateTime? PODETA { get; set; }
        public DateTime? PODETD { get; set; }
        public DateTime? CARGOREADYDATE { get; set; }
        public DateTime? CARGODELIVERYDATE { get; set; }
        public string PLACEOFRECEIPTCODE { get; set; }
        public string PLACEOFDELIVERYCODE { get; set; }
        public string PLACEOFRECEIPT { get; set; }
        public string PLACEOFDELIVERY { get; set; }
        public string PLACEOFRECEIPTETD { get; set; }
        public string PLACEOFDELIVERYETA { get; set; }
        public string DESTCODE { get; set; }
        public string FINALDEST { get; set; }
        public string SHIPPERREMARKS { get; set; }
        public string CARRIERREMARKS { get; set; }
        public string MOVETYPE { get; set; }
        public string EMPTYPICKUPCOMPNAME { get; set; }
        public string EMPTYPICKUPCOMPADDRESS { get; set; }
        public string EMPTYPICKUPCONTACTNAME { get; set; }
        public string EMPTYPICKUPCONTACTPHONENO { get; set; }
        public string EMPTYPICKUPDATEPICKUP { get; set; }
        public string SHIPTOCOMPNAME { get; set; }
        public string SHIPTOCOMPADDRESS { get; set; }
        public string SHIPTOCONTACTNAME { get; set; }
        public string SHIPTOCONTACTPHONENO { get; set; }
        public string SHIPTODATEDELIVERY { get; set; }
        public string SHIPFROMCOMPNAME { get; set; }
        public string SHIPFROMCOMPADDRESS { get; set; }
        public string SHIPFROMCONTACTNAME { get; set; }
        public string SHIPFROMCONTACTPHONENO { get; set; }
        public string SHIPFROMDATEPICKUP { get; set; }
        public string SHIPFROMDATEPOSITIONING { get; set; }
        public string CONTRACTNO { get; set; }
        public string CONTRACTPARTYNAME { get; set; }
        public string REPRESENTATIVENAME { get; set; }
        public string REPRESENTATIVECONTACTNO { get; set; }
        public string REPRESENTATIVEEMAIL { get; set; }
        public string CONSIGNEENAME { get; set; }
        public string FORWARDERNAME { get; set; }
        public string SHIPPERREFNO { get; set; }
        public string SHIPPERPARTYID { get; set; }
        public string SHIPPERNAME { get; set; }
        public string FORWARDERREFNO { get; set; }
        public string MAINNOTIFYPARTY { get; set; }
        public string COMMONREF { get; set; }
        public string PRESHIPCONTACT { get; set; }
        public string PREASSBKREFNO { get; set; }
        public string CHRGTYPE { get; set; }
        public string FRTTERM { get; set; }
        public string PAYER { get; set; }
        public string PMTLOC { get; set; }
        public DateTime? SUBMITTEDDATE { get; set; }
        public decimal? BOOKINGSTATUS { get; set; }
        public decimal? PREVBOOKINGSTATUS { get; set; }
    }
}
