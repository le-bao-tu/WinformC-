using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmCLASS : Form
    {
        public FrmCLASS()
        {
            InitializeComponent();
        }

        private void FrmCLASS_Load(object sender, EventArgs e)
        {
            ShowAllClass();
        }
        private void ShowAllClass()
        {
            dataGridViewDSLH.DataSource = null; // reset lại cơ sở dữ liệu
            // gọi thủ tục
            SqlDataAdapter da = new SqlDataAdapter("spu_GetAllClass", SQLServerConnection.StringConnection);
            // khi gọi bằng thủ tục phải thêm dòng này
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // tạo DataSet để chức dữ liệu
            DataSet ds = new DataSet();
            da.Fill(ds, "Class");
            //Hiển thị dữ liệu lên Grid view
            dataGridViewDSLH.DataSource = ds.Tables["Class"];
        }
        // cap nhat
        private void dataGridViewDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDSLH.CurrentRow != null)
            {
                var classId = dataGridViewDSLH.CurrentRow.Cells[0].Value.ToString();
                //truyền mã sinh viên này sang form sinh viên (FrmStudent)
                new FrmLopHoc(classId).ShowDialog();
                // sau khi nó ấn cập nhật xong nó gọi lại hàm bên dưới để load   lại dữ liệu
                ShowAllClass();
            }
        }

        // them moi
        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FrmLopHoc(null).ShowDialog();
            // sau khi nó ấn thêm mới  xong nó gọi lại hàm bên dưới để load lại dữ liệu
            ShowAllClass();
        }

        // xoa
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DeleteClass";
                cmd.CommandType = CommandType.StoredProcedure;
                var msv = dataGridViewDSLH.CurrentRow.Cells[0].Value.ToString();
                cmd.Parameters.AddWithValue("teacherId", msv);
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllClass();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // tìm kiếm 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", textSearch.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDSLH.DataSource = dt;
            
        }
        // sự kiện tìm kiếm không cần nhập 
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchClass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", textSearch.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDSLH.DataSource = dt;
         
           
        }

       
    }
}