using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class EditRepository
    {
        public Models.EditModel PopulateEdit(string IncidentNumber)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();
            DallasPoliceActiveCallsServiceReference.ActiveCalls activeCalls = new DallasPoliceActiveCallsServiceReference.ActiveCalls();
            activeCalls = serviceClient.GetDetails(IncidentNumber);

            Models.EditModel editModel = new Models.EditModel {
                 Beat =  activeCalls.Beat,
                  Block =  activeCalls.Block,
                   Date_Time = activeCalls.Date_Time,
                    Division =  activeCalls.Division,
                     IncidentNumber = activeCalls.IncidentNumber,
                      Location = activeCalls.Location,
                       NatureOfCalls = activeCalls.NatureOfCalls,
                        Priority = activeCalls.Priority,
                         ReportingArea = activeCalls.ReportingArea,
                          Status = activeCalls.Status,
                           UnitNumber = activeCalls.UnitNumber
            };

            return editModel;
        }


        public void EditData(Models.EditModel editModel)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();
          

            DallasPoliceActiveCallsServiceReference.ActiveCalls activeCalls = new DallasPoliceActiveCallsServiceReference.ActiveCalls
            {
                Beat = editModel.Beat,
                Block = editModel.Block,
                Date_Time = editModel.Date_Time,
                Division = editModel.Division,
                IncidentNumber = editModel.IncidentNumber,
                Location = editModel.Location,
                NatureOfCalls = editModel.NatureOfCalls,
                Priority = editModel.Priority,
                ReportingArea = editModel.ReportingArea,
                Status = editModel.Status,
                UnitNumber = editModel.UnitNumber

            };

            serviceClient.UpdateData(activeCalls);
        }
    }
}