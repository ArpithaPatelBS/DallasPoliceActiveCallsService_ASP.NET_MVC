using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class DeleteRepository
    {
        public Models.DeleteModel PopulateDelete(string IncidentNumber)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();
            DallasPoliceActiveCallsServiceReference.ActiveCalls activeCalls = new DallasPoliceActiveCallsServiceReference.ActiveCalls();
            activeCalls = serviceClient.GetDetails(IncidentNumber);

            Models.DeleteModel deleteModel = new Models.DeleteModel
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

            return deleteModel;
        }

        public void DeleteData(string IncidentID)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();

            serviceClient.DeleteData(IncidentID);
        }
    }
}