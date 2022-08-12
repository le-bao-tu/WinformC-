using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
     

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // dang nhap 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(checkLogin())
            {
                FrmMain wl = new FrmMain();
                wl.ShowDialog();
                //this.Hide();
            }
        }

        private bool checkLogin()
        {
            string name = txtUserName.Text;
            string pass = txtPass.Text;
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_CheckLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@accountName", SqlDbType.VarChar, 50).Value = name;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                if(dr.Read()) 
                {
                    if(dr.GetString(1) == name && dr.GetString(2) == pass)
                    {
                         return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi đăng nhập ", "Thông báo", MessageBoxButtons.OK);
            }
            return false;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}