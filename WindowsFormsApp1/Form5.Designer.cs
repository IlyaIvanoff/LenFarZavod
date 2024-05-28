namespace WindowsFormsApp1
{
    partial class Form5
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.CancelUser = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SearchCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Корзина";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(51, 65);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(337, 150);
            this.dataGridViewOrders.TabIndex = 18;
            // 
            // CreateOrder
            // 
            this.CreateOrder.BackColor = System.Drawing.Color.IndianRed;
            this.CreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateOrder.FlatAppearance.BorderSize = 0;
            this.CreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateOrder.ForeColor = System.Drawing.Color.White;
            this.CreateOrder.Location = new System.Drawing.Point(51, 267);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(153, 35);
            this.CreateOrder.TabIndex = 19;
            this.CreateOrder.Text = "Оформить";
            this.CreateOrder.UseVisualStyleBackColor = false;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // CancelUser
            // 
            this.CancelUser.BackColor = System.Drawing.Color.IndianRed;
            this.CancelUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelUser.FlatAppearance.BorderSize = 0;
            this.CancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelUser.ForeColor = System.Drawing.Color.White;
            this.CancelUser.Location = new System.Drawing.Point(235, 267);
            this.CancelUser.Margin = new System.Windows.Forms.Padding(4);
            this.CancelUser.Name = "CancelUser";
            this.CancelUser.Size = new System.Drawing.Size(153, 35);
            this.CancelUser.TabIndex = 20;
            this.CancelUser.Text = "Отклонить";
            this.CancelUser.UseVisualStyleBackColor = false;
            this.CancelUser.Click += new System.EventHandler(this.CancelUser_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(400, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SearchCart
            // 
            this.SearchCart.BackColor = System.Drawing.Color.IndianRed;
            this.SearchCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchCart.FlatAppearance.BorderSize = 0;
            this.SearchCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCart.ForeColor = System.Drawing.Color.White;
            this.SearchCart.Location = new System.Drawing.Point(144, 222);
            this.SearchCart.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCart.Name = "SearchCart";
            this.SearchCart.Size = new System.Drawing.Size(153, 35);
            this.SearchCart.TabIndex = 22;
            this.SearchCart.Text = "Просмотреть корзину";
            this.SearchCart.UseVisualStyleBackColor = false;
            this.SearchCart.Click += new System.EventHandler(this.SearchCart_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 376);
            this.Controls.Add(this.SearchCart);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CancelUser);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button CancelUser;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SearchCart;
    }
}