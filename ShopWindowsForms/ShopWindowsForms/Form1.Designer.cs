namespace ShopWindowsForms
{
    partial class Form1
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
            this.btn_search = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.tb_View = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_changeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_search.Location = new System.Drawing.Point(1027, 144);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(122, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Execute";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(868, 131);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 1;
            this.Id.Text = "Id";
            // 
            // tb_View
            // 
            this.tb_View.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_View.Location = new System.Drawing.Point(12, 12);
            this.tb_View.Multiline = true;
            this.tb_View.Name = "tb_View";
            this.tb_View.Size = new System.Drawing.Size(823, 439);
            this.tb_View.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(862, 147);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(356, 613);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.vScrollBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(997, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Product",
            "User",
            "Orders"});
            this.comboBox2.Location = new System.Drawing.Point(862, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Get",
            "Put",
            "Post",
            "Delete"});
            this.comboBox3.Location = new System.Drawing.Point(862, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(862, 173);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(287, 20);
            this.textBox_message.TabIndex = 13;
            // 
            // button_changeForm
            // 
            this.button_changeForm.Location = new System.Drawing.Point(887, 510);
            this.button_changeForm.Name = "button_changeForm";
            this.button_changeForm.Size = new System.Drawing.Size(75, 23);
            this.button_changeForm.TabIndex = 14;
            this.button_changeForm.Text = "button1";
            this.button_changeForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 695);
            this.Controls.Add(this.button_changeForm);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.tb_View);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox tb_View;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_changeForm;
    }
}

