using System;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

// using Microsoft.Extensions.Configuration;


namespace WinFormsApp

{
    public partial class Form : System.Windows.Forms.Form
    {
        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True");
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /* string sensorName, sensorType;

            sensorName = sensorNameValue.Text;
            sensorType = sensorTypeValue.Text;

            try
            {
                string sqlQuery = "INSERT INTO SENSOR (SensorName, SensorType) VALUES (" + "'" + sensorNameValue.Text + "'" + "," + "'" + sensorTypeValue.Text + "'" + ")";
                System.Data.SqlClient.SqlCommand sc = new System.Data.SqlClient.SqlCommand(sqlQuery, conn);
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();
            } */
            
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True");
            string sqlQuery = "INSERT INTO SENSOR (SensorName, SensorType) VALUES (" + "'" + sensorNameValue.Text + "'" + "," + "'" + sensorTypeValue.Text + "'" + ")";
            

            conn.Open();
            System.Data.SqlClient.SqlCommand sc = new System.Data.SqlClient.SqlCommand(sqlQuery, conn);
           
            
            sc.ExecuteNonQuery();
            conn.Close();


            // Above in the connection string, we have set the TrustServerCertificate to true, but this is bad practice.
            // SQL Server books online under the topic of "Encryption Hierarchy", and "Using Encryption Without Validation".
            // Setting TrustServerCertificate=true causes the SQL client to ignore the certificate presented by the SQL server.
            // This defeats the purpose of encryption as hackers can observe the data with ease.
            // There is a link to learn more about Configuring SQL Server Database Engine for encryption connections on microsoft docs
            // https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/configure-sql-server-encryption?view=sql-server-ver16
        }
    }
}
