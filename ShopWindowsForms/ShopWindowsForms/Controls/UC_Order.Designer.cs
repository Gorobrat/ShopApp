namespace ShopWindowsForms.Controls
{
    partial class UC_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.tbOrd_Search = new System.Windows.Forms.TextBox();
            this.label_OrderStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Order
            // 
            this.dataGridView_Order.AllowUserToAddRows = false;
            this.dataGridView_Order.AllowUserToDeleteRows = false;
            this.dataGridView_Order.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Order.Location = new System.Drawing.Point(3, 81);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.ReadOnly = true;
            this.dataGridView_Order.Size = new System.Drawing.Size(777, 473);
            this.dataGridView_Order.TabIndex = 0;
            this.dataGridView_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Order_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Create.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Create.Location = new System.Drawing.Point(19, 43);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(106, 23);
            this.button_Create.TabIndex = 4;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_search.Location = new System.Drawing.Point(529, 41);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(106, 27);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // tbOrd_Search
            // 
            this.tbOrd_Search.Location = new System.Drawing.Point(131, 45);
            this.tbOrd_Search.Name = "tbOrd_Search";
            this.tbOrd_Search.Size = new System.Drawing.Size(392, 20);
            this.tbOrd_Search.TabIndex = 6;
            // 
            // label_OrderStatus
            // 
            this.label_OrderStatus.AutoSize = true;
            this.label_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OrderStatus.Location = new System.Drawing.Point(652, 49);
            this.label_OrderStatus.Name = "label_OrderStatus";
            this.label_OrderStatus.Size = new System.Drawing.Size(0, 16);
            this.label_OrderStatus.TabIndex = 8;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_OrderStatus);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.tbOrd_Search);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Order);
            this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(783, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox tbOrd_Search;
        private System.Windows.Forms.Label label_OrderStatus;
    }
}
