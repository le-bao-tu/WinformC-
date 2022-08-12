namespace BTL_QLSV_WINFORM
{
    partial class FrmDSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentId,
            this.createdDate,
            this.creator,
            this.updateDay,
            this.updater,
            this.fullName,
            this.middleName,
            this.birthday,
            this.sex,
            this.homeTown,
            this.address,
            this.phone,
            this.email});
            this.dataGridViewStudent.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewStudent.Location = new System.Drawing.Point(0, 147);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(1201, 303);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellContentClick);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCreateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudent.Location = new System.Drawing.Point(28, 68);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(102, 37);
            this.btnCreateStudent.TabIndex = 1;
            this.btnCreateStudent.Text = "Thêm mới";
            this.btnCreateStudent.UseVisualStyleBackColor = false;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.Location = new System.Drawing.Point(150, 68);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(102, 37);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ khóa ";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(772, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1060, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 24);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Excel
            // 
            this.Excel.BackColor = System.Drawing.Color.Green;
            this.Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.Location = new System.Drawing.Point(282, 68);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(102, 37);
            this.Excel.TabIndex = 6;
            this.Excel.Text = "Xuất Excel ";
            this.Excel.UseVisualStyleBackColor = false;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // studentId
            // 
            this.studentId.DataPropertyName = "studentId";
            this.studentId.HeaderText = "studentId";
            this.studentId.MinimumWidth = 6;
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            this.studentId.Width = 125;
            // 
            // createdDate
            // 
            this.createdDate.DataPropertyName = "createdDate";
            this.createdDate.HeaderText = "createdDate";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Width = 125;
            // 
            // creator
            // 
            this.creator.DataPropertyName = "creator";
            this.creator.HeaderText = "creator";
            this.creator.MinimumWidth = 6;
            this.creator.Name = "creator";
            this.creator.ReadOnly = true;
            this.creator.Width = 125;
            // 
            // updateDay
            // 
            this.updateDay.DataPropertyName = "updateDay";
            this.updateDay.HeaderText = "updateDay";
            this.updateDay.MinimumWidth = 6;
            this.updateDay.Name = "updateDay";
            this.updateDay.ReadOnly = true;
            this.updateDay.Width = 125;
            // 
            // updater
            // 
            this.updater.DataPropertyName = "updater";
            this.updater.HeaderText = "updater";
            this.updater.MinimumWidth = 6;
            this.updater.Name = "updater";
            this.updater.ReadOnly = true;
            this.updater.Width = 125;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "fullName";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Width = 125;
            // 
            // middleName
            // 
            this.middleName.DataPropertyName = "middleName";
            this.middleName.HeaderText = "middleName";
            this.middleName.MinimumWidth = 6;
            this.middleName.Name = "middleName";
            this.middleName.ReadOnly = true;
            this.middleName.Width = 125;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "birthday";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 125;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "sex";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 125;
            // 
            // homeTown
            // 
            this.homeTown.DataPropertyName = "homeTown";
            this.homeTown.HeaderText = "homeTown";
            this.homeTown.MinimumWidth = 6;
            this.homeTown.Name = "homeTown";
            this.homeTown.ReadOnly = true;
            this.homeTown.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // FrmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Controls.Add(this.dataGridViewStudent);
            this.Name = "FrmDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên ";
            this.Load += new System.EventHandler(this.FrmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTown;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}