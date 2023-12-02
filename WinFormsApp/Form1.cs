using Microsoft.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp

{
    public partial class Form : System.Windows.Forms.Form
    {
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
            // string connectionString = "Data Source=KYLENUNND4C4;Initial Catalog=SensorSystems;Integrated Security=True;TrustServerCertificate=True";
            // The above code is "hardcodin"g the connection string. We are going to create a connection string with the App.config file below.
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

            string sqlQuery = "INSERT INTO SENSOR (SensorName, SensorType) VALUES (" + "'" + sensorNameValue.Text + "'" + "," + "'" + sensorTypeValue.Text + "'" + ")";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();

            // Above in the connection string, we have set the TrustServerCertificate to true, but this is bad practice.
            // SQL Server books online under the topic of "Encryption Hierarchy", and "Using Encryption Without Validation".
            // Setting TrustServerCertificate=true causes the SQL client to ignore the certificate presented by the SQL server.
            // This defeats the purpose of encryption as hackers can observe the data with ease.
            // There is a link to learn more about Configuring SQL Server Database Engine for encryption connections on microsoft docs
            // https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/configure-sql-server-encryption?view=sql-server-ver16
        }
    }
}
