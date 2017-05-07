using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework;


namespace Brgy_Laram_Information_System
{
    public partial class Login : MetroForm
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            string LOGIN = "SELECT * FROM Users WHERE Username = @un AND Password = @pw";
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pw", txt_pw.Text);
            cmd.CommandText = LOGIN;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MetroMessageBox.Show(this, "Welcome!", "Brgy Laram Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainParent main = new MainParent();
                main.Show();
                Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password or username", "Brgy Laram Information System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            conn.Close();

            cmd.Parameters.Clear();
        }
    }
}
