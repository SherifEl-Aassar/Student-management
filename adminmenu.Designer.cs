namespace Student_management
{
    partial class adminmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminmenu));
            this.radAddStudent = new System.Windows.Forms.RadioButton();
            this.radAddcourse = new System.Windows.Forms.RadioButton();
            this.radViewst = new System.Windows.Forms.RadioButton();
            this.radViewCrs = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCnt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radAddStudent
            // 
            this.radAddStudent.AutoSize = true;
            this.radAddStudent.Location = new System.Drawing.Point(39, 38);
            this.radAddStudent.Name = "radAddStudent";
            this.radAddStudent.Size = new System.Drawing.Size(109, 17);
            this.radAddStudent.TabIndex = 0;
            this.radAddStudent.Text = "Add New Student";
            this.radAddStudent.UseVisualStyleBackColor = true;
            this.radAddStudent.CheckedChanged += new System.EventHandler(this.radAddStudent_CheckedChanged);
            // 
            // radAddcourse
            // 
            this.radAddcourse.AutoSize = true;
            this.radAddcourse.Location = new System.Drawing.Point(39, 77);
            this.radAddcourse.Name = "radAddcourse";
            this.radAddcourse.Size = new System.Drawing.Size(104, 17);
            this.radAddcourse.TabIndex = 1;
            this.radAddcourse.Text = "Add new Course";
            this.radAddcourse.UseVisualStyleBackColor = true;
            this.radAddcourse.CheckedChanged += new System.EventHandler(this.radAddcourse_CheckedChanged);
            // 
            // radViewst
            // 
            this.radViewst.AutoSize = true;
            this.radViewst.Location = new System.Drawing.Point(39, 115);
            this.radViewst.Name = "radViewst";
            this.radViewst.Size = new System.Drawing.Size(230, 17);
            this.radViewst.TabIndex = 3;
            this.radViewst.Text = "View List of all students in a specific course";
            this.radViewst.UseVisualStyleBackColor = true;
            this.radViewst.CheckedChanged += new System.EventHandler(this.radViewst_CheckedChanged);
            // 
            // radViewCrs
            // 
            this.radViewCrs.AutoSize = true;
            this.radViewCrs.Location = new System.Drawing.Point(39, 158);
            this.radViewCrs.Name = "radViewCrs";
            this.radViewCrs.Size = new System.Drawing.Size(346, 17);
            this.radViewCrs.TabIndex = 4;
            this.radViewCrs.Text = "View List of all courses (Finished - Progressed) of a specific student";
            this.radViewCrs.UseVisualStyleBackColor = true;
            this.radViewCrs.CheckedChanged += new System.EventHandler(this.radViewCrs_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(39, 199);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(116, 17);
            this.radEdit.TabIndex = 5;
            this.radEdit.Text = "Edit all course data";
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radEdit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCnt);
            this.groupBox1.Controls.Add(this.radAddcourse);
            this.groupBox1.Controls.Add(this.radEdit);
            this.groupBox1.Controls.Add(this.radAddStudent);
            this.groupBox1.Controls.Add(this.radViewCrs);
            this.groupBox1.Controls.Add(this.radViewst);
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCnt
            // 
            this.btnCnt.BackColor = System.Drawing.Color.LightGray;
            this.btnCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCnt.Image = ((System.Drawing.Image)(resources.GetObject("btnCnt.Image")));
            this.btnCnt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCnt.Location = new System.Drawing.Point(130, 240);
            this.btnCnt.Name = "btnCnt";
            this.btnCnt.Size = new System.Drawing.Size(114, 31);
            this.btnCnt.TabIndex = 6;
            this.btnCnt.Text = "&Continue";
            this.btnCnt.UseVisualStyleBackColor = false;
            this.btnCnt.Click += new System.EventHandler(this.btnCnt_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(389, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 26);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = " &Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Review the feedback file ";
            this.notifyIcon1.BalloonTipTitle = "One new message";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // adminmenu
            // 
            this.AcceptButton = this.btnCnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminmenu";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.adminmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radAddStudent;
        private System.Windows.Forms.RadioButton radAddcourse;
        private System.Windows.Forms.RadioButton radViewst;
        private System.Windows.Forms.RadioButton radViewCrs;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCnt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}