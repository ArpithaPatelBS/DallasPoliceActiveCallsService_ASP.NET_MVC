using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DallasPoliceActiveCallsService
{
    public class DallasPoliceActiveCallsBL
    {
        public List<ActiveCalls> GetData()
        {
            try
            {
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                return da.GetData();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void CreateData(ActiveCalls activeCalls)
        {
            try
            {
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                da.CreateData(activeCalls);
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
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                da.UpdateData(activeCalls);
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
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                da.DeleteData(IncidentNumber);
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
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                return da.GetDetails(IncidentNumber);
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
                DallasPoliceActiveCallsDA da = new DallasPoliceActiveCallsDA();
                return da.GetPriorityGraphValues();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}