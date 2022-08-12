namespace BTL_QLSV_WINFORM
{
    partial class FrmCLASS
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDSLH = new System.Windows.Forms.DataGridView();
            this.classId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(22, 60);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 31);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Thêm mới ";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1072, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(768, 64);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(298, 22);
            this.textSearch.TabIndex = 10;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ khóa ";
            // 
            // dataGridViewDSLH
            // 
            this.dataGridViewDSLH.AllowUserToAddRows = false;
            this.dataGridViewDSLH.AllowUserToDeleteRows = false;
            this.dataGridViewDSLH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classId,
            this.createdDate,
            this.creator,
            this.updateDay,
            this.updater,
            this.subjectName,
            this.fullName});
            this.dataGridViewDSLH.Location = new System.Drawing.Point(-1, 123);
            this.dataGridViewDSLH.MultiSelect = false;
            this.dataGridViewDSLH.Name = "dataGridViewDSLH";
            this.dataGridViewDSLH.RowHeadersWidth = 51;
            this.dataGridViewDSLH.RowTemplate.Height = 24;
            this.dataGridViewDSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSLH.Size = new System.Drawing.Size(1201, 330);
            this.dataGridViewDSLH.TabIndex = 8;
            this.dataGridViewDSLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSLH_CellDoubleClick);
            // 
            // classId
            // 
            this.classId.DataPropertyName = "classId";
            this.classId.HeaderText = "classId";
            this.classId.MinimumWidth = 6;
            this.classId.Name = "classId";
            // 
            // createdDate
            // 
            this.createdDate.DataPropertyName = "createdDate";
            this.createdDate.HeaderText = "createdDate";
            this.createdDate.MinimumWidth = 6;
            this.createdDate.Name = "createdDate";
            // 
            // creator
            // 
            this.creator.DataPropertyName = "creator";
            this.creator.HeaderText = "creator";
            this.creator.MinimumWidth = 6;
            this.creator.Name = "creator";
            // 
            // updateDay
            // 
            this.updateDay.DataPropertyName = "updateDay";
            this.updateDay.HeaderText = "updateDay";
            this.updateDay.MinimumWidth = 6;
            this.updateDay.Name = "updateDay";
            // 
            // updater
            // 
            this.updater.DataPropertyName = "updater";
            this.updater.HeaderText = "updater";
            this.updater.MinimumWidth = 6;
            this.updater.Name = "updater";
            // 
            // subjectName
            // 
            this.subjectName.DataPropertyName = "subjectName";
            this.subjectName.HeaderText = "subjectName";
            this.subjectName.MinimumWidth = 6;
            this.subjectName.Name = "subjectName";
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "fullName";
            this.fullName.HeaderText = "fullName";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(159, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xóa ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCLASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDSLH);
            this.Name = "FrmCLASS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCLASS";
            this.Load += new System.EventHandler(this.FrmCLASS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDSLH;
        private System.Windows.Forms.DataGridViewTextBoxColumn classId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.Button button1;
    }
}