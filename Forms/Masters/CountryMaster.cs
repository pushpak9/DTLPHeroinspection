using DTPLLogs;
using HeroInspection.BusinessLayer;
using HeroInspection.DataLayer;
using HeroInspection.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HeroInspection.Forms.Masters
{
    public partial class CountryMaster : Form
    {
        int SelectedId = 0;
        DL_CountryMaster obj = new DL_CountryMaster();
        public CountryMaster()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "ADD")
                {
                    _ClearControls();
                    _EnableDisableControls(true);
                    txtCountryName.Focus();
                    btnAdd.Text = "SAVE";
                    btnEdit.Enabled = false;
                }
                else
                {
                    if (txtCountryName.Text.Trim() == "")
                    {
                        blCommon.ShowMessage("Please enter Country name", 2);
                        txtCountryName.Focus(); return;
                    }

                    CountryMasterModel plobj = new CountryMasterModel();
                    plobj.CountryName = txtCountryName.Text.Trim();
                


                    DataTable dt = obj.SaveCountry(plobj);

                    if (dt.Rows.Count > 0)
                    {
                        string sResult = dt.Rows[0][0].ToString();
                        if (sResult.StartsWith("SUCCESS~"))
                            blCommon.ShowMessage("Data saved successfully.", 1);
                        else
                            blCommon.ShowMessage(sResult, 2);
                    }

                    setReload();
                    _ClearControls();
                    _EnableDisableControls(false);
                    btnAdd.Text = "ADD";
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnEdit.Text == "EDIT")
                {
                    if (txtCountryName.Text.Trim() == "")
                    {
                        blCommon.ShowMessage("Select record first", 2);
                        return;
                    }

                    _EnableDisableControls(true);
                    btnEdit.Text = "SAVE";
                    btnAdd.Enabled = false;
                }
                else
                {
                    CountryMasterModel plobj = new CountryMasterModel();
                    plobj.CountryId = SelectedId;
                    plobj.CountryName = txtCountryName.Text.Trim();
                   // plobj.PartCode = cmbPartCode.Text.Trim();


                    DataTable dt = obj.UpdateCountry(plobj);

                    if (dt.Rows.Count > 0)
                    {
                        string sResult = dt.Rows[0][0].ToString();
                        if (sResult.StartsWith("SUCCESS~"))
                            blCommon.ShowMessage("Updated successfully.", 1);
                        else
                            blCommon.ShowMessage(sResult, 2);
                    }

                    setReload();
                    _ClearControls();
                    _EnableDisableControls(false);
                    btnEdit.Text = "EDIT";
                    btnAdd.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountryMaster_Load(object sender, EventArgs e)
        {
            setReload();
        }
        void _ClearControls()
        {
            txtCountryName.Text = "";
            SelectedId = 0;
        }

        void _EnableDisableControls(bool flag)
        {
            txtCountryName.Enabled = flag;
        }
        public void setReload()
        {
            DataTable dt = obj.GetCountry();
            if (dt.Rows.Count > 0)
            {
                lvCountry.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    // 2nd column ka data
                    ListViewItem item = new ListViewItem(dr[1].ToString());

                    // 3rd column ka data
                    item.SubItems.Add(dr[2].ToString());

                    // ListView me add
                    lvCountry.Items.Add(item);
                }

            }
        }
        private void LogError(Exception ex)
        {
            PCommon.mAppLog.WriteLog(
                ex.Message,
                DTPLLogsWrite.LogType.Error,
                MethodBase.GetCurrentMethod());

            blCommon.ShowMessage(ex.Message, 3);
        }

        private void CountryMaster_Load_1(object sender, EventArgs e)
        {
            setReload();
            //cmbPartCode.Enabled = true;

        }

        private void lvCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCountry.SelectedItems.Count > 0)
            {
                //SelectedId = Convert.ToInt32(lvCountry.SelectedItems[0].SubItems[0].Text);
                txtCountryName.Text = lvCountry.SelectedItems[0].SubItems[1].Text;
                //cmbPartCode.Text = lvCountry.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
