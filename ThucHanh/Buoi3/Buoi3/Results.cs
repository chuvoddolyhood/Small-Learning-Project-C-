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
    public partial class Results : Form
    {
        //String strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=majomiStore;Integrated Security=True";
        String strDatabase = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Results;Integrated Security=True";
        public Results()
        {
            InitializeComponent();
        }

        private DataSet getInfo()
        {
            DataSet data = new DataSet();
            string query = "SELECT S.StudentCode,S.StudentName,R.ExamCode,E.ExamName,R.Score FROM Result R JOIN Students S ON R.StudentCode = S.StudentCode JOIN Exams E ON R.ExamCode = E.ExamCode WHERE S.StudentCode = @id; ";

            using (SqlConnection connection = new SqlConnection(strDatabase))
            {
                connection.Open();
                //sqlCommand
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id",cmbID.Text);
                //sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getInfo().Tables[0];
        }

        private void Results_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = getInfo().Tables[0];
        }
    }
}
