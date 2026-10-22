using HeroInspection.PL;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace HeroInspection.DataLayer
{
    public class DL_ItemMaster
    {
        Common obj = new Common();
        SqlCommand cmd = null;
        
        
        public DataTable dtGetItem()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ITEMMASTER";
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
        public DataTable SaveItem(ItemMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ITEMMASTER";
                cmd.Parameters.AddWithValue("@type", "SAVE");
                cmd.Parameters.AddWithValue("@SiteCode", PCommon.SiteCode);
                cmd.Parameters.AddWithValue("@ItemCode", request.ItemCode);
                cmd.Parameters.AddWithValue("@ItemName", request.ItemName);
                cmd.Parameters.AddWithValue("@ItemDesc", request.ItemDesc);
                cmd.Parameters.AddWithValue("@Encode", request.Encode);
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
        public DataTable UpdateItem(ItemMasterModel request)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ITEMMASTER";
                cmd.Parameters.AddWithValue("@TYPE", "UPDATE");
                cmd.Parameters.AddWithValue("@ItemCode", request.ItemCode);
                cmd.Parameters.AddWithValue("@ItemName", request.ItemName);
                cmd.Parameters.AddWithValue("@ItemDesc", request.ItemDesc);
                cmd.Parameters.AddWithValue("@Encode", request.Encode);
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
    }
}