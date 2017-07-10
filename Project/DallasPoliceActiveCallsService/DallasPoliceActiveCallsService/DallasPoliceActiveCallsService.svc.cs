using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DallasPoliceActiveCallsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DallasPoliceActiveCallsService : IDallasPoliceActiveCallsService
    {
        public List<ActiveCalls> GetData()
        {
            try {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                return bl.GetData();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public void CreateData(ActiveCalls activeCalls)
        {
            try
            {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                bl.CreateData(activeCalls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void UpdateData(ActiveCalls activeCalls)
        {
            try
            {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                bl.UpdateData(activeCalls);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteData(string IncidentNumber)
        {
            try
            {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                bl.DeleteData(IncidentNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActiveCalls GetDetails(string IncidentNumber)
        {
            try
            {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                return bl.GetDetails(IncidentNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<PriorityGraph> GetPriorityGraphValues()
        {
            try
            {
                DallasPoliceActiveCallsBL bl = new DallasPoliceActiveCallsBL();
                return bl.GetPriorityGraphValues();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
