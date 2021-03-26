
namespace Bai2
{
    partial class employeeDetail
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
            this.emloyeeDetailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dateOfJoiningLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.eduListBox = new System.Windows.Forms.ListBox();
            this.dateJoinTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emloyeeDetailLabel
            // 
            this.emloyeeDetailLabel.AutoSize = true;
            this.emloyeeDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.emloyeeDetailLabel.Location = new System.Drawing.Point(76, 40);
            this.emloyeeDetailLabel.Name = "emloyeeDetailLabel";
            this.emloyeeDetailLabel.Size = new System.Drawing.Size(356, 52);
            this.emloyeeDetailLabel.TabIndex = 0;
            this.emloyeeDetailLabel.Text = "Employee Detail";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(52, 133);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Employee Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(52, 201);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(123, 17);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Empoyee Address";
            // 
            // dateOfJoiningLabel
            // 
            this.dateOfJoiningLabel.AutoSize = true;
            this.dateOfJoiningLabel.Location = new System.Drawing.Point(52, 277);
            this.dateOfJoiningLabel.Name = "dateOfJoiningLabel";
            this.dateOfJoiningLabel.Size = new System.Drawing.Size(103, 17);
            this.dateOfJoiningLabel.TabIndex = 3;
            this.dateOfJoiningLabel.Text = "Date of Joining";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(52, 347);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(71, 17);
            this.educationLabel.TabIndex = 4;
            this.educationLabel.Text = "Education";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(52, 410);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(82, 17);
            this.departmentLabel.TabIndex = 5;
            this.departmentLabel.Text = "Department";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(193, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(193, 201);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(188, 22);
            this.addressTextBox.TabIndex = 7;
            // 
            // eduListBox
            // 
            this.eduListBox.FormattingEnabled = true;
            this.eduListBox.ItemHeight = 16;
            this.eduListBox.Items.AddRange(new object[] {
            "UnderGraduate",
            "PostGraduate"});
            this.eduListBox.Location = new System.Drawing.Point(193, 347);
            this.eduListBox.Name = "eduListBox";
            this.eduListBox.Size = new System.Drawing.Size(188, 36);
            this.eduListBox.TabIndex = 9;
            // 
            // dateJoinTextBox
            // 
            this.dateJoinTextBox.Location = new System.Drawing.Point(193, 274);
            this.dateJoinTextBox.Name = "dateJoinTextBox";
            this.dateJoinTextBox.Size = new System.Drawing.Size(188, 22);
            this.dateJoinTextBox.TabIndex = 8;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "Human Resource",
            "Marketing",
            "R&D"});
            this.departmentComboBox.Location = new System.Drawing.Point(193, 410);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(188, 24);
            this.departmentComboBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(55, 485);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(193, 485);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(336, 485);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 564);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.dateJoinTextBox);
            this.Controls.Add(this.eduListBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.dateOfJoiningLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.emloyeeDetailLabel);
            this.Name = "employeeDetail";
            this.Text = "employeeDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emloyeeDetailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dateOfJoiningLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ListBox eduListBox;
        private System.Windows.Forms.TextBox dateJoinTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}