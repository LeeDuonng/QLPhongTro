using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.ChildForm
{
    public partial class frmTienDichVu : Form
    {
        public frmTienDichVu()
        {
            db = new Database();
            InitializeComponent();
            LoadDsTienDV();
        }

        private Database db;

        private void LoadDsTienDV()
        {

            dgvTienDV.DataSource = db.SelectData("TienDichVu");
        }
        private void frmTienDichVu_Load(object sender, EventArgs e)
        {
       
            LoadDsTienDV();

        }
    }
}
