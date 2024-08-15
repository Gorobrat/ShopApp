namespace ShopWindowsForms
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Top = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_User = new Guna.UI2.WinForms.Guna2Button();
            this.btn_product = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 70);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label_Top
            // 
            this.label_Top.AutoSize = true;
            this.label_Top.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Top.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Top.Location = new System.Drawing.Point(275, 22);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(214, 27);
            this.label_Top.TabIndex = 0;
            this.label_Top.Text = "Welcome our shop";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.guna2Button2);
            this.panel4.Controls.Add(this.btn_User);
            this.panel4.Controls.Add(this.btn_product);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 48);
            this.panel4.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(523, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(254, 42);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Orders";
            this.guna2Button2.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_User
            // 
            this.btn_User.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_User.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_User.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_User.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.btn_User.CustomBorderColor = System.Drawing.Color.White;
            this.btn_User.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btn_User.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_User.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_User.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_User.FillColor = System.Drawing.Color.White;
            this.btn_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_User.ForeColor = System.Drawing.Color.Black;
            this.btn_User.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_User.Location = new System.Drawing.Point(263, 3);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(254, 42);
            this.btn_User.TabIndex = 1;
            this.btn_User.Text = "Users";
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_product
            // 
            this.btn_product.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_product.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_product.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_product.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.btn_product.CustomBorderColor = System.Drawing.Color.White;
            this.btn_product.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btn_product.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_product.FillColor = System.Drawing.Color.White;
            this.btn_product.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_product.ForeColor = System.Drawing.Color.Black;
            this.btn_product.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btn_product.Location = new System.Drawing.Point(3, 3);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(254, 42);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Products";
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 118);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(783, 557);
            this.panelContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Oure Shop";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(783, 675);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btn_product;
        private Guna.UI2.WinForms.Guna2Button btn_User;
        private System.Windows.Forms.Label label_Top;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
    }
}