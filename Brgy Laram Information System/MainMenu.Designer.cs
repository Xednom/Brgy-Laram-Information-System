namespace Brgy_Laram_Information_System
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_migration = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_migration
            // 
            this.btn_migration.ActiveControl = null;
            this.btn_migration.Location = new System.Drawing.Point(23, 63);
            this.btn_migration.Name = "btn_migration";
            this.btn_migration.Size = new System.Drawing.Size(123, 66);
            this.btn_migration.TabIndex = 0;
            this.btn_migration.Text = "Migration";
            this.btn_migration.UseSelectable = true;
            this.btn_migration.Click += new System.EventHandler(this.btn_migration_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 749);
            this.Controls.Add(this.btn_migration);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Resizable = false;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_migration;
    }
}