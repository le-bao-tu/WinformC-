using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmGV : Form
    {
        public FrmGV(string mgv)
        {
            this.mgv = mgv;
            InitializeComponent();
        }

        private string mgv;

        private void FrmGV_Load(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Thêm mới giáo viên ";
                labelFormStudent.Text = "THÊM MỚI GIÁO VIÊN";
                // khi thêm mới giáo viên sẽ không cho nó thêm nhưng trường sau 
                txtTeacherId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtUpdateDay.Enabled = false;
                txtUpdater.ReadOnly = true;

            }
            else
            {
                this.Text = "Cập nhật giáo viên ";
                labelFormStudent.Text = "CẬP NHẬT GIÁO VIÊN";
                // khi cập nhật sẽ không cho nó cập nhật các trường sau 
                txtTeacherId.ReadOnly = true;
                txtCreatedDate.Enabled = false;
                txtCreator.ReadOnly = true;
                txtUpdateDay.Enabled = false;
                // gọi thủ tuc show chi tiết
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DetailTeacher";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@teacherId", SqlDbType.VarChar , 50).Value = this.mgv;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    if(dr.Read())
                    {
                        txtTeacherId.Text = dr.GetInt32(0).ToString();
                        txtCreatedDate.Value = dr.GetDateTime(1);
                        txtCreator.Text = dr.GetString(2);
                        txtUpdateDay.Value = dr.GetDateTime(3);
                        txtUpdater.Text = dr.GetString(4);
                        txtFullName.Text = dr.GetString(5);
                        txtMiddleName.Text = dr.GetString(6);
                        if (dr.GetValue(7).ToString() == "1")
                        {
                            txtNam.Checked = true;
                        }
                        else
                        {
                            txtNu.Checked = true;
                        }
                        txtBirthday.Value = dr.GetDateTime(8);
                        txtPhone.Text = dr.GetString(9);
                        txtEmail.Text = dr.GetString(10);
                        txtAddress.Text = dr.GetString(11);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại sinh viên có mã như trên", "Read data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

            // button này sẽ xử lí một lúc hai tình huống
            // +> trường hợp không truyền msv sang ==> thêm mới
            // +> trường hợp có truyền msv sang ==> cập nhật
            if (string.IsNullOrEmpty(mgv))
            {
                if (ValidateChildren(ValidationConstraints.Enabled)) 
                { 
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_InsertTeacher";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gái giá trị cho tham số
                    cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                    cmd.Parameters.AddWithValue("updateDay",txtUpdateDay.Value);
                    cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                    cmd.Parameters.AddWithValue("fullName ", txtFullName.Text);
                    cmd.Parameters.AddWithValue("middleName", txtMiddleName.Text);
                    cmd.Parameters.AddWithValue("sex", txtNam.Checked);
                    cmd.Parameters.AddWithValue("birthday ", txtBirthday.Value);
                    cmd.Parameters.AddWithValue("phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("address", txtAddress.Text);
                    //Thêm mới vào database
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
            else // trường hợp cập nhật sinh viên
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_UpdateTeacher";
                cmd.CommandType = CommandType.StoredProcedure;
                // gái giá trị cho tham số
                cmd.Parameters.AddWithValue("teacherId", txtTeacherId.Text);
                cmd.Parameters.AddWithValue("createdDate", txtCreatedDate.Value);
                cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                cmd.Parameters.AddWithValue("updateDay", txtUpdateDay.Value = DateTime.Now);
                cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                cmd.Parameters.AddWithValue("fullName ", txtFullName.Text);
                cmd.Parameters.AddWithValue("middleName", txtMiddleName.Text);
                cmd.Parameters.AddWithValue("sex", txtNam.Checked);
                cmd.Parameters.AddWithValue("birthday ", txtBirthday.Value);
                cmd.Parameters.AddWithValue("phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                //Thêm mới vào database
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Cập thành công ", "Thông báo  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(); // đóng form sau khi thêm mới
                }
                else
                {
                    MessageBox.Show("Error", "Thêm mới thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Dispose();
                }
            }
        }

        //  --------- VALIDATE ---------
        // người tạo 
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
        // FullName
        private void txtFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider.SetError(txtFullName, "txtFullName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFullName, "");
            }
        }
        // Tên đệm 
        private void txtMiddleName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                e.Cancel = true;
                txtMiddleName.Focus();
                errorProvider.SetError(txtMiddleName, "txtMiddleName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMiddleName, "");
            }
        }
        // Địa chỉ 
        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider.SetError(txtAddress, "txtAddress should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtAddress, "");
            }
        }
        // Phone 
        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider.SetError(txtPhone, "txtPhone should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhone, "");
            }
        }
        // Email 
        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider.SetError(txtEmail, "txtEmail should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmail, "");
            }
        }
    }
}