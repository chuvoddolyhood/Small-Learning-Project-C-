using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class flightReservation : Form
    {
        public flightReservation()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ticketNumberTextBox.Clear();
            PassengerNameTextBox.Clear();
            passportNumbertextBox.Clear();
            sourcelistBox.ClearSelected();
            desListBox.ClearSelected();
            flightDateTimePicker.ResetText();
            classComboBox.ResetText();

            foreach(int i in serviceCheckedListBox.CheckedIndices)
            {
                serviceCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if (sourcelistBox.SelectedItem.Equals(desListBox.SelectedItem))
            {
                MessageBox.Show("Ban da chon noi xuat phat va noi den trung nhau");
            }
            else MessageBox.Show("Verified");
        }
    }
}
