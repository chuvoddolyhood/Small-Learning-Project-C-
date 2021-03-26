using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Equals("nghia") && passTextBox.Text.Equals("nghia123"))
            {
                //MessageBox.Show("Dang nhap thanh cong");
                this.Hide();
                employeeDetail f = new employeeDetail();
                f.Show();
            }
            else if (userNameTextBox.Text.Equals("nghia") && !passTextBox.Text.Equals("nghia123"))
            {
                MessageBox.Show("Sai Mat Khau");
            }
            else MessageBox.Show("Dang nhap khong thanh cong");
        }
    }
}
