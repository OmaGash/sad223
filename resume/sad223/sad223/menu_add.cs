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
    }
}
