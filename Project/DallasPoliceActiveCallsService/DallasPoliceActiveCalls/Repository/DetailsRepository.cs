using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class DetailsRepository
    {
        public Models.Details GetDetails(string IncidentNumber)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();
            DallasPoliceActiveCallsServiceReference.ActiveCalls activeCalls = new DallasPoliceActiveCallsServiceReference.ActiveCalls();
            activeCalls = serviceClient.GetDetails(IncidentNumber);

            Models.Details details = new Models.Details
            {
                Beat = activeCalls.Beat,
                Block = activeCalls.Block,
                Date_Time = activeCalls.Date_Time,
                Division = activeCalls.Division,
                IncidentNumber = activeCalls.IncidentNumber,
                Location = activeCalls.Location,
                NatureOfCalls = activeCalls.NatureOfCalls,
                Priority = activeCalls.Priority,
                ReportingArea = activeCalls.ReportingArea,
                Status = activeCalls.Status,
                UnitNumber = activeCalls.UnitNumber
            };

            return details;
        }
    }
}