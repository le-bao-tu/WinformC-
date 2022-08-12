using BTL_QLSV_WINFORM.DataAccessConnect;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QLSV_WINFORM
{
    public partial class FrmStudent : Form
    {
        public FrmStudent(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }

        private string msv;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên ";
                labelFormStudent.Text = "Thêm Mới Sinh Viên";
                // khi thêm mới sẽ không cho nó thêm mới ngày cập nhật và người cập nhật
                txtUpdater.ReadOnly = true;
                txtupdateDay.Enabled = false;
                txtcreatedDate.Enabled = false;
            }
            else
            {
                this.Text = "Cập nhật sinh viên ";
                labelFormStudent.Text = "Cập nhật Thông Tin";
                // khi cập nhật sẽ không cho nó sửa ngày tạo và người tạo và ngày cập nhật
                textStudenid.ReadOnly = true;
                txtcreatedDate.Enabled = false;
                txtupdateDay.Enabled = false;
                txtCreator.ReadOnly = true;
                // gọi thủ tuc show chi tiết
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_DetailStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@studentId", SqlDbType.VarChar, 50).Value = this.msv;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //đọc dữ liệu ra form
                    if (dr.Read())
                    {
                        textStudenid.Text = dr.GetString(0);
                        txtcreatedDate.Value = dr.GetDateTime(1);
                        txtCreator.Text = dr.GetString(2);
                        txtupdateDay.Value = dr.GetDateTime(3);
                        txtUpdater.Text = dr.GetString(4);
                        txtFullName.Text = dr.GetString(5);
                        txtmiddleName.Text = dr.GetString(6);
                        txtBirthday.Value = dr.GetDateTime(7);
                        if (dr.GetValue(8).ToString() == "1")
                        {
                            txtSex.Checked = true;
                        }
                        else
                        {
                            txtNu.Checked = true;
                        }
                        txtHomeTown.Text = dr.GetString(9);
                        txtAddress.Text = dr.GetString(10);
                        txtPhone.Text = dr.GetString(11);
                        txtEmail.Text = dr.GetString(12);
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

        // đóng form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            // button này sẽ xử lí một lúc hai tình huống
            // +> trường hợp không truyền msv sang ==> thêm mới
            // +> trường hợp có truyền msv sang ==> cập nhật
            if (string.IsNullOrEmpty(msv)) // trường hợp thêm mới sinh viên
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                    cmd.CommandText = "spu_InsertStudent";
                    cmd.CommandType = CommandType.StoredProcedure;
                    // gái giá trị cho tham số
                    cmd.Parameters.AddWithValue("studentId", textStudenid.Text);
                    cmd.Parameters.AddWithValue("createdDate", txtcreatedDate.Value);
                    cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                    cmd.Parameters.AddWithValue("updateDay", txtupdateDay.Value);
                    cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                    cmd.Parameters.AddWithValue("fullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("middleName", txtmiddleName.Text);
                    cmd.Parameters.AddWithValue("birthday", txtBirthday.Value);
                    cmd.Parameters.AddWithValue("sex", txtSex.Checked);
                    cmd.Parameters.AddWithValue("homeTown", txtHomeTown.Text);
                    cmd.Parameters.AddWithValue("address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    //Thêm mới vào database
                    int row = cmd.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Thêm mới thành công ", "Thông báo  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose(); // đóng form sau khi thêm mới
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại","Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // trường hợp cập nhật sinh viên
            {
                SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
                cmd.CommandText = "spu_UpdateStudent";
                cmd.CommandType = CommandType.StoredProcedure;
                // gái giá trị cho tham số
                cmd.Parameters.AddWithValue("studentId", textStudenid.Text);
                cmd.Parameters.AddWithValue("createdDate", txtcreatedDate.Value);
                cmd.Parameters.AddWithValue("creator", txtCreator.Text);
                cmd.Parameters.AddWithValue("updateDay", txtupdateDay.Value = DateTime.Now);
                cmd.Parameters.AddWithValue("updater", txtUpdater.Text);
                cmd.Parameters.AddWithValue("fullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("middleName", txtmiddleName.Text);
                cmd.Parameters.AddWithValue("birthday", txtBirthday.Value);
                cmd.Parameters.AddWithValue("sex", txtSex.Checked);
                cmd.Parameters.AddWithValue("homeTown", txtHomeTown.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
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

        //  --------- VALIDATE ---------
        private void textStudenid_Validating(object sender, CancelEventArgs e)
        {
            // studentId
            if (string.IsNullOrWhiteSpace(textStudenid.Text))
            {
                e.Cancel = true;
                textStudenid.Focus();
                errorProvider.SetError(textStudenid, "textStudenid should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textStudenid, "");
            }
        }

        // txtCreator
        private void txtCreator_Validating(object sender, CancelEventArgs e)
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

        // fullName
        private void txtFullName_Validating(object sender, CancelEventArgs e)
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

        // txtmiddleName
        private void txtmiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmiddleName.Text))
            {
                e.Cancel = true;
                txtmiddleName.Focus();
                errorProvider.SetError(txtmiddleName, "txtmiddleName should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtmiddleName, "");
            }
        }
        // txtBirthday
        private void txtBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthday.Value.ToString()))
            {
                e.Cancel = true;
                txtBirthday.Focus();
                errorProvider.SetError(txtBirthday, "txtBirthday should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBirthday, "");
            }
        }
        // txtHomeTown
        private void txtHomeTown_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHomeTown.Text))
            {
                e.Cancel = true;
                txtHomeTown.Focus();
                errorProvider.SetError(txtHomeTown, "txtHomeTown should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtHomeTown, "");
            }
        }
        // txtAddress
        private void txtAddress_Validating(object sender, CancelEventArgs e)
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
        // txtPhone
        private void txtPhone_Validating(object sender, CancelEventArgs e)
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
        // txtEmail
        private void txtEmail_Validating(object sender, CancelEventArgs e)
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