using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GPRS_CLOUD.Models
{
    public class LiveWeather
    {

        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]

        [DisplayName("Serial No")]
        public string Serial_No { get; set; }
        [Required]

        [DisplayName("Model No")]
        public string Model_No { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]

        [DisplayName("Solar Power")]
        public string Solar_Power { get; set; }
       
        public string Pump { get; set; }

        [DisplayName("Motor Speed")]
        public string Motor_Speed { get; set; }
        public string Weather { get; set; }
        public string Status { get; set; }

        public DateTime Installation_Date { get; set; }

        public string View { get; set; }

        public string Temp { get; set; }

      





    }
}