using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Data;
using HeroInspection.DataLayer;
using HeroInspection.BusinessLayer;
using DTPLLogs;
using System.Reflection;
using HeroInspection.PL;

namespace HeroInspection
{
    public partial class frmProductMaster : MaterialForm
    {
        #region Variable and Object Declaration
        CustomerMasterModel clsCustomerMaster = new CustomerMasterModel();

        DL_ProductVerification objOperation =
            new DL_ProductVerification();
        #endregion

        public frmProductMaster()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
           Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            DataTable dt =
                     objOperation.dtBindCountry();

            if (dt.Rows.Count > 0)
            {
                blCommon.FillComboBox(
                    txtcountry,
                    dt,
                    true);
            }
            try
            {
                
              
                _DisableControls();
                setReload();
                btnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
        }
       //It displays the existing data to the listview during form load  
        public void setReload()
        {
            try
            {
                DL_CustomerMaster clsCustomerMaster = new DL_CustomerMaster();
                DataTable dt = clsCustomerMaster.dtGetItem();
                lblNoOfRecords.Text = "No Of Records : " + dt.Rows.Count;
                if (dt.Rows.Count > 0)
                {
                    PCommon.FillListView(dt, lv);
                    if (dt.Rows.Count >= 1)
                    {
                        btnAdd.Enabled = false;
                        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
            catch (Exception ex)
            {
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        #region Methods related to enable,disable and clear the controls

        void _DisableControls()
        {

            txtCustomerCode.Enabled = false;
            txtCustomerName.Enabled = false;
            txtDescription.Enabled = false;
        }

        void _EnableControls()
        {
            txtCustomerCode.Enabled = true;
            // txtSecondaryGTIN.Enabled = true;
            txtDescription.Enabled = true;
            txtCustomerName.Enabled = true;
           
        }

        void _ClearControls()
        {
            txtCustomerName.Text = "";
            txtDescription.Text = "";
            txtCustomerCode.Text = "";
        }

        #endregion

        # region Ma1n Operations on the form

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "ADD")
                {
                    _ClearControls();
                    _EnableControls();
                    txtCustomerCode.Focus();
                    btnAdd.Text = "SAVE";
                    btnEdit.Enabled = false;
                }
                else
                {
                    if (txtCustomerCode.Text.Trim() == "")
                    { blCommon.ShowMessage("Please enter customer code", 2); txtCustomerCode.Focus(); return; }
                    if ((txtCustomerCode.Text.Trim()) == "0")
                    { blCommon.ShowMessage("Invalid customer code", 2); txtCustomerCode.Focus(); return; }
                    if (txtCustomerName.Text.Trim() == "")
                    { blCommon.ShowMessage("Please enter customer name", 2); txtCustomerName.Focus(); return; }
                    
                    clsCustomerMaster.ProductCode = txtCustomerCode.Text.Trim();
                    clsCustomerMaster.Slotno = txtCustomerName.Text.Trim().ToUpper();
                    clsCustomerMaster.Description = txtDescription.Text.Trim();
                    clsCustomerMaster.Country = txtcountry.Text.Trim();
                   

                    DL_CustomerMaster obj = new DL_CustomerMaster();
                    DataTable dt = obj.SaveItem(clsCustomerMaster);
                    if (dt.Rows.Count > 0)
                    {
                        string sResult = dt.Rows[0][0].ToString();
                        if (sResult.StartsWith("SUCCESS~"))
                        {
                            blCommon.ShowMessage("Data saved successfully.", 1);
                        }
                        else
                        {
                            blCommon.ShowMessage(sResult, 2);
                        }
                    }
                    _ClearControls();
                    _DisableControls();
                    setReload();
                    btnAdd.Text = "ADD";
                    btnEdit.Enabled = true;
                    btnAdd.Enabled= true;
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable _dt = new DataTable();
            try
            {
                if (btnEdit.Text != "SAVE")
                {
                    btnAdd.Enabled = false;
                    txtCustomerCode.Enabled = false;
                    if (txtCustomerName.Text == "")
                    { blCommon.ShowMessage("Please select data from grid", 2); txtCustomerName.Focus(); return; }
                }
                else
                {
                    if (txtCustomerCode.Text.Trim() == "")
                    { blCommon.ShowMessage("Please enter customer code", 2); txtCustomerCode.Focus(); return; }                   
                    if (txtCustomerName.Text.Trim() == "")
                    { blCommon.ShowMessage("Please enter customer name", 2); txtCustomerName.Focus(); return; }
                   
                    clsCustomerMaster.ProductCode = txtCustomerCode.Text.Trim();
                    clsCustomerMaster.Slotno = txtCustomerName.Text.Trim().ToUpper();
                    clsCustomerMaster.Description = txtDescription.Text.Trim();
                    clsCustomerMaster.Country = txtcountry.Text.Trim();

                    DL_CustomerMaster obj = new DL_CustomerMaster();
                    DataTable dt = obj.UpdateItem(clsCustomerMaster);
                    if (dt.Rows.Count > 0)
                    {
                        string sResult = dt.Rows[0][0].ToString();
                        if (sResult.StartsWith("SUCCESS~"))
                        {
                            blCommon.ShowMessage("Data Update successfully.", 1);
                        }
                        else
                        {
                            blCommon.ShowMessage(sResult, 2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
            finally 
            {
                setReload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text.Trim() == "")
                { blCommon.ShowMessage("Please select data from grid", 2); return; }
                else
                {
                    if (MessageBox.Show("Are you sure to delete?", blCommon.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        clsCustomerMaster.ProductCode = txtCustomerCode.Text.Trim().ToUpper();
                        DL_CustomerMaster obj = new DL_CustomerMaster();
                        DataTable dt = obj.DeleteItem(clsCustomerMaster);
                        if (dt.Rows.Count > 0)
                        {
                            string sResult = dt.Rows[0][0].ToString();
                            if (sResult.StartsWith("SUCCESS~"))
                            {
                                blCommon.ShowMessage("Data deleted successfully.", 1);
                            }
                            else
                            {
                                blCommon.ShowMessage(sResult, 2);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
            finally
            {
                setReload();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ClearControls();
            _DisableControls();
            btnEdit.Text = "EDIT";
            btnAdd.Text = "ADD";
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            txtCustomerCode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnClear_Click(sender, e);
                foreach (ListViewItem _item in lv.Items)
                {
                    if (_item.Selected == true)
                    {
                        btnEdit.Text = "SAVE";
                        btnAdd.Enabled = false;
                       
                        _EnableControls();
                        txtCustomerCode.Enabled = false;
                        txtCustomerCode.Text = _item.SubItems[0].Text.Trim();
                        txtCustomerName.Text = _item.SubItems[1].Text.Trim();
                        txtDescription.Text = _item.SubItems[2].Text.Trim().ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        #endregion

        # region Validations on controls

        private void txtBrandName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))//e.KeyChar!=(char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtBtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtGtin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            //{
            //    e.Handled = true;

            //}
        }
        #endregion
               
    }
}