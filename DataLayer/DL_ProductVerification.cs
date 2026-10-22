using HeroInspection.PL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace HeroInspection.DataLayer
{
    internal class DL_ProductVerification
    {
        Common obj = new Common();
        SqlCommand cmd = null;

        public DataTable dtBindProduct(string CountryName)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "BINDCUSTOMERCODE");
                cmd.Parameters.AddWithValue("@SITECODE", PCommon.SiteCode);
                cmd.Parameters.AddWithValue("@CountryName", CountryName);
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

        public DataTable dtBindCountry()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "dtBindCountry");
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

        public DataTable dtGetStart(string UserID, string sPassword, string sModule)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "VALIDATEStart");
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@Password", sPassword);
                cmd.Parameters.AddWithValue("@MODULENAME", sModule);

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
        public DataTable dtGetStop(string UserID, string sPassword, string sModule)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "VALIDATEStop");
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@Password", sPassword);
                cmd.Parameters.AddWithValue("@MODULENAME", sModule);

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



        public DataTable GetLastData(string partCode)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_Mapping";
                cmd.Parameters.AddWithValue("@type", "GetLastData");
                cmd.Parameters.AddWithValue("@PRODUCTCODE", partCode);
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

        public DataTable dtBindSlotNo(string sPartCode)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ProductVerification";
                cmd.Parameters.AddWithValue("@type", "BINDPRODUCT");
                cmd.Parameters.AddWithValue("@PRODUCTCODE", sPartCode);
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

        public DataTable CheckDuplicateSerial(string barcodeValue)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ProductVerification";
                cmd.Parameters.AddWithValue("@type", "BindSerialNoDuplicateCheck");
                cmd.Parameters.AddWithValue("@Barcode", barcodeValue);
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
        public DataTable SaveData(string sProductCode,string Message, string status, string statusReason, string cmbShift)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "USP_ProductVerification";
                cmd.Parameters.AddWithValue("@type", "SAVEDATA");
                cmd.Parameters.AddWithValue("@SiteCode", PCommon.SiteCode);
                cmd.Parameters.AddWithValue("@PRODUCTCODE", sProductCode);
                cmd.Parameters.AddWithValue("@Message", Message);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@statusReason", statusReason);
                cmd.Parameters.AddWithValue("@CreatedBy", PCommon.UserID);
                cmd.Parameters.AddWithValue("@Shift",cmbShift);
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
