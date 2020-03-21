using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sad223
{
    public partial class menu_add : Form
    {
        Form main_menu;
        public menu_add(Form prev_menu)
        {
            main_menu = prev_menu;
            InitializeComponent();
        }

        private void menu_add_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_menu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            t_balance.Text = t_cash.Text;
        }
    }
}
