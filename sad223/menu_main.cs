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
    public partial class menu_main : Form
    {
        MySqlConnection sql = new MySqlConnection();
        MySqlCommand cmd;

        MySqlDataAdapter adapter;
        BindingSource bind;
        DataTable dtable;


        String fname;
        String lname;
        String search_type;
        bool can_update = false;
        Form main_form;

        private void command(String command)
        {
            cmd = new MySqlCommand(command, sql);
        }

        private void uupdate()
        {
            adapter = new MySqlDataAdapter();
            bind = new BindingSource();
            dtable = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dtable);
            bind.DataSource = dtable;
            adapter.Update(dtable);
            d_table.DataSource = bind;
                }

        public menu_main(String first_name, String last_name, Form login)
        {
            fname = first_name;
            lname = last_name;
            main_form = login;
            InitializeComponent();
        }
        private void menu_main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + fname + " " + lname);
            this.KeyPreview = true;
            sql.ConnectionString = "server=localhost;userid=root;password=test;database=record system";
            try
            {
                sql.Open();
                command("SELECT * FROM tblrecord");
                uupdate();
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

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void c_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            t_search.Enabled = true;
            switch (c_search.SelectedIndex)
            {
                case 0:
                    search_type = "customerid";
                    break;
                case 1:
                    search_type = "surname";
                    break;
                case 2:
                    search_type = "firstname";
                    break;
                case 3:
                    search_type = "middlename";
                    break;
                case 4:
                    search_type = "course";
                    break;
                default:
                    break;
            }
        }

        

        private void menu_main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.W)
            {
                logoutToolStripMenuItem.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.Q)
            {
                exitToolStripMenuItem.PerformClick();
            }
            else if(e.Control && e.KeyCode == Keys.J)
            {
                addToolStripMenuItem.PerformClick();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_form.Close();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_form.Show();
            can_update = false;
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            menu_add new_menu = new menu_add(this, 0);
            can_update = true;
            new_menu.Show();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Hide();
            menu_add new_menu = new menu_add(this, 1);
            new_menu.Show();*/
            MessageBox.Show(d_table.SelectedRows.Count.ToString());
        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                command("SELECT * FROM tblrecord WHERE `" + search_type + "` LIKE '" + t_search.Text + "%'");
                uupdate();
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

        private void menu_main_Activated(object sender, EventArgs e)
        {
            if (can_update)
            {
                try
                {
                    if (sql.State != ConnectionState.Open) sql.Open();
                    command("SELECT * FROM tblrecord");
                    uupdate();
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (d_table.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            can_update = false;
            DialogResult answer = MessageBox.Show("Delete row?", "Confirm Deletion", MessageBoxButtons.YesNo);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            if (answer == DialogResult.Yes)
            {
                //MessageBox.Show(d_table.SelectedRows.ToString());
                try
                {
                    sql.Open();
                    adapter = new MySqlDataAdapter("SELECT * FROM tblrecord", sql);
                    foreach (DataGridViewRow row in d_table.SelectedRows)
                    {
                        command("DELETE FROM tblrecord WHERE `customerid`=" + row.Cells[0].Value);
                        uupdate();
                    }
                    MessageBox.Show("Deleted successfully.");
                    command("SELECT * FROM tblrecord");
                    uupdate();
                    sql.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sql.Dispose();
                    can_update = true;
                }
            }
        }
    }
}
