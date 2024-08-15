namespace ShopWindowsForms.Controls
{
    partial class UC_Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.button_Create = new System.Windows.Forms.Button();
            this.tbProd_Search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_ProductStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(3, 81);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.Size = new System.Drawing.Size(777, 473);
            this.dataGridView_Product.TabIndex = 1;
            this.dataGridView_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Product_CellContentClick);
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Create.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Create.Location = new System.Drawing.Point(19, 43);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(106, 23);
            this.button_Create.TabIndex = 3;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // tbProd_Search
            // 
            this.tbProd_Search.Location = new System.Drawing.Point(132, 45);
            this.tbProd_Search.Name = "tbProd_Search";
            this.tbProd_Search.Size = new System.Drawing.Size(392, 20);
            this.tbProd_Search.TabIndex = 4;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_search.Location = new System.Drawing.Point(530, 41);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(106, 27);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_ProductStatus
            // 
            this.label_ProductStatus.AutoSize = true;
            this.label_ProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ProductStatus.Location = new System.Drawing.Point(658, 49);
            this.label_ProductStatus.Name = "label_ProductStatus";
            this.label_ProductStatus.Size = new System.Drawing.Size(0, 16);
            this.label_ProductStatus.TabIndex = 6;
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_ProductStatus);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.tbProd_Search);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_Product);
            this.Controls.Add(this.label1);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(783, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.TextBox tbProd_Search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_ProductStatus;
    }
}
