
namespace HunterShop
{
    partial class ClientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_cust_label = new System.Windows.Forms.Label();
            this.listBox_table = new System.Windows.Forms.ListBox();
            this.show_table_button = new System.Windows.Forms.Button();
            this.my_orders_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_to_order_button = new System.Windows.Forms.Button();
            this.create_order_button = new System.Windows.Forms.Button();
            this.delete_prod_button = new System.Windows.Forms.Button();
            this.listBox1_manuf = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.remove_selected_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_cust_label
            // 
            this.id_cust_label.AutoSize = true;
            this.id_cust_label.Location = new System.Drawing.Point(12, 445);
            this.id_cust_label.Name = "id_cust_label";
            this.id_cust_label.Size = new System.Drawing.Size(36, 13);
            this.id_cust_label.TabIndex = 1;
            this.id_cust_label.Text = "label1";
            // 
            // listBox_table
            // 
            this.listBox_table.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_table.FormattingEnabled = true;
            this.listBox_table.ItemHeight = 25;
            this.listBox_table.Items.AddRange(new object[] {
            "Помповые ружья",
            "Самозарядные ружья",
            "Бокфлинт",
            "Пневматические винтовки"});
            this.listBox_table.Location = new System.Drawing.Point(12, 325);
            this.listBox_table.Name = "listBox_table";
            this.listBox_table.Size = new System.Drawing.Size(248, 104);
            this.listBox_table.TabIndex = 2;
            // 
            // show_table_button
            // 
            this.show_table_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_table_button.Location = new System.Drawing.Point(266, 335);
            this.show_table_button.Name = "show_table_button";
            this.show_table_button.Size = new System.Drawing.Size(122, 52);
            this.show_table_button.TabIndex = 3;
            this.show_table_button.Text = "Отобразить";
            this.show_table_button.UseVisualStyleBackColor = false;
            this.show_table_button.Click += new System.EventHandler(this.show_table_button_Click);
            // 
            // my_orders_button
            // 
            this.my_orders_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.my_orders_button.Location = new System.Drawing.Point(809, 406);
            this.my_orders_button.Name = "my_orders_button";
            this.my_orders_button.Size = new System.Drawing.Size(122, 52);
            this.my_orders_button.TabIndex = 4;
            this.my_orders_button.Text = "Мои заказы";
            this.my_orders_button.UseVisualStyleBackColor = false;
            this.my_orders_button.Click += new System.EventHandler(this.my_orders_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(792, 354);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Адрес доставки";
            // 
            // add_to_order_button
            // 
            this.add_to_order_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_to_order_button.Location = new System.Drawing.Point(627, 335);
            this.add_to_order_button.Name = "add_to_order_button";
            this.add_to_order_button.Size = new System.Drawing.Size(122, 52);
            this.add_to_order_button.TabIndex = 9;
            this.add_to_order_button.Text = "Добавить в корзину";
            this.add_to_order_button.UseVisualStyleBackColor = false;
            this.add_to_order_button.Click += new System.EventHandler(this.add_to_order_button_Click);
            // 
            // create_order_button
            // 
            this.create_order_button.BackColor = System.Drawing.Color.PaleGreen;
            this.create_order_button.Location = new System.Drawing.Point(992, 337);
            this.create_order_button.Name = "create_order_button";
            this.create_order_button.Size = new System.Drawing.Size(122, 52);
            this.create_order_button.TabIndex = 10;
            this.create_order_button.Text = "Создать заказ";
            this.create_order_button.UseVisualStyleBackColor = false;
            this.create_order_button.Click += new System.EventHandler(this.create_order_button_Click);
            // 
            // delete_prod_button
            // 
            this.delete_prod_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_prod_button.Location = new System.Drawing.Point(627, 406);
            this.delete_prod_button.Name = "delete_prod_button";
            this.delete_prod_button.Size = new System.Drawing.Size(122, 52);
            this.delete_prod_button.TabIndex = 11;
            this.delete_prod_button.Text = "Удалить из корзины";
            this.delete_prod_button.UseVisualStyleBackColor = false;
            this.delete_prod_button.Click += new System.EventHandler(this.delete_prod_button_Click);
            // 
            // listBox1_manuf
            // 
            this.listBox1_manuf.FormattingEnabled = true;
            this.listBox1_manuf.Location = new System.Drawing.Point(267, 407);
            this.listBox1_manuf.Name = "listBox1_manuf";
            this.listBox1_manuf.Size = new System.Drawing.Size(121, 56);
            this.listBox1_manuf.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Производитель";
            // 
            // remove_selected_button
            // 
            this.remove_selected_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.remove_selected_button.Location = new System.Drawing.Point(394, 407);
            this.remove_selected_button.Name = "remove_selected_button";
            this.remove_selected_button.Size = new System.Drawing.Size(122, 52);
            this.remove_selected_button.TabIndex = 14;
            this.remove_selected_button.Text = "Убрать выделенные критерии";
            this.remove_selected_button.UseVisualStyleBackColor = false;
            this.remove_selected_button.Click += new System.EventHandler(this.remove_selected_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.OrangeRed;
            this.exit_button.Location = new System.Drawing.Point(992, 407);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(122, 52);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "Выйти";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 471);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.remove_selected_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1_manuf);
            this.Controls.Add(this.delete_prod_button);
            this.Controls.Add(this.create_order_button);
            this.Controls.Add(this.add_to_order_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.my_orders_button);
            this.Controls.Add(this.show_table_button);
            this.Controls.Add(this.listBox_table);
            this.Controls.Add(this.id_cust_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "Магазин";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label id_cust_label;
        private System.Windows.Forms.ListBox listBox_table;
        private System.Windows.Forms.Button show_table_button;
        private System.Windows.Forms.Button my_orders_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_to_order_button;
        private System.Windows.Forms.Button create_order_button;
        private System.Windows.Forms.Button delete_prod_button;
        private System.Windows.Forms.ListBox listBox1_manuf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remove_selected_button;
        private System.Windows.Forms.Button exit_button;
    }
}