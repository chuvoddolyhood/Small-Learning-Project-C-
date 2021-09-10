using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi3
{
    public partial class frmDVDCatalog : Form
    {
        public frmDVDCatalog()
        {
            InitializeComponent();
        }


        private string strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=DVDLibraryNET;Integrated Security=True";
        private int id;

        private void createID()
        {
            try
            {
                SqlConnection connector = new SqlConnection(strDatabase);
                connector.Open();
                string query = "SELECT MAX(DVDCodeNo) FROM DVDNET;";
                SqlCommand command = new SqlCommand(query, connector);
                id = Convert.ToInt32(command.ExecuteScalar());
                //txtCodeNo.Text = id.ToString();
            }
            catch (Exception ex)
            {
                id = 0;
                //MessageBox.Show(ex.Message);
            }
            id++;
            txtCodeNo.Text = id.ToString();
        }


        private void frmDVDCatalog_Load(object sender, EventArgs e)
        {
            //createID();
        }
        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            createID();
            txtTitle.Text = "";
            cboLang.ResetText();
            updPrice.Value = 5;
            radYes.Checked = true;
            radNo.Checked = false;

            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Close();
            Application.Exit();
        }

        private int getValueRadio()
        {
            int test = (radYes.Checked = true) ? 1 : 0;
            return test;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();
            string query = "INSERT INTO DVDNET VALUES (@id,@title,@lang,@sub,@money);";
            SqlCommand command = new SqlCommand(query, connector);
            command.Parameters.AddWithValue("@id",txtCodeNo.Text);
            command.Parameters.AddWithValue("@title", txtTitle.Text);
            command.Parameters.AddWithValue("@lang", cboLang.Text);
            command.Parameters.AddWithValue("@sub", getValueRadio().ToString());
            command.Parameters.AddWithValue("@money", updPrice.Text);
            command.ExecuteNonQuery();


            MessageBox.Show("Saved");
            connector.Close();
        }

        private void chooseID()
        {
            txtCodeNo.Visible = false;
            cmbDVDCodeNumber.Visible = true;
            //SqlConnection connector = new SqlConnection(strDatabase);
            //connector.Open();
            //string query = "SELECT DVDCodeNo FROM DVDNET;";
            //SqlCommand command = new SqlCommand(query, connector);
            //int[] result;
            //foreach (int i in result)
            //{
            //    result[i]= Convert.ToInt32(command.ExecuteScalar());
            //}
                
            //MessageBox.Show(result.ToString());



            //cmbDVDCodeNumber.Items.AddRange(new object[] {
            //"1",
            //"2"});
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            chooseID();

            btnAddNew.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            txtCodeNo.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnAddNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void cmbDVDCodeNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connector = new SqlConnection(strDatabase);
            connector.Open();

            string queryTitle = "SELECT DVDTitle FROM DVDNET WHERE DVDCodeNo=@id;";
            SqlCommand commandTitle = new SqlCommand(queryTitle, connector);
            commandTitle.Parameters.AddWithValue("@id",cmbDVDCodeNumber.Text);
            string title= (string)commandTitle.ExecuteScalar();
            txtTitle.Text = title;

            string queryLang = "SELECT Language FROM DVDNET WHERE DVDCodeNo=@id;";
            SqlCommand commandLanguages = new SqlCommand(queryLang, connector);
            commandLanguages.Parameters.AddWithValue("@id", cmbDVDCodeNumber.Text);
            string lang = (string)commandLanguages.ExecuteScalar();
            cboLang.Text = lang;
        }
    }
}
