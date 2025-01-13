using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nnch202
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static string Loginstat = "";
        public static string DATA = "Data Source =.; Database=datasec3202; Trusted_Connection=True;";
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin FLI = new FormLogin();
            FLI.ShowDialog();
            if (Loginstat == "")
            {
                Application.Exit();
            }

            //FLT.MdiParent = this;
            //FLT.WindowState = FormWindowState.Normal;
            //FLT.Show();
        }
        private void CloseFrom(Form fop)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name != fop.Name)
                {
                    f.Close();
                }
                else
                    return;
            }
            fop.MdiParent = this;
            fop.WindowState = FormWindowState.Maximized;
            fop.Show();
        }
        private void สมาชกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer FCT = new FormCustomer();
            CloseFrom(FCT);
        }
    }
}
