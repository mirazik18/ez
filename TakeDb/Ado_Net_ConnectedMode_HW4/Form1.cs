using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado_Net_ConnectedMode_HW4
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        string connection;
        public Form1()
        {
            connection = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            InitializeComponent();
            AddData();
        }

        private void AddData()
        {
            sqlConnection = new SqlConnection(connection);
            string Select = "select table_name from INFORMATION_SCHEMA.TABLES where TABLE_TYPE = 'base table' and table_name not like 'sys%';";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(Select, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox1.Items.Add(sqlDataReader["table_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection?.Close();
                sqlCommand?.Clone();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("Select * from "+ comboBox1.Text, sqlConnection);
            DataSet dataSet = new DataSet();
            dataGridView1.DataSource = null;
            Adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
