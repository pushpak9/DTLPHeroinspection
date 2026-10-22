using HeroInspection.PL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace HeroInspection.DataLayer
{
    public class DL_ProductCustomerMapping
    {
        Common obj = new Common();
        SqlCommand cmd = null;

        public DataTable dtBindCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "BINDCUSTOMERCODE");
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

        public DataTable dtBindProduct()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "BINDPRODUCT");
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
        public DataTable GetPrductDetails(string sProductCode)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "GETPRODUCTDETAILS");
                cmd.Parameters.AddWithValue("@SITECODE", PCommon.SiteCode);
                cmd.Parameters.AddWithValue("@PRODUCTCODE", sProductCode);
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

        public DataTable dtGetItem()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "GETITEM");
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
        public DataTable dtGetItemByID(int itbdID)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "GETITEMBYID");
                cmd.Parameters.AddWithValue("@TBDID", itbdID);
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
        public DataTable SaveItem(ItemMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "SAVEDATA");
                cmd.Parameters.AddWithValue("@SiteCode", PCommon.SiteCode);
                cmd.Parameters.AddWithValue("@PRODUCTCODE", request.ItemCode);
                cmd.Parameters.AddWithValue("@CUSTOMERCODE", request.CustomerCode);
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
        public DataTable DeleteMapped(ItemMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@TYPE", "UNMAPPED");
                cmd.Parameters.AddWithValue("@TBDID", request.iTbdID);
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
