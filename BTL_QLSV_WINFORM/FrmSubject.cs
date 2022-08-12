using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmSubject : Form
    {
        public FrmSubject(string subjectId)
        {
            this.subjectId = subjectId;
            InitializeComponent();
        }

        private string subjectId;

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(subjectId))
            {
                this.Text = "Thêm mới môn học ";
                labelSubject.Text = "THÊM MỚI MÔN HỌC ";
                // khi thêm mới sẽ không cho nó nhập  những trường sau
                txtSubjectId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtUpdateDay.Enabled = false;
                txtUpdater.ReadOnly = true;
            }
            else
            {
                this.Text = "Cập nhật môn học";
                labelSubject.Text = "CẬP NHẬT MÔN HỌC ";
                // khi cập nhật sẽ không cho nó cập nhật những trường sau
                txtSubjectId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtCreator.ReadOnly = true;
                txtUpdateDay.Enabled = false;
                // gọi thủ tục show chi tiết môn học
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DetailSubject";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@subjectId", SqlDbType.VarChar, 50).Value = this.subjectId;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // đọc dữ liệu ra form
                    if (dr.Read())
                    {
                        txtSubjectId.Text = dr.GetInt32(0).ToString();
                        txtCreatedDate.Value = dr.GetDateTime(1);
                        txtCreator.Text = dr.GetString(2);
                        txtUpdateDay.Value = dr.GetDateTime(3);
                        txtUpdater.Text = dr.GetString(4);
                        txtSubjectName.Text = dr.GetString(5);
                        txtCredits.Text = dr.GetInt32(6).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã môn học ", "Read data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
        }

        // đóng from
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // button này sẽ xử lí một lúc hai tình huống
            // +> trường hợp không truyền msv sang ==> thêm mới
            // +> trường hợp có truyền msv sang ==> cập nhật
            if (string.IsNullOrEmpty(subjectId)) // trường hợp thêm mới môn học
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                 {
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_InsertSubject";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gán giá trị cho tham số
                    cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                    cmd.Parameters.AddWithValue("updateDay", txtUpdateDay.Value);
                    cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                    cmd.Parameters.AddWithValue("subjectName", txtSubjectName.Text);
                    cmd.Parameters.AddWithValue("credits", txtCredits.Text);
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
            else // truường hợp cập nhật môn học
            {
              
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_UpdateSubject";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gái giá trị cho tham số
                    cmd.Parameters.AddWithValue("subjectId", txtSubjectId.Text);
                    cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                    cmd.Parameters.AddWithValue("updateDay", txtUpdateDay.Value = DateTime.Now);
                    cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                    cmd.Parameters.AddWithValue("subjectName", txtSubjectName.Text);
                    cmd.Parameters.AddWithValue("credits", txtCredits.Text);
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

        // VALIDATE --------------

       

        private void txtSubjectName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                e.Cancel = true;
                txtSubjectName.Focus();
                errorProvider.SetError(txtSubjectName, "txtSubjectName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCreator, "");
            }
        }

        private void txtCreator_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCreator.Text))
            {
                e.Cancel = true;
                txtCreator.Focus();
                errorProvider.SetError(txtCreator, "txtCreator should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCreator, "");
            }
        }
    }
}