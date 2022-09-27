using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HunterShop
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == ""  || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Введены не все данные для создания новой записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NpgsqlConnection conn = ConnectToDatabase;
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;

                comm.CommandText = $"INSERT INTO public.customers" +
                  $"(first_name_cust, last_name_cust,middle_name_cust,login_cust,pass_cust,email_cust,phone_cust,discount_amount_cust)" +
                  $"VALUES('{textBox1.Text}','{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}',  '{textBox7.Text}', 0.02)";

                NpgsqlDataReader rdr = comm.ExecuteReader();

                comm.Dispose();
                conn.Dispose();
                conn.Close();
                this.Hide();

            }
        }
    }
}
