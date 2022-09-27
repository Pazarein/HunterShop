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
    public partial class OtkatForm : Form
    {
        public OtkatForm()
        {
            InitializeComponent();
        }
        public NpgsqlConnection ConnectToDatabase => new NpgsqlConnection("Server=localhost;Port=5432;DataBase=HunterShop;User Id=postgres;Password=1q2w3e4r");
        
        private void delete_otkat_button_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = ConnectToDatabase;
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            String HeaderName = otkat_dataGridView.Columns[0].HeaderText;
            comm.CommandText = $"DELETE FROM {otkat_tables_listBox.SelectedItem.ToString()} WHERE {HeaderName}={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}";

            NpgsqlDataReader rdr = comm.ExecuteReader();

            comm.Dispose();
            conn.Dispose();
            conn.Close();

            show_otkat_tables_button.PerformClick();
        }

        private void show_otkat_tables_button_Click(object sender, EventArgs e)
        {
            if (otkat_tables_listBox.SelectedIndex.ToString() != null)
            {

                NpgsqlConnection conn = ConnectToDatabase;
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
              
                {
                    comm.CommandText = $"SELECT * FROM {otkat_tables_listBox.SelectedItem.ToString()}";
                }


                NpgsqlDataReader rdr = comm.ExecuteReader();

                if (rdr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);
                    otkat_dataGridView.DataSource = dt;
                }
                else
                {
                    otkat_tables_listBox.Show();
                    MessageBox.Show("Таблица пуста!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите таблицу, которую хотите отобразить!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void otkat_prod_button_Click(object sender, EventArgs e)
        {
            if (otkat_dataGridView.GetCellCount(DataGridViewElementStates.Selected) > 8)
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
                NpgsqlCommand comm3 = new NpgsqlCommand();
                comm3.Connection = conn;
                comm3.CommandType = CommandType.Text;
                NpgsqlCommand comm4 = new NpgsqlCommand();
                comm4.Connection = conn;
                comm4.CommandType = CommandType.Text;
                NpgsqlCommand comm5 = new NpgsqlCommand();
                comm5.Connection = conn;
                comm5.CommandType = CommandType.Text;


                if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "DELETE")
                {

                    comm.CommandText = $"INSERT INTO public.products" +
                   $"(id_prod,id_categ,id_manuf,name_prod,price,weight,amount,license_requirement,desc_prod)" +  
                   $"VALUES" +
                   $"({otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"{otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"'{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}," +
                   $"{otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}," +
                   $"'{otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'); ";

                    NpgsqlDataReader rdr = comm.ExecuteReader();
                    rdr.DisposeAsync();

                    comm.Dispose();


                    comm1.CommandText = $"DELETE FROM products_otkat  WHERE id_prod={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();

                }


                 if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "INSERT")
                {


                    comm2.CommandText = $"DELETE FROM products_otkat  WHERE id_prod={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr2 = comm2.ExecuteReader();

                    rdr2.DisposeAsync();

                    comm2.Dispose();

                    comm3.CommandText = $"DELETE FROM  products WHERE id_prod={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr3 = comm3.ExecuteReader();

                    comm3.Cancel();
                    comm3.Dispose();

                    comm2.Dispose();
                    conn.Dispose();
                    conn.Close();

                }


                 if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "UPDATE")
                {


                    comm4.CommandText =
                        $"UPDATE products SET " +
                        $"id_categ = '{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"id_manuf = {otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                        $"name_prod = '{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"price = {otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                        $"weight = {otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                        $"amount = '{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"license_requirement = {otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}," +
                        $"desc_prod = '{otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'" +
                        $" WHERE id_prod = {otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";


                    NpgsqlDataReader rdr4 = comm4.ExecuteReader();

                    rdr4.DisposeAsync();

                    comm4.Dispose();

                    comm5.CommandText = $"DELETE FROM  products_otkat WHERE id_prod={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr5 = comm5.ExecuteReader();

                    comm5.Cancel();
                    comm5.Dispose();



                }



            }
            else
            {
                MessageBox.Show("Выберите запись целиком!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            show_otkat_tables_button.PerformClick();
        }

        private void otkat_staff_button_Click(object sender, EventArgs e)
        {
            if (otkat_dataGridView.GetCellCount(DataGridViewElementStates.Selected) > 9)
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
                NpgsqlCommand comm3 = new NpgsqlCommand();
                comm3.Connection = conn;
                comm3.CommandType = CommandType.Text;
                NpgsqlCommand comm4 = new NpgsqlCommand();
                comm4.Connection = conn;
                comm4.CommandType = CommandType.Text;
                NpgsqlCommand comm5 = new NpgsqlCommand();
                comm5.Connection = conn;
                comm5.CommandType = CommandType.Text;


                if (otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "DELETE")
                {

                    comm.CommandText = $"INSERT INTO public.staff" +
                   $"(id_staff,first_name_staff,last_name_staff,middle_name_staff,login_staff,pass_staff,position_staff,enhanced_rights)" +
                   $"VALUES" +
                   $"({otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"'{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                   $"'{otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                   $"{otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()});";

                    NpgsqlDataReader rdr = comm.ExecuteReader();
                    rdr.DisposeAsync();

                    comm.Dispose();


                    comm1.CommandText = $"DELETE FROM staff_otkat WHERE id_staff={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();

                }


                if (otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "INSERT")
                {


                    comm2.CommandText = $"DELETE FROM staff_otkat WHERE id_staff={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr2 = comm2.ExecuteReader();

                    rdr2.DisposeAsync();

                    comm2.Dispose();

                    comm3.CommandText = $"DELETE FROM  staff WHERE id_staff={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr3 = comm3.ExecuteReader();

                    comm3.Cancel();
                    comm3.Dispose();

                    comm2.Dispose();
                    conn.Dispose();
                    conn.Close();

                }


                if (otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "UPDATE")
                {


                    comm4.CommandText =
                        $"UPDATE staff SET " +
                        $"first_name_staff = '{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"last_name_staff  = '{otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"middle_name_staff = '{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"login_staff = '{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"pass_staff = '{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"position_staff = '{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"enhanced_rights = '{otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                        $" WHERE id_staff = {otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";


                    NpgsqlDataReader rdr4 = comm4.ExecuteReader();

                    rdr4.DisposeAsync();

                    comm4.Dispose();

                    comm5.CommandText = $"DELETE FROM  staff_otkat WHERE id_staff={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr5 = comm5.ExecuteReader();

                    comm5.Cancel();
                    comm5.Dispose();



                }



            }
            else
            {
                MessageBox.Show("Выберите запись целиком!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            show_otkat_tables_button.PerformClick();
        }

        private void otkat_customers_button_Click(object sender, EventArgs e)
        {
            if (otkat_dataGridView.GetCellCount(DataGridViewElementStates.Selected) > 8)
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
                NpgsqlCommand comm3 = new NpgsqlCommand();
                comm3.Connection = conn;
                comm3.CommandType = CommandType.Text;
                NpgsqlCommand comm4 = new NpgsqlCommand();
                comm4.Connection = conn;
                comm4.CommandType = CommandType.Text;
                NpgsqlCommand comm5 = new NpgsqlCommand();
                comm5.Connection = conn;
                comm5.CommandType = CommandType.Text;


                if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "DELETE")
                {

                    comm.CommandText = $"INSERT INTO public.customers" +
                   $"(id_cust,first_name_cust,last_name_cust,middle_name_cust,login_cust,pass_cust,email_cust,phone_cust,discount_amount_cust)" +
                   $"VALUES" +
                   $"({otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"'{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                   $"'{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                   $"'{otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                   $"{otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()});";

                    NpgsqlDataReader rdr = comm.ExecuteReader();
                    rdr.DisposeAsync();

                    comm.Dispose();


                    comm1.CommandText = $"DELETE FROM customers_otkat  WHERE id_cust={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();

                }


                if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "INSERT")
                {


                    comm2.CommandText = $"DELETE FROM customers_otkat WHERE id_cust={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr2 = comm2.ExecuteReader();

                    rdr2.DisposeAsync();

                    comm2.Dispose();

                    comm3.CommandText = $"DELETE FROM customers WHERE id_cust={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr3 = comm3.ExecuteReader();

                    comm3.Cancel();
                    comm3.Dispose();

                    comm2.Dispose();
                    conn.Dispose();
                    conn.Close();

                }


                if (otkat_dataGridView[9, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "UPDATE")
                {


                    comm4.CommandText =
                        $"UPDATE customers SET " +
                        $"first_name_cust = '{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"last_name_cust  = '{otkat_dataGridView[2, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"middle_name_cust = '{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"login_cust = '{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"pass_cust = '{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"email_cust = '{otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}', " +
                        $"phone_cust = '{otkat_dataGridView[7, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                        $"discount_amount_cust = {otkat_dataGridView[8, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}" +
                        $" WHERE id_cust = {otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";


                    NpgsqlDataReader rdr4 = comm4.ExecuteReader();

                    rdr4.DisposeAsync();

                    comm4.Dispose();

                    comm5.CommandText = $"DELETE FROM  customers_otkat WHERE id_cust={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr5 = comm5.ExecuteReader();

                    comm5.Cancel();
                    comm5.Dispose();



                }



            }
            else
            {
                MessageBox.Show("Выберите запись целиком!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            show_otkat_tables_button.PerformClick();
        }

        private void otkat_orders_button_Click(object sender, EventArgs e)
        {
            if (otkat_dataGridView.GetCellCount(DataGridViewElementStates.Selected) > 5)
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
                NpgsqlCommand comm3 = new NpgsqlCommand();
                comm3.Connection = conn;
                comm3.CommandType = CommandType.Text;
                NpgsqlCommand comm4 = new NpgsqlCommand();
                comm4.Connection = conn;
                comm4.CommandType = CommandType.Text;
                NpgsqlCommand comm5 = new NpgsqlCommand();
                comm5.Connection = conn;
                comm5.CommandType = CommandType.Text;


                if (otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "DELETE")
                {

                    comm.CommandText = $"INSERT INTO public.orders" +
                   $"(id_order,id_cast,id_staff,grand_total,status,pickup_point)" +
                   $"VALUES" +
                   $"({otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"{otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"null, " +
                   $"{otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                   $"'В рассмотрении', " +
                   $"'{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}') ";
                 

                    NpgsqlDataReader rdr = comm.ExecuteReader();
                    rdr.DisposeAsync();

                    comm.Dispose();


                    comm1.CommandText = $"DELETE FROM orders_otkat WHERE id_order={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr1 = comm1.ExecuteReader();

                }


                if (otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "INSERT")
                {


                    comm2.CommandText = $"DELETE FROM orders_otkat WHERE id_order={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}; ";
                    NpgsqlDataReader rdr2 = comm2.ExecuteReader();

                    rdr2.DisposeAsync();

                    comm2.Dispose();

                    comm3.CommandText = $"DELETE FROM orders WHERE id_order={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr3 = comm3.ExecuteReader();

                    comm3.Cancel();
                    comm3.Dispose();

                    comm2.Dispose();
                    conn.Dispose();
                    conn.Close();

                }


                if (otkat_dataGridView[6, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString() == "UPDATE")
                {


                    comm4.CommandText =
                        $"UPDATE orders SET " +
                        $"id_cast = {otkat_dataGridView[1, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}, " +
                        $"id_staff  = null, " +
                        $"grand_total = {Convert.ToInt32(otkat_dataGridView[3, otkat_dataGridView.CurrentCell.RowIndex].Value)}, " +
                        $"status = '{otkat_dataGridView[4, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}'," +
                        $"pickup_point = '{otkat_dataGridView[5, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()}' " +
                        $" WHERE id_order = {otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";


                    NpgsqlDataReader rdr4 = comm4.ExecuteReader();

                    rdr4.DisposeAsync();

                    comm4.Dispose();

                    comm5.CommandText = $"DELETE FROM orders_otkat WHERE id_order={otkat_dataGridView[0, otkat_dataGridView.CurrentCell.RowIndex].Value.ToString()};";
                    NpgsqlDataReader rdr5 = comm5.ExecuteReader();

                    comm5.Cancel();
                    comm5.Dispose();



                }



            }
            else
            {
                MessageBox.Show("Выберите запись целиком!", "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            show_otkat_tables_button.PerformClick();
        
        }
    }
}
