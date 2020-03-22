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

        public menu_main new_menu;
        public int access_level = 0;
        public String name_first;
        public String name_last;

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
                //MessageBox.Show("works");
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
                    name_first = reader.GetString("fname");
                    name_last = reader.GetString("lname");
                    if (int.TryParse(reader.GetString("alevel"), out access_level))
                    {
                        Hide();
                        new_menu = new menu_main(name_first, name_last, this, access_level);
                        t_pass.Text = "";
                        new_menu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
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
