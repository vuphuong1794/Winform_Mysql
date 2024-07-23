namespace connectSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.HoTen = new System.Windows.Forms.Label();
            this.NamSinh = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_namsinh = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(343, 386);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(449, 386);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(553, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // HoTen
            // 
            this.HoTen.AutoSize = true;
            this.HoTen.Location = new System.Drawing.Point(12, 92);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(39, 13);
            this.HoTen.TabIndex = 4;
            this.HoTen.Text = "Họ tên";
            // 
            // NamSinh
            // 
            this.NamSinh.AutoSize = true;
            this.NamSinh.Location = new System.Drawing.Point(12, 133);
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.Size = new System.Drawing.Size(51, 13);
            this.NamSinh.TabIndex = 5;
            this.NamSinh.Text = "Năm sinh";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(13, 167);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(40, 13);
            this.DiaChi.TabIndex = 6;
            this.DiaChi.Text = "Địa chỉ";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(13, 49);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 7;
            this.Id.Text = "Id";
            this.Id.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(87, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(150, 20);
            this.tb_id.TabIndex = 8;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(87, 82);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(150, 20);
            this.tb_hoten.TabIndex = 9;
            // 
            // tb_namsinh
            // 
            this.tb_namsinh.Location = new System.Drawing.Point(87, 130);
            this.tb_namsinh.Name = "tb_namsinh";
            this.tb_namsinh.Size = new System.Drawing.Size(150, 20);
            this.tb_namsinh.TabIndex = 10;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(87, 164);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(150, 20);
            this.tb_diachi.TabIndex = 11;
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(667, 386);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 12;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(16, 232);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(162, 232);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 14;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_namsinh);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.DiaChi);
            this.Controls.Add(this.NamSinh);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label HoTen;
        private System.Windows.Forms.Label NamSinh;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_namsinh;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
    }
}

