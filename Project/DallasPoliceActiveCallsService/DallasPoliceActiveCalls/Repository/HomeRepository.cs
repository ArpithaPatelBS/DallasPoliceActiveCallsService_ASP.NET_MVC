using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class HomeRepository
    {
        public List<Models.ActiveCallsIndex> GetData()
        {
            List<DallasPoliceActiveCallsServiceReference.ActiveCalls> activeCalls = new List<DallasPoliceActiveCallsServiceReference.ActiveCalls>();

            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();

            activeCalls = serviceClient.GetData();

            List<Models.ActiveCallsIndex> activeCallIndexList = new List<Models.ActiveCallsIndex>();

            foreach (var item in activeCalls)
            {
                Models.ActiveCallsIndex activecallIndex = new Models.ActiveCallsIndex { Beat = item.Beat,
                                                                    Date_Time = item.Date_Time,
                                                                    Divison = item.Division,
                                                                    IncidentNumber = item.IncidentNumber,
                                                                    Location = item.Location,
                                                                    NatureOfCalls = item.NatureOfCalls,
                                                                    Priority = item.Priority,
                                                                    ReportingArea = item.ReportingArea
                                                                    };

                activeCallIndexList.Add(activecallIndex);
            }
             
            return activeCallIndexList;
        }
    }
}