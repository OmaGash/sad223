using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sad223
{
    public partial class login : Form
    {
        MySqlConnection sql = new MySqlConnection();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            sql.ConnectionString = "server=localhost;userid=root;password=test;database=record system";
            try
            {
                sql.Open();
                MessageBox.Show("works");
                sql.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Dispose();
            }
        }

        private void c_show_CheckedChanged(object sender, EventArgs e)
        {
            if (c_show.Checked)
            {
                t_pass.UseSystemPasswordChar = false;
            }
            else
            {
t_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
