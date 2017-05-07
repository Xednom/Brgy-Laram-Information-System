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

namespace Brgy_Laram_Information_System
{
    public partial class Migration : MetroForm
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public static string apelyido = "";
        public static string unangPangalan = "";
        public static string gitnangPangalan = "";
        public static string kasarian = "";
        public static string edad = "";
        public static string katayuangSibil = "";
        public static string kasalukuyangAntas = "";
        public static string migrants = "";
        public static string kungNagtatrabaho = "";
        public static string lugarNagtatrabaho = "";
        public static string katayuanTrabaho = "";
        public static string sarilingPinagkakakitaan = "";
        public static string kabuuang = "";

        public Migration()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal1"].ToString();
        }

        public void sort()
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM dbo.Migration ORDER BY Apelyido ASC";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            GridView.DataSource = dt;
            GridView.Refresh();
            conn.Close();
        }

        public void clear()
        {
            txt_antas.Text = null;
            txt_apelyido.Text = null;
            txt_edad.Text = null;
            txt_gitnang.Text = null;
            txt_kabuuang.Text = null;
            txt_katayuan.Text = null;
            txt_lugar.Text = null;
            txt_migrants.Text = null;
            txt_sarili.Text = null;
            txt_trabaho.Text = null;
            txt_unang.Text = null;
        }

        private void Migration_Load(object sender, EventArgs e)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM dbo.Migration;";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            GridView.DataSource = dt;
            GridView.Refresh();
            conn.Close();
        }

        

        private void btn_sort_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            gBmigration.Show();
        }

        private void gBmigration_Move(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            gBmigration.Hide();
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Codes.migrationAdd();
            
        }

        private void btn_sort_Click_1(object sender, EventArgs e)
        {
            sort();
        }
    }
}
