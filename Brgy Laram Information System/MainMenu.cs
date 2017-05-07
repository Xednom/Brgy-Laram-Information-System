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

namespace Brgy_Laram_Information_System
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_migration_Click(object sender, EventArgs e)
        {
            Migration migration = new Migration();
            migration.Show();
        }
    }
}
