using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DallasPoliceActiveCalls.Models
{
    public class ActiveCallsIndex
    {
        public string IncidentNumber { get; set; }

        public string Divison { get; set; }

        public string NatureOfCalls { get; set; }

        public int? Priority { get; set; }

        public DateTime Date_Time { get; set; }
         
        public string Location { get; set; }

        public int Beat { get; set; }

        public int ReportingArea { get; set; }
    }
}