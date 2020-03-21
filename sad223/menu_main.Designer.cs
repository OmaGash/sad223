namespace sad223
{
    partial class menu_main
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
            this.c_search = new System.Windows.Forms.ComboBox();
            this.t_search = new System.Windows.Forms.TextBox();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d_table = new System.Windows.Forms.DataGridView();
            this.menu_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for";
            // 
            // c_search
            // 
            this.c_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_search.FormattingEnabled = true;
            this.c_search.Items.AddRange(new object[] {
            "ID",
            "Last Name",
            "First Name",
            "Middle Name",
            "Course"});
            this.c_search.Location = new System.Drawing.Point(74, 30);
            this.c_search.Name = "c_search";
            this.c_search.Size = new System.Drawing.Size(121, 21);
            this.c_search.TabIndex = 1;
            this.c_search.SelectedIndexChanged += new System.EventHandler(this.c_search_SelectedIndexChanged);
            // 
            // t_search
            // 
            this.t_search.Enabled = false;
            this.t_search.Location = new System.Drawing.Point(201, 30);
            this.t_search.Name = "t_search";
            this.t_search.Size = new System.Drawing.Size(100, 20);
            this.t_search.TabIndex = 2;
            this.t_search.TextChanged += new System.EventHandler(this.t_search_TextChanged);
            // 
            // menu_strip
            // 
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(324, 24);
            this.menu_strip.TabIndex = 4;
            this.menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logoutToolStripMenuItem.Text = "Logout (Ctrl + W)";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit (Ctrl + Q)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.recordToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addToolStripMenuItem.Text = "Add (Ctrl + J)";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.editToolStripMenuItem.Text = "Edit (Ctrl + K)";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.deleteIDToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            // 
            // deleteIDToolStripMenuItem
            // 
            this.deleteIDToolStripMenuItem.Name = "deleteIDToolStripMenuItem";
            this.deleteIDToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteIDToolStripMenuItem.Text = "Delete ID";
            // 
            // d_table
            // 
            this.d_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_table.Location = new System.Drawing.Point(12, 57);
            this.d_table.Name = "d_table";
            this.d_table.Size = new System.Drawing.Size(300, 245);
            this.d_table.TabIndex = 5;
            // 
            // menu_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 314);
            this.ControlBox = false;
            this.Controls.Add(this.d_table);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.c_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_strip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu_strip;
            this.Name = "menu_main";
            this.Text = "Record System";
            this.Load += new System.EventHandler(this.menu_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menu_main_KeyDown);
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox c_search;
        private System.Windows.Forms.TextBox t_search;
        private System.Windows.Forms.MenuStrip menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView d_table;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteIDToolStripMenuItem;
    }
}