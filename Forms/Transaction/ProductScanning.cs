using com.itextpdf.text.pdf;
using DTPLLogs;
using HeroInspection.BusinessLayer;
using HeroInspection.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Modbus.Device;

namespace HeroInspection.Forms.Transaction
{
    public partial class ProductScanning : Form
    {
        string ScannerIP = "";

        // RECEIVE PORT
        int ScannerDataPort = 0;

        // COMMAND PORT
        int ScannerCommandPort = 0;
        private SerialPort port;

        DL_ProductVerification objOperation =
            new DL_ProductVerification();

        ClsSocket.ClientSocket_MultiSocket objBin =
            new ClsSocket.ClientSocket_MultiSocket();

        public ProductScanning()
        {
            InitializeComponent();
        }

        //private void ConnectPLC()
        //{
        //    try
        //    {
        //        string comPort =
        //            ConfigurationManager.AppSettings["PLC_COM"];

        //        int baudRate =
        //            Convert.ToInt32(
        //                ConfigurationManager.AppSettings["PLC_BAUD"]);

        //        Parity parity =
        //            (Parity)Enum.Parse(
        //                typeof(Parity),
        //                ConfigurationManager.AppSettings["PLC_PARITY"]);

        //        int dataBits =
        //            Convert.ToInt32(
        //                ConfigurationManager.AppSettings["PLC_DATABITS"]);

        //        StopBits stopBits =
        //            (StopBits)Enum.Parse(
        //                typeof(StopBits),
        //                ConfigurationManager.AppSettings["PLC_STOPBITS"]);

        //        port = new SerialPort
        //        {
        //            PortName = comPort,
        //            BaudRate = baudRate,
        //            Parity = parity,
        //            DataBits = dataBits,
        //            StopBits = stopBits,
        //            Encoding = Encoding.ASCII,
        //            ReadTimeout = 1000,
        //            WriteTimeout = 1000000000
        //        };

        //        port.Open();

        //       // blCommon.ShowMessage("", 1);

        //    }
        //    catch (Exception ex)
        //    {
        //        PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
        //        blCommon.ShowMessage(ex.Message, 3);

        //    }
        //}



