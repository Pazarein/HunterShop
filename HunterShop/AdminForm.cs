using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using Npgsql;

namespace HunterShop
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");

        private void show_table_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"select * from {listBox_tables.SelectedItem.ToString()}";
            
            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView_admin.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void add_employee_button_Click(object sender, EventArgs e) // Кнопка добавления сотрудника
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
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

                comm.CommandText = $"INSERT INTO public.staff" +
                  $"(first_name_staff, last_name_staff, middle_name_staff, login_staff, pass_staff, position_staff, enhanced_rights)" +
                  $"VALUES('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}',{checkBox1.Checked.ToString()})";

                NpgsqlDataReader rdr = comm.ExecuteReader();

                comm.Dispose();
                conn.Dispose();
                conn.Close();


            }

        }

        private void add_new_manufacturers_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" )
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

                comm.CommandText = $"INSERT INTO public.manufacturers" +
                  $"(country, name_manuf, desc_manuf)" +
                  $"VALUES('{textBox7.Text}', '{textBox8.Text}', '{textBox9.Text}')";

                NpgsqlDataReader rdr = comm.ExecuteReader();

                comm.Dispose();
                conn.Dispose();
                conn.Close();


            }
        }

        private void add_new_category_Click(object sender, EventArgs e)
        {
            if (textBox10.Text == "" || textBox11.Text == "")
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

                comm.CommandText = $"INSERT INTO public.categories" +
                  $"(name_categ, desc_categ)" +
                  $"VALUES('{textBox10.Text}', '{textBox11.Text}')";

                NpgsqlDataReader rdr = comm.ExecuteReader();

                comm.Dispose();
                conn.Dispose();
                conn.Close();


            }
        }

        private void add_new_product_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "")
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
                try
                {
                    comm.CommandText = $"INSERT INTO public.products" +
                 $"(id_categ, id_manuf,name_prod,price,weight,amount,license_requirement,desc_prod)" +
                 $"VALUES(get_id_categ('{textBox12.Text}'), get_id_manuf('{textBox13.Text}'), '{textBox14.Text}', '{textBox15.Text}', '{textBox16.Text}', '{textBox17.Text}', {checkBox2.Checked.ToString()}, '{textBox18.Text}')";

                    NpgsqlDataReader rdr = comm.ExecuteReader();
                }
                catch
                {
                    MessageBox.Show("Данные введены неверно, возможно вы неправильно ввели название категории или производителя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                comm.Dispose();
                conn.Dispose();
                conn.Close();


            }
        }

        private void otkat_button_Click(object sender, EventArgs e)
        {
            OtkatForm OtkF = new OtkatForm();
            OtkF.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            String HeaderName = dataGridView_admin.Columns[0].HeaderText;

            if (listBox_tables.SelectedItems.Count == 1)
            {
                if (listBox_tables.SelectedItem.ToString() == "manufacturers" || listBox_tables.SelectedItem.ToString() == "categories" || listBox_tables.SelectedItem.ToString() == "orders_products")
                {
                    MessageBox.Show($"Вы не можете удалять данные из {listBox_tables.SelectedItem.ToString()}!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите произвести удаление?", "Внимание!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (listBox_tables.SelectedItem.ToString() == "orders" || listBox_tables.SelectedItem.ToString() == "products" || listBox_tables.SelectedItem.ToString() == "customers")
                        {
                            comm.CommandText = $"DELETE FROM {listBox_tables.SelectedItem.ToString()} CASCADE WHERE {HeaderName}={dataGridView_admin[0, dataGridView_admin.CurrentCell.RowIndex].Value.ToString()} ;";
                        }
                        else
                        {
                            comm.CommandText = $"DELETE FROM {listBox_tables.SelectedItem.ToString()} WHERE {HeaderName}={dataGridView_admin[0, dataGridView_admin.CurrentCell.RowIndex].Value.ToString()} ;";
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

        private void exit_button_Click(object sender, EventArgs e)
        {
            LoginForm CF = new LoginForm();
            CF.Show();
            this.Hide();
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
            String HeaderName = dataGridView_admin.Columns[0].HeaderText;
            if (listBox_tables.SelectedItem.ToString() == "orders")
            {

                int[] id_prod = new int[10];
                int counter1 = 0;
                comm2.CommandText = $"select id_prod from orders_products where id_order = {Convert.ToInt32(dataGridView_admin[0, dataGridView_admin.CurrentRow.Index].Value)}";
                NpgsqlDataReader rdr2 = comm2.ExecuteReader();
                while (rdr2.Read()) //Читаем пока есть данные
                {
                    id_prod[counter1] = (Convert.ToInt32(rdr2.GetValue(0)));
                    counter1++;
                }
                rdr2.Close();
                comm2.Dispose();

                for (int i = 0; id_prod[i] != 0; i++)
                {
                    comm1.CommandText = $"select * from update_amount({id_prod[i]});";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();
                    rdr1.Close();
                }

                comm.CommandText = $"UPDATE orders SET id_staff = 8, status = 'Отправлен по адресу' WHERE {HeaderName} = {dataGridView_admin[0, dataGridView_admin.CurrentRow.Index].Value.ToString()}; select * from {listBox_tables.SelectedItem.ToString()}; ";
                NpgsqlDataReader rdr = comm.ExecuteReader();
                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView_admin.DataSource = dt;
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

        private void reserved_copy_button_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            string d = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()
                + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

            
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"C:\Program Files\PostgreSQL\13\bin\";
            p.StartInfo.Arguments = "/k pg_dump.exe --file \"C:\\Users\\FargusMell\\source\\repos\\HunterShop" + d + ".sql\" --host \"localhost\" --port \"5432\" --username \"postgres\" --verbose --format=c --blobs \"HunterShop\"";
            p.Start();
            MessageBox.Show("Успешно!");
            p.Close();
        }

        private void download_copy_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL file (*.sql)|*.sql|All files(*.*)|*.*";
            string pathdb = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            pathdb = openFileDialog1.FileName;

            //cmd с указанием пути до pg_dump с параметром
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = @"C:\Program Files\PostgreSQL\13\bin\";
            p.StartInfo.Arguments = "/k pg_restore.exe --host \"localhost\" --port \"5432\" --username \"postgres\" --role \"postgres\" --dbname \"HunterShop\" --verbose \"" + pathdb + "\"";
            p.Start();
            MessageBox.Show("Успешно!");
            p.Close();
        }

        private void open_order_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = $"SELECT orders_products.id_prod,products.name_prod,products.price,orders_products.amount FROM orders_products join products on orders_products.id_prod = products.id_prod WHERE id_order={dataGridView_admin[0, dataGridView_admin.CurrentCell.RowIndex].Value.ToString()};";

            NpgsqlDataReader rdr = comm.ExecuteReader();

            if (rdr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView_admin.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comm.Dispose();
            conn.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_tables.SelectedItem.ToString() == "products")
            {
                NpgsqlConnection conn = ConnectToDatabase;
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;

                comm.CommandText = $"UPDATE products set amount = {Convert.ToInt32(textBox17.Text)} where id_prod = {dataGridView_admin[0, dataGridView_admin.CurrentRow.Index].Value}; select * from products";
                NpgsqlDataReader rdr = comm.ExecuteReader();

                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    dataGridView_admin.DataSource = dt;
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
    
}
