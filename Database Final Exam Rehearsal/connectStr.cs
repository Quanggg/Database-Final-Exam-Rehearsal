using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Final_Exam_Rehearsal
{
    public partial class connectStr : Form
    {
        public connectStr()
        {
            InitializeComponent();
        }
        bool connecting = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!connecting) 
                testDBconnection();
        }
        private async void testDBconnection()
        {
            connecting = true;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connectionString = config.ConnectionStrings.ConnectionStrings["Quang"].ConnectionString;
            Console.WriteLine(connectionString);
            button1.Text = "please wait";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                connection.Close();
                MainForm f = new MainForm();
                f.Closed += (sender, args) => this.Close();
                this.Hide();
                Console.WriteLine("reach");
                f.Show();
            }
            catch (SqlException)
            {
                MessageBox.Show("Cannot connect to database. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Cannot connect to database. Please try again!", "Error1", MessageBoxButtons.OK);
            }
            connecting = false;
        }
    }
}
