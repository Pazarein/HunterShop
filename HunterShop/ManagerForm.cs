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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");

        public string id_staff
        {
            get
            {
                return id_staff_label.Text;
            }
            set
            {
                this.id_staff_label.Text = value;
            }
        }

        private void show_table_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"select * from {listBox1.SelectedItem.ToString()}";

            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            
                NpgsqlConnection conn = ConnectToDatabase;
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                String HeaderName = dataGridView1.Columns[0].HeaderText;

                if (listBox1.SelectedItems.Count == 1)
                {
                    if (listBox1.SelectedItem.ToString() == "manufacturers" || listBox1.SelectedItem.ToString() == "categories" || listBox1.SelectedItem.ToString() == "orders_products")
                    {
                        MessageBox.Show($"Вы не можете удалять данные из {listBox1.SelectedItem.ToString()}!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите произвести удаление?", "Внимание!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (listBox1.SelectedItem.ToString() == "orders" || listBox1.SelectedItem.ToString() == "products" || listBox1.SelectedItem.ToString() == "customers")
                            {
                                comm.CommandText = $"DELETE FROM {listBox1.SelectedItem.ToString()} CASCADE WHERE {HeaderName}={dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()} ;";
                            }
                            else
                            {
                                comm.CommandText = $"DELETE FROM {listBox1.SelectedItem.ToString()} WHERE {HeaderName}={dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()} ;";
                            }

                            NpgsqlDataReader rdr_del = comm.ExecuteReader();




                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Вы отменили удаление!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите таблицу для удаления!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comm.Dispose();
                conn.Dispose();
                conn.Close();
            
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn;
            comm1.CommandType = CommandType.Text;
            NpgsqlCommand comm2 = new NpgsqlCommand();
            comm2.Connection = conn;
            comm2.CommandType = CommandType.Text;
            String HeaderName = dataGridView1.Columns[0].HeaderText;
            if (listBox1.SelectedItem.ToString() == "orders")
            {

                int [] id_prod = new int[10];
                int counter1 = 0;
                comm2.CommandText = $"select id_prod from orders_products where id_order = {Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)}";
                NpgsqlDataReader rdr2 = comm2.ExecuteReader();
                while (rdr2.Read()) //Читаем пока есть данные
                {
                    id_prod[counter1] = (Convert.ToInt32(rdr2.GetValue(0)));
                    counter1++;
                }
                rdr2.Close();
                comm2.Dispose();

                for (int i = 0; id_prod[i] != 0; i++ )
                {
                    comm1.CommandText = $"select * from update_amount({id_prod[i]});";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();
                    rdr1.Close();
                }
                
                comm.CommandText = $"UPDATE orders SET id_staff = {id_staff}, status = 'Отправлен по адресу' WHERE {HeaderName} = {dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()}; select * from {listBox1.SelectedItem.ToString()}; ";
                NpgsqlDataReader rdr = comm.ExecuteReader();
                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Ошибка!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comm1.Dispose();
            comm.Dispose();
            conn.Dispose();
            conn.Close();

        }

        private void show_table_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"select * from {listBox1.SelectedItem.ToString()}";

            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            LoginForm CF = new LoginForm();
            CF.Show();
            this.Hide();
        }

        private void open_order_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"SELECT orders_products.id_prod,products.name_prod,products.price,orders_products.amount FROM orders_products join products on orders_products.id_prod = products.id_prod WHERE id_order={ dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString()};";

            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }
    }
}
