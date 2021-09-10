
namespace Bai3
{
    partial class flightReservation
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
            this.flightReservationDetailsLabels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketNumberTextBox = new System.Windows.Forms.TextBox();
            this.PassengerNameTextBox = new System.Windows.Forms.TextBox();
            this.passportNumbertextBox = new System.Windows.Forms.TextBox();
            this.sourcelistBox = new System.Windows.Forms.ListBox();
            this.desListBox = new System.Windows.Forms.ListBox();
            this.flightDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.serviceCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // flightReservationDetailsLabels
            // 
            this.flightReservationDetailsLabels.AutoSize = true;
            this.flightReservationDetailsLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.flightReservationDetailsLabels.Location = new System.Drawing.Point(97, 26);
            this.flightReservationDetailsLabels.Name = "flightReservationDetailsLabels";
            this.flightReservationDetailsLabels.Size = new System.Drawing.Size(202, 20);
            this.flightReservationDetailsLabels.TabIndex = 0;
            this.flightReservationDetailsLabels.Text = "Flight Reservation Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passenger Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Passport Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flight Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Service";
            // 
            // ticketNumberTextBox
            // 
            this.ticketNumberTextBox.Location = new System.Drawing.Point(200, 74);
            this.ticketNumberTextBox.Name = "ticketNumberTextBox";
            this.ticketNumberTextBox.Size = new System.Drawing.Size(214, 22);
            this.ticketNumberTextBox.TabIndex = 9;
            // 
            // PassengerNameTextBox
            // 
            this.PassengerNameTextBox.Location = new System.Drawing.Point(200, 113);
            this.PassengerNameTextBox.Name = "PassengerNameTextBox";
            this.PassengerNameTextBox.Size = new System.Drawing.Size(214, 22);
            this.PassengerNameTextBox.TabIndex = 10;
            // 
            // passportNumbertextBox
            // 
            this.passportNumbertextBox.Location = new System.Drawing.Point(200, 158);
            this.passportNumbertextBox.Name = "passportNumbertextBox";
            this.passportNumbertextBox.Size = new System.Drawing.Size(214, 22);
            this.passportNumbertextBox.TabIndex = 11;
            // 
            // sourcelistBox
            // 
            this.sourcelistBox.FormattingEnabled = true;
            this.sourcelistBox.ItemHeight = 16;
            this.sourcelistBox.Items.AddRange(new object[] {
            "Hanoi",
            "Singapore",
            "Saigon",
            "New York",
            "Tokyo",
            "Bangkok",
            "Paris",
            "London"});
            this.sourcelistBox.Location = new System.Drawing.Point(200, 198);
            this.sourcelistBox.Name = "sourcelistBox";
            this.sourcelistBox.Size = new System.Drawing.Size(214, 84);
            this.sourcelistBox.TabIndex = 12;
            // 
            // desListBox
            // 
            this.desListBox.FormattingEnabled = true;
            this.desListBox.ItemHeight = 16;
            this.desListBox.Items.AddRange(new object[] {
            "Hanoi",
            "Singapore",
            "Saigon",
            "New York",
            "Tokyo",
            "Bangkok",
            "Paris",
            "London"});
            this.desListBox.Location = new System.Drawing.Point(200, 290);
            this.desListBox.Name = "desListBox";
            this.desListBox.Size = new System.Drawing.Size(214, 84);
            this.desListBox.TabIndex = 13;
            // 
            // flightDateTimePicker
            // 
            this.flightDateTimePicker.Location = new System.Drawing.Point(200, 387);
            this.flightDateTimePicker.Name = "flightDateTimePicker";
            this.flightDateTimePicker.Size = new System.Drawing.Size(214, 22);
            this.flightDateTimePicker.TabIndex = 14;
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Items.AddRange(new object[] {
            "Vip",
            "Economic",
            "Bussiness",
            "Second"});
            this.classComboBox.Location = new System.Drawing.Point(200, 430);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(214, 24);
            this.classComboBox.TabIndex = 15;
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(101, 545);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(75, 23);
            this.verifyButton.TabIndex = 17;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(252, 545);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // serviceCheckedListBox
            // 
            this.serviceCheckedListBox.FormattingEnabled = true;
            this.serviceCheckedListBox.Items.AddRange(new object[] {
            "Child Care",
            "Nurse"});
            this.serviceCheckedListBox.Location = new System.Drawing.Point(200, 473);
            this.serviceCheckedListBox.Name = "serviceCheckedListBox";
            this.serviceCheckedListBox.Size = new System.Drawing.Size(214, 55);
            this.serviceCheckedListBox.TabIndex = 19;
            // 
            // flightReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 595);
            this.Controls.Add(this.serviceCheckedListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.flightDateTimePicker);
            this.Controls.Add(this.desListBox);
            this.Controls.Add(this.sourcelistBox);
            this.Controls.Add(this.passportNumbertextBox);
            this.Controls.Add(this.PassengerNameTextBox);
            this.Controls.Add(this.ticketNumberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightReservationDetailsLabels);
            this.Name = "flightReservation";
            this.Text = "Flight Reservation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flightReservationDetailsLabels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticketNumberTextBox;
        private System.Windows.Forms.TextBox PassengerNameTextBox;
        private System.Windows.Forms.TextBox passportNumbertextBox;
        private System.Windows.Forms.ListBox sourcelistBox;
        private System.Windows.Forms.ListBox desListBox;
        private System.Windows.Forms.DateTimePicker flightDateTimePicker;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckedListBox serviceCheckedListBox;
    }
}

