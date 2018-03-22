using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace addressbook
{
    public partial class Form1 : Form
    {
        SqlConnection _sqlConn = new SqlConnection();
        string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

        //add connection string
        SqlCommand _sqlCmd;
        SqlDataAdapter _sqlAdapter;

        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            _sqlConn.ConnectionString = ConnectionString;
            //DisplayData();
        }

        private void DisplayData()
        {
            _sqlConn.Open();
            DataTable dt = new DataTable();
            _sqlAdapter = new SqlDataAdapter("SELECT * FROM tbl_users", _sqlConn);
            _sqlAdapter.Fill(dt);
            dataGridView.DataSource = dt;
            _sqlConn.Close();
        }

        private void ClearData()
        {
            textLastname.Text = "";
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
            //todo add condition
            //todo open connection
            _sqlConn.Open();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO tbl_users (lastname,firstname, mobile,telephone, email) " +
                "VALUES (@lastname, @firstname, @mobile, @telephone, @email);");
            sqlCommand.Connection = _sqlConn;

            sqlCommand.Parameters.Add("@lastname", SqlDbType.NChar);
            sqlCommand.Parameters["@lastname"].Value = textLastname.Text;

            sqlCommand.Parameters.Add("@firstname", SqlDbType.NChar);
            sqlCommand.Parameters["@firstname"].Value = textFirstname.Text;

            sqlCommand.Parameters.Add("@mobile", SqlDbType.NChar);
            sqlCommand.Parameters["@mobile"].Value = testMobile.Text;

            sqlCommand.Parameters.Add("@telephone", SqlDbType.NChar);
            sqlCommand.Parameters["@telephone"].Value = textTelephone.Text;

            sqlCommand.Parameters.Add("@email", SqlDbType.NChar);
            sqlCommand.Parameters["@email"].Value = textMail.Text;


            sqlCommand.ExecuteNonQuery();

            _sqlConn.Close();

            MessageBox.Show("Record Inserted Successfully");

            DisplayData();
            //close conn
        }

        private void buttonUpdateClick(object sender, EventArgs e)
        {
            //build Sql Command with parameters
            //use update query
            _sqlConn.Open();
			//todo add rest of fields
			SqlCommand sqlCommand = new SqlCommand("update tbl_users set lastname=@lastname, firstname=@firstname");

			sqlCommand.Connection = _sqlConn;

            sqlCommand.Parameters.Add("@lastname", SqlDbType.NChar);
            sqlCommand.Parameters["@lastname"].Value = textLastname.Text;

            sqlCommand.Parameters.Add("@firstname", SqlDbType.NChar);
            sqlCommand.Parameters["@firstname"].Value = textFirstname.Text;

            sqlCommand.Parameters.Add("@mobile", SqlDbType.NChar);
            sqlCommand.Parameters["@mobile"].Value = testMobile.Text;

            sqlCommand.Parameters.Add("@telephone", SqlDbType.NChar);
            sqlCommand.Parameters["@telephone"].Value = textTelephone.Text;

            sqlCommand.Parameters.Add("@email", SqlDbType.NChar);
            sqlCommand.Parameters["@email"].Value = textMail.Text;

            sqlCommand.ExecuteNonQuery();

            _sqlConn.Close();

            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
			textLastname.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
			textFirstname.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
			testMobile.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
			textTelephone.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
			textMail.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
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
			_sqlConn.Open();

			SqlCommand sqlCommand = new SqlCommand("delete tbl_users where id=@id");
			sqlCommand.Parameters.Add("@id", SqlDbType.Int);
			sqlCommand.Parameters["@id"].Value = ID;
			sqlCommand.Connection = _sqlConn;
			sqlCommand.ExecuteNonQuery();

			_sqlConn.Close();

			DisplayData();
		}
    }
}
