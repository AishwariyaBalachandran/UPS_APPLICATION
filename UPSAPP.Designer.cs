
namespace UPS_APPLICATION
{
    partial class UPSAPP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvSearchBtn = new System.Windows.Forms.Button();
            this.lvExportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvNameTxt = new System.Windows.Forms.TextBox();
            this.lvDataResultGrid = new System.Windows.Forms.DataGridView();
            this.lvClearGridBtn = new System.Windows.Forms.Button();
            this.saveFileDialogBx = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBarCreate = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lvSavebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvGenderFemaleRdBtn = new System.Windows.Forms.RadioButton();
            this.lvGenderMaleRdBtn = new System.Windows.Forms.RadioButton();
            this.lvStatusTxtBx = new System.Windows.Forms.TextBox();
            this.lvEmailTxtBx = new System.Windows.Forms.TextBox();
            this.lvNameTxtBx = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ProgressBarBackground = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerCreate = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvDataResultGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSearchBtn
            // 
            this.lvSearchBtn.Location = new System.Drawing.Point(339, 47);
            this.lvSearchBtn.Name = "lvSearchBtn";
            this.lvSearchBtn.Size = new System.Drawing.Size(127, 30);
            this.lvSearchBtn.TabIndex = 0;
            this.lvSearchBtn.Text = "Search";
            this.lvSearchBtn.UseVisualStyleBackColor = true;
            this.lvSearchBtn.Click += new System.EventHandler(this.lvSearchBtn_Click);
            // 
            // lvExportBtn
            // 
            this.lvExportBtn.Enabled = false;
            this.lvExportBtn.FlatAppearance.BorderSize = 10;
            this.lvExportBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lvExportBtn.Location = new System.Drawing.Point(857, 601);
            this.lvExportBtn.Name = "lvExportBtn";
            this.lvExportBtn.Size = new System.Drawing.Size(127, 30);
            this.lvExportBtn.TabIndex = 2;
            this.lvExportBtn.Text = "Export";
            this.lvExportBtn.UseVisualStyleBackColor = true;
            this.lvExportBtn.Click += new System.EventHandler(this.lvExportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lvNameTxt);
            this.groupBox1.Controls.Add(this.lvSearchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.errorProvider.SetIconAlignment(this.groupBox1, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(59, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Search";
            // 
            // lvNameTxt
            // 
            this.lvNameTxt.Location = new System.Drawing.Point(85, 51);
            this.lvNameTxt.Name = "lvNameTxt";
            this.lvNameTxt.Size = new System.Drawing.Size(229, 22);
            this.lvNameTxt.TabIndex = 4;
            // 
            // lvDataResultGrid
            // 
            this.lvDataResultGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lvDataResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvDataResultGrid.Location = new System.Drawing.Point(59, 166);
            this.lvDataResultGrid.Name = "lvDataResultGrid";
            this.lvDataResultGrid.RowHeadersWidth = 51;
            this.lvDataResultGrid.RowTemplate.Height = 24;
            this.lvDataResultGrid.Size = new System.Drawing.Size(925, 411);
            this.lvDataResultGrid.TabIndex = 5;
            // 
            // lvClearGridBtn
            // 
            this.lvClearGridBtn.BackColor = System.Drawing.Color.Transparent;
            this.lvClearGridBtn.FlatAppearance.BorderSize = 10;
            this.lvClearGridBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lvClearGridBtn.Location = new System.Drawing.Point(690, 601);
            this.lvClearGridBtn.Name = "lvClearGridBtn";
            this.lvClearGridBtn.Size = new System.Drawing.Size(127, 30);
            this.lvClearGridBtn.TabIndex = 6;
            this.lvClearGridBtn.Text = "Clear Grid";
            this.lvClearGridBtn.UseVisualStyleBackColor = false;
            this.lvClearGridBtn.Click += new System.EventHandler(this.lvClearGridBtn_Click);
            // 
            // saveFileDialogBx
            // 
            this.saveFileDialogBx.CheckFileExists = true;
            this.saveFileDialogBx.InitialDirectory = "@\"C:\\\\\"";
            this.saveFileDialogBx.RestoreDirectory = true;
            this.saveFileDialogBx.Title = "Browse ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 724);
            this.panel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(46, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 680);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.progressBar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lvClearGridBtn);
            this.tabPage2.Controls.Add(this.lvExportBtn);
            this.tabPage2.Controls.Add(this.lvDataResultGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1206, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search User";
            this.tabPage2.ToolTipText = "Search and Export the users list.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(59, 601);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(597, 30);
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1206, 651);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Create User";
            this.tabPage1.ToolTipText = "Create new user";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.progressBarCreate);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lvSavebtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lvGenderFemaleRdBtn);
            this.panel2.Controls.Add(this.lvGenderMaleRdBtn);
            this.panel2.Controls.Add(this.lvStatusTxtBx);
            this.panel2.Controls.Add(this.lvEmailTxtBx);
            this.panel2.Controls.Add(this.lvNameTxtBx);
            this.panel2.Location = new System.Drawing.Point(46, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 544);
            this.panel2.TabIndex = 1;
            // 
            // progressBarCreate
            // 
            this.progressBarCreate.Location = new System.Drawing.Point(54, 222);
            this.progressBarCreate.Name = "progressBarCreate";
            this.progressBarCreate.Size = new System.Drawing.Size(631, 23);
            this.progressBarCreate.TabIndex = 9;
            this.progressBarCreate.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(341, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvSavebtn
            // 
            this.lvSavebtn.BackColor = System.Drawing.Color.White;
            this.lvSavebtn.Location = new System.Drawing.Point(195, 266);
            this.lvSavebtn.Name = "lvSavebtn";
            this.lvSavebtn.Size = new System.Drawing.Size(100, 29);
            this.lvSavebtn.TabIndex = 10;
            this.lvSavebtn.Text = "Save";
            this.lvSavebtn.UseVisualStyleBackColor = false;
            this.lvSavebtn.Click += new System.EventHandler(this.lvSavebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // lvGenderFemaleRdBtn
            // 
            this.lvGenderFemaleRdBtn.AutoSize = true;
            this.lvGenderFemaleRdBtn.Location = new System.Drawing.Point(311, 140);
            this.lvGenderFemaleRdBtn.Name = "lvGenderFemaleRdBtn";
            this.lvGenderFemaleRdBtn.Size = new System.Drawing.Size(75, 21);
            this.lvGenderFemaleRdBtn.TabIndex = 4;
            this.lvGenderFemaleRdBtn.TabStop = true;
            this.lvGenderFemaleRdBtn.Text = "Female";
            this.lvGenderFemaleRdBtn.UseVisualStyleBackColor = true;
            // 
            // lvGenderMaleRdBtn
            // 
            this.lvGenderMaleRdBtn.AutoSize = true;
            this.lvGenderMaleRdBtn.Location = new System.Drawing.Point(195, 140);
            this.lvGenderMaleRdBtn.Name = "lvGenderMaleRdBtn";
            this.lvGenderMaleRdBtn.Size = new System.Drawing.Size(59, 21);
            this.lvGenderMaleRdBtn.TabIndex = 3;
            this.lvGenderMaleRdBtn.TabStop = true;
            this.lvGenderMaleRdBtn.Text = "Male";
            this.lvGenderMaleRdBtn.UseVisualStyleBackColor = true;
            // 
            // lvStatusTxtBx
            // 
            this.lvStatusTxtBx.Location = new System.Drawing.Point(195, 179);
            this.lvStatusTxtBx.Name = "lvStatusTxtBx";
            this.lvStatusTxtBx.Size = new System.Drawing.Size(246, 22);
            this.lvStatusTxtBx.TabIndex = 2;
            // 
            // lvEmailTxtBx
            // 
            this.lvEmailTxtBx.Location = new System.Drawing.Point(195, 97);
            this.lvEmailTxtBx.Name = "lvEmailTxtBx";
            this.lvEmailTxtBx.Size = new System.Drawing.Size(372, 22);
            this.lvEmailTxtBx.TabIndex = 1;
            // 
            // lvNameTxtBx
            // 
            this.lvNameTxtBx.Location = new System.Drawing.Point(195, 43);
            this.lvNameTxtBx.Name = "lvNameTxtBx";
            this.lvNameTxtBx.Size = new System.Drawing.Size(246, 22);
            this.lvNameTxtBx.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ProgressBarBackground
            // 
            this.ProgressBarBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProgressBarBackground_DoWork);
            this.ProgressBarBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProgressBarBackground_ProgressChanged);
            this.ProgressBarBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProgressBarBackground_RunWorkerCompleted);
            // 
            // backgroundWorkerCreate
            // 
            this.backgroundWorkerCreate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProgressBarBackgroundCreate_DoWork);
            this.backgroundWorkerCreate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ProgressBarBackgroundCreate_ProgressChanged);
            this.backgroundWorkerCreate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProgressBarBackgroundCreate_RunWorkerCompleted);
            // 
            // UPSAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 721);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UPSAPP";
            this.Text = "UPS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvDataResultGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lvSearchBtn;
        private System.Windows.Forms.Button lvExportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lvNameTxt;
        private System.Windows.Forms.DataGridView lvDataResultGrid;
        private System.Windows.Forms.Button lvClearGridBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lvSavebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton lvGenderFemaleRdBtn;
        private System.Windows.Forms.RadioButton lvGenderMaleRdBtn;
        private System.Windows.Forms.TextBox lvStatusTxtBx;
        private System.Windows.Forms.TextBox lvEmailTxtBx;
        private System.Windows.Forms.TextBox lvNameTxtBx;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ProgressBar progressBarCreate;
        private System.ComponentModel.BackgroundWorker ProgressBarBackground;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCreate;
    }
}