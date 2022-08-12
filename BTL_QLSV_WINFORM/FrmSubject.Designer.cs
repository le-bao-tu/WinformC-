namespace BTL_QLSV_WINFORM
{
    partial class FrmSubject
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
            this.labelSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreator = new System.Windows.Forms.TextBox();
            this.txtUpdateDay = new System.Windows.Forms.DateTimePicker();
            this.txtUpdater = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(101, 19);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(279, 25);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "DANH SÁCH MÔN HỌC ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "subjectId";
            // 
            // createDate
            // 
            this.createDate.AutoSize = true;
            this.createDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDate.Location = new System.Drawing.Point(12, 126);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(93, 16);
            this.createDate.TabIndex = 2;
            this.createDate.Text = "createdDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "creator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "updateDay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "updater";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "subjectName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "credits";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(123, 72);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(281, 22);
            this.txtSubjectId.TabIndex = 9;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(123, 120);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(281, 22);
            this.txtCreatedDate.TabIndex = 10;
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(123, 167);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(281, 22);
            this.txtCreator.TabIndex = 11;
            this.txtCreator.Validating += new System.ComponentModel.CancelEventHandler(this.txtCreator_Validating);
            // 
            // txtUpdateDay
            // 
            this.txtUpdateDay.Location = new System.Drawing.Point(123, 221);
            this.txtUpdateDay.Name = "txtUpdateDay";
            this.txtUpdateDay.Size = new System.Drawing.Size(281, 22);
            this.txtUpdateDay.TabIndex = 12;
            // 
            // txtUpdater
            // 
            this.txtUpdater.Location = new System.Drawing.Point(123, 267);
            this.txtUpdater.Name = "txtUpdater";
            this.txtUpdater.Size = new System.Drawing.Size(281, 22);
            this.txtUpdater.TabIndex = 13;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(123, 321);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(281, 22);
            this.txtSubjectName.TabIndex = 14;
            this.txtSubjectName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubjectName_Validating);
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(123, 380);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(281, 22);
            this.txtCredits.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(213, 461);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Hủy";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(334, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 528);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.txtUpdater);
            this.Controls.Add(this.txtUpdateDay);
            this.Controls.Add(this.txtCreator);
            this.Controls.Add(this.txtCreatedDate);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSubject);
            this.Name = "FrmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSubject";
            this.Load += new System.EventHandler(this.FrmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label createDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.DateTimePicker txtCreatedDate;
        private System.Windows.Forms.TextBox txtCreator;
        private System.Windows.Forms.DateTimePicker txtUpdateDay;
        private System.Windows.Forms.TextBox txtUpdater;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.NumericUpDown txtCredits;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}