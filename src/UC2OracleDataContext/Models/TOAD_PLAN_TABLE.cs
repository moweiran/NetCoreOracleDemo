using System;
using System.Collections.Generic;

namespace UC2OracleDataContext.Models
{
    public partial class TOAD_PLAN_TABLE
    {
        public string STATEMENT_ID { get; set; }
        public decimal? PLAN_ID { get; set; }
        public DateTime? TIMESTAMP { get; set; }
        public string REMARKS { get; set; }
        public string OPERATION { get; set; }
        public string OPTIONS { get; set; }
        public string OBJECT_NODE { get; set; }
        public string OBJECT_OWNER { get; set; }
        public string OBJECT_NAME { get; set; }
        public string OBJECT_ALIAS { get; set; }
        public decimal? OBJECT_INSTANCE { get; set; }
        public string OBJECT_TYPE { get; set; }
        public string OPTIMIZER { get; set; }
        public decimal? SEARCH_COLUMNS { get; set; }
        public decimal? ID { get; set; }
        public decimal? PARENT_ID { get; set; }
        public decimal? DEPTH { get; set; }
        public decimal? POSITION { get; set; }
        public decimal? COST { get; set; }
        public decimal? CARDINALITY { get; set; }
        public decimal? BYTES { get; set; }
        public string OTHER_TAG { get; set; }
        public string PARTITION_START { get; set; }
        public string PARTITION_STOP { get; set; }
        public decimal? PARTITION_ID { get; set; }
        public string OTHER { get; set; }
        public string DISTRIBUTION { get; set; }
        public decimal? CPU_COST { get; set; }
        public decimal? IO_COST { get; set; }
        public decimal? TEMP_SPACE { get; set; }
        public string ACCESS_PREDICATES { get; set; }
        public string FILTER_PREDICATES { get; set; }
        public string PROJECTION { get; set; }
        public decimal? TIME { get; set; }
        public string QBLOCK_NAME { get; set; }
        public string OTHER_XML { get; set; }
    }
}
