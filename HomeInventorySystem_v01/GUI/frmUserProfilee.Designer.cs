namespace HomeInventorySystem_v01.GUI
{
    partial class frmUserProfilee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPasswordN = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.Label();
            this.txtPasswordN = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUserN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFirstN
            // 
            this.txtFirstN.Location = new System.Drawing.Point(95, 86);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(100, 20);
            this.txtFirstN.TabIndex = 1;
            // 
            // txtLastN
            // 
            this.txtLastN.Location = new System.Drawing.Point(300, 86);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(100, 20);
            this.txtLastN.TabIndex = 3;
            this.txtLastN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNewPasswordN
            // 
            this.txtNewPasswordN.Location = new System.Drawing.Point(320, 189);
            this.txtNewPasswordN.Name = "txtNewPasswordN";
            this.txtNewPasswordN.Size = new System.Drawing.Size(100, 20);
            this.txtNewPasswordN.TabIndex = 5;
            this.txtNewPasswordN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoSize = true;
            this.txtNewPassword.Location = new System.Drawing.Point(317, 128);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(78, 13);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Text = "New Password";
            // 
            // txtPasswordN
            // 
            this.txtPasswordN.Location = new System.Drawing.Point(95, 189);
            this.txtPasswordN.Name = "txtPasswordN";
            this.txtPasswordN.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordN.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(92, 128);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // txtUserN
            // 
            this.txtUserN.Location = new System.Drawing.Point(480, 86);
            this.txtUserN.Name = "txtUserN";
            this.txtUserN.Size = new System.Drawing.Size(100, 20);
            this.txtUserN.TabIndex = 9;
            this.txtUserN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UserName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(529, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(208, 303);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "DeleteUser";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmUserProfilee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtUserN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtNewPasswordN);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtLastN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstN);
            this.Controls.Add(this.label1);
            this.Name = "frmUserProfilee";
            this.Text = "frmEditProfail";
            this.Load += new System.EventHandler(this.frmEditProfail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPasswordN;
        private System.Windows.Forms.Label txtNewPassword;
        private System.Windows.Forms.TextBox txtPasswordN;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUserN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}