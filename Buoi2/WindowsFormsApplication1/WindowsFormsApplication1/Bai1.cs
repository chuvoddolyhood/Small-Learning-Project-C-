using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string hobby = "";
            int countHobbies = lstHob.CheckedItems.Count;
            for (int i = 0; i < countHobbies; i++)
            {
                hobby = hobby + lstHob.CheckedItems[i];
                if (i < countHobbies - 1)
                {
                    hobby = hobby + ", ";
                }
            }
            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from class " + lstClass.Text + 
                ", Division " +cboDiv.Text+" has following hobbies "+hobby);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            lstClass.ClearSelected();
            cboDiv.ResetText();

            //uncheck options in checkedListBox
            foreach (int i in lstHob.CheckedIndices)
            {
                lstHob.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
