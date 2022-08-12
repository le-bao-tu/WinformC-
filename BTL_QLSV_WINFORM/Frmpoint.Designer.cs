namespace BTL_QLSV_WINFORM
{
    partial class Frmpoint
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
            this.components = new System.ComponentModel.Container();
            this.labelPoint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.Label();
            this.creator = new System.Windows.Forms.Label();
            this.updateDay = new System.Windows.Forms.Label();
            this.updater = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.classId = new System.Windows.Forms.Label();
            this.onetime = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.txtpointId = new System.Windows.Forms.TextBox();
            this.txtcreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtcreator = new System.Windows.Forms.TextBox();
            this.txtupdateDay = new System.Windows.Forms.DateTimePicker();
            this.txtupdater = new System.Windows.Forms.TextBox();
            this.cbstudentId = new System.Windows.Forms.ComboBox();
            this.cbclassId = new System.Windows.Forms.ComboBox();
            this.txtpointOneTime = new System.Windows.Forms.TextBox();
            this.txtsecond_Point = new System.Windows.Forms.TextBox();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoint.Location = new System.Drawing.Point(88, 20);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(306, 30);
            this.labelPoint.TabIndex = 0;
            this.labelPoint.Text = "THÔNG TIN ĐIỂM THI ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "pointId ";
            // 
            // createdDate
            // 
            this.createdDate.AutoSize = true;
            this.createdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDate.Location = new System.Drawing.Point(14, 124);
            this.createdDate.Name = "createdDate";
            this.createdDate.Size = new System.Drawing.Size(93, 16);
            this.createdDate.TabIndex = 2;
            this.createdDate.Text = "createdDate";
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator.Location = new System.Drawing.Point(15, 170);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(56, 16);
            this.creator.TabIndex = 3;
            this.creator.Text = "creator";
            // 
            // updateDay
            // 
            this.updateDay.AutoSize = true;
            this.updateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDay.Location = new System.Drawing.Point(14, 221);
            this.updateDay.Name = "updateDay";
            this.updateDay.Size = new System.Drawing.Size(83, 16);
            this.updateDay.TabIndex = 4;
            this.updateDay.Text = "updateDay";
            // 
            // updater
            // 
            this.updater.AutoSize = true;
            this.updater.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updater.Location = new System.Drawing.Point(11, 268);
            this.updater.Name = "updater";
            this.updater.Size = new System.Drawing.Size(60, 16);
            this.updater.TabIndex = 5;
            this.updater.Text = "updater";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(12, 318);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 16);
            this.name.TabIndex = 6;
            this.name.Text = "studentId";
            // 
            // classId
            // 
            this.classId.AutoSize = true;
            this.classId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classId.Location = new System.Drawing.Point(15, 369);
            this.classId.Name = "classId";
            this.classId.Size = new System.Drawing.Size(57, 16);
            this.classId.TabIndex = 7;
            this.classId.Text = "classId";
            // 
            // onetime
            // 
            this.onetime.AutoSize = true;
            this.onetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onetime.Location = new System.Drawing.Point(11, 417);
            this.onetime.Name = "onetime";
            this.onetime.Size = new System.Drawing.Size(104, 16);
            this.onetime.TabIndex = 8;
            this.onetime.Text = "pointOneTime";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(15, 467);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(101, 16);
            this.point.TabIndex = 9;
            this.point.Text = "second_Point";
            // 
            // txtpointId
            // 
            this.txtpointId.Location = new System.Drawing.Point(124, 72);
            this.txtpointId.Name = "txtpointId";
            this.txtpointId.Size = new System.Drawing.Size(286, 22);
            this.txtpointId.TabIndex = 10;
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(124, 119);
            this.txtcreatedDate.Name = "txtcreatedDate";
            this.txtcreatedDate.Size = new System.Drawing.Size(286, 22);
            this.txtcreatedDate.TabIndex = 11;
            // 
            // txtcreator
            // 
            this.txtcreator.Location = new System.Drawing.Point(124, 167);
            this.txtcreator.Name = "txtcreator";
            this.txtcreator.Size = new System.Drawing.Size(286, 22);
            this.txtcreator.TabIndex = 12;
            this.txtcreator.Validating += new System.ComponentModel.CancelEventHandler(this.txtcreator_Validating);
            // 
            // txtupdateDay
            // 
            this.txtupdateDay.Location = new System.Drawing.Point(124, 216);
            this.txtupdateDay.Name = "txtupdateDay";
            this.txtupdateDay.Size = new System.Drawing.Size(286, 22);
            this.txtupdateDay.TabIndex = 13;
            // 
            // txtupdater
            // 
            this.txtupdater.Location = new System.Drawing.Point(124, 265);
            this.txtupdater.Name = "txtupdater";
            this.txtupdater.Size = new System.Drawing.Size(286, 22);
            this.txtupdater.TabIndex = 14;
            // 
            // cbstudentId
            // 
            this.cbstudentId.FormattingEnabled = true;
            this.cbstudentId.Location = new System.Drawing.Point(124, 314);
            this.cbstudentId.Name = "cbstudentId";
            this.cbstudentId.Size = new System.Drawing.Size(286, 24);
            this.cbstudentId.TabIndex = 15;
            // 
            // cbclassId
            // 
            this.cbclassId.FormattingEnabled = true;
            this.cbclassId.Location = new System.Drawing.Point(124, 365);
            this.cbclassId.Name = "cbclassId";
            this.cbclassId.Size = new System.Drawing.Size(286, 24);
            this.cbclassId.TabIndex = 16;
            // 
            // txtpointOneTime
            // 
            this.txtpointOneTime.Location = new System.Drawing.Point(124, 414);
            this.txtpointOneTime.Name = "txtpointOneTime";
            this.txtpointOneTime.Size = new System.Drawing.Size(286, 22);
            this.txtpointOneTime.TabIndex = 17;
            // 
            // txtsecond_Point
            // 
            this.txtsecond_Point.Location = new System.Drawing.Point(124, 464);
            this.txtsecond_Point.Name = "txtsecond_Point";
            this.txtsecond_Point.Size = new System.Drawing.Size(286, 22);
            this.txtsecond_Point.TabIndex = 18;
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.Color.RosyBrown;
            this.txtExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtExit.Location = new System.Drawing.Point(214, 530);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(88, 32);
            this.txtExit.TabIndex = 19;
            this.txtExit.Text = "Hủy";
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtSave
            // 
            this.txtSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSave.Location = new System.Drawing.Point(322, 530);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(88, 32);
            this.txtSave.TabIndex = 20;
            this.txtSave.Text = "Lưu ";
            this.txtSave.UseVisualStyleBackColor = false;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Frmpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 598);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtsecond_Point);
            this.Controls.Add(this.txtpointOneTime);
            this.Controls.Add(this.cbclassId);
            this.Controls.Add(this.cbstudentId);
            this.Controls.Add(this.txtupdater);
            this.Controls.Add(this.txtupdateDay);
            this.Controls.Add(this.txtcreator);
            this.Controls.Add(this.txtcreatedDate);
            this.Controls.Add(this.txtpointId);
            this.Controls.Add(this.point);
            this.Controls.Add(this.onetime);
            this.Controls.Add(this.classId);
            this.Controls.Add(this.name);
            this.Controls.Add(this.updater);
            this.Controls.Add(this.updateDay);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.createdDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPoint);
            this.Name = "Frmpoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmpoint";
            this.Load += new System.EventHandler(this.Frmpoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label createdDate;
        private System.Windows.Forms.Label creator;
        private System.Windows.Forms.Label updateDay;
        private System.Windows.Forms.Label updater;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label classId;
        private System.Windows.Forms.Label onetime;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.TextBox txtpointId;
        private System.Windows.Forms.DateTimePicker txtcreatedDate;
        private System.Windows.Forms.TextBox txtcreator;
        private System.Windows.Forms.DateTimePicker txtupdateDay;
        private System.Windows.Forms.TextBox txtupdater;
        private System.Windows.Forms.ComboBox cbstudentId;
        private System.Windows.Forms.ComboBox cbclassId;
        private System.Windows.Forms.TextBox txtpointOneTime;
        private System.Windows.Forms.TextBox txtsecond_Point;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}