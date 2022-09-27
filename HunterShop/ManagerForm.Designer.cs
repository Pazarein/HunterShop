
namespace HunterShop
{
    partial class ManagerForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.show_table = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.accept_button = new System.Windows.Forms.Button();
            this.id_staff_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.open_order_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "categories",
            "orders",
            "orders_products",
            "products",
            "manufacturers",
            "customers"});
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 95);
            this.listBox1.TabIndex = 1;
            // 
            // show_table
            // 
            this.show_table.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_table.Location = new System.Drawing.Point(12, 114);
            this.show_table.Name = "show_table";
            this.show_table.Size = new System.Drawing.Size(105, 40);
            this.show_table.TabIndex = 2;
            this.show_table.Text = "Отобразить таблицу";
            this.show_table.UseVisualStyleBackColor = false;
            this.show_table.Click += new System.EventHandler(this.show_table_Click_1);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.Tomato;
            this.delete_button.Location = new System.Drawing.Point(12, 160);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(105, 40);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить запись";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accept_button.Location = new System.Drawing.Point(12, 265);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(105, 40);
            this.accept_button.TabIndex = 7;
            this.accept_button.Text = "Подтвердить заказ";
            this.accept_button.UseVisualStyleBackColor = false;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // id_staff_label
            // 
            this.id_staff_label.AutoSize = true;
            this.id_staff_label.Location = new System.Drawing.Point(13, 424);
            this.id_staff_label.Name = "id_staff_label";
            this.id_staff_label.Size = new System.Drawing.Size(36, 13);
            this.id_staff_label.TabIndex = 8;
            this.id_staff_label.Text = "label1";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit_button.Location = new System.Drawing.Point(13, 381);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(105, 40);
            this.exit_button.TabIndex = 9;
            this.exit_button.Text = "Выйти";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // open_order_button
            // 
            this.open_order_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.open_order_button.Location = new System.Drawing.Point(12, 206);
            this.open_order_button.Name = "open_order_button";
            this.open_order_button.Size = new System.Drawing.Size(105, 53);
            this.open_order_button.TabIndex = 10;
            this.open_order_button.Text = "Отобразить содержание заказа";
            this.open_order_button.UseVisualStyleBackColor = false;
            this.open_order_button.Click += new System.EventHandler(this.open_order_button_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.open_order_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.id_staff_label);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.show_table);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button show_table;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Label id_staff_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button open_order_button;
    }
}