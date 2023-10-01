using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmDoanhThu : Form
    {
        private Database db;

        public frmDoanhThu()
        {
            InitializeComponent();
            LoadDsDoanhThu();

        }

        private void LoadDsDoanhThu()
        {
            db = new Database();

            var dt = db.SelectData("sp_TenPhongDaThanhToan");

            dgvDoanhthu.DataSource = dt;

        }
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDsDoanhThu();
            txtTongDoanhThu.Text = db.SelectData("TongDoanhThu").Rows[0][0].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
