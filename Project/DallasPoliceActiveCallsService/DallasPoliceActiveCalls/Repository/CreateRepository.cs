using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class CreateRepository
    {
        public void CreateData(Models.CreateModel createModel)
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();


            DallasPoliceActiveCallsServiceReference.ActiveCalls activeCalls = new DallasPoliceActiveCallsServiceReference.ActiveCalls {
                 Beat = createModel.Beat,
                  Block = createModel.Block,
                   Date_Time = createModel.Date_Time,
                    Division =  createModel.Division,
                      IncidentNumber = createModel.IncidentNumber,
                       Location = createModel.Location,
                        NatureOfCalls = createModel.NatureOfCalls,
                         Priority = createModel.Priority,
                          ReportingArea = createModel.ReportingArea,
                           Status = createModel.Status,
                            UnitNumber = createModel.UnitNumber

            };

            serviceClient.CreateData(activeCalls);

        }
    }
}