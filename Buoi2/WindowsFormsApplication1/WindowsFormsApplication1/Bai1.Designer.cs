namespace WindowsFormsApplication1
{
    partial class Bai1
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
            this.studentName_Label = new System.Windows.Forms.Label();
            this.yearOfBirth_Label = new System.Windows.Forms.Label();
            this.standard_Label = new System.Windows.Forms.Label();
            this.division_Label = new System.Windows.Forms.Label();
            this.hobbies_Label = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboDiv = new System.Windows.Forms.ComboBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstHob = new System.Windows.Forms.CheckedListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName_Label
            // 
            this.studentName_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentName_Label.AutoSize = true;
            this.studentName_Label.Location = new System.Drawing.Point(28, 33);
            this.studentName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentName_Label.Name = "studentName_Label";
            this.studentName_Label.Size = new System.Drawing.Size(98, 17);
            this.studentName_Label.TabIndex = 0;
            this.studentName_Label.Text = "Student Name";
            // 
            // yearOfBirth_Label
            // 
            this.yearOfBirth_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearOfBirth_Label.AutoSize = true;
            this.yearOfBirth_Label.Location = new System.Drawing.Point(28, 91);
            this.yearOfBirth_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearOfBirth_Label.Name = "yearOfBirth_Label";
            this.yearOfBirth_Label.Size = new System.Drawing.Size(86, 17);
            this.yearOfBirth_Label.TabIndex = 1;
            this.yearOfBirth_Label.Text = "Year of birth";
            // 
            // standard_Label
            // 
            this.standard_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standard_Label.AutoSize = true;
            this.standard_Label.Location = new System.Drawing.Point(28, 134);
            this.standard_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.standard_Label.Name = "standard_Label";
            this.standard_Label.Size = new System.Drawing.Size(104, 17);
            this.standard_Label.TabIndex = 2;
            this.standard_Label.Text = "Standard/Class";
            // 
            // division_Label
            // 
            this.division_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.division_Label.AutoSize = true;
            this.division_Label.Location = new System.Drawing.Point(32, 257);
            this.division_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.division_Label.Name = "division_Label";
            this.division_Label.Size = new System.Drawing.Size(57, 17);
            this.division_Label.TabIndex = 3;
            this.division_Label.Text = "Division";
            // 
            // hobbies_Label
            // 
            this.hobbies_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hobbies_Label.AutoSize = true;
            this.hobbies_Label.Location = new System.Drawing.Point(32, 308);
            this.hobbies_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hobbies_Label.Name = "hobbies_Label";
            this.hobbies_Label.Size = new System.Drawing.Size(60, 17);
            this.hobbies_Label.TabIndex = 4;
            this.hobbies_Label.Text = "Hobbies";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(183, 33);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(183, 81);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(159, 22);
            this.txtYear.TabIndex = 6;
            // 
            // cboDiv
            // 
            this.cboDiv.FormattingEnabled = true;
            this.cboDiv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDiv.Location = new System.Drawing.Point(183, 257);
            this.cboDiv.Margin = new System.Windows.Forms.Padding(4);
            this.cboDiv.Name = "cboDiv";
            this.cboDiv.Size = new System.Drawing.Size(160, 24);
            this.cboDiv.TabIndex = 8;
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.lstClass.Location = new System.Drawing.Point(183, 134);
            this.lstClass.Margin = new System.Windows.Forms.Padding(4);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(159, 100);
            this.lstClass.TabIndex = 7;
            // 
            // lstHob
            // 
            this.lstHob.FormattingEnabled = true;
            this.lstHob.Items.AddRange(new object[] {
            "Singing",
            "Dancing",
            "Swimming",
            "Reading",
            "Travelling"});
            this.lstHob.Location = new System.Drawing.Point(183, 308);
            this.lstHob.Margin = new System.Windows.Forms.Padding(4);
            this.lstHob.Name = "lstHob";
            this.lstHob.Size = new System.Drawing.Size(159, 89);
            this.lstHob.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(61, 449);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 28);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm Student Details";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 449);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 492);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstHob);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.cboDiv);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.hobbies_Label);
            this.Controls.Add(this.division_Label);
            this.Controls.Add(this.standard_Label);
            this.Controls.Add(this.studentName_Label);
            this.Controls.Add(this.yearOfBirth_Label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName_Label;
        private System.Windows.Forms.Label yearOfBirth_Label;
        private System.Windows.Forms.Label standard_Label;
        private System.Windows.Forms.Label division_Label;
        private System.Windows.Forms.Label hobbies_Label;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cboDiv;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.CheckedListBox lstHob;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
    }
}

