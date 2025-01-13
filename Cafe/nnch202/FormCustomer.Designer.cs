namespace nnch202
{
    partial class FormCustomer
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
            this.DTGV_CT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBNAME = new System.Windows.Forms.TextBox();
            this.TBSNAME = new System.Windows.Forms.TextBox();
            this.TBADDRESS = new System.Windows.Forms.TextBox();
            this.TBTEL = new System.Windows.Forms.TextBox();
            this.DTBD = new System.Windows.Forms.DateTimePicker();
            this.CBMEMBER = new System.Windows.Forms.ComboBox();
            this.CBSEX = new System.Windows.Forms.ComboBox();
            this.BTADD = new System.Windows.Forms.Button();
            this.BTEDIT = new System.Windows.Forms.Button();
            this.BTDL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BTSR = new System.Windows.Forms.Button();
            this.LBID = new System.Windows.Forms.Label();
            this.BTGENID = new System.Windows.Forms.Button();
            this.BTRS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_CT
            // 
            this.DTGV_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_CT.Location = new System.Drawing.Point(556, 129);
            this.DTGV_CT.MultiSelect = false;
            this.DTGV_CT.Name = "DTGV_CT";
            this.DTGV_CT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGV_CT.Size = new System.Drawing.Size(490, 507);
            this.DTGV_CT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "เลขสมาชิก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "นามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "ที่อยู่";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "เพศ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "เบอร์โทร";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "วันเกิด";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "ระดับสมาชิก";
            // 
            // TBNAME
            // 
            this.TBNAME.Location = new System.Drawing.Point(88, 74);
            this.TBNAME.Name = "TBNAME";
            this.TBNAME.Size = new System.Drawing.Size(177, 29);
            this.TBNAME.TabIndex = 10;
            // 
            // TBSNAME
            // 
            this.TBSNAME.Location = new System.Drawing.Point(88, 129);
            this.TBSNAME.Name = "TBSNAME";
            this.TBSNAME.Size = new System.Drawing.Size(177, 29);
            this.TBSNAME.TabIndex = 11;
            // 
            // TBADDRESS
            // 
            this.TBADDRESS.Location = new System.Drawing.Point(16, 225);
            this.TBADDRESS.Multiline = true;
            this.TBADDRESS.Name = "TBADDRESS";
            this.TBADDRESS.Size = new System.Drawing.Size(249, 113);
            this.TBADDRESS.TabIndex = 12;
            // 
            // TBTEL
            // 
            this.TBTEL.Location = new System.Drawing.Point(88, 390);
            this.TBTEL.MaxLength = 10;
            this.TBTEL.Name = "TBTEL";
            this.TBTEL.Size = new System.Drawing.Size(177, 29);
            this.TBTEL.TabIndex = 14;
            // 
            // DTBD
            // 
            this.DTBD.Location = new System.Drawing.Point(88, 435);
            this.DTBD.Name = "DTBD";
            this.DTBD.Size = new System.Drawing.Size(177, 29);
            this.DTBD.TabIndex = 15;
            // 
            // CBMEMBER
            // 
            this.CBMEMBER.FormattingEnabled = true;
            this.CBMEMBER.Location = new System.Drawing.Point(126, 477);
            this.CBMEMBER.Name = "CBMEMBER";
            this.CBMEMBER.Size = new System.Drawing.Size(139, 32);
            this.CBMEMBER.TabIndex = 16;
            // 
            // CBSEX
            // 
            this.CBSEX.FormattingEnabled = true;
            this.CBSEX.Location = new System.Drawing.Point(88, 348);
            this.CBSEX.Name = "CBSEX";
            this.CBSEX.Size = new System.Drawing.Size(177, 32);
            this.CBSEX.TabIndex = 17;
            // 
            // BTADD
            // 
            this.BTADD.Location = new System.Drawing.Point(367, 199);
            this.BTADD.Name = "BTADD";
            this.BTADD.Size = new System.Drawing.Size(92, 59);
            this.BTADD.TabIndex = 18;
            this.BTADD.Text = "Add";
            this.BTADD.UseVisualStyleBackColor = true;
            this.BTADD.Click += new System.EventHandler(this.BTADD_Click);
            // 
            // BTEDIT
            // 
            this.BTEDIT.Location = new System.Drawing.Point(367, 282);
            this.BTEDIT.Name = "BTEDIT";
            this.BTEDIT.Size = new System.Drawing.Size(92, 56);
            this.BTEDIT.TabIndex = 19;
            this.BTEDIT.Text = "Edit";
            this.BTEDIT.UseVisualStyleBackColor = true;
            // 
            // BTDL
            // 
            this.BTDL.Location = new System.Drawing.Point(367, 354);
            this.BTDL.Name = "BTDL";
            this.BTDL.Size = new System.Drawing.Size(92, 63);
            this.BTDL.TabIndex = 20;
            this.BTDL.Text = "DELETE";
            this.BTDL.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 29);
            this.textBox1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "เลขสมาชิก";
            // 
            // BTSR
            // 
            this.BTSR.Location = new System.Drawing.Point(954, 31);
            this.BTSR.Name = "BTSR";
            this.BTSR.Size = new System.Drawing.Size(92, 35);
            this.BTSR.TabIndex = 23;
            this.BTSR.Text = "Search";
            this.BTSR.UseVisualStyleBackColor = true;
            // 
            // LBID
            // 
            this.LBID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBID.Location = new System.Drawing.Point(43, 33);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(222, 34);
            this.LBID.TabIndex = 24;
            // 
            // BTGENID
            // 
            this.BTGENID.Location = new System.Drawing.Point(284, 34);
            this.BTGENID.Name = "BTGENID";
            this.BTGENID.Size = new System.Drawing.Size(166, 35);
            this.BTGENID.TabIndex = 25;
            this.BTGENID.Text = "Create Member";
            this.BTGENID.UseVisualStyleBackColor = true;
            this.BTGENID.Click += new System.EventHandler(this.BTGENID_Click);
            // 
            // BTRS
            // 
            this.BTRS.Location = new System.Drawing.Point(367, 439);
            this.BTRS.Name = "BTRS";
            this.BTRS.Size = new System.Drawing.Size(92, 59);
            this.BTRS.TabIndex = 26;
            this.BTRS.Text = "Reset";
            this.BTRS.UseVisualStyleBackColor = true;
            this.BTRS.Click += new System.EventHandler(this.BTRS_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 651);
            this.Controls.Add(this.BTRS);
            this.Controls.Add(this.BTGENID);
            this.Controls.Add(this.LBID);
            this.Controls.Add(this.BTSR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTDL);
            this.Controls.Add(this.BTEDIT);
            this.Controls.Add(this.BTADD);
            this.Controls.Add(this.CBSEX);
            this.Controls.Add(this.CBMEMBER);
            this.Controls.Add(this.DTBD);
            this.Controls.Add(this.TBTEL);
            this.Controls.Add(this.TBADDRESS);
            this.Controls.Add(this.TBSNAME);
            this.Controls.Add(this.TBNAME);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGV_CT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCustomer";
            this.Text = "ฐานข้อมูลลูกค้า";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_CT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_CT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBNAME;
        private System.Windows.Forms.TextBox TBSNAME;
        private System.Windows.Forms.TextBox TBADDRESS;
        private System.Windows.Forms.TextBox TBTEL;
        private System.Windows.Forms.DateTimePicker DTBD;
        private System.Windows.Forms.ComboBox CBMEMBER;
        private System.Windows.Forms.ComboBox CBSEX;
        private System.Windows.Forms.Button BTADD;
        private System.Windows.Forms.Button BTEDIT;
        private System.Windows.Forms.Button BTDL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTSR;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Button BTGENID;
        private System.Windows.Forms.Button BTRS;
    }
}