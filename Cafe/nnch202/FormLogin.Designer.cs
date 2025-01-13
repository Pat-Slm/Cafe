namespace nnch202
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUSERNAME = new System.Windows.Forms.TextBox();
            this.TBPASSWORD = new System.Windows.Forms.TextBox();
            this.BTLOGIN = new System.Windows.Forms.Button();
            this.CBPW = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(193, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(193, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // TBUSERNAME
            // 
            this.TBUSERNAME.Location = new System.Drawing.Point(365, 153);
            this.TBUSERNAME.Name = "TBUSERNAME";
            this.TBUSERNAME.Size = new System.Drawing.Size(126, 20);
            this.TBUSERNAME.TabIndex = 2;
            // 
            // TBPASSWORD
            // 
            this.TBPASSWORD.Location = new System.Drawing.Point(365, 207);
            this.TBPASSWORD.Name = "TBPASSWORD";
            this.TBPASSWORD.PasswordChar = '*';
            this.TBPASSWORD.Size = new System.Drawing.Size(126, 20);
            this.TBPASSWORD.TabIndex = 3;
            // 
            // BTLOGIN
            // 
            this.BTLOGIN.Location = new System.Drawing.Point(292, 305);
            this.BTLOGIN.Name = "BTLOGIN";
            this.BTLOGIN.Size = new System.Drawing.Size(101, 30);
            this.BTLOGIN.TabIndex = 4;
            this.BTLOGIN.Text = "LOGIN";
            this.BTLOGIN.UseVisualStyleBackColor = true;
            this.BTLOGIN.Click += new System.EventHandler(this.BTLOGIN_Click);
            // 
            // CBPW
            // 
            this.CBPW.AutoSize = true;
            this.CBPW.Location = new System.Drawing.Point(365, 244);
            this.CBPW.Name = "CBPW";
            this.CBPW.Size = new System.Drawing.Size(99, 17);
            this.CBPW.TabIndex = 5;
            this.CBPW.Text = "show password";
            this.CBPW.UseVisualStyleBackColor = true;
            this.CBPW.CheckedChanged += new System.EventHandler(this.CBPW_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 413);
            this.Controls.Add(this.CBPW);
            this.Controls.Add(this.BTLOGIN);
            this.Controls.Add(this.TBPASSWORD);
            this.Controls.Add(this.TBUSERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUSERNAME;
        private System.Windows.Forms.TextBox TBPASSWORD;
        private System.Windows.Forms.Button BTLOGIN;
        private System.Windows.Forms.CheckBox CBPW;
    }
}