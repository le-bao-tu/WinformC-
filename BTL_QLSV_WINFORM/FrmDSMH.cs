using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmDSMH : Form
    {
        public FrmDSMH()
        {
            InitializeComponent();
        }

        private void FrmDSMH_Load(object sender, EventArgs e)
        {
            showAllSubject();
        }

        private void showAllSubject()
        {
            dataGridViewSubject.DataSource = null; // reset lại cơ sở dữ liệu
            // gọi thủ tục
            SqlDataAdapter da = new SqlDataAdapter("spu_GetAllSubject", SQLServerConnection.StringConnection);
            // khi gọi bằng thủ tục phải thêm dòng này
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // tạo DataSet để chức dữ liệu
            DataSet ds = new DataSet();
            da.Fill(ds, "Subject");
            //Hiển thị dữ liệu lên Grid view
            dataGridViewSubject.DataSource = ds.Tables["Subject"];
        }

        private void dataGridViewSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy về mã môn học
            var subjectId = dataGridViewSubject.CurrentRow.Cells[0].Value.ToString();
            // truyền mã môn học sang fromSubject để cập nhật
            new FrmSubject(subjectId).ShowDialog();
            // gọi lại showAllSubject để load lại dữ liệu
            showAllSubject();
        }

        // Thêm mới
        private void btnCreateSubject_Click(object sender, EventArgs e)
        {
            new FrmSubject(null).ShowDialog();
            showAllSubject();
        }

        // xóa
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DeleteSubject";
                cmd.CommandType = CommandType.StoredProcedure;
                var msv = dataGridViewSubject.CurrentRow.Cells[0].Value.ToString();
                cmd.Parameters.AddWithValue("subjectId", msv);
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showAllSubject(); ;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // tìm kiếm
        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", textSearchSubject.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSubject.DataSource = dt;
        }

        // sự kiện tìm kiếm
        private void textSearchSubject_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "spu_SearchSubject";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tukhoa", textSearchSubject.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewSubject.DataSource = dt;
        }
    }
}