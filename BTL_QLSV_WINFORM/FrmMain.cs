using System;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmWelcome f = new FrmWelcome();
            AddForm(f);
        }
        private void AddForm(Form f)
        {
            this.panel.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel.Controls.Add(f);
            this.Text = f.Text;
            f.Show();
        }
        //Thoát
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn có chăc chắn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // quann li sinh vien 
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSSV f = new FrmDSSV();
            AddForm(f);
        }
        // quan li mon hoc
        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSMH f = new FrmDSMH();
            AddForm(f);
        }
        // quan li giao vien
        private void giaoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSGV f = new FrmDSGV();
            AddForm(f);
        }
        // quan li diem
        private void diemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDSDT f = new FrmDSDT();
            AddForm(f);
        }
        // quan li lop hoc 
        private void lopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCLASS f = new FrmCLASS();
            AddForm(f);
        }

       
    }
}