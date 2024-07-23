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
            try
            {
                conn = new MySqlConnection(strconn);
                adap = new MySqlDataAdapter(query_select, conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                dataGridView1.DataSource = mytable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi Kết Nối Mysql", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
