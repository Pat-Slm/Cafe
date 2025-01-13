using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //sql
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nnch202
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            string sql = "SELECT* FROM View_CT";
            SqlDataAdapter da = new SqlDataAdapter(sql, FormMain.DATA);
            da.Fill(ds, "ViewCT");
            DTGV_CT.DataSource = ds.Tables["ViewCT"];
            string sql2 = "SELECT* FROM Tbl_Sex";
            string sql3 = "SELECT* FROM Tbl_Member";
            da = new SqlDataAdapter(sql2, FormMain.DATA);
            da.Fill(ds, "typesex");
            CBSEX.DisplayMember = "NameSex";
            CBSEX.ValueMember = "TypeSex";
            CBSEX.DataSource = ds.Tables["typesex"];


            da = new SqlDataAdapter(sql3, FormMain.DATA);
            da.Fill(ds, "typemember");
            CBMEMBER.DisplayMember = "NameMember";
            CBMEMBER.ValueMember = "TypeMember";
            CBMEMBER.DataSource = ds.Tables["typemember"];
            BTEDIT.Enabled = false;
            BTDL.Enabled = false;



        }

        private void BTGENID_Click(object sender, EventArgs e)
        {
            string id1 = "SELECT TOP 1 * FROM TblCT ORDER BY IDCT DESC";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(id1, FormMain.DATA);
            da.Fill(dt);
            int Topid = Convert.ToInt32(dt.Rows[0]["IDCT"]) + 1;
            LBID.Text = Topid.ToString();
            BTSR.Enabled = false;





        }
        private void Updatedata()
        {
            string sql = "SELECT* FROM TblCT";
            SqlDataAdapter da = new SqlDataAdapter(sql, FormMain.DATA);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "CT");

            string sql1 = "SELECT* FROM View_CT";
            da = new SqlDataAdapter(sql1, FormMain.DATA);
            da.Fill(ds, "ViewCT");

        }

        private void BTRS_Click(object sender, EventArgs e)
        {
            LBID.Text = "";
            TBNAME.Text = "";
            TBSNAME.Text = "";
            TBADDRESS.Text = "";
            TBTEL.Text = "";
            CBSEX.SelectedIndex = 0;
            CBMEMBER.SelectedIndex = 0;
            DTBD.ResetText();
            BTDL.Enabled = true;
        }

        private void BTADD_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();

            string sql = "SELECT* FROM TblCT";
            SqlDataAdapter da = new SqlDataAdapter(sql, FormMain.DATA);
            da.Fill(ds, "CT");
            DataRow[] drs = ds.Tables["CT"].Select("IDCT='" + LBID.Text + "'");
            if (drs.Length == 0)
            {
                DataRow dr = ds.Tables["CT"].NewRow();
                dr["IDCT"] = LBID.Text;
                dr["IDMEMBER"] = LBID.Text;
                dr["NameCT"] = TBNAME.Text;
                dr["SnameCT"] = TBSNAME.Text;
                dr["AddressCT"] = TBADDRESS.Text;
                dr["TelCT"] = TBTEL.Text;
                dr["BDCT"] = DTBD.Text;
                dr["TypeSex"] = CBSEX.SelectedValue;
                dr["TypeMember"] = CBMEMBER.SelectedValue;
                ds.Tables["CT"].Rows.Add(dr); // เอาข้อมูลใส่ตาราง
                Updatedata();

                string sql1 = "SELECT* FROM View_CT";
                SqlDataAdapter da2 = new SqlDataAdapter(sql1, FormMain.DATA);
                da2.Fill(ds2, "ViewCT");
            }
            else
            {
                MessageBox.Show("เลข ID ซ้ำ", "ERROR");
            }
            
            DTGV_CT.DataSource = ds2.Tables["ViewCT"]; //อัพเดทตาราง
        }
    }
}