        private async Task SendNGSignal()
        {
            try
            {
                // --- Modbus TCP Configuration ---
                string ipAddress = ConfigurationManager.AppSettings["PLC_IP"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PLC_PORT"]);
                byte slaveId = 1;
                ushort coilAddress = Convert.ToUInt16(ConfigurationManager.AppSettings["PLC_NGADDRESS"]); ; // 0-based address for ModScan's 2049
                bool value = true;         // Turn coil ON

                // We wrap the network communication in Task.Run to keep the UI thread responsive,
                // just like your original Task.Run(() => port.Write(cmdOn));
                await Task.Run(() =>
                {
                    // Initialize the TCP connection
                    using (TcpClient client = new TcpClient(ipAddress, port))
                    {
                        // Create the Modbus TCP Master instance
                        ModbusIpMaster modbus = ModbusIpMaster.CreateIp(client);

                        // Send the Write Single Coil command (Function Code 05)
                        modbus.WriteSingleCoil(slaveId, coilAddress, value);

                        // WriteLog("SEND -> Modbus TCP Write Success to Coil 2051");
                    }
                });
            }
            catch (Exception ex)
            {
                // Maintained your existing error handling structure
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        private async Task SendOKSignal()
        {
            try
            {
                // --- Modbus TCP Configuration ---
                string ipAddress = ConfigurationManager.AppSettings["PLC_IP"];
                int port = Convert.ToInt32(ConfigurationManager.AppSettings["PLC_PORT"]);
                byte slaveId = 1;
                ushort coilAddress = Convert.ToUInt16(ConfigurationManager.AppSettings["PLC_OKADDRESS"]); ; // 0-based address for ModScan's 2049
                bool value = true;         // Turn coil ON

                // Execute network communication on a background thread
                await Task.Run(() =>
                {
                    // Initialize the TCP connection
                    using (TcpClient client = new TcpClient(ipAddress, port))
                    {
                        // Create the Modbus TCP Master instance
                        ModbusIpMaster modbus = ModbusIpMaster.CreateIp(client);

                        // Send the Write Single Coil command (Function Code 05)
                        modbus.WriteSingleCoil(slaveId, coilAddress, value);

                        // WriteLog("SEND -> Modbus TCP Write Success to Coil 2049 (OK Signal)");
                    }
                });
            }
            catch (Exception ex)
            {
                // Maintain existing error handling
                PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
                blCommon.ShowMessage(ex.Message, 3);
            }
        }

        /// <summary>
        /// OLD FUNCTIONS ON COM PORT
        /// </summary>
        /// <returns></returns>
        //private async Task SendNGSignal()
        //{
        //    try
        //    {
        //        if (port == null || !port.IsOpen)
        //        {
        //            //WriteLog("PLC Port Not Open");
        //            return;
        //        }

        //        string cmdOn = ":01050800FF00F3\r\n";

        //        // WriteLog("SEND -> " + cmdOn.Trim());

        //        await Task.Run(() => port.Write(cmdOn));


        //    }
        //    catch (Exception ex)
        //    {
        //        PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
        //        blCommon.ShowMessage(ex.Message, 3);
        //    }
        //}

        //private async Task SendOKSignal()
        //{
        //    try
        //    {
        //        if (port == null || !port.IsOpen)
        //        {
        //            //WriteLog("PLC Port Not Open");
        //            return;
        //        }

        //        string cmdOn = ":01050802FF00F1\r\n";

        //        // WriteLog("SEND -> " + cmdOn.Trim());

        //        await Task.Run(() => port.Write(cmdOn));


        //    }
        //    catch (Exception ex)
        //    {
        //        PCommon.mAppLog.WriteLog(ex.Message, DTPLLogsWrite.LogType.Error, MethodBase.GetCurrentMethod());
        //        blCommon.ShowMessage(ex.Message, 3);
        //    }
        //}






        private void ItemValidatation_Load(
            object sender,
            EventArgs e)
        {
            TxtInspection.Text = "0";
            TotalOK.Text = "0";
            TxtNg.Text = "0";
            txtReadFailed.Text = "0";
            PanelStart.Visible = false;
            PanelStop.Visible = false;
            Stop.Enabled = false;
            Stop.BackColor = Color.Gray;
            cmbShift.Enabled = true;
            //ConnectPLC();



             this.WindowState = FormWindowState.Maximized;
            try
            {

                BindCountry();

                txtScannerIP.Text =
                    ConfigurationManager.AppSettings["ScannerIP"];

                txtScannerPort.Text =
                    ConfigurationManager.AppSettings["ScannerDataPort"];
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        void DisconnectScanner()
        {
            try
            {
                if (objBin != null && objBin.IsConnected)
                {
                    // EVENT REMOVE
                    objBin.DataArrived -= objBin_DataArrived;

                    objBin = null;


                    // Garbage collector force
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    // blCommon.ShowMessage("Socket Disconnected Successfully.", 1);
                }
                else
                {
                    //blCommon.ShowMessage("Socket Already Disconnected.", 1);
                }
            }
            catch (Exception ex)
            {
                blCommon.ShowMessage("Socket Disconnect Failed.", 1);
                LogError(ex);
            }
        }

        // ================= RECEIVE CONNECTION =================
        void FMSConnection()
        {
            try
            {
                ScannerIP =
                    ConfigurationManager.AppSettings["ScannerIP"];

                string dataPort =
                    ConfigurationManager.AppSettings["ScannerDataPort"];

                if (string.IsNullOrWhiteSpace(ScannerIP))
                {
                    MessageBox.Show("Scanner IP Missing");
                    return;
                }

                if (!int.TryParse(dataPort, out ScannerDataPort))
                {
                    MessageBox.Show("Invalid Scanner Data Port");
                    return;
                }

                objBin.IPAddress = ScannerIP;

                objBin.Port = ScannerDataPort;

                // REMOVE OLD EVENT
                objBin.DataArrived -= objBin_DataArrived;

                // ADD EVENT
                objBin.DataArrived += objBin_DataArrived;

                if (!objBin.IsConnected)
                {
                    objBin.Poll = true;

                    objBin.Open();

                    // CHECK CONNECTION STATUS
                    if (objBin.IsConnected)
                    {
                        //blCommon.ShowMessage("Socket Connected Successfully.", 1);
                    }
                    else
                    {
                        //  blCommon.ShowMessage("Socket Connection Failed.", 1);
                    }
                }
                else
                {
                    // blCommon.ShowMessage("Socket Already Connected.", 1);
                }
            }
            catch (Exception ex)
            {
                blCommon.ShowMessage("Socket Connection Failed.", 1);
                LogError(ex);
            }
        }

        // ================= GET LAST DATA =================
        void GetLastData()
        {
            try
            {
                if (cmbPartCode.SelectedIndex > 0)
                {
                    DataTable response =
                        objOperation.GetLastData(
                            cmbPartCode.Text);

                    if (response != null &&
                        response.Rows.Count > 0)
                    {
                        TxtInspection.Text =
                            response.Rows[0][0].ToString();

                        TotalOK.Text =
                            response.Rows[0][1].ToString();

                        TxtNg.Text =
                            response.Rows[0][2].ToString();

                        txtReadFailed.Text =
                            response.Rows[0][3].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= DATA RECEIVE =================
        private void objBin_DataArrived(string ClientIP, string Message)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Message))
                {
                    string msg = Message.Trim().ToLower();

                    if (msg.Contains("command:loadjob") && msg.Contains("ok"))
                        return;
                    btnstatus.Text = "Status";
                    btnstatus.BackColor = Color.Green;
                }

                if (this == null || this.IsDisposed || !this.IsHandleCreated)
                    return;

                this.BeginInvoke((MethodInvoker)delegate
                {
                    if (!lvdata.IsHandleCreated)
                        return;
                    string status = "";
                    string statusReason = "";

                    string barcodeValue = "";
                    string leftCircle = "";
                    string topCircle = "";
                    string rightCircle = "";
                    string IsLightPart = "";

                    string selectedModel =
                        cmbPartCode.Text.Trim().Replace(" ", "");

                    // ================= NO READ =================
                    if (string.IsNullOrWhiteSpace(Message))
                    {
                        status = "NOREAD";
                        statusReason = "Scanner Message Empty";
                    }
                    else
                    {

                        string[] data = Message.Split(',');

                        foreach (string item in data)
                        {
                            if (item.Contains("BarcodeValue:"))
                                barcodeValue =
                                    item.Replace("BarcodeValue:", "").Trim();

                            else if (item.Contains("LeftCircleResult:"))
                                leftCircle =
                                    item.Replace("LeftCircleResult:", "")
                                    .Trim()
                                    .ToLower();

                            else if (item.Contains("TopRightCircleResult:"))
                                topCircle =
                                    item.Replace("TopRightCircleResult:", "")
                                    .Trim()
                                    .ToLower();

                            else if (item.Contains("IsLightPart:"))
                                IsLightPart =
                                    item.Replace("IsLightPart:", "")
                                    .Trim()
                                    .ToLower();

                            else if (item.Contains("RightCircleResult:"))
                                rightCircle =
                                    item.Replace("RightCircleResult:", "")
                                    .Trim()
                                    .ToLower();
                        }

                        // ================= BARCODE FAIL =================
                        if (string.IsNullOrWhiteSpace(barcodeValue))
                        {
                            status = "NOREAD";
                            statusReason = "Barcode Missing, बारकोड गायब है";

                        }
                        else
                        {
                            DataTable dtDuplicate =
                         objOperation.CheckDuplicateSerial(barcodeValue);

                            if (dtDuplicate != null &&
                                dtDuplicate.Rows.Count > 0)
                            {
                                string result =
                                    dtDuplicate.Rows[0][0]
                                    .ToString()
                                    .Trim();

                                // Duplicate mila
                                if (result.StartsWith("ERROR"))
                                {
                                    status = "DUPLICATE";
                                    statusReason =
                                        "Duplicate Serial No Found";
                                }


                            }


                            // ================= MODEL VALIDATION =================
                            if (string.IsNullOrEmpty(status))
                            {
                                bool ok = false;

                                string expected = "";

                                // ================= MODEL RULES =================
                                if (selectedModel == "BLACKBS4WITHASV" || selectedModel == "BS4BLACKWITHASV")
                                {
                                    expected =
                                        "L=true, T=false, R=true, IsLightPart =false";

                                    if (leftCircle == "true" &&
                                        topCircle == "false" &&
                                        rightCircle == "true" && IsLightPart == "false")
                                    {
                                        ok = true;
                                    }
                                }

                                else if ((selectedModel == "SILVERBS4WITHASV" || selectedModel == "BS4SILVERWITHASV") && txtSlotNo.Text == "3")
                                {
                                    expected =
                                    //"L=true, T=false, IsLightPart =true";
                                    "L=true, T=false, R=true, IsLightPart =true";

                                    if (leftCircle == "true" &&
                                        topCircle == "false" &&
                                        rightCircle == "true" && IsLightPart == "true")
                                    {
                                        ok = true;
                                    }
                                }
                                else if (selectedModel == "BLACKBS4NONASV" || selectedModel == "BS4BLACKNONASV")
                                {
                                    expected =
                                        "L=true, T=false, R=false,IsLightPart =false";

                                    if (leftCircle == "true" &&
                                        topCircle == "false" &&
                                        rightCircle == "false" && IsLightPart == "false")
                                    {
                                        ok = true;
                                    }
                                }

                                else if (
                                         (selectedModel == "BS4SILVERNONASV" ||
                                          selectedModel == "SILVERBS4NONASV")
                                                &&
                                           txtSlotNo.Text == "3"
                                          )
                                {
                                    expected =
                                    //"L=true, T=false, IsLightPart=true";
                                    "L=true, T=false, R=false, IsLightPart=true";

                                    if (leftCircle == "true" &&
                                        topCircle == "false" &&
                                        rightCircle == "false" &&
                                        IsLightPart == "true")
                                    {
                                        ok = true;
                                    }
                                }

                                else if (selectedModel == "ACKBLACKBS6")
                                {
                                    expected =
                                        "L=true, T=true, R=false,IsLightPart =false";

                                    if (leftCircle == "true" &&
                                        topCircle == "true" &&
                                        rightCircle == "false" && IsLightPart == "false")
                                    {
                                        ok = true;
                                    }
                                }

                                else if (selectedModel == "ACKSILVERBS6" && txtSlotNo.Text == "3")
                                {
                                    expected =
                                    //"L=true, T=true,IsLightPart =true";
                                    "L=true, T=true,R=false,IsLightPart =true";

                                    if (leftCircle == "true" &&
                                        topCircle == "true" &&
                                        rightCircle == "false" && IsLightPart == "true")
                                    {
                                        ok = true;
                                    }
                                }
                                //else if (selectedModel == "BS4BlackCasting")
                                //{
                                //    expected =
                                //        "L=false, T=false, R=false,IsLightPart =false";

                                //    if (leftCircle == "false" &&
                                //        topCircle == "false" &&
                                //        rightCircle == "false" && IsLightPart == "false")
                                //    {
                                //        ok = true;
                                //    }
                                //}

                                //else if (selectedModel == "ACKSilverBS6" && txtSlotNo.Text.Trim() == "3")
                                //{
                                //    expected =
                                //        "L=true, T=false , IsLightPart = true";

                                //    if (leftCircle == "true" &&
                                //        topCircle == "false"
                                //     && IsLightPart == "true")
                                //    {
                                //        ok = true;
                                //    }
                                //}

                                //else if (selectedModel == "BS4SilverNonAsv" && txtSlotNo.Text.Trim() == "3")
                                //{
                                //    expected =
                                //        "L=true, T=true,IsLightPart =true";

                                //    if (leftCircle == "true" &&
                                //        topCircle == "true"
                                //     && IsLightPart == "true")
                                //    {
                                //        ok = true;
                                //    }
                                //}
                                else
                                {
                                    status = "NG";
                                    //statusReason =
                                    //    "Invalid Model Selected";
                                }

                                // ================= RESULT =================
                                if (string.IsNullOrEmpty(status))
                                {
                                    if (ok)
                                    {
                                        status = "OK";
                                        statusReason = "PASS,(ठीक है।)";
                                    }
                                    else
                                    {
                                        status = "NG";

                                        // ================= AUTO FAIL REASON =================
                                        List<string> failed =
                                            new List<string>();

                                        if (selectedModel == "ACKBLACKBS6" ||
                                            selectedModel == "BLACKBS4NONASV" ||
                                            selectedModel == "BLACKBS4WITHASV" ||
                                            selectedModel == "BS4BLACKNONASV" ||
                                            selectedModel == "BS4BLACKWITHASV")

                                        {
                                            if (IsLightPart != expected.Split(',')[3].Split('=')[1].Trim())
                                                failed.Add("IsLightPart,(लाइट पार्ट मेल नहीं खा रहा)");

                                            if (leftCircle != expected.Split(',')[0].Split('=')[1].Trim())
                                                failed.Add("LeftCircle,(लेफ्ट सर्कल मेल नहीं खा रहा)");

                                            if (topCircle != expected.Split(',')[1].Split('=')[1].Trim())
                                                failed.Add("TopCircle,(टॉप सर्कल मेल नहीं खा रहा)");

                                            if (rightCircle != expected.Split(',')[2].Split('=')[1].Trim())
                                                failed.Add("RightCircle,(राइट सर्कल मेल नहीं खा रहा)");
                                            statusReason =
                                           "FAIL - " +
                                           (failed.Count > 0
                                               ? string.Join(" + ", failed)
                                               : "Unknown");
                                        }
                                        if (selectedModel == "ACKSILVERBS6" ||
                                             selectedModel == "BS4SILVERNONASV" ||
                                             selectedModel == "BS4SILVERWITHASV" ||
                                               selectedModel == "SILVERBS4NONASV" ||
                                                selectedModel == "SILVERBS4WITHASV")

                                        {
                                            if (IsLightPart != expected.Split(',')[2].Split('=')[1].Trim())
                                                failed.Add("IsLightPart,(लाइट पार्ट मेल नहीं खा रहा)");

                                            if (leftCircle != expected.Split(',')[0].Split('=')[1].Trim())
                                                failed.Add("LeftCircle,(लेफ्ट सर्कल मेल नहीं खा रहा)");

                                            if (topCircle != expected.Split(',')[1].Split('=')[1].Trim())
                                                failed.Add("TopCircle,(टॉप सर्कल मेल नहीं खा रहा)");
                                            if (rightCircle != expected.Split(',')[2].Split('=')[1].Trim())
                                                failed.Add("RightCircle,(राइट सर्कल मेल नहीं खा रहा)");



                                            statusReason =
                                          "FAIL - " +
                                          (failed.Count > 0
                                              ? string.Join(" + ", failed)
                                              : "Unknown");
                                        }




                                    }
                                }
                            }
                        }

                    }
                   
                

                    // ================= COUNTS =================
                    if (status == "OK" || status == "NG")
                    {
                        TxtInspection.Text =
                            (GetInt(TxtInspection.Text) + 1).ToString();
                    }

                    if (status == "OK")
                    {
                        TotalOK.Text =
                            (GetInt(TotalOK.Text) + 1).ToString();
                        btnstatus.Text = "OK PART, पार्ट मेल  खा रहा है ";
                        _ = SendOKSignal();
                      
                    }
                    //else if (statusReason == "Duplicate Serial No Found" && status == "NG")

                    //{
                    //    TxtNg.Text =
                    //        (GetInt(TxtNg.Text) + 1).ToString();
                    //    btnstatus.Text = "Duplicate  Found,डुप्लीकेट आ रहा है";
                    //    btnstatus.BackColor = Color.Red;
                    //    _ = SendNGSignal();
                      

                    //}

                    else if (status == "DUPLICATE")

                    {
                        //txtReadFailed.Text =
                        //   (GetInt(txtReadFailed.Text) + 1).ToString();

                        TxttDuplicate.Text =
                        (GetInt(TxttDuplicate.Text) + 1).ToString();
                        //TxtNg.Text =
                        //    (GetInt(TxtNg.Text) + 1).ToString();
                        TxtInspection.Text =
                            (GetInt(TxtInspection.Text) + 1).ToString();
                        btnstatus.Text = "Duplicate  Found,डुप्लीकेट आ रहा है";
                        btnstatus.BackColor = Color.Red;
                        _ = SendNGSignal();


                    }

                    else if (status == "NG")
                    {
                        TxtNg.Text =
                            (GetInt(TxtNg.Text) + 1).ToString();
                        btnstatus.Text = "NG PART";
                        btnstatus.BackColor = Color.Red;
                        _ = SendNGSignal();


                    }
                    else if (status == "NOREAD")
                    {
                        txtReadFailed.Text =
                            (GetInt(txtReadFailed.Text) + 1).ToString();
                        //TxtNg.Text =
                        //    (GetInt(TxtNg.Text) + 1).ToString();
                        TxtInspection.Text =
                            (GetInt(TxtInspection.Text) + 1).ToString();
                        btnstatus.Text = "NOREAD  PART,(कैमरा इसे पढ़ नहीं पा रहा है)";
                        btnstatus.BackColor = Color.Red;
                        _ = SendNGSignal();


                    }

                    //// ================= LISTVIEW =================

                    //// Max 20 rows rakhni ho to
                    ////if (lvdata.Items.Count >= 20)
                    ////    lvdata.Items.RemoveAt(lvdata.Items.Count - 1);

                    //ListViewItem itemRow =
                    //    new ListViewItem(barcodeValue);

                    //itemRow.SubItems.Add(
                    //    DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

                    //itemRow.SubItems.Add(statusReason);

                    //// Latest row top pe add hogi
                    //lvdata.Items.Insert(0, itemRow);

                    //// Top row visible rahegi
                    //lvdata.EnsureVisible(0);

                    // ================= LISTVIEW =================

                    // Sorting disable
                    lvdata.ListViewItemSorter = null;
                    lvdata.Sorting = SortOrder.None;

                    // Max 20 rows rakhni ho to
                    //if (lvdata.Items.Count >= 20)
                    //    lvdata.Items.RemoveAt(lvdata.Items.Count - 1);

                    ListViewItem itemRow =
                        new ListViewItem(barcodeValue);

                    itemRow.SubItems.Add(
                        DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));

                    itemRow.SubItems.Add(statusReason);

                    // Hamesha top pe add hoga
                    lvdata.Items.Insert(0, itemRow);

                    // Top visible rahega
                    lvdata.EnsureVisible(0);

                    // ================= SAVE =================
                    if (cmbPartCode.SelectedValue != null )
                    {
                        objOperation.SaveData(
                            cmbPartCode.Text,
                            barcodeValue,
                            status,
                            statusReason,
                           cmbShift.Text);
                    }
                });
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= SEND COMMAND =================
        private void SendScannerCommand()
        {
            try
            {
                // CONDITION
                //      if (cmbPartCode.Text.Trim().ToUpper() != "MODEL1"
                //          && txtSlotNo.Text.Trim() != "2")
                //      {
                //          return;
                //      }
                //      if (cmbPartCode.Text.Trim().ToUpper() != "MODEL2"
                //        && txtSlotNo.Text.Trim() != "2")
                //      {
                //          return;
                //      }
                //      if (cmbPartCode.Text.Trim().ToUpper() != "MODEL3"
                //      && txtSlotNo.Text.Trim() != "2")
                //      {
                //          return;
                //      }
                //  if (cmbPartCode.Text.Trim().ToUpper() != "MODEL4"
                //&& txtSlotNo.Text.Trim() != "2")
                //  {
                //      return;
                //  }

                //      if (cmbPartCode.Text.Trim().ToUpper() != "MODEL5"
                //  && txtSlotNo.Text.Trim() != "3")
                //      {
                //          return;
                //      }

                //      if (cmbPartCode.Text.Trim().ToUpper() != "MODEL6"
                //&& txtSlotNo.Text.Trim() != "3")
                //      {
                //          return;
                //      }

                string scannerIP =
                    ConfigurationManager.AppSettings["ScannerIP"];

                string commandPort =
                    ConfigurationManager.AppSettings["ScannerCommandPort"];

                if (string.IsNullOrWhiteSpace(scannerIP))
                {
                    MessageBox.Show("Scanner IP Missing");
                    return;
                }

                if (!int.TryParse(
                    commandPort,
                    out ScannerCommandPort))
                {
                    MessageBox.Show(
                        "Invalid Scanner Command Port");

                    return;
                }

                using (TcpClient client = new TcpClient())
                {
                    client.Connect(
                        scannerIP,
                        ScannerCommandPort);

                    NetworkStream stream =
                        client.GetStream();

                    stream.ReadTimeout = 5000;

                    // LOOP UNTIL SUCCESS
                    while (true)
                    {
                        // COMMAND
                        string command =
                            "loadjob " +
                            txtSlotNo.Text.Trim() +
                            "\r\n";

                        byte[] data =
                            Encoding.ASCII.GetBytes(command);

                        stream.Write(data, 0, data.Length);

                        stream.Flush();

                        // WAIT
                        Thread.Sleep(500);

                        // RESPONSE
                        byte[] buffer = new byte[1024];

                        int bytesRead =
                            stream.Read(
                                buffer,
                                0,
                                buffer.Length);

                        string response =
                            Encoding.ASCII.GetString(
                                buffer,
                                0,
                                bytesRead);

                        response =
                            response.Trim().ToLower();

                        // SUCCESS
                        if (response.Contains("ok"))
                        {
                            TxtStatus.BackColor =
                                Color.GreenYellow;
                            blCommon.ShowMessage("Job Loaded Successfuly.", 1);

                            break;
                        }

                        // FAILED
                        else
                        {
                            TxtStatus.BackColor =
                                Color.Red;
                            blCommon.ShowMessage("Job Loaded Failed.", 1);

                            Thread.Sleep(1000);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TxtStatus.BackColor = Color.Red;

                LogError(ex);
            }
        }

        // ================= PRODUCT BIND =================
        private void BindProductCode()
        {
            try
            {
                cmbPartCode.DataSource = null;
                cmbPartCode.Text = "";
                DataTable dt =
                    objOperation.dtBindProduct(cmbCountry.Text);

                // Pehle old data clear karo


                if (dt != null && dt.Rows.Count > 0)
                {
                    blCommon.FillComboBox(
                        cmbPartCode,
                        dt,
                        true);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        private void BindCountry()
        {
            try
            {
                DataTable dt =
                    objOperation.dtBindCountry();

                if (dt.Rows.Count > 0)
                {
                    blCommon.FillComboBox(
                        cmbCountry,
                        dt,
                        true);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= SLOT BIND =================
        private void bindSlotNo()
        {
            try
            {
                DataTable dt =
                    objOperation.dtBindSlotNo(
                        cmbPartCode.SelectedValue.ToString());

                if (dt.Rows.Count > 0)
                {
                    txtSlotNo.Text =
                        dt.Rows[0]["SlotNo"].ToString();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= PART CHANGE =================
        private void cmbPartCode_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbPartCode.SelectedIndex > 0 &&
                    cmbPartCode.SelectedValue != null)
                {
                    bindSlotNo();
                    //txtSlotNo.Text = cmbPartCode.SelectedValue.ToString();

                    // GetLastData();

                    // SEND JOB COMMAND
                    SendScannerCommand();

                    // START SCANNER

                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= SAFE INT =================
        private int GetInt(string value)
        {
            int.TryParse(value, out int result);

            return result;
        }

        // ================= FORM CLOSE =================
        private void ItemValidatation_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = false;

                Application.Exit();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        // ================= LOG =================
        private void LogError(Exception ex)
        {
            PCommon.mAppLog.WriteLog(
                ex.Message,
                DTPLLogsWrite.LogType.Error,
                MethodBase.GetCurrentMethod());

            blCommon.ShowMessage(ex.Message, 3);
        }

        // ================= CLOSE BUTTON =================
        //private void button1_Click(
        //    object sender,
        //    EventArgs e)
        //{
        //    this.Close();
        //}

        private void txtSlotNo_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelStop.Visible = true;
            TxttUserId.Text = string.Empty;
            TxttPassword.Text = string.Empty;
            TxttUserId.Focus();

            //DialogResult dr = MessageBox.Show("are You Sure You Want to Stop", blCommon.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //if (dr == DialogResult.Yes)
            //{
            //    PanelStop.Visible = true;
            //    TxttUserId.Text = string.Empty;
            //    TxttPassword.Text = string.Empty;
            //    TxttUserId.Focus();
            //}
            //else
            //{
            //    blCommon.ShowMessage("Please select yes ", 1);
            //    return;
            //}


            //TxtInspection.Text = "0";
            //TotalOK.Text = "0";
            //TxtNg.Text = "0";
            //txtReadFailed.Text = "0";
            //// lvdata.Clear();
            //blCommon.ShowMessage("All Data Reset Successfully.", 1);




        }

        private void Start_Click(object sender, EventArgs e)
        {
            //if(cmbShift.Text =="")
            //{
            //    blCommon.ShowMessage("Please select shift ", 1);
            //     return;
            //}
            PanelStart.Visible = true;
            TxUserID.Text = string.Empty;
            TxPassword.Text = string.Empty;
            TxUserID.Focus();

            

            //DialogResult dr = MessageBox.Show("are You Sure You Want to Start", blCommon.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            //if (dr == DialogResult.Yes)
            //{
            //    PanelStart.Visible = true;
            //    TxUserID.Text = string.Empty;
            //    TxPassword.Text = string.Empty;
            //    TxUserID.Focus();
            //}
            //else
            //{
            //    blCommon.ShowMessage("Please select yes ", 1);
            //    return;
            //}

        }

        private void grpScanner_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = objOperation.dtGetStart(
                TxUserID.Text,
                TxPassword.Text,
                "StartProcess"
            );

            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Columns.Contains("Msg"))
                {
                    string msg = dt.Rows[0]["Msg"].ToString();

                    if (msg.StartsWith("ERROR"))
                    {
                        blCommon.ShowMessage(msg.Replace("ERROR~", ""), 1);
                        return;
                    }
                    else if (msg.StartsWith("SUCCESS"))
                    {
                        FMSConnection();

                        Start.Enabled = false;
                        Start.BackColor = Color.Gray;
                        txtSlotNo.Enabled = false;

                        TotalOK.Text = "0";
                        TxtNg.Text = "0";
                        txtReadFailed.Text = "0";
                        txtSlotNo.Enabled = false;
                        Stop.Enabled = true;
                        Stop.BackColor = Color.Red;

                        cmbPartCode.Enabled = false;
                        FMSConnection();
                        PanelStart.Hide();


                        blCommon.ShowMessage("Started Successfully.", 1);
                    }
                }
                else
                {
                    blCommon.ShowMessage("Please Enter Valid Details.", 1);
                    return;
                }
                TxUserID.Clear();
                TxPassword.Clear();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = objOperation.dtGetStop(
                TxttUserId.Text,
                TxttPassword.Text,
                "StopProcess"
            );

            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Columns.Contains("Msg"))
                {
                    string msg = dt.Rows[0]["Msg"].ToString();

                    if (msg.StartsWith("ERROR"))
                    {
                        blCommon.ShowMessage(
                            msg.Replace("ERROR~", ""),
                            1
                        );
                        return;
                    }
                    else if (msg.StartsWith("SUCCESS"))
                    {
                        //DisconnectScanner();

                        TxtInspection.Text = "0";
                        TotalOK.Text = "0";
                        TxtNg.Text = "0";
                        txtReadFailed.Text = "0";

                        lvdata.Items.Clear();

                        Start.Enabled = true;
                        Start.BackColor = Color.Green;

                        Stop.Enabled = false;
                        Stop.BackColor = Color.Gray;

                        txtSlotNo.Enabled = true;
                        cmbPartCode.Enabled = true;
                        PanelStop.Hide();

                        blCommon.ShowMessage(
                            "All Data Reset Successfully.",
                            1
                        );
                    }
                }
                else
                {
                    blCommon.ShowMessage(
                        "Please Enter Valid Details.",
                        1
                    );
                    return;
                }

                TxttUserId.Clear();
                TxttPassword.Clear();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindProductCode();
        }
    }
}