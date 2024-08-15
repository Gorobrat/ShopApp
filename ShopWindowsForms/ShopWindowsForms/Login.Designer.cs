namespace ShopWindowsForms
{
    partial class Login
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
            this.tb_Log = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(160, 88);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(166, 20);
            this.tb_Log.TabIndex = 0;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(160, 127);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(166, 20);
            this.tb_Pass.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LogIn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_Log);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Log;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button button1;
    }
}