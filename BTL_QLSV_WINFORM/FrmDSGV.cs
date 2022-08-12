using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmDSGV : Form
    {
        public FrmDSGV()
        {
            InitializeComponent();
        }

        // laod tất cả danh sách giáo viên lên
        private void FrmDSGV_Load(object sender, EventArgs e)
        {
            showAllTeacher();
        }

        private void showAllTeacher()
        {
            dataGridViewTeacher.DataSource = null; // reset lại cơ sở dữ liệu
            // gọi thủ tục
            SqlDataAdapter da = new SqlDataAdapter("spu_GetAllTeacher", SQLServerConnection.StringConnection);
            // khi gọi bằng thủ tục phải thêm dòng này
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // tạo DataSet để chức dữ liệu
            DataSet ds = new DataSet();
            da.Fill(ds, "Teacher");
            //Hiển thị dữ liệu lên Grid view
            dataGridViewTeacher.DataSource = ds.Tables["Teacher"];
        }

        private void dataGridViewTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var mgv = dataGridViewTeacher.CurrentRow.Cells[0].Value.ToString();
            // truyền mã giáo viên sang form FrmGV
            new FrmGV(mgv).ShowDialog();
            // sau khi cập nhật xong gọi lại hàm ShowAllTeacher để load lại dữ liệu 
            showAllTeacher();
        }

        //Thêm mới 
        private void btnCreateTeacher_Click(object sender, EventArgs e)
        {
            new FrmGV(null).ShowDialog();
            // sau khi thêm mới xong gọi lại hàm ShowAllTeacher để load lại dữ liệu 
            showAllTeacher();
        }

        // Xóa Giáo Viên 
        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DeleteTeacher";
                cmd.CommandType = CommandType.StoredProcedure;
                var msv = dataGridViewTeacher.CurrentRow.Cells[0].Value.ToString();
                cmd.Parameters.AddWithValue("teacherId", msv);

                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showAllTeacher();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Tìm kiếm 
        private void btnSearchTeacher_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchTeacher";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", txtSearchTeacher.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTeacher.DataSource = dt;
        }
        // sự kiện tìm kiếm 
        private void txtSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchTeacher";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", txtSearchTeacher.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewTeacher.DataSource = dt;
        }


    }
}