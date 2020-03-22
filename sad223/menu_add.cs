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
    public partial class menu_add : Form
    {
        MySqlConnection sql = new MySqlConnection();
        MySqlCommand cmd;

        MySqlDataAdapter adapter;
        BindingSource bind;
        DataTable dtable;

        Form main_menu;
        int method;
        private void command(String command)
        {
            cmd = new MySqlCommand(command, sql);
        }

        private void uupdate(DataGridView table)
        {
            adapter = new MySqlDataAdapter();
            bind = new BindingSource();
            dtable = new DataTable();

            adapter.SelectCommand = cmd;
            adapter.Fill(dtable);
            bind.DataSource = dtable;
            adapter.Update(dtable);
            table.DataSource = bind;
        }
        public menu_add(Form prev_menu, int mode)
        {
            method = mode;
            main_menu = prev_menu;
            InitializeComponent();
        }

        private void menu_add_Load(object sender, EventArgs e)
        {
            sql.ConnectionString = "server=localhost;userid=root;password=test;database=record system";
            switch (method)
            {
                case 0:
                    Text = "Add Record";
                    break;
                case 1:
                    Text = "Update Record";
                    b_add.Text = "Update";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Add button pressed
            
            for (int i = 0; i < gbox_info.Controls.Count; i++)
            {//check the info field for missing entries
                if (gbox_info.Controls[i] is TextBox)
                {
                    if (gbox_info.Controls[i].Text == "")
                    {
                        MessageBox.Show("Missing Field (Information)");
                        gbox_info.Controls[i].Focus();
                        return;
                    }
                }
            }

            for (int i = 0; i < gbox_reg.Controls.Count; i++)
            {//Check the reg field for missing entries
                //all of the controls inside the gbox_reg are panel containers
                bool complete = false;
                for (int f = 0; f < gbox_reg.Controls[i].Controls.Count; f++)
                {//check for checked radio buttons
                    RadioButton rad = gbox_reg.Controls[i].Controls[f] as RadioButton;
                    if (rad.Checked)
                    {
                        complete = true;
                        break;
                    }
                }
                if (!complete)
                {
                    MessageBox.Show("Missing field (Registration)");
                    gbox_reg.Controls[i].Focus();
                    return;
                }
            }

            for (int i = 0; i < gbox_finance.Controls.Count; i++)
            {//check the finance gbox
                if (gbox_finance.Controls[i] is TextBox)
                {//only enabled textboxes will be checked
                    if (gbox_finance.Controls[i].Enabled)
                    {
                        if (gbox_finance.Controls[i].Text == "")
                        {
                            MessageBox.Show("Missing field (Finance)");
                            gbox_finance.Controls[i].Focus();
                            return;
                        }
                    }
                }
            }

            //if all checks passed then update or add info
            /* command("UPDATE tblinfo set " + "date='" + date.Text + "',surname='" + t_lname.Text +
                 "', firstname='" + t_fname.Text + "',middlename='" + t_mname.Text +
                 "',contact='" + t_contact.Text + "',address='" + t_address.Text +
                 "',birthdate='" + date_bday.Text + "',birthplace='" + t_bplace.Text +
                 "',sex='" + t_sex.Text + "',nationality='" + t_nation.Text +
                 "',status='" + t_status.Text + "',occupation='" + t_work.Text +
                 "',course='" + t_course.Text + "',cash='" + t_cash.Text + "',balance='" + t_balance.Text +
                 "',remarks='" + t_remarks.Text +
                 "' where customerid ='" + t_id.Text + "'");
                 update command*/

            
            try
            {
                sql.Open();
                command("INSERT INTO tblrecord (customerid, date,surname, firstname,middlename,contact,address,birthdate,birthplace,sex,nationality,status,occupation,course,cash,balance,remarks)" +
                                " VALUES (" + t_id.Text + ",'" + date.Text + "','" + t_lname.Text +
                                    "','" + t_fname.Text + "','" + t_mname.Text +
                                    "','" + t_contact.Text + "','" + t_address.Text +
                                    "','" + date_bday.Text + "','" + t_bplace.Text +
                                    "','" + t_sex.Text + "','" + t_nation.Text +
                                    "','" + t_status.Text + "','" + t_work.Text +
                                    "','" + t_course.Text + "'," + t_cash.Text + "," + t_balance.Text +
                                    ",'" + t_remarks.Text + "')");
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Entries added successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(date.Text);
            }
            finally
            {
                sql.Dispose();
            }
            b_close.PerformClick();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            t_balance.Text = "0";//t_cash.Text;
        }
    }
}
