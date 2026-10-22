using DTPLLogs;
using HeroInspection;
using HeroInspection.BusinessLayer;
using HeroInspection.DataLayer;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace HeroInspection.Reports
{
    public partial class InspectionReport : Form
    {
        DL_Report objDL_Report = new DL_Report();
        public InspectionReport()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                string sReportHeader = string.Empty;
                if (cmbFilter.Text == "Barcode")
                {
                    sReportHeader = "Barcode";
                }
                if (cmbFilter.Text == "status")
                {
                    sReportHeader = "status";
                }
                if (cmbFilter.Text == "shift")
                {
                    sReportHeader = "shift";
                }

                DataTable dt = objDL_Report.dtGetReport(sReportHeader, txtValue.Text,Datefromdate.Text, DateTodate.Text);
                if (dt.Rows.Count > 0)
                {
                    ReceivingGrid.DataSource = dt;
                }
                else
                {
                    blCommon.ShowMessage("No result found", 3);
                    ReceivingGrid.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (ReceivingGrid.Rows.Count >= 1)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = (DataTable)ReceivingGrid.DataSource;
                        string sFilePath = saveFileDialog.FileName;
                        blCommon.exportToExcel1(dt, sFilePath);
                        blCommon.ShowMessage("File export successfull", 1);
                    }
                }
                catch (Exception ex)
                {
                    PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                    blCommon.ShowMessage(ex.Message, 3);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("No Record to Export !");

            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ReceivingGrid.DataSource = null;
        }

        private void btnPDFExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReceivingGrid.Rows.Count > 0)
                {
                    Cursor = Cursors.WaitCursor;
                    DataTable dt = (DataTable)ReceivingGrid.DataSource;
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sFilePath = saveFileDialog.FileName;
                        blCommon.ExportToPdf(dt, sFilePath, "Data Validation Report");
                        blCommon.ShowMessage("File export successfull", 1);
                    }
                }
                else
                {
                    blCommon.ShowMessage("No data found to export", 2);
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
