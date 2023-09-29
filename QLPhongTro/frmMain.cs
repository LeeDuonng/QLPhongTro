using QLPhongTro.ChildForm;
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

namespace QLPhongTro
{
    public partial class frmMain : Form
    {
       
        private Database db;
        private string connetionString = @"Data Source=LEDUONG\SQLEXPRESS;Initial Catalog=QLPhongTro;Integrated Security=True";
        private SqlConnection conn;

        public frmMain()
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        #region gui
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ptbState_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                ptbState.Image = Properties.Resources.res;

              
               

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ptbState.Image = Properties.Resources.maxi;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        //hàm add form lên groupbox có tên là grbContent
        private void AddForm(Form f)
        {
            this.grbContent.Controls.Clear();//xóa các control hiện có trên groupbox
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;//bỏ viền của form
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.grbContent.Controls.Add(f);
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var f = new frmWelcome();
            AddForm(f);

        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            AddForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            AddForm(f);
        }

        private void dichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDichVu();
            AddForm(f);
        }

        private void thuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        private void grbContent_Enter(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLienHe frmLienHe = new frmLienHe();
            frmLienHe.ShowDialog();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pblBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tảiLạiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connetionString);
            try
            {
                conn.Open();
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối thành công !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại. Lỗi: " + ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }  
        }

        private void nhậpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tácVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmThuePhong();
            AddForm(f);
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngĐangThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngTrốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhongTrong();
            AddForm(f);
        }

        private void tiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiềnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tiendichvutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTienDichVu();
            AddForm(f);
        }
    }
}
