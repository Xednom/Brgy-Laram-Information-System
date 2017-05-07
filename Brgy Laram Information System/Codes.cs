using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using MetroFramework;
using System.Windows.Forms;

namespace Brgy_Laram_Information_System
{
    class Codes
    {
        public static void migrationAdd()
        {
            SqlCommand cmd = new SqlCommand();
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

                Migration _owner = new Migration();

                conn.Open();
                cmd.Connection = conn;
                string ADD = "INSERT INTO Migration(Apelyido,UnangPangalan,GitnangPangalan,KASARIAN,EDAD,KATAYUANGSIBIL,KasalukuyangAntasngPinagAralan,MgaMigrantsNaNasa16_65yrsNaWalangTrabaho,KungNagtatrabahoAnongSectorNgIndustriya,SaanLugarNagtatrabaho,AnoAngKatayuanSaTrabaho,MaySarilingPinagkakakitaan,KabuuangKitaSaIsangBuwan)VALUES(@apelyido,@unang,@gitnang,@kasarian,@edad,@katayuangSibil,@kasalikuyangAntas,@migrants,@sector,@lugar,@katayuan,@sarili,@kita)";
                    cmd.Parameters.AddWithValue("apelyido", Migration.apelyido);
                    cmd.Parameters.AddWithValue("unang", Migration.unangPangalan);
                    cmd.Parameters.AddWithValue("gitnang", Migration.gitnangPangalan);
                    cmd.Parameters.AddWithValue("kasarian", Migration.kasarian);
                    cmd.Parameters.AddWithValue("edad", Migration.edad);
                    cmd.Parameters.AddWithValue("katayuangSibil", Migration.katayuangSibil);
                    cmd.Parameters.AddWithValue("kasalikuyangAntas", Migration.kasalukuyangAntas);
                    cmd.Parameters.AddWithValue("migrants", Migration.migrants);
                    cmd.Parameters.AddWithValue("sector", Migration.kungNagtatrabaho);
                    cmd.Parameters.AddWithValue("lugar", Migration.lugarNagtatrabaho);
                    cmd.Parameters.AddWithValue("katayuan", Migration.katayuanTrabaho);
                    cmd.Parameters.AddWithValue("sarili", Migration.sarilingPinagkakakitaan);
                    cmd.Parameters.AddWithValue("kita", Migration.kabuuang);
                cmd.CommandText = ADD;
                cmd.ExecuteNonQuery();

                MetroMessageBox.Show(_owner, "Added","Brgy Laram Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();

                cmd.Parameters.Clear();
            }
        }
    }
}
