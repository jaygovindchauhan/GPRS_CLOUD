using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;    

namespace GPRS_CLOUD.Models
{
    public class HistoricalDataM
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

    }
}