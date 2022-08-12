namespace BTL_QLSV_WINFORM
{
    partial class FrmDSGV
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
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.teacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.btnCreateTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.AllowUserToAddRows = false;
            this.dataGridViewTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherId,
            this.createdDate,
            this.creator,
            this.updateDay,
            this.updater,
            this.fullName,
            this.middleName,
            this.v,
            this.birthday,
            this.phone,
            this.email,
            this.address});
            this.dataGridViewTeacher.Location = new System.Drawing.Point(0, 153);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.ReadOnly = true;
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.RowTemplate.Height = 24;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(1197, 297);
            this.dataGridViewTeacher.TabIndex = 0;
            this.dataGridViewTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellContentClick);
            // 
            // teacherId
            // 
            this.teacherId.DataPropertyName = "teacherId";
            this.teacherId.HeaderText = "teacherId";
            this.teacherId.MinimumWidth = 6;
            this.teacherId.Name = "teacherId";
            this.teacherId.ReadOnly = true;
            this.teacherId.Width = 125;
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
            // v
            // 
            this.v.DataPropertyName = "sex";
            this.v.HeaderText = "sex";
            this.v.MinimumWidth = 6;
            this.v.Name = "v";
            this.v.ReadOnly = true;
            this.v.Width = 125;
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
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa ";
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchTeacher.Location = new System.Drawing.Point(775, 81);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(280, 22);
            this.txtSearchTeacher.TabIndex = 2;
            this.txtSearchTeacher.TextChanged += new System.EventHandler(this.txtSearchTeacher_TextChanged);
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeacher.Location = new System.Drawing.Point(28, 76);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(100, 35);
            this.btnCreateTeacher.TabIndex = 3;
            this.btnCreateTeacher.Text = "Thêm mới";
            this.btnCreateTeacher.UseVisualStyleBackColor = false;
            this.btnCreateTeacher.Click += new System.EventHandler(this.btnCreateTeacher_Click);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.Location = new System.Drawing.Point(147, 76);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteTeacher.TabIndex = 4;
            this.btnDeleteTeacher.Text = "Xóa";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.Location = new System.Drawing.Point(1061, 81);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(100, 25);
            this.btnSearchTeacher.TabIndex = 5;
            this.btnSearchTeacher.Text = "Tìm kiếm";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.btnSearchTeacher_Click);
            // 
            // FrmDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1197, 450);
            this.Controls.Add(this.btnSearchTeacher);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnCreateTeacher);
            this.Controls.Add(this.txtSearchTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDSGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách giáo viên ";
            this.Load += new System.EventHandler(this.FrmDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.Button btnCreateTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn v;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}