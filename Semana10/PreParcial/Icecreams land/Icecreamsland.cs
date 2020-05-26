using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Icecreamsland;

namespace Icecreams_land
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.Equals(textBox1.Text))
            {
                Usuarios u = (Usuarios) comboBox1.SelectedItem;
                if (u.activo)
                {
                    if (Usuarios.admin)
                    {
                        AdminView admin = new AdminView();
                        admin.Show();
                    }
                    else
                    {
                        UserView user = new UserView();
                        user.Show();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = ConnectionDB.ExecuteQuery("SELECT usuario FROM USUARIOS");
            var customerCombo = new List<string>();

            foreach (DataRow dr in customer.Rows)
            {
                customerCombo.Add(dr[0].ToString());
            }

            comboBox1.DataSource = customerCombo;
        }
    }
}