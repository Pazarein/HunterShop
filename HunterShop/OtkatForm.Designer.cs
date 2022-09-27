
namespace HunterShop
{
    partial class OtkatForm
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
            this.otkat_tables_listBox = new System.Windows.Forms.ListBox();
            this.delete_otkat_button = new System.Windows.Forms.Button();
            this.otkat_dataGridView = new System.Windows.Forms.DataGridView();
            this.show_otkat_tables_button = new System.Windows.Forms.Button();
            this.otkat_prod_button = new System.Windows.Forms.Button();
            this.otkat_staff_button = new System.Windows.Forms.Button();
            this.otkat_customers_button = new System.Windows.Forms.Button();
            this.otkat_orders_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otkat_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // otkat_tables_listBox
            // 
            this.otkat_tables_listBox.FormattingEnabled = true;
            this.otkat_tables_listBox.Items.AddRange(new object[] {
            "staff_otkat",
            "products_otkat",
            "customers_otkat",
            "orders_otkat"});
            this.otkat_tables_listBox.Location = new System.Drawing.Point(12, 12);
            this.otkat_tables_listBox.Name = "otkat_tables_listBox";
            this.otkat_tables_listBox.Size = new System.Drawing.Size(134, 95);
            this.otkat_tables_listBox.TabIndex = 0;
            // 
            // delete_otkat_button
            // 
            this.delete_otkat_button.BackColor = System.Drawing.Color.Salmon;
            this.delete_otkat_button.Location = new System.Drawing.Point(13, 114);
            this.delete_otkat_button.Name = "delete_otkat_button";
            this.delete_otkat_button.Size = new System.Drawing.Size(133, 51);
            this.delete_otkat_button.TabIndex = 1;
            this.delete_otkat_button.Text = "Удалить данные из темпоральной таблицы";
            this.delete_otkat_button.UseVisualStyleBackColor = false;
            this.delete_otkat_button.Click += new System.EventHandler(this.delete_otkat_button_Click);
            // 
            // otkat_dataGridView
            // 
            this.otkat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otkat_dataGridView.Location = new System.Drawing.Point(259, 13);
            this.otkat_dataGridView.Name = "otkat_dataGridView";
            this.otkat_dataGridView.RowTemplate.Height = 24;
            this.otkat_dataGridView.Size = new System.Drawing.Size(1034, 425);
            this.otkat_dataGridView.TabIndex = 2;
            // 
            // show_otkat_tables_button
            // 
            this.show_otkat_tables_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_otkat_tables_button.Location = new System.Drawing.Point(152, 13);
            this.show_otkat_tables_button.Name = "show_otkat_tables_button";
            this.show_otkat_tables_button.Size = new System.Drawing.Size(101, 53);
            this.show_otkat_tables_button.TabIndex = 3;
            this.show_otkat_tables_button.Text = "Выбор таблицы для отката";
            this.show_otkat_tables_button.UseVisualStyleBackColor = false;
            this.show_otkat_tables_button.Click += new System.EventHandler(this.show_otkat_tables_button_Click);
            // 
            // otkat_prod_button
            // 
            this.otkat_prod_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otkat_prod_button.Location = new System.Drawing.Point(13, 171);
            this.otkat_prod_button.Name = "otkat_prod_button";
            this.otkat_prod_button.Size = new System.Drawing.Size(101, 53);
            this.otkat_prod_button.TabIndex = 4;
            this.otkat_prod_button.Text = "Откат товаров";
            this.otkat_prod_button.UseVisualStyleBackColor = false;
            this.otkat_prod_button.Click += new System.EventHandler(this.otkat_prod_button_Click);
            // 
            // otkat_staff_button
            // 
            this.otkat_staff_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otkat_staff_button.Location = new System.Drawing.Point(12, 230);
            this.otkat_staff_button.Name = "otkat_staff_button";
            this.otkat_staff_button.Size = new System.Drawing.Size(101, 53);
            this.otkat_staff_button.TabIndex = 5;
            this.otkat_staff_button.Text = "Откат персонала";
            this.otkat_staff_button.UseVisualStyleBackColor = false;
            this.otkat_staff_button.Click += new System.EventHandler(this.otkat_staff_button_Click);
            // 
            // otkat_customers_button
            // 
            this.otkat_customers_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otkat_customers_button.Location = new System.Drawing.Point(13, 289);
            this.otkat_customers_button.Name = "otkat_customers_button";
            this.otkat_customers_button.Size = new System.Drawing.Size(101, 53);
            this.otkat_customers_button.TabIndex = 6;
            this.otkat_customers_button.Text = "Откат покупателей";
            this.otkat_customers_button.UseVisualStyleBackColor = false;
            this.otkat_customers_button.Click += new System.EventHandler(this.otkat_customers_button_Click);
            // 
            // otkat_orders_button
            // 
            this.otkat_orders_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otkat_orders_button.Location = new System.Drawing.Point(13, 348);
            this.otkat_orders_button.Name = "otkat_orders_button";
            this.otkat_orders_button.Size = new System.Drawing.Size(101, 53);
            this.otkat_orders_button.TabIndex = 7;
            this.otkat_orders_button.Text = "Откат заказов";
            this.otkat_orders_button.UseVisualStyleBackColor = false;
            this.otkat_orders_button.Click += new System.EventHandler(this.otkat_orders_button_Click);
            // 
            // OtkatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 450);
            this.Controls.Add(this.otkat_orders_button);
            this.Controls.Add(this.otkat_customers_button);
            this.Controls.Add(this.otkat_staff_button);
            this.Controls.Add(this.otkat_prod_button);
            this.Controls.Add(this.show_otkat_tables_button);
            this.Controls.Add(this.otkat_dataGridView);
            this.Controls.Add(this.delete_otkat_button);
            this.Controls.Add(this.otkat_tables_listBox);
            this.Name = "OtkatForm";
            this.Text = "OtkatForm";
            ((System.ComponentModel.ISupportInitialize)(this.otkat_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox otkat_tables_listBox;
        private System.Windows.Forms.Button delete_otkat_button;
        private System.Windows.Forms.DataGridView otkat_dataGridView;
        private System.Windows.Forms.Button show_otkat_tables_button;
        private System.Windows.Forms.Button otkat_prod_button;
        private System.Windows.Forms.Button otkat_staff_button;
        private System.Windows.Forms.Button otkat_customers_button;
        private System.Windows.Forms.Button otkat_orders_button;
    }
}