using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCalls.Repository
{
    public class GraphRepository
    {
        public List<Models.PriorityGraphModel> GetPriorityGraphDetails()
        {
            DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient serviceClient = new DallasPoliceActiveCallsServiceReference.DallasPoliceActiveCallsServiceClient();
                       

            List<DallasPoliceActiveCallsServiceReference.PriorityGraph> priorityGraph = serviceClient.GetPriorityGraphValues();

            List<Models.PriorityGraphModel> priorityGraphModel = new List<Models.PriorityGraphModel>();

            foreach (var item in priorityGraph)
            {
                Models.PriorityGraphModel priorityGraphModelObject = new Models.PriorityGraphModel {
                    Count = item.Count,
                     Priority =  item.Priority
                };
                priorityGraphModel.Add(priorityGraphModelObject);

            }
            


            return priorityGraphModel;

        } 
    }
}