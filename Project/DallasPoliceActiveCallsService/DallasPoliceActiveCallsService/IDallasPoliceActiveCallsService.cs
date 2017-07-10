using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DallasPoliceActiveCallsService
{
    // Service Contract to use to get the specific service
    [ServiceContract]
    public interface IDallasPoliceActiveCallsService
    {

        [OperationContract]
        List<ActiveCalls> GetData();

        [OperationContract]
        void CreateData(ActiveCalls activeCalls);

        [OperationContract]
        void UpdateData(ActiveCalls activeCalls);

        [OperationContract]
        void DeleteData(string IncidentNumber);

        [OperationContract]
        ActiveCalls GetDetails(string IncidentNumber);

        [OperationContract]
        List<PriorityGraph> GetPriorityGraphValues();
    }


    //Data Contract of the Police Active Calls
    [DataContract]
    public class ActiveCalls
    {
        [DataMember]
        public string IncidentNumber { get; set; }

        [DataMember]
        public string Division { get; set; }

        [DataMember]
        public string NatureOfCalls { get; set; }

        [DataMember]
        public int Priority { get; set; }

        [DataMember]
        public DateTime Date_Time { get; set; }

        [DataMember]
        public string UnitNumber { get; set; }

        [DataMember]
        public int Block { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public int Beat { get; set; }

        [DataMember]
        public int ReportingArea { get; set;}

        [DataMember]
        public string Status { get; set; }
        
    }

    [DataContract]
    public class PriorityGraph
    {
        [DataMember]
        public int Priority { get; set; }

        [DataMember]
        public int Count { get; set; }
    }
}
