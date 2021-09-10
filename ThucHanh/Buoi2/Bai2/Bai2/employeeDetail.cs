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
    public partial class employeeDetail : Form
    {
        public employeeDetail()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            addressTextBox.Clear();
            dateJoinTextBox.Clear();
            eduListBox.ClearSelected();
            departmentComboBox.ResetText();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
