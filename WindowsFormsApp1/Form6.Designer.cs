namespace WindowsFormsApp1
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsersOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Nalichie = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.AcceptOrder = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IdItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchItem = new System.Windows.Forms.Button();
            this.CheckItems = new System.Windows.Forms.Button();
            this.CheckOrders = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nalichie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Заказы пользователей";
            // 
            // UsersOrders
            // 
            this.UsersOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersOrders.Location = new System.Drawing.Point(21, 55);
            this.UsersOrders.Name = "UsersOrders";
            this.UsersOrders.Size = new System.Drawing.Size(301, 229);
            this.UsersOrders.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(428, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Наличие на складе";
            // 
            // Nalichie
            // 
            this.Nalichie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Nalichie.Location = new System.Drawing.Point(353, 55);
            this.Nalichie.Name = "Nalichie";
            this.Nalichie.Size = new System.Drawing.Size(409, 229);
            this.Nalichie.TabIndex = 20;
            // 
            // OrderId
            // 
            this.OrderId.BackColor = System.Drawing.Color.Silver;
            this.OrderId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderId.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderId.ForeColor = System.Drawing.Color.Black;
            this.OrderId.Location = new System.Drawing.Point(69, 335);
            this.OrderId.Margin = new System.Windows.Forms.Padding(4);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(253, 24);
            this.OrderId.TabIndex = 21;
            // 
            // AcceptOrder
            // 
            this.AcceptOrder.BackColor = System.Drawing.Color.IndianRed;
            this.AcceptOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AcceptOrder.FlatAppearance.BorderSize = 0;
            this.AcceptOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptOrder.ForeColor = System.Drawing.Color.White;
            this.AcceptOrder.Location = new System.Drawing.Point(21, 392);
            this.AcceptOrder.Margin = new System.Windows.Forms.Padding(4);
            this.AcceptOrder.Name = "AcceptOrder";
            this.AcceptOrder.Size = new System.Drawing.Size(132, 35);
            this.AcceptOrder.TabIndex = 22;
            this.AcceptOrder.Text = "Принять";
            this.AcceptOrder.UseVisualStyleBackColor = false;
            this.AcceptOrder.Click += new System.EventHandler(this.AcceptOrder_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.BackColor = System.Drawing.Color.IndianRed;
            this.CancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelOrder.FlatAppearance.BorderSize = 0;
            this.CancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelOrder.ForeColor = System.Drawing.Color.White;
            this.CancelOrder.Location = new System.Drawing.Point(190, 392);
            this.CancelOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(132, 35);
            this.CancelOrder.TabIndex = 23;
            this.CancelOrder.Text = "Отменить";
            this.CancelOrder.UseVisualStyleBackColor = false;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "ФИО";
            // 
            // IdItem
            // 
            this.IdItem.BackColor = System.Drawing.Color.Silver;
            this.IdItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdItem.ForeColor = System.Drawing.Color.Black;
            this.IdItem.Location = new System.Drawing.Point(436, 335);
            this.IdItem.Margin = new System.Windows.Forms.Padding(4);
            this.IdItem.Name = "IdItem";
            this.IdItem.Size = new System.Drawing.Size(326, 24);
            this.IdItem.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(350, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID товара";
            // 
            // SearchItem
            // 
            this.SearchItem.BackColor = System.Drawing.Color.IndianRed;
            this.SearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchItem.FlatAppearance.BorderSize = 0;
            this.SearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchItem.ForeColor = System.Drawing.Color.White;
            this.SearchItem.Location = new System.Drawing.Point(353, 392);
            this.SearchItem.Margin = new System.Windows.Forms.Padding(4);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(409, 35);
            this.SearchItem.TabIndex = 27;
            this.SearchItem.Text = "Поиск";
            this.SearchItem.UseVisualStyleBackColor = false;
            this.SearchItem.Click += new System.EventHandler(this.SearchItem_Click);
            // 
            // CheckItems
            // 
            this.CheckItems.BackColor = System.Drawing.Color.IndianRed;
            this.CheckItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckItems.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckItems.FlatAppearance.BorderSize = 0;
            this.CheckItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckItems.ForeColor = System.Drawing.Color.White;
            this.CheckItems.Location = new System.Drawing.Point(353, 289);
            this.CheckItems.Margin = new System.Windows.Forms.Padding(4);
            this.CheckItems.Name = "CheckItems";
            this.CheckItems.Size = new System.Drawing.Size(409, 35);
            this.CheckItems.TabIndex = 28;
            this.CheckItems.Text = "Проверить наличие";
            this.CheckItems.UseVisualStyleBackColor = false;
            this.CheckItems.Click += new System.EventHandler(this.CheckItems_Click);
            // 
            // CheckOrders
            // 
            this.CheckOrders.BackColor = System.Drawing.Color.IndianRed;
            this.CheckOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOrders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckOrders.FlatAppearance.BorderSize = 0;
            this.CheckOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckOrders.ForeColor = System.Drawing.Color.White;
            this.CheckOrders.Location = new System.Drawing.Point(21, 289);
            this.CheckOrders.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOrders.Name = "CheckOrders";
            this.CheckOrders.Size = new System.Drawing.Size(301, 35);
            this.CheckOrders.TabIndex = 29;
            this.CheckOrders.Text = "Проверить заказы";
            this.CheckOrders.UseVisualStyleBackColor = false;
            this.CheckOrders.Click += new System.EventHandler(this.CheckOrders_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(755, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 30;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CheckOrders);
            this.Controls.Add(this.CheckItems);
            this.Controls.Add(this.SearchItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.AcceptOrder);
            this.Controls.Add(this.OrderId);
            this.Controls.Add(this.Nalichie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsersOrders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.UsersOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nalichie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UsersOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Nalichie;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Button AcceptOrder;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchItem;
        private System.Windows.Forms.Button CheckItems;
        private System.Windows.Forms.Button CheckOrders;
        private System.Windows.Forms.Button Exit;
    }
}