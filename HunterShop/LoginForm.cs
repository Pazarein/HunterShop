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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;
            NpgsqlConnection conn1 = ConnectToDatabase;
            conn1.Open();


            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;

            comm1.CommandText = $"SELECT id_cust FROM customers WHERE login_cust='{loginUser}' AND pass_cust='{passwordUser}'";
            NpgsqlDataReader rdr1 = comm1.ExecuteReader();

            comm1.Dispose();

            if (rdr1.HasRows)
            {
                ClientForm CF = new ClientForm();
                CF.Show();
                rdr1.Read();
                CF.id_cust = rdr1.GetInt32(0).ToString();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;
            NpgsqlConnection conn1 = ConnectToDatabase;
            conn1.Open();


            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn1;
            comm1.CommandType = CommandType.Text;

            comm1.CommandText = $"SELECT id_staff FROM staff WHERE login_staff='{loginUser}' AND pass_staff='{passwordUser}'";
            NpgsqlDataReader rdr1 = comm1.ExecuteReader();

            comm1.Dispose();

            if (rdr1.HasRows)
            {
                ManagerForm CF = new ManagerForm();
                CF.Show();
                rdr1.Read();
                CF.id_staff = rdr1.GetInt32(0).ToString();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "admin" && passwordField.Text == "adminForm123")
            {
                AdminForm AdF = new AdminForm();
                AdF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            RegForm RegF = new RegForm();
            RegF.Show();
        }
    }
}
