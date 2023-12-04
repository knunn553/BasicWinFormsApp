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


            // string sqlQuery = "INSERT INTO SENSOR (SensorName, SensorType) VALUES (" + "'" + sensorNameValue.Text + "'" + "," + "'" + sensorTypeValue.Text + "'" + ")";
            try
            {
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True");


                conn.Open();

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SaveSensor", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                string sensorName = sensorNameValue.Text;
                string sensorType = sensorTypeValue.Text;

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SensorName", sensorName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@SensorType", sensorType));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("There has been an error. We are rapidly resolving this issue and we will notify you via email when this error is resolved.");
            }
            


            // Above in the connection string, we have set the TrustServerCertificate to true, but this is bad practice.
            // SQL Server books online under the topic of "Encryption Hierarchy", and "Using Encryption Without Validation".
            // Setting TrustServerCertificate=true causes the SQL client to ignore the certificate presented by the SQL server.
            // This defeats the purpose of encryption as hackers can observe the data with ease.
            // There is a link to learn more about Configuring SQL Server Database Engine for encryption connections on microsoft docs
            // https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/configure-sql-server-encryption?view=sql-server-ver16
        }
    }
}
