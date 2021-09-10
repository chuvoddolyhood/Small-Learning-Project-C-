using System.Windows.Forms;
namespace Chuong4
{
    partial class Form1
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
            this.titleTravel = new System.Windows.Forms.Label();
            this.travelerName = new System.Windows.Forms.Label();
            this.travelerAddress = new System.Windows.Forms.Label();
            this.travelType = new System.Windows.Forms.Label();
            this.travelDuration = new System.Windows.Forms.Label();
            this.travelMode = new System.Windows.Forms.Label();
            this.titleTravelTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTravel
            // 
            this.titleTravel.AutoSize = true;
            this.titleTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTravel.Location = new System.Drawing.Point(303, 29);
            this.titleTravel.Name = "titleTravel";
            this.titleTravel.Size = new System.Drawing.Size(185, 17);
            this.titleTravel.TabIndex = 0;
            this.titleTravel.Text = "Around the world travels";
            this.titleTravel.Click += new System.EventHandler(this.titleTravel_Click);
            // 
            // travelerName
            // 
            this.travelerName.AutoSize = true;
            this.travelerName.Location = new System.Drawing.Point(30, 100);
            this.travelerName.Name = "travelerName";
            this.travelerName.Size = new System.Drawing.Size(102, 17);
            this.travelerName.TabIndex = 1;
            this.travelerName.Text = "Traveler Name";
            // 
            // travelerAddress
            // 
            this.travelerAddress.AutoSize = true;
            this.travelerAddress.Location = new System.Drawing.Point(30, 150);
            this.travelerAddress.Name = "travelerAddress";
            this.travelerAddress.Size = new System.Drawing.Size(117, 17);
            this.travelerAddress.TabIndex = 2;
            this.travelerAddress.Text = "Traveler Address";
            // 
            // travelType
            // 
            this.travelType.AutoSize = true;
            this.travelType.Location = new System.Drawing.Point(30, 200);
            this.travelType.Name = "travelType";
            this.travelType.Size = new System.Drawing.Size(137, 17);
            this.travelType.TabIndex = 3;
            this.travelType.Text = "Desired Travel Type";
            // 
            // travelDuration
            // 
            this.travelDuration.AutoSize = true;
            this.travelDuration.Location = new System.Drawing.Point(30, 250);
            this.travelDuration.Name = "travelDuration";
            this.travelDuration.Size = new System.Drawing.Size(106, 17);
            this.travelDuration.TabIndex = 4;
            this.travelDuration.Text = "Travel Duration";
            // 
            // travelMode
            // 
            this.travelMode.AutoSize = true;
            this.travelMode.Location = new System.Drawing.Point(30, 300);
            this.travelMode.Name = "travelMode";
            this.travelMode.Size = new System.Drawing.Size(156, 17);
            this.travelMode.TabIndex = 5;
            this.travelMode.Text = "Desired Mode of Travel";
            // 
            // titleTravelTextBox
            // 
            this.titleTravelTextBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.titleTravelTextBox.Location = new System.Drawing.Point(220, 95);
            this.titleTravelTextBox.Name = "titleTravelTextBox";
            this.titleTravelTextBox.Size = new System.Drawing.Size(102, 22);
            this.titleTravelTextBox.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(220, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 22);
            this.textBox1.TabIndex = 7;
            //this.textBox1.PasswordChar = '*';
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleTravel);
            this.Controls.Add(this.travelerName);
            this.Controls.Add(this.travelerAddress);
            this.Controls.Add(this.travelType);
            this.Controls.Add(this.travelDuration);
            this.Controls.Add(this.travelMode);
            this.Controls.Add(this.titleTravelTextBox);
            this.Name = "Form1";
            this.Text = "Travel Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleTravel;
        private Label travelerName;
        private Label travelerAddress;
        private Label travelType;
        private Label travelDuration;
        private Label travelMode;
        private TextBox titleTravelTextBox;
        private TextBox textBox1;
    }
}