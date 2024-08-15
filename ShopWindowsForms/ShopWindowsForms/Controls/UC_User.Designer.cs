namespace ShopWindowsForms.Controls
{
    partial class UC_User
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
            this.dataGridView_User = new System.Windows.Forms.DataGridView();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.tbUs_Search = new System.Windows.Forms.TextBox();
            this.label_UserStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // dataGridView_User
            // 
            this.dataGridView_User.AllowUserToAddRows = false;
            this.dataGridView_User.AllowUserToDeleteRows = false;
            this.dataGridView_User.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_User.Location = new System.Drawing.Point(3, 81);
            this.dataGridView_User.Name = "dataGridView_User";
            this.dataGridView_User.Size = new System.Drawing.Size(777, 473);
            this.dataGridView_User.TabIndex = 1;
            this.dataGridView_User.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_User_CellContentClick);
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Create.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Create.Location = new System.Drawing.Point(19, 43);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(106, 23);
            this.button_Create.TabIndex = 2;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_search.Location = new System.Drawing.Point(530, 41);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(106, 27);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // tbUs_Search
            // 
            this.tbUs_Search.Location = new System.Drawing.Point(132, 45);
            this.tbUs_Search.Name = "tbUs_Search";
            this.tbUs_Search.Size = new System.Drawing.Size(392, 20);
            this.tbUs_Search.TabIndex = 6;
            // 
            // label_UserStatus
            // 
            this.label_UserStatus.AutoSize = true;
            this.label_UserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_UserStatus.Location = new System.Drawing.Point(651, 48);
            this.label_UserStatus.Name = "label_UserStatus";
            this.label_UserStatus.Size = new System.Drawing.Size(0, 16);
            this.label_UserStatus.TabIndex = 8;
            // 
            // UC_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label_UserStatus);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.tbUs_Search);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.dataGridView_User);
            this.Controls.Add(this.label1);
            this.Name = "UC_User";
            this.Size = new System.Drawing.Size(783, 557);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_User;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox tbUs_Search;
        private System.Windows.Forms.Label label_UserStatus;
    }
}
