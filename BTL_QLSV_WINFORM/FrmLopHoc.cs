using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmLopHoc : Form
    {
        public FrmLopHoc(string classId)
        {
            this.classId = classId;
            InitializeComponent();
        }

        private string classId;

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            // load dữ liệu cho combobox môn học 
            SqlDataAdapter mh = new SqlDataAdapter("spu_GetAllSubject", SQLServerConnection.StringConnection);
            mh.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dsmh = new DataSet();
            mh.Fill(dsmh, "Subject");
            cbSubjectId.DataSource = dsmh.Tables["Subject"];
            // mình đổ cate ra kiểu dạng select lên phải lấy id và name 
            cbSubjectId.DisplayMember = "subjectName";
            cbSubjectId.ValueMember = "subjectId";
          


            // load dữ liệu cho combobox giáo viên  
            SqlDataAdapter gv = new SqlDataAdapter("spu_GetAllTeacher", SQLServerConnection.StringConnection);
            gv.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dsgv = new DataSet();
            gv.Fill(dsgv, "Teacher");
            cbTeacherId.DataSource = dsgv.Tables["Teacher"];
            // mình đổ cate ra kiểu dạng select lên phải lấy id và name 
            cbTeacherId.DisplayMember = "fullName";
            cbTeacherId.ValueMember = "teacherId";
       


            if (string.IsNullOrEmpty(classId))
            {
                this.Text = "Thêm mới lớp học";
                labelFormClass.Text = "THÊM MỚI LỚP HỌC";
                txtClassId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtUpdateDay.Enabled = false;
                txtUpdater.ReadOnly = true;

            }
            else
            {
                this.Text = "Cập nhật lớp học";
                labelFormClass.Text = "CẬP NHẬT LỚP HỌC";
                txtClassId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtUpdateDay.Enabled = false;
                txtCreator.ReadOnly = true;
                // gọi thủ tuc show chi tiết
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DetailClass";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@classId", SqlDbType.VarChar, 50).Value = this.classId;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    if(dr.Read())
                    {
                        txtClassId.Text = dr.GetInt32(0).ToString();
                        txtclassName.Text = dr.GetString(1);
                        txtCreatedDate.Value = dr.GetDateTime(2);
                        txtCreator.Text = dr.GetString(3);
                        txtUpdateDay.Value = dr.GetDateTime(4);
                        txtUpdater.Text = dr.GetString(5);
                        cbSubjectId.SelectedValue = dr.GetInt32(6).ToString();
                        cbTeacherId.SelectedValue = dr.GetInt32(8).ToString();
                        // hoặc dùng cách dưới 
                        //cbSubjectId.SelectedValue = dr["subjectId"].ToString();
                        //cbTeacherId.SelectedValue = dr["teacherId"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại lớp học có mã như trên", "Read data",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(classId)) // thêm mới lớp học 
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_InsertClass";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gái giá trị cho tham số
                    cmd.Parameters.AddWithValue("className", txtclassName.Text);
                    cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                    cmd.Parameters.AddWithValue("updateDay", txtUpdateDay.Value);
                    cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                    cmd.Parameters.AddWithValue("subjectId", cbSubjectId.SelectedValue);
                    cmd.Parameters.AddWithValue("teacherId", cbTeacherId.SelectedValue);
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
            else // cập nhật lớp học 
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_UpdateClass";
                cmd.CommandType = CommandType.StoredProcedure;
                // gái giá trị cho tham số
                // gái giá trị cho tham số
                cmd.Parameters.AddWithValue("classId", txtClassId.Text);
                cmd.Parameters.AddWithValue("className", txtclassName.Text);
                cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                cmd.Parameters.AddWithValue("updateDay", txtUpdateDay.Value = DateTime.Now);
                cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                cmd.Parameters.AddWithValue("subjectId", cbSubjectId.SelectedValue);
                cmd.Parameters.AddWithValue("teacherId", cbTeacherId.SelectedValue);
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

        private void txtCreator_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCreator.Text))
            {
                e.Cancel = true;
                
                errorProvider.SetError(txtCreator, "txtCreator should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCreator, "");
            }
        }

        private void txtclassName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtclassName.Text))
            {
                e.Cancel = true;
               
                errorProvider.SetError(txtclassName, "txtclassName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtclassName, "");
            }
        }
    }
}