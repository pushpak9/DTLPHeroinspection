using HeroInspection.PL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace HeroInspection.DataLayer
{
    public class DL_UserMaster
    {
        Common obj = new Common();
        SqlCommand cmd = null;
    
        public DataTable GETUSER()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_USERMASTER";
                cmd.Parameters.AddWithValue("@type", "GETUSER");
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
        public DataTable dtGetUserByID(string sUserID)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_USERMASTER";
                cmd.Parameters.AddWithValue("@type", "GETUSERBYID");
                cmd.Parameters.AddWithValue("@UserID", sUserID);
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
        public DataTable SaveUser(UserMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_USERMASTER";
                cmd.Parameters.AddWithValue("@type", "SAVE");
                cmd.Parameters.AddWithValue("@UserID", request.UserID);
                cmd.Parameters.AddWithValue("@UserName", request.UserName);
                cmd.Parameters.AddWithValue("@UserType", request.UserType);
                cmd.Parameters.AddWithValue("@Password", request.Password);
                cmd.Parameters.AddWithValue("@ACTIVE", request.Active);
                cmd.Parameters.AddWithValue("@CreatedBy", PCommon.UserID);
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
        public DataTable UpdateUser(UserMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_USERMASTER";
                cmd.Parameters.AddWithValue("@type", "UPDATE");
                cmd.Parameters.AddWithValue("@UserID", request.UserID);
                cmd.Parameters.AddWithValue("@UserName", request.UserName);
                cmd.Parameters.AddWithValue("@UserType", request.UserType);
                cmd.Parameters.AddWithValue("@Password", request.Password);
                cmd.Parameters.AddWithValue("@ACTIVE", request.Active);
                cmd.Parameters.AddWithValue("@CreatedBy", PCommon.UserID);
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
        public DataTable DeleteUser(UserMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_USERMASTER";
                cmd.Parameters.AddWithValue("@type", "DELETEUSER");
                cmd.Parameters.AddWithValue("@UserID", request.UserID);
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
    }
}