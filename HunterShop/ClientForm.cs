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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");
        int counter = 0;
        public string id_cust
        {
            get
            {
                return id_cust_label.Text;
            }
            set
            {
                this.id_cust_label.Text = value;
            }
        }
        
        private void ClientForm_Load(object sender, EventArgs e)  
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = $"SELECT name_manuf FROM manufacturers;";
            NpgsqlDataReader rdr = comm.ExecuteReader();
            while (rdr.Read()) //Читаем пока есть данные
            {
                listBox1_manuf.Items.Add(rdr.GetValue(0).ToString()); //Добавляем данные в лист итем
            }
            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void show_table_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            if (listBox_table.SelectedItem == null && listBox1_manuf.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали критерии для отображения!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (listBox1_manuf.SelectedItem != null && listBox_table.SelectedItem != null)
                {
                    if (listBox_table.SelectedItem.ToString() == "Помповые ружья")
                    {
                        comm.CommandText = $"SELECT  products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products where products.id_manuf={listBox1_manuf.SelectedIndex + 1} and products.id_categ = 1;";
                    }
                    if (listBox_table.SelectedItem.ToString() == "Самозарядные ружья")
                    {
                        comm.CommandText = $"SELECT  products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products where products.id_manuf={listBox1_manuf.SelectedIndex + 1} and products.id_categ = 2;";
                    }
                    if (listBox_table.SelectedItem.ToString() == "Бокфлинт")
                    {
                        comm.CommandText = $"SELECT  products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products where products.id_manuf={listBox1_manuf.SelectedIndex + 1} and products.id_categ = 3;";
                    }
                    if (listBox_table.SelectedItem.ToString() == "Пневматические винтовки")
                    {
                        comm.CommandText = $"SELECT  products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products where products.id_manuf={listBox1_manuf.SelectedIndex + 1} and products.id_categ = 4;";
                    }

                }
                else if (listBox_table.SelectedItem == null && listBox1_manuf.SelectedItem != null)
                {
                    
                        comm.CommandText = $"SELECT products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,categories.name_categ,products.desc_prod FROM products join categories on products.id_categ = categories.id_categ where products.id_manuf={listBox1_manuf.SelectedIndex + 1};";
                    
                }
                else
                {
                    if (listBox_table.SelectedItem.ToString() == "Помповые ружья") { comm.CommandText = $"SELECT manufacturers.name_manuf, products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products join manufacturers on products.id_manuf=manufacturers.id_manuf WHERE products.id_categ = 1;"; }
                    if (listBox_table.SelectedItem.ToString() == "Самозарядные ружья") { comm.CommandText = $"SELECT manufacturers.name_manuf, products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products join manufacturers on products.id_manuf=manufacturers.id_manuf WHERE products.id_categ = 2;"; }
                    if (listBox_table.SelectedItem.ToString() == "Бокфлинт") { comm.CommandText = $"SELECT manufacturers.name_manuf, products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products join manufacturers on products.id_manuf=manufacturers.id_manuf WHERE products.id_categ = 3;"; }
                    if (listBox_table.SelectedItem.ToString() == "Пневматические винтовки") { comm.CommandText = $"SELECT manufacturers.name_manuf, products.id_prod, products.name_prod,products.price,products.weight,products.amount,products.license_requirement,products.desc_prod FROM products join manufacturers on products.id_manuf=manufacturers.id_manuf WHERE products.id_categ = 4;"; }
                }
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
            }
            

            

            

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void my_orders_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"SELECT orders.grand_total,orders.status,orders.pickup_point FROM orders WHERE id_cast = {id_cust}";
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

        private void add_to_order_button_Click(object sender, EventArgs e)
        {
           
            
            
            
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = conn;
            comm1.CommandType = CommandType.Text;

            
            if (listBox1_manuf.SelectedItem != null)
            {
                if (counter == 0)
                {
                    comm1.CommandText = $"INSERT into orders (id_order,id_cast) VALUES (nextval('id_orders_seq'),{Convert.ToInt32(id_cust)})";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();
                    rdr1.Close();
                    comm.CommandText = $"INSERT into public.orders_products (id_order,id_prod,amount) VALUES (setval('id_orders_seq',nextval('id_orders_seq')-1),{Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)},{Convert.ToInt32(textBox1.Text)});" +
                                       $"SELECT * FROM public.orders_products WHERE id_order=currval('id_orders_seq');";
                    counter++;
                }
                else
                {
                    comm.CommandText = $"INSERT into public.orders_products (id_order,id_prod,amount) VALUES (setval('id_orders_seq',nextval('id_orders_seq')-1),{Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)},{Convert.ToInt32(textBox1.Text)});" +
                                       $"SELECT * FROM public.orders_products WHERE id_order=currval('id_orders_seq');";
                }
            }
            else
            {
                if (counter == 0)
                {
                    comm1.CommandText = $"INSERT into orders (id_order,id_cast) VALUES (nextval('id_orders_seq'),{Convert.ToInt32(id_cust)})";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();
                    rdr1.Close();
                    comm.CommandText = $"INSERT into public.orders_products (id_order,id_prod,amount) VALUES (setval('id_orders_seq',nextval('id_orders_seq')-1),{Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)},{Convert.ToInt32(textBox1.Text)});" +
                                       $"SELECT * FROM public.orders_products WHERE id_order=currval('id_orders_seq');";
                    counter++;
                }
                else
                {
                    comm.CommandText = $"INSERT into public.orders_products (id_order,id_prod,amount) VALUES (setval('id_orders_seq',nextval('id_orders_seq')-1),{Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)},{Convert.ToInt32(textBox1.Text)});" +
                                       $"SELECT * FROM public.orders_products WHERE id_order=currval('id_orders_seq');";
                }
            }
           
            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show(comm.CommandText, "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void create_order_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            if (textBox2.Text != null)
            {
                comm.CommandText = $"UPDATE orders set id_cast = {Convert.ToInt32(id_cust)}, grand_total = (select sum(products.price*orders_products.amount*0.98) from orders_products join products on orders_products.id_prod = products.id_prod WHERE orders_products.id_order = (SELECT last_value FROM id_orders_seq)), status = 'В рассмотрении', pickup_point = '{textBox2.Text}' where id_order = setval('id_orders_seq',nextval('id_orders_seq')-1)";

                NpgsqlDataReader rdr = comm.ExecuteReader();


                MessageBox.Show("Заказ добавлен", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ввеите адрес доставки", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void delete_prod_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            String HeaderName = dataGridView1.Columns[0].HeaderText;
            comm.CommandText = $"DELETE FROM orders_products WHERE {HeaderName}={dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()}; SELECT * FROM public.orders_products WHERE id_order=setval('id_orders_seq',nextval('id_orders_seq')-1);";
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

        private void remove_selected_button_Click(object sender, EventArgs e)
        {
            listBox1_manuf.ClearSelected();
            listBox_table.ClearSelected();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }
    }
}
