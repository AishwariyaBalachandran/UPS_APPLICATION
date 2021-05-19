using ClosedXML.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPS_APPLICATION
{
    public partial class UPSAPP : Form
    {
        public UPSAPP()
        {
            InitializeComponent();
        }

        private void lvClearGridBtn_Click(object sender, EventArgs e)
        {
            lvDataResultGrid.DataSource = null;
            if (lvDataResultGrid.Rows.Count < 0)
            {
                lvExportBtn.Enabled = false;
            }

        }

        private void lvExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog lvsaveFileDialog = new SaveFileDialog();

            lvsaveFileDialog.Filter = "excel files (*.xlsx)|*.xlsx";
            lvsaveFileDialog.FilterIndex = 2;
            lvsaveFileDialog.RestoreDirectory = true;
            lvsaveFileDialog.OverwritePrompt = true;
            string lvfileName = "";
            if (lvsaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProgressBarBackground.WorkerReportsProgress = true;
                ProgressBarBackground.RunWorkerAsync();
                lvfileName = lvsaveFileDialog.FileName;
                progressBar.Visible = true;                
                DataTable lvDataTable = new DataTable();

                //Adding the Columns.
                foreach (DataGridViewColumn column in lvDataResultGrid.Columns)
                {
                    lvDataTable.Columns.Add(column.HeaderText, column.ValueType);
                }

                //Adding the Rows.
                foreach (DataGridViewRow row in lvDataResultGrid.Rows)
                {
                    lvDataTable.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        lvDataTable.Rows[lvDataTable.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                using (XLWorkbook lvWorkbook = new XLWorkbook())
                {
                    try
                    {
                        lvWorkbook.Worksheets.Add(lvDataTable, "Customers");
                        lvWorkbook.Worksheet(1).Columns().AdjustToContents();
                        lvWorkbook.SaveAs(lvfileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void lvSearchBtn_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient()) //WebClient  
            {
                var lvData= GetUserResultList(client);
                lvDataResultGrid.DataSource = lvData;
                if (lvDataResultGrid.Rows.Count > 0)
                {
                    lvExportBtn.Enabled = true;
                }
            }
        }

        public List<EmployeeDetail> GetUserResultList(WebClient client)
        {
            client.Headers.Add("Content-Type:application/json"); //Content-Type  
            client.Headers.Add("Accept:application/json");
            var JSONresult = client.DownloadString(ConfigurationManager.AppSettings["APIURL"] + "users?name=" + lvNameTxt.Text); //URI  
            var jsonObject = JObject.Parse(JSONresult.ToString());
            var lvData = JsonConvert.DeserializeObject<List<EmployeeDetail>>(jsonObject["data"].ToString());
            return lvData;
        }

        public void lvSavebtn_Click(object sender, EventArgs e)
        {

            EmployeeDetail lvEmployeeDetail = new EmployeeDetail();
            bool lvValidateInput = validateInputs();
            if (!lvValidateInput)
            {
                progressBarCreate.Visible = true;
                backgroundWorkerCreate.WorkerReportsProgress = true;
                backgroundWorkerCreate.RunWorkerAsync();
                errorProvider.Clear();
                lvEmployeeDetail.name = lvNameTxtBx.Text;
                lvEmployeeDetail.status = lvStatusTxtBx.Text;
                if (lvGenderMaleRdBtn.Checked)
                {
                    lvEmployeeDetail.gender = "Male";
                }
                else if (lvGenderFemaleRdBtn.Checked)
                {
                    lvEmployeeDetail.gender = "Female";
                }
                lvEmployeeDetail.email = lvEmailTxtBx.Text;
                lvEmployeeDetail.created_at = DateTime.Now;
                lvEmployeeDetail.updated_at = DateTime.Now;

                ReturnResponse(lvEmployeeDetail);
            }
        }

        private void SuccessfullCreation(string result)
        {
            JObject lvjObject = JObject.Parse(result.ToString());

            var lvJtoken = lvjObject["data"];
            string message = null;
            foreach (var item in lvJtoken)
            {
                string lvJsondata = Convert.ToString(item);
                if (lvJsondata.Contains("message"))
                {
                    message += lvJsondata.Replace("{", "").Replace("}", "") + " ";
                }
                else
                {
                    message = "Creation Successfull";
                }

            }
            if (message != "")
            {
                progressBarCreate.Visible = false;
                if (message.Equals("Creation Successfull"))
                { 
                    if(MessageBox.Show("Creation Successfull") == System.Windows.Forms.DialogResult.OK){
                        ClearInputs();
                    }

                }
                else
                {
                    if (MessageBox.Show(message.TrimEnd(), "Error Messages", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK)
                    {
                        progressBarCreate.Visible = false;
                    }
                }
               

            }
        }
        public async void ReturnResponse(EmployeeDetail lvEmployeeDetail)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("Authorization", "Bearer " + "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56");
                var fsd = JsonConvert.SerializeObject(lvEmployeeDetail);
                Uri uri = new Uri("https://gorest.co.in/public-api/users/");
                var result = await client.UploadStringTaskAsync(uri, "POST", fsd);
                SuccessfullCreation(result);
            }

        }

        private bool validateInputs()
        {
            bool isValidInput = false;

            if (lvNameTxtBx.Text == "")
            {
                errorProvider.SetError(lvNameTxtBx, "Name cannot be empty");
                isValidInput = true;
            }

            if (lvStatusTxtBx.Text == "")
            {
                errorProvider.SetError(lvStatusTxtBx, "Status cannot be empty");
                isValidInput = true;
            }
            if (lvEmailTxtBx.Text == "")
            {
                errorProvider.SetError(lvEmailTxtBx, "email cannot be empty");
                isValidInput = true;
            }

            return isValidInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            lvNameTxtBx.Clear();
            lvEmailTxtBx.Clear();
            lvStatusTxtBx.Clear();
            lvGenderFemaleRdBtn.Checked = false;
            lvGenderMaleRdBtn.Checked = false;
            return;
        }


        private void ProgressBarBackground_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                ProgressBarBackground.ReportProgress(i);

            }
        }


        private void ProgressBarBackground_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void ProgressBarBackground_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
        }

        private void ProgressBarBackgroundCreate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarCreate.Value = e.ProgressPercentage;
        }
        private void ProgressBarBackgroundCreate_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBarCreate.Visible = false;
        }

        private void ProgressBarBackgroundCreate_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                backgroundWorkerCreate.ReportProgress(i);

            }
        }
    }
}
