using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace connectSql
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;

        string strconn = "Server = localhost; Database = cs_mysql; UId = root; Pwd = ; Pooling=false;Character Set=utf8";
        string query_select = "SELECT * FROM sinhvien";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            EnableControls(false);
        }

        private void EnableControls(bool enable)
        {
            btn_add.Enabled = enable;
            btn_edit.Enabled = enable;
            btn_delete.Enabled = enable;
            btn_find.Enabled = enable;
            dataGridView1.Enabled = enable;
            tb_id.Enabled = enable;
            tb_hoten.Enabled = enable;
            tb_namsinh.Enabled = enable;
            tb_diachi.Enabled = enable;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                    conn = new MySqlConnection(strconn);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_connect.Enabled = false;
                    btn_disconnect.Enabled = true;
                    EnableControls(true);
                    Read_Data();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đã ngắt kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_connect.Enabled = true;
                btn_disconnect.Enabled = false;
                EnableControls(false);
                dataGridView1.DataSource = null;
            }
        }

        private void Read_Data()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                adap = new MySqlDataAdapter(query_select, conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                dataGridView1.DataSource = mytable;
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                string query_insert = "INSERT INTO sinhvien (`HoTen`, `NamSinh`, `DiaChi`) VALUES (@HoTen, @NamSinh, @DiaChi)";
                MySqlCommand command = new MySqlCommand(query_insert, conn);
                command.Parameters.AddWithValue("@HoTen", tb_hoten.Text);
                command.Parameters.AddWithValue("@NamSinh", tb_namsinh.Text);
                command.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                command.ExecuteNonQuery();
                Read_Data();
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                string query_update = "UPDATE sinhvien SET `HoTen`=@HoTen, `NamSinh`=@NamSinh, `DiaChi`=@DiaChi WHERE Id = @Id";
                MySqlCommand command = new MySqlCommand(query_update, conn);
                command.Parameters.AddWithValue("@HoTen", tb_hoten.Text);
                command.Parameters.AddWithValue("@NamSinh", tb_namsinh.Text);
                command.Parameters.AddWithValue("@DiaChi", tb_diachi.Text);
                command.Parameters.AddWithValue("@Id", int.Parse(tb_id.Text));
                command.ExecuteNonQuery();
                Read_Data();
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                string query_delete = "DELETE FROM sinhvien WHERE `Id`=@Id";
                MySqlCommand command = new MySqlCommand(query_delete, conn);
                command.Parameters.AddWithValue("@Id", int.Parse(tb_id.Text));
                command.ExecuteNonQuery();
                Read_Data();
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                string query_find = "SELECT * FROM sinhvien WHERE `id`=@Id";
                MySqlCommand command = new MySqlCommand(query_find, conn);
                command.Parameters.AddWithValue("@Id", int.Parse(tb_id.Text));

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;

                    tb_hoten.Text = dataTable.Rows[0]["HoTen"].ToString();
                    tb_namsinh.Text = dataTable.Rows[0]["NamSinh"].ToString();
                    tb_diachi.Text = dataTable.Rows[0]["DiaChi"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với ID này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối đến cơ sở dữ liệu trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This method is empty, you can remove it if not needed
        }
    }
}