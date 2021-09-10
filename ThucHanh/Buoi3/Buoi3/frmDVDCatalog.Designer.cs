
namespace Buoi3
{
    partial class frmDVDCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDVDCodeNo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDong = new System.Windows.Forms.Label();
            this.txtCodeNo = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.updPrice = new System.Windows.Forms.NumericUpDown();
            this.grpSubtitles = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbDVDCodeNumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).BeginInit();
            this.grpSubtitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.lblHeading.Location = new System.Drawing.Point(133, 7);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(311, 67);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "DVD Catalog";
            // 
            // lblDVDCodeNo
            // 
            this.lblDVDCodeNo.AutoSize = true;
            this.lblDVDCodeNo.Location = new System.Drawing.Point(61, 85);
            this.lblDVDCodeNo.Name = "lblDVDCodeNo";
            this.lblDVDCodeNo.Size = new System.Drawing.Size(128, 17);
            this.lblDVDCodeNo.TabIndex = 1;
            this.lblDVDCodeNo.Text = "DVD Code Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(61, 127);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "DVD Title";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(61, 169);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(72, 17);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "Language";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(61, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblDong
            // 
            this.lblDong.AutoSize = true;
            this.lblDong.Location = new System.Drawing.Point(360, 218);
            this.lblDong.Name = "lblDong";
            this.lblDong.Size = new System.Drawing.Size(37, 17);
            this.lblDong.TabIndex = 5;
            this.lblDong.Text = "VND";
            // 
            // txtCodeNo
            // 
            this.txtCodeNo.Location = new System.Drawing.Point(204, 85);
            this.txtCodeNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeNo.Name = "txtCodeNo";
            this.txtCodeNo.ReadOnly = true;
            this.txtCodeNo.Size = new System.Drawing.Size(318, 22);
            this.txtCodeNo.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(204, 127);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(318, 22);
            this.txtTitle.TabIndex = 7;
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "Chinese",
            "Russian",
            "Vietnamese",
            "Korean"});
            this.cboLang.Location = new System.Drawing.Point(204, 169);
            this.cboLang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(318, 24);
            this.cboLang.TabIndex = 8;
            // 
            // updPrice
            // 
            this.updPrice.Location = new System.Drawing.Point(204, 218);
            this.updPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updPrice.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.updPrice.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updPrice.Name = "updPrice";
            this.updPrice.Size = new System.Drawing.Size(150, 22);
            this.updPrice.TabIndex = 9;
            this.updPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // grpSubtitles
            // 
            this.grpSubtitles.Controls.Add(this.radNo);
            this.grpSubtitles.Controls.Add(this.radYes);
            this.grpSubtitles.Location = new System.Drawing.Point(204, 266);
            this.grpSubtitles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSubtitles.Name = "grpSubtitles";
            this.grpSubtitles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSubtitles.Size = new System.Drawing.Size(270, 65);
            this.grpSubtitles.TabIndex = 10;
            this.grpSubtitles.TabStop = false;
            this.grpSubtitles.Text = "Subtitles";
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(147, 32);
            this.radNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 21);
            this.radNo.TabIndex = 1;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Location = new System.Drawing.Point(7, 32);
            this.radYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(53, 21);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 350);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(94, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(357, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(459, 350);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(195, 350);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(276, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDVDCodeNumber
            // 
            this.cmbDVDCodeNumber.FormattingEnabled = true;
            this.cmbDVDCodeNumber.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbDVDCodeNumber.Location = new System.Drawing.Point(204, 81);
            this.cmbDVDCodeNumber.Name = "cmbDVDCodeNumber";
            this.cmbDVDCodeNumber.Size = new System.Drawing.Size(318, 24);
            this.cmbDVDCodeNumber.TabIndex = 17;
            this.cmbDVDCodeNumber.Visible = false;
            this.cmbDVDCodeNumber.SelectedIndexChanged += new System.EventHandler(this.cmbDVDCodeNumber_SelectedIndexChanged);
            // 
            // frmDVDCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 393);
            this.Controls.Add(this.cmbDVDCodeNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpSubtitles);
            this.Controls.Add(this.updPrice);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCodeNo);
            this.Controls.Add(this.lblDong);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDVDCodeNo);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDVDCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD Catalog";
            this.Load += new System.EventHandler(this.frmDVDCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).EndInit();
            this.grpSubtitles.ResumeLayout(false);
            this.grpSubtitles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDVDCodeNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDong;
        private System.Windows.Forms.TextBox txtCodeNo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.NumericUpDown updPrice;
        private System.Windows.Forms.GroupBox grpSubtitles;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbDVDCodeNumber;
    }
}

