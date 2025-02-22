namespace WindowsFormsApp1
{
    partial class FormHD
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxMahang = new System.Windows.Forms.ComboBox();
            this.comboBoxMakh = new System.Windows.Forms.ComboBox();
            this.textBoxSoluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Mahd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaymua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mahang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(637, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 64);
            this.button3.TabIndex = 27;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 64);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 64);
            this.button1.TabIndex = 25;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxMahang
            // 
            this.comboBoxMahang.FormattingEnabled = true;
            this.comboBoxMahang.Location = new System.Drawing.Point(433, 140);
            this.comboBoxMahang.Name = "comboBoxMahang";
            this.comboBoxMahang.Size = new System.Drawing.Size(416, 37);
            this.comboBoxMahang.TabIndex = 24;
            // 
            // comboBoxMakh
            // 
            this.comboBoxMakh.FormattingEnabled = true;
            this.comboBoxMakh.Location = new System.Drawing.Point(433, 92);
            this.comboBoxMakh.Name = "comboBoxMakh";
            this.comboBoxMakh.Size = new System.Drawing.Size(416, 37);
            this.comboBoxMakh.TabIndex = 23;
            // 
            // textBoxSoluong
            // 
            this.textBoxSoluong.Location = new System.Drawing.Point(433, 189);
            this.textBoxSoluong.Name = "textBoxSoluong";
            this.textBoxSoluong.Size = new System.Drawing.Size(416, 37);
            this.textBoxSoluong.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "So Luong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ma KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ma hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mahd,
            this.Ngaymua,
            this.Makh,
            this.Mahang,
            this.Soluong});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 318);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1155, 322);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Mahd
            // 
            this.Mahd.Text = "Ma HD";
            this.Mahd.Width = 137;
            // 
            // Ngaymua
            // 
            this.Ngaymua.Text = "Ngay Mua";
            this.Ngaymua.Width = 176;
            // 
            // Makh
            // 
            this.Makh.Text = "Ma KH";
            this.Makh.Width = 158;
            // 
            // Mahang
            // 
            this.Mahang.Text = "Mahang";
            this.Mahang.Width = 131;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Soluong";
            this.Soluong.Width = 138;
            // 
            // FormHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxMahang);
            this.Controls.Add(this.comboBoxMakh);
            this.Controls.Add(this.textBoxSoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormHD";
            this.Text = "FormHD";
            this.Load += new System.EventHandler(this.FormHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMahang;
        private System.Windows.Forms.ComboBox comboBoxMakh;
        private System.Windows.Forms.TextBox textBoxSoluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Mahd;
        private System.Windows.Forms.ColumnHeader Ngaymua;
        private System.Windows.Forms.ColumnHeader Makh;
        private System.Windows.Forms.ColumnHeader Mahang;
        private System.Windows.Forms.ColumnHeader Soluong;
    }
}