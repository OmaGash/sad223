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
        MySqlDataReader reader;
        MySqlCommand cmd;

        public int access_level = 0;

        public login()
        {
            InitializeComponent();
        }

        private void command(String command)
        {
            cmd = new MySqlCommand(command, sql);
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

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                sql.Open();
                command("SELECT * FROM tbllog WHERE `uname`='" +
                    t_uname.Text + "' AND `pword`='" + t_pass.Text + "'" ) ;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    MessageBox.Show("logged in");
                    if (int.TryParse(reader.GetString("alevel"), out access_level))
                    {
                        MessageBox.Show(access_level.ToString());
                    }
                }
                else
                {
                    MessageBox.Show(count.ToString());
                }

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
    }
}
