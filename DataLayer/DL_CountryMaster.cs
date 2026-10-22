using HeroInspection.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HeroInspection.DataLayer
{
    
    public class DL_CountryMaster
    {
        Common obj = new Common();
        SqlCommand cmd = null;


        public DataTable GetCountry()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_CountryMASTER";
                cmd.Parameters.AddWithValue("@type", "GET");

                DataSet ds = obj.ExecuteDataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }


        public DataTable dtBindProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "BINDCUSTOMERCODE1");
                cmd.Parameters.AddWithValue("@SITECODE", PCommon.SiteCode);
                DataSet ds = obj.ExecuteDataset(cmd);
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }

        // 🔹 GET BY ID
        public DataTable dtCountryByID(int CountryId)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_CountryMASTER";
                cmd.Parameters.AddWithValue("@type", "GETBYID");
                cmd.Parameters.AddWithValue("@CountryId", CountryId);

                DataSet ds = obj.ExecuteDataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }

        // 🔹 SAVE
        public DataTable SaveCountry(CountryMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_CountryMASTER";
                cmd.Parameters.AddWithValue("@type", "SAVE");
                cmd.Parameters.AddWithValue("@CountryName", request.CountryName);
                cmd.Parameters.AddWithValue("@CreatedBy", PCommon.UserID);

                DataSet ds = obj.ExecuteDataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }

        // 🔹 UPDATE
        public DataTable UpdateCountry(CountryMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_CountryMASTER";
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.Parameters.AddWithValue("@CountryId", request.CountryId);
                cmd.Parameters.AddWithValue("@CountryName", request.CountryName);
                cmd.Parameters.AddWithValue("@CreatedBy", PCommon.UserID);

                DataSet ds = obj.ExecuteDataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }

        // 🔹 DELETE (optional)
        public DataTable DeleteCountry(CountryMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_CountryMASTER";
                cmd.Parameters.AddWithValue("@type", "DELETE");
                cmd.Parameters.AddWithValue("@CountryId", request.CountryId);

                DataSet ds = obj.ExecuteDataset(cmd);

                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogs.DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                throw ex;
            }
            return dt;
        }
    }
}
