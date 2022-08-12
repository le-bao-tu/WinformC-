namespace BTL_QLSV_WINFORM
{
    partial class FrmDSMH
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
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.subjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearchSubject = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.AllowUserToAddRows = false;
            this.dataGridViewSubject.AllowUserToDeleteRows = false;
            this.dataGridViewSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectId,
            this.createdDate,
            this.creator,
            this.updateDay,
            this.updater,
            this.subjectName,
            this.credits});
            this.dataGridViewSubject.Location = new System.Drawing.Point(0, 159);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.ReadOnly = true;
            this.dataGridViewSubject.RowHeadersWidth = 51;
            this.dataGridViewSubject.RowTemplate.Height = 24;
            this.dataGridViewSubject.Size = new System.Drawing.Size(1204, 291);
            this.dataGridViewSubject.TabIndex = 0;
            this.dataGridViewSubject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubject_CellDoubleClick);
            // 
            // subjectId
            // 
            this.subjectId.DataPropertyName = "subjectId";
            this.subjectId.HeaderText = "subjectId";
            this.subjectId.MinimumWidth = 6;
            this.subjectId.Name = "subjectId";
            this.subjectId.ReadOnly = true;
            this.subjectId.Width = 125;
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
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "subjectName";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            this.subjectName.Width = 125;
            // 
            // credits
            // 
            this.credits.DataPropertyName = "credits";
            this.credits.HeaderText = "credits";
            this.credits.MinimumWidth = 6;
            this.credits.Name = "credits";
            this.credits.ReadOnly = true;
            this.credits.Width = 125;
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.Location = new System.Drawing.Point(23, 78);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(98, 37);
            this.btnCreateSubject.TabIndex = 1;
            this.btnCreateSubject.Text = "Thêm mới";
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(149, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Xóa";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ khóa ";
            // 
            // textSearchSubject
            // 
            this.textSearchSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchSubject.Location = new System.Drawing.Point(815, 86);
            this.textSearchSubject.Name = "textSearchSubject";
            this.textSearchSubject.Size = new System.Drawing.Size(231, 22);
            this.textSearchSubject.TabIndex = 4;
            this.textSearchSubject.TextChanged += new System.EventHandler(this.textSearchSubject_TextChanged);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(1052, 85);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(113, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Tìm kiếm ";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // FrmDSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textSearchSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreateSubject);
            this.Controls.Add(this.dataGridViewSubject);
            this.Name = "FrmDSMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học ";
            this.Load += new System.EventHandler(this.FrmDSMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubject;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearchSubject;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn credits;
    }
}