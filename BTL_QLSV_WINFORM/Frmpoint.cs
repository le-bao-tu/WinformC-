using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class Frmpoint : Form
    {
        public Frmpoint(string pointId)
        {
            InitializeComponent();
            this.pointId = pointId;
        }

        private string pointId;

        private void Frmpoint_Load(object sender, System.EventArgs e)
        {
            // load du lieu cho combobox sinh vien 
            SqlDataAdapter mh = new SqlDataAdapter("spu_GetAllStudents", SQLServerConnection.StringConnection);
            mh.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            mh.Fill(ds, "Student");
            cbstudentId.DataSource = ds.Tables["Student"];
            // mình đổ cate ra kiểu dạng select lên phải lấy id và name 
            cbstudentId.DisplayMember = "fullName";
            cbstudentId.ValueMember = "studentId";

            // load du lieu cho combobox class 
            SqlDataAdapter lh = new SqlDataAdapter("spu_GetAllClass", SQLServerConnection.StringConnection);
            lh.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dsgv = new DataSet();
            lh.Fill(dsgv, "Class");
            cbclassId.DataSource = dsgv.Tables["Class"];
            // mình đổ cate ra kiểu dạng select lên phải lấy id và name 
            cbclassId.DisplayMember = "className";
            cbclassId.ValueMember = "classId";

            if (string.IsNullOrEmpty(pointId))
            {
                this.Text = "Thêm mới điểm ";
                labelPoint.Text = "THÊM MỚI ĐIỂM ";
                txtpointId.ReadOnly = true;
                txtcreatedDate.Enabled = false;
                txtupdateDay.Enabled = false;
                txtupdater.ReadOnly = true;

            }
            else // CẬP NHẬT 
            {
                this.Text = "cập nhật điểm ";
                labelPoint.Text = "CẬP NHẬT ĐIỂM";
                txtpointId.ReadOnly = true;
                txtcreatedDate.Enabled = false;
                txtcreator.ReadOnly = true;
                txtupdateDay.Enabled = false;

                // gọi thủ tuc show chi tiết
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DetailPoints";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pointId ", SqlDbType.VarChar, 50).Value = this.pointId;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    if(dr.Read())
                    {
                        txtpointId.Text = dr.GetInt32(0).ToString();
                        txtcreatedDate.Value = dr.GetDateTime(1);
                        txtcreator.Text = dr.GetString(2);
                        txtupdateDay.Value = dr.GetDateTime(3);
                        txtupdater.Text = dr.GetString(4);
                        cbstudentId.SelectedValue = dr.GetString(5);
                        cbclassId.SelectedValue = dr.GetInt32(6).ToString();
                        txtpointOneTime.Text = dr.GetDouble(9).ToString();
                        txtsecond_Point.Text = dr.GetDouble(10).ToString();
                    }
                }
                else
                {

                    MessageBox.Show("Không tồn tại điểm có mã như trên", "Read data",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void txtSave_Click(object sender, System.EventArgs e)
        {
            if(string.IsNullOrEmpty(pointId))
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_InsertPoints";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gái giá trị cho tham số
                    cmd.Parameters.AddWithValue("createdDate", txtcreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtcreator.Text);
                    cmd.Parameters.AddWithValue("updateDay", txtupdateDay.Value);
                    cmd.Parameters.AddWithValue("updater", txtupdater.Text);
                    cmd.Parameters.AddWithValue("studentId", cbstudentId.SelectedValue);
                    cmd.Parameters.AddWithValue("classId", cbclassId.SelectedValue);
                    cmd.Parameters.AddWithValue("pointOneTime", txtpointOneTime.Text);
                    cmd.Parameters.AddWithValue("second_Point", txtsecond_Point.Text);
                    // thêm mới vào database
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Thêm mới thành công ", "Thông báo  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(); // đóng form sau khi thêm mới
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // cap nhat 
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_UpdatePoints";
                cmd.CommandType = CommandType.StoredProcedure;
                // gái giá trị cho tham số
                cmd.Parameters.AddWithValue("pointId", txtpointId.Text);
                cmd.Parameters.AddWithValue("createdDate", txtcreatedDate.Value);
                cmd.Parameters.AddWithValue("creator", txtcreator.Text);
                cmd.Parameters.AddWithValue("updateDay", txtupdateDay.Value = DateTime.Now);
                cmd.Parameters.AddWithValue("updater", txtupdater.Text);
                cmd.Parameters.AddWithValue("studentId", cbstudentId.SelectedValue);
                cmd.Parameters.AddWithValue("classId", cbclassId.SelectedValue);
                cmd.Parameters.AddWithValue("pointOneTime", txtpointOneTime.Text);
                cmd.Parameters.AddWithValue("second_Point", txtsecond_Point.Text);

                //Thêm mới vào database
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Cập nhật thành công ", "Thông báo  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(); // đóng form sau khi thêm mới
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtcreator_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcreator.Text))
            {
                e.Cancel = true;
                txtcreator.Focus();
                errorProvider.SetError(txtcreator, "txtCreator should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtcreator, "");
            }
        }
    }
}