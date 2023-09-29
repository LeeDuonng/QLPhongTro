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
    public partial class frmTraPhong : Form
    {
        public frmTraPhong(string idHopDong)
        {
            InitializeComponent();
            this.idHopDong = idHopDong;
        }

        string idHopDong;
        private Database db = new Database(); 

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            var ls = new List<CustomParameter>
            {
                new CustomParameter
                {
                    key = "@idHopDong",
                    value = "idHopDong"

                }
            };

            var dt = db.SelectData("ChotHopDong", ls);
            txtSoNo.Text = dt.Rows[0]["no"].ToString();
        }
    }
}
