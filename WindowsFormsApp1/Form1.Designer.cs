
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.StudentTxt = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.StudentPercentage = new System.Windows.Forms.Label();
            this.PercentageTxt = new System.Windows.Forms.TextBox();
            this.BinaryRead = new System.Windows.Forms.Button();
            this.BinaryWrite = new System.Windows.Forms.Button();
            this.JSONWrite = new System.Windows.Forms.Button();
            this.XMLRead = new System.Windows.Forms.Button();
            this.XMLWrite = new System.Windows.Forms.Button();
            this.SOAPWrite = new System.Windows.Forms.Button();
            this.SOAPRead = new System.Windows.Forms.Button();
            this.JSONRead = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentTxt
            // 
            this.StudentTxt.Location = new System.Drawing.Point(255, 81);
            this.StudentTxt.Name = "StudentTxt";
            this.StudentTxt.Size = new System.Drawing.Size(146, 22);
            this.StudentTxt.TabIndex = 0;
            this.StudentTxt.TextChanged += new System.EventHandler(this.StudentTxt_TextChanged);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(106, 81);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(70, 17);
            this.StudentID.TabIndex = 1;
            this.StudentID.Text = "StudentID";
            this.StudentID.Click += new System.EventHandler(this.StudentID_Click);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(106, 129);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(94, 17);
            this.StudentName.TabIndex = 2;
            this.StudentName.Text = "StudentName";
            this.StudentName.Click += new System.EventHandler(this.StudentName_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(255, 129);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(146, 22);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // StudentPercentage
            // 
            this.StudentPercentage.AutoSize = true;
            this.StudentPercentage.Location = new System.Drawing.Point(106, 182);
            this.StudentPercentage.Name = "StudentPercentage";
            this.StudentPercentage.Size = new System.Drawing.Size(130, 17);
            this.StudentPercentage.TabIndex = 4;
            this.StudentPercentage.Text = "StudentPercentage";
            this.StudentPercentage.Click += new System.EventHandler(this.StudentPercentage_Click);
            // 
            // PercentageTxt
            // 
            this.PercentageTxt.Location = new System.Drawing.Point(255, 179);
            this.PercentageTxt.Name = "PercentageTxt";
            this.PercentageTxt.Size = new System.Drawing.Size(146, 22);
            this.PercentageTxt.TabIndex = 5;
            this.PercentageTxt.TextChanged += new System.EventHandler(this.PercentageTxt_TextChanged);
            // 
            // BinaryRead
            // 
            this.BinaryRead.Location = new System.Drawing.Point(109, 343);
            this.BinaryRead.Name = "BinaryRead";
            this.BinaryRead.Size = new System.Drawing.Size(112, 23);
            this.BinaryRead.TabIndex = 6;
            this.BinaryRead.Text = "BinaryRead";
            this.BinaryRead.UseVisualStyleBackColor = true;
            this.BinaryRead.Click += new System.EventHandler(this.BinaryRead_Click);
            // 
            // BinaryWrite
            // 
            this.BinaryWrite.Location = new System.Drawing.Point(244, 343);
            this.BinaryWrite.Name = "BinaryWrite";
            this.BinaryWrite.Size = new System.Drawing.Size(119, 23);
            this.BinaryWrite.TabIndex = 7;
            this.BinaryWrite.Text = "BinaryWrite";
            this.BinaryWrite.UseVisualStyleBackColor = true;
            this.BinaryWrite.Click += new System.EventHandler(this.BinaryWrite_Click);
            // 
            // JSONWrite
            // 
            this.JSONWrite.Location = new System.Drawing.Point(609, 180);
            this.JSONWrite.Name = "JSONWrite";
            this.JSONWrite.Size = new System.Drawing.Size(106, 23);
            this.JSONWrite.TabIndex = 9;
            this.JSONWrite.Text = "JSONWrite";
            this.JSONWrite.UseVisualStyleBackColor = true;
            this.JSONWrite.Click += new System.EventHandler(this.JSONWrite_Click);
            // 
            // XMLRead
            // 
            this.XMLRead.Location = new System.Drawing.Point(109, 420);
            this.XMLRead.Name = "XMLRead";
            this.XMLRead.Size = new System.Drawing.Size(112, 23);
            this.XMLRead.TabIndex = 10;
            this.XMLRead.Text = "XMLRead";
            this.XMLRead.UseVisualStyleBackColor = true;
            this.XMLRead.Click += new System.EventHandler(this.XMLRead_Click);
            // 
            // XMLWrite
            // 
            this.XMLWrite.Location = new System.Drawing.Point(244, 420);
            this.XMLWrite.Name = "XMLWrite";
            this.XMLWrite.Size = new System.Drawing.Size(119, 23);
            this.XMLWrite.TabIndex = 11;
            this.XMLWrite.Text = "XMLWrite";
            this.XMLWrite.UseVisualStyleBackColor = true;
            this.XMLWrite.Click += new System.EventHandler(this.XMLWrite_Click);
            // 
            // SOAPWrite
            // 
            this.SOAPWrite.Location = new System.Drawing.Point(609, 112);
            this.SOAPWrite.Name = "SOAPWrite";
            this.SOAPWrite.Size = new System.Drawing.Size(106, 23);
            this.SOAPWrite.TabIndex = 12;
            this.SOAPWrite.Text = "SOAPWrite";
            this.SOAPWrite.UseVisualStyleBackColor = true;
            this.SOAPWrite.Click += new System.EventHandler(this.SOAPWrite_Click);
            // 
            // SOAPRead
            // 
            this.SOAPRead.Location = new System.Drawing.Point(466, 112);
            this.SOAPRead.Name = "SOAPRead";
            this.SOAPRead.Size = new System.Drawing.Size(102, 23);
            this.SOAPRead.TabIndex = 13;
            this.SOAPRead.Text = "SOAPRead";
            this.SOAPRead.UseVisualStyleBackColor = true;
            this.SOAPRead.Click += new System.EventHandler(this.SOAPRead_Click);
            // 
            // JSONRead
            // 
            this.JSONRead.Location = new System.Drawing.Point(466, 180);
            this.JSONRead.Name = "JSONRead";
            this.JSONRead.Size = new System.Drawing.Size(102, 27);
            this.JSONRead.TabIndex = 14;
            this.JSONRead.Text = "JSONRead";
            this.JSONRead.UseVisualStyleBackColor = true;
            this.JSONRead.Click += new System.EventHandler(this.JSONRead_Click);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(255, 268);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(108, 30);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(109, 268);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(127, 30);
            this.Login.TabIndex = 16;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(384, 271);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(135, 27);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(106, 226);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(82, 17);
            this.Department.TabIndex = 18;
            this.Department.Text = "Department";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // dept
            // 
            this.dept.Location = new System.Drawing.Point(255, 226);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(146, 22);
            this.dept.TabIndex = 19;
            this.dept.TextChanged += new System.EventHandler(this.dept_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Details Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.JSONRead);
            this.Controls.Add(this.SOAPRead);
            this.Controls.Add(this.SOAPWrite);
            this.Controls.Add(this.XMLWrite);
            this.Controls.Add(this.XMLRead);
            this.Controls.Add(this.JSONWrite);
            this.Controls.Add(this.BinaryWrite);
            this.Controls.Add(this.BinaryRead);
            this.Controls.Add(this.PercentageTxt);
            this.Controls.Add(this.StudentPercentage);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentTxt);
            this.Name = "Form1";
            this.Text = "MY STUDENT FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentTxt;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label StudentPercentage;
        private System.Windows.Forms.TextBox PercentageTxt;
        private System.Windows.Forms.Button BinaryRead;
        private System.Windows.Forms.Button BinaryWrite;
        private System.Windows.Forms.Button JSONWrite;
        private System.Windows.Forms.Button XMLRead;
        private System.Windows.Forms.Button XMLWrite;
        private System.Windows.Forms.Button SOAPWrite;
        private System.Windows.Forms.Button SOAPRead;
        private System.Windows.Forms.Button JSONRead;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.Label label1;
    }
}

