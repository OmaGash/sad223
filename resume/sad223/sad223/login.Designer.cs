namespace sad223
{
    partial class login
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
            this.t_uname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_show = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // t_uname
            // 
            this.t_uname.Location = new System.Drawing.Point(115, 75);
            this.t_uname.Name = "t_uname";
            this.t_uname.Size = new System.Drawing.Size(100, 20);
            this.t_uname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username: ";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(115, 184);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 3;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(115, 115);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(100, 20);
            this.t_pass.TabIndex = 1;
            this.t_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password: ";
            // 
            // c_show
            // 
            this.c_show.AutoSize = true;
            this.c_show.Location = new System.Drawing.Point(115, 151);
            this.c_show.Name = "c_show";
            this.c_show.Size = new System.Drawing.Size(102, 17);
            this.c_show.TabIndex = 2;
            this.c_show.Text = "Show Password";
            this.c_show.UseVisualStyleBackColor = true;
            this.c_show.CheckedChanged += new System.EventHandler(this.c_show_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 294);
            this.Controls.Add(this.c_show);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.t_uname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_uname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox c_show;
    }
}

