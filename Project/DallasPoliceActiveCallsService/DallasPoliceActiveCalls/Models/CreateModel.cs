using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DallasPoliceActiveCalls.Models
{
    public class CreateModel
    {
        [Required]
        public string IncidentNumber { get; set; }

        [Required]
        public string Division { get; set; }

        [Required]
        public string NatureOfCalls { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public DateTime Date_Time { get; set; }

        [Required]
        public string UnitNumber { get; set; }

        [Required]
        public int Block { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Beat { get; set; }

        [Required]
        public int ReportingArea { get; set; }

        [Required]
        public string Status { get; set; }
    }
}