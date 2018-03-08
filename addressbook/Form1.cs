using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace addressbook
{
    public partial class Form1 : Form
    {
        SqlConnection _sqlConn = new SqlConnection();
        //add connection string
        SqlCommand _sqlCmd;
        SqlDataAdapter _sqlAdapter;

        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            _sqlConn.Open();

            //create data table
            //create sql adapter

            _sqlConn.Close();
        }

        private void ClearData()
        {
        }


        private void buttonQuitClick(object sender, EventArgs e)
        {
            //use MessageBox
        }

        private void buttonAboutClick(object sender, EventArgs e)
        {
            //use MessageBox
        }

        private void buttonSaveClick(object sender, EventArgs e)
        {
            //build Sql Command with parameters
            //use insert query
        }

        private void buttonUpdateClick(object sender, EventArgs e)
        {
            //build Sql Command with parameters
            //use update query
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonNewClick(object sender, EventArgs e)
        {
            textLastname.Text = "";
            textFirstname.Text = "";
            testMobile.Text = "";
            textTelephone.Text = "";
            textMail.Text = "";
            textLastname.Focus();
        }

        private void buttonDeleteClick(object sender, EventArgs e)
        {
        }
    }
}
