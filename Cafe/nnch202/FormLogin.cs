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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BTLOGIN_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM TBL_ADMIN WHERE USERNAME='{0}' AND PASSWORD='{1}'", TBUSERNAME.Text, TBPASSWORD.Text);
            SqlDataAdapter da = new SqlDataAdapter(sql,FormMain.DATA);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1) //login correct
            {
                string name = dt.Rows[0]["USERNAME"].ToString();
                MessageBox.Show("Welcome");
                FormMain.Loginstat = "1234";
                this.Close();
            }
            else
            {
                MessageBox.Show("User Or Password wrong", "ERROR");
            }
        }

        private void CBPW_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPW.Checked == true)
            {
                TBPASSWORD.PasswordChar = '\0';
            }
            else
            {
                TBPASSWORD.PasswordChar = '*';
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
