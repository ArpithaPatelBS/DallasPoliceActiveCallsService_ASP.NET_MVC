using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DallasPoliceActiveCallsService
{
    public class DallasPoliceActiveCallsDA
    {
        SqlConnection conn = null;
        public DallasPoliceActiveCallsDA()
        {
                var connectionString = ConfigurationManager.ConnectionStrings["DallaPoliceDB"].ConnectionString;
                conn = new SqlConnection(connectionString);
           
        }

        public List<ActiveCalls> GetData()
        {
            try
            {
                List<ActiveCalls> listActiveCalls = new List<ActiveCalls>();

                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("GetData", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqlRedaer = sqlCmd.ExecuteReader();

                while (sqlRedaer.Read())
                {
                    ActiveCalls activeCalls = new ActiveCalls();
                    activeCalls.IncidentNumber = sqlRedaer["IncidentNumber"].ToString();
                    activeCalls.Division = sqlRedaer["Division"].ToString();
                    activeCalls.NatureOfCalls = sqlRedaer["NatureOfCall"].ToString();
                    activeCalls.Priority = Convert.ToInt32(sqlRedaer["Priority"].ToString());
                    activeCalls.Date_Time = Convert.ToDateTime(sqlRedaer["DateTime"].ToString());
                    activeCalls.UnitNumber = sqlRedaer["UnitNumber"].ToString();
                    activeCalls.Block = (sqlRedaer["Block"].ToString() != "") ? Convert.ToInt32(sqlRedaer["Block"].ToString()) : 0;
                    activeCalls.Location = sqlRedaer["Location"].ToString();
                    activeCalls.Beat = (sqlRedaer["Beat"].ToString() != "") ? Convert.ToInt32(sqlRedaer["Beat"].ToString()) : 0;
                    activeCalls.ReportingArea = (sqlRedaer["ReportingArea"].ToString() != "") ? Convert.ToInt32(sqlRedaer["ReportingArea"].ToString()) : 0;
                    activeCalls.Status = sqlRedaer["Status"].ToString();
                    listActiveCalls.Add(activeCalls);
                }
                return listActiveCalls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }



        public void CreateData(ActiveCalls activeCalls)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("CreateData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IncidentNumber", SqlDbType.VarChar).Value = activeCalls.IncidentNumber;
                    cmd.Parameters.AddWithValue("@Division", SqlDbType.VarChar).Value = activeCalls.Division;
                    cmd.Parameters.AddWithValue("@NatureOfCall", SqlDbType.VarChar).Value = activeCalls.NatureOfCalls;
                    cmd.Parameters.AddWithValue("@Priority", SqlDbType.VarChar).Value = activeCalls.Priority;
                    cmd.Parameters.AddWithValue("@DateTime", SqlDbType.DateTime).Value = activeCalls.Date_Time;
                    cmd.Parameters.AddWithValue("@UnitNumber", SqlDbType.VarChar).Value = activeCalls.UnitNumber;
                    cmd.Parameters.AddWithValue("@Block", SqlDbType.VarChar).Value = activeCalls.Block.ToString();
                    cmd.Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = activeCalls.Location;
                    cmd.Parameters.AddWithValue("@Beat", SqlDbType.VarChar).Value = activeCalls.Beat.ToString();
                    cmd.Parameters.AddWithValue("@ReportingArea", SqlDbType.VarChar).Value = activeCalls.ReportingArea.ToString();
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = activeCalls.Status;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }



        public void UpdateData(ActiveCalls activeCalls)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UpdateData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IncidentNumber", SqlDbType.VarChar).Value = activeCalls.IncidentNumber;
                    cmd.Parameters.AddWithValue("@Division", SqlDbType.VarChar).Value = activeCalls.Division;
                    cmd.Parameters.AddWithValue("@NatureOfCall", SqlDbType.VarChar).Value = activeCalls.NatureOfCalls;
                    cmd.Parameters.AddWithValue("@Priority", SqlDbType.VarChar).Value = activeCalls.Priority;
                    cmd.Parameters.AddWithValue("@DateTime", SqlDbType.DateTime).Value = activeCalls.Date_Time;
                    cmd.Parameters.AddWithValue("@UnitNumber", SqlDbType.VarChar).Value = activeCalls.UnitNumber;
                    cmd.Parameters.AddWithValue("@Block", SqlDbType.VarChar).Value = activeCalls.Block.ToString();
                    cmd.Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = activeCalls.Location;
                    cmd.Parameters.AddWithValue("@Beat", SqlDbType.VarChar).Value = activeCalls.Beat.ToString();
                    cmd.Parameters.AddWithValue("@ReportingArea", SqlDbType.VarChar).Value = activeCalls.ReportingArea.ToString();
                    cmd.Parameters.AddWithValue("@Status", SqlDbType.VarChar).Value = activeCalls.Status;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }


        public void DeleteData(string IncidentNumber)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IncidentNumber", SqlDbType.VarChar).Value = IncidentNumber;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }

        }


        public ActiveCalls GetDetails(string IncidentNumber)
        {
            try
            {
                
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("GetDetails", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IncidentNumber", SqlDbType.VarChar).Value = IncidentNumber;
                SqlDataReader sqlRedaer = sqlCmd.ExecuteReader();
                ActiveCalls activeCalls = new ActiveCalls();

                while (sqlRedaer.Read())
                {
                    
                    activeCalls.IncidentNumber = sqlRedaer["IncidentNumber"].ToString();
                    activeCalls.Division = sqlRedaer["Division"].ToString();
                    activeCalls.NatureOfCalls = sqlRedaer["NatureOfCall"].ToString();
                    activeCalls.Priority = Convert.ToInt32(sqlRedaer["Priority"].ToString());
                    activeCalls.Date_Time = Convert.ToDateTime(sqlRedaer["DateTime"].ToString());
                    activeCalls.UnitNumber = sqlRedaer["UnitNumber"].ToString();
                    activeCalls.Block = (sqlRedaer["Block"].ToString() != "") ? Convert.ToInt32(sqlRedaer["Block"].ToString()) : 0;
                    activeCalls.Location = sqlRedaer["Location"].ToString();
                    activeCalls.Beat = (sqlRedaer["Beat"].ToString() != "") ? Convert.ToInt32(sqlRedaer["Beat"].ToString()) : 0;
                    activeCalls.ReportingArea = (sqlRedaer["ReportingArea"].ToString() != "") ? Convert.ToInt32(sqlRedaer["ReportingArea"].ToString()) : 0;
                    activeCalls.Status = sqlRedaer["Status"].ToString();
                }
                return activeCalls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }


        public List<PriorityGraph> GetPriorityGraphValues()
        {
            try
            {
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("GetPriorityCountValues", conn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqlRedaer = sqlCmd.ExecuteReader();
                List<PriorityGraph> priorityGraphList = new List<PriorityGraph>();

                while (sqlRedaer.Read())
                {
                    PriorityGraph priorityGraph = new PriorityGraph();
                    priorityGraph.Priority = Convert.ToInt32(sqlRedaer["Priority"].ToString());
                    priorityGraph.Count = Convert.ToInt32(sqlRedaer["Priority_Count"].ToString());
                    priorityGraphList.Add(priorityGraph);
                }
                return priorityGraphList;
                ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
    }
}