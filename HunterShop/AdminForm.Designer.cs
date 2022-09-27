
namespace HunterShop
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.show_table = new System.Windows.Forms.Button();
            this.listBox_tables = new System.Windows.Forms.ListBox();
            this.dataGridView_admin = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_employee_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add_new_category = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.add_new_manufacturers = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.add_new_product = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.otkat_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.reserved_copy_button = new System.Windows.Forms.Button();
            this.download_copy_button = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.open_order_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_table
            // 
            this.show_table.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_table.Location = new System.Drawing.Point(140, 12);
            this.show_table.Name = "show_table";
            this.show_table.Size = new System.Drawing.Size(105, 40);
            this.show_table.TabIndex = 0;
            this.show_table.Text = "Отобразить таблицу";
            this.show_table.UseVisualStyleBackColor = false;
            this.show_table.Click += new System.EventHandler(this.show_table_Click);
            // 
            // listBox_tables
            // 
            this.listBox_tables.FormattingEnabled = true;
            this.listBox_tables.Items.AddRange(new object[] {
            "staff",
            "categories",
            "orders",
            "orders_products",
            "products",
            "manufacturers",
            "customers"});
            this.listBox_tables.Location = new System.Drawing.Point(13, 13);
            this.listBox_tables.Name = "listBox_tables";
            this.listBox_tables.Size = new System.Drawing.Size(120, 95);
            this.listBox_tables.TabIndex = 1;
            // 
            // dataGridView_admin
            // 
            this.dataGridView_admin.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_admin.Location = new System.Drawing.Point(475, 13);
            this.dataGridView_admin.Name = "dataGridView_admin";
            this.dataGridView_admin.Size = new System.Drawing.Size(742, 478);
            this.dataGridView_admin.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(13, 189);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(456, 302);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add_employee_button);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(448, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // add_employee_button
            // 
            this.add_employee_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_employee_button.Location = new System.Drawing.Point(35, 199);
            this.add_employee_button.Name = "add_employee_button";
            this.add_employee_button.Size = new System.Drawing.Size(100, 38);
            this.add_employee_button.TabIndex = 14;
            this.add_employee_button.Text = "Добавить";
            this.add_employee_button.UseVisualStyleBackColor = false;
            this.add_employee_button.Click += new System.EventHandler(this.add_employee_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Есть?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 138);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Повышенные права";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add_new_category);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.add_new_manufacturers);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(448, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Производителя или категории";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // add_new_category
            // 
            this.add_new_category.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_new_category.Location = new System.Drawing.Point(326, 172);
            this.add_new_category.Name = "add_new_category";
            this.add_new_category.Size = new System.Drawing.Size(100, 38);
            this.add_new_category.TabIndex = 22;
            this.add_new_category.Text = "Добавить";
            this.add_new_category.UseVisualStyleBackColor = false;
            this.add_new_category.Click += new System.EventHandler(this.add_new_category_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.PeachPuff;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(8, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Категория";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.PeachPuff;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(8, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Производитель";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(89, 211);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(218, 22);
            this.textBox11.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(89, 172);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Описание:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Название:";
            // 
            // add_new_manufacturers
            // 
            this.add_new_manufacturers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_new_manufacturers.Location = new System.Drawing.Point(326, 33);
            this.add_new_manufacturers.Name = "add_new_manufacturers";
            this.add_new_manufacturers.Size = new System.Drawing.Size(100, 38);
            this.add_new_manufacturers.TabIndex = 15;
            this.add_new_manufacturers.Text = "Добавить";
            this.add_new_manufacturers.UseVisualStyleBackColor = false;
            this.add_new_manufacturers.Click += new System.EventHandler(this.add_new_manufacturers_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(89, 102);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(218, 22);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(89, 66);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(89, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Описание:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Название:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Страна:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.add_new_product);
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.textBox16);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(448, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Товара";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // add_new_product
            // 
            this.add_new_product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_new_product.Location = new System.Drawing.Point(342, 169);
            this.add_new_product.Name = "add_new_product";
            this.add_new_product.Size = new System.Drawing.Size(100, 38);
            this.add_new_product.TabIndex = 23;
            this.add_new_product.Text = "Добавить";
            this.add_new_product.UseVisualStyleBackColor = false;
            this.add_new_product.Click += new System.EventHandler(this.add_new_product_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(135, 211);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Требуется?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(87, 239);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(348, 22);
            this.textBox18.TabIndex = 14;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(96, 179);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(132, 22);
            this.textBox17.TabIndex = 13;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(52, 144);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(176, 22);
            this.textBox16.TabIndex = 12;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(80, 112);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(148, 22);
            this.textBox15.TabIndex = 11;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(85, 79);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(143, 22);
            this.textBox14.TabIndex = 10;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(117, 45);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(111, 22);
            this.textBox13.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(89, 13);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(139, 22);
            this.textBox12.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Описание:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Наличие лицензии:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Количество:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Вес:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Цена:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Название:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Производитель:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Категория:";
            // 
            // otkat_button
            // 
            this.otkat_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otkat_button.Location = new System.Drawing.Point(12, 128);
            this.otkat_button.Name = "otkat_button";
            this.otkat_button.Size = new System.Drawing.Size(105, 40);
            this.otkat_button.TabIndex = 4;
            this.otkat_button.Text = "Откат транзакций";
            this.otkat_button.UseVisualStyleBackColor = false;
            this.otkat_button.Click += new System.EventHandler(this.otkat_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Tomato;
            this.delete_button.Location = new System.Drawing.Point(364, 13);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(105, 40);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Удалить запись";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_button.Location = new System.Drawing.Point(364, 165);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(105, 40);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Выйти";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accept_button.Location = new System.Drawing.Point(364, 68);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(105, 40);
            this.accept_button.TabIndex = 11;
            this.accept_button.Text = "Подтвердить заказ";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // reserved_copy_button
            // 
            this.reserved_copy_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reserved_copy_button.Location = new System.Drawing.Point(140, 128);
            this.reserved_copy_button.Name = "reserved_copy_button";
            this.reserved_copy_button.Size = new System.Drawing.Size(105, 55);
            this.reserved_copy_button.TabIndex = 12;
            this.reserved_copy_button.Text = "Создать резервную копию";
            this.reserved_copy_button.UseVisualStyleBackColor = false;
            this.reserved_copy_button.Click += new System.EventHandler(this.reserved_copy_button_Click);
            // 
            // download_copy_button
            // 
            this.download_copy_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.download_copy_button.Location = new System.Drawing.Point(251, 128);
            this.download_copy_button.Name = "download_copy_button";
            this.download_copy_button.Size = new System.Drawing.Size(105, 55);
            this.download_copy_button.TabIndex = 13;
            this.download_copy_button.Text = "Загрузить резервную копию";
            this.download_copy_button.UseVisualStyleBackColor = false;
            this.download_copy_button.Click += new System.EventHandler(this.download_copy_button_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.IndianRed;
            this.label23.Location = new System.Drawing.Point(13, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Добавление";
            // 
            // open_order_button
            // 
            this.open_order_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.open_order_button.Location = new System.Drawing.Point(253, 62);
            this.open_order_button.Name = "open_order_button";
            this.open_order_button.Size = new System.Drawing.Size(105, 53);
            this.open_order_button.TabIndex = 15;
            this.open_order_button.Text = "Отобразить содержание заказа";
            this.open_order_button.UseVisualStyleBackColor = false;
            this.open_order_button.Click += new System.EventHandler(this.open_order_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(236, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 24;
            this.button1.Text = "Изменить только количество";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1229, 508);
            this.Controls.Add(this.open_order_button);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.download_copy_button);
            this.Controls.Add(this.reserved_copy_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.otkat_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView_admin);
            this.Controls.Add(this.listBox_tables);
            this.Controls.Add(this.show_table);
            this.Name = "AdminForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_admin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_table;
        private System.Windows.Forms.ListBox listBox_tables;
        private System.Windows.Forms.DataGridView dataGridView_admin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_employee_button;
        private System.Windows.Forms.Button add_new_manufacturers;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button add_new_category;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button add_new_product;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button otkat_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button reserved_copy_button;
        private System.Windows.Forms.Button download_copy_button;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button open_order_button;
        private System.Windows.Forms.Button button1;
    }
}