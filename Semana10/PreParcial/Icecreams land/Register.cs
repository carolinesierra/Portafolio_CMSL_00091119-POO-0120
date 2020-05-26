using System;
using System.Windows.Forms;
using Icecreamsland;

namespace Icecreams_land
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool userType = !radioButton1.Checked;

            try 
            {
                ConnectionDB.ExecuteNonQuery($"INSERT INTO USUARIOS VALUES(" +
                                             $"'{textBox1.Text}', " +
                                             $"'{textBox2.Text}', " +
                                             $"'{userType}', " + true + ")");
            
                MessageBox.Show("Los datos se han registrado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.");
            }
        }
    }

}