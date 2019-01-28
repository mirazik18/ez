using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_ConnectedMode_HW3
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
        string User, Password;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                User = textBox1.Text;
                Password = textBox2.Text;
                sqlConnectionStringBuilder.DataSource= @"(LocalDb)\MSSQLLocalDB";
                sqlConnectionStringBuilder.InitialCatalog= "MyDb";
                sqlConnectionStringBuilder.UserID = User;
                sqlConnectionStringBuilder.Password = Password;
                SqlConnection conn = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                try
                {
                    conn.Open();
                    if(conn.State == ConnectionState.Open)
                        MessageBox.Show("Connected");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn?.Close();
                }
                
            
        }
    }
}
