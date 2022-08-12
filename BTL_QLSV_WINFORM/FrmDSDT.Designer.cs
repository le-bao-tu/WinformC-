namespace BTL_QLSV_WINFORM
{
    partial class FrmDSDT
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
            this.dataGridViewDSDT = new System.Windows.Forms.DataGridView();
            this.pointId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointOneTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.second_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSDT
            // 
            this.dataGridViewDSDT.AllowUserToAddRows = false;
            this.dataGridViewDSDT.AllowUserToDeleteRows = false;
            this.dataGridViewDSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDSDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pointId,
            this.createdDate,
            this.creator,
            this.updateDay,
            this.updater,
            this.className,
            this.fullName,
            this.pointOneTime,
            this.second_Point});
            this.dataGridViewDSDT.Location = new System.Drawing.Point(0, 157);
            this.dataGridViewDSDT.Name = "dataGridViewDSDT";
            this.dataGridViewDSDT.ReadOnly = true;
            this.dataGridViewDSDT.RowHeadersWidth = 51;
            this.dataGridViewDSDT.RowTemplate.Height = 24;
            this.dataGridViewDSDT.Size = new System.Drawing.Size(1201, 293);
            this.dataGridViewDSDT.TabIndex = 0;
            this.dataGridViewDSDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDT_CellContentClick);
            // 
            // pointId
            // 
            this.pointId.DataPropertyName = "pointId";
            this.pointId.HeaderText = "pointId";
            this.pointId.MinimumWidth = 6;
            this.pointId.Name = "pointId";
            this.pointId.ReadOnly = true;
            this.pointId.Width = 125;
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
            // className
            // 
            this.className.DataPropertyName = "className";
            this.className.HeaderText = "className";
            this.className.MinimumWidth = 6;
            this.className.Name = "className";
            this.className.ReadOnly = true;
            this.className.Width = 125;
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
            // pointOneTime
            // 
            this.pointOneTime.DataPropertyName = "pointOneTime";
            this.pointOneTime.HeaderText = "pointOneTime";
            this.pointOneTime.MinimumWidth = 6;
            this.pointOneTime.Name = "pointOneTime";
            this.pointOneTime.ReadOnly = true;
            this.pointOneTime.Width = 125;
            // 
            // second_Point
            // 
            this.second_Point.DataPropertyName = "second_Point";
            this.second_Point.HeaderText = "second_Point";
            this.second_Point.MinimumWidth = 6;
            this.second_Point.Name = "second_Point";
            this.second_Point.ReadOnly = true;
            this.second_Point.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa ";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(775, 73);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(298, 22);
            this.textSearch.TabIndex = 2;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1095, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 31);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Thêm mới ";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(129, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(246, 69);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(117, 31);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "Xuất Excel ";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FrmDSDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDSDT);
            this.Name = "FrmDSDT";
            this.Text = "Danh sách điểm thi ";
            this.Load += new System.EventHandler(this.FrmDSDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointId;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointOneTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn second_Point;
        private System.Windows.Forms.Button btnExcel;
    }
}