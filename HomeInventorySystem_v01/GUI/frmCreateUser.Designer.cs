namespace HomeInventorySystem_v01.GUI
{
    partial class frmCreateUser
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
            this.txtUserFName = new System.Windows.Forms.TextBox();
            this.txtUserLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserPasswordC = new System.Windows.Forms.TextBox();
            this.txtUserNameC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtUserFName
            // 
            this.txtUserFName.Location = new System.Drawing.Point(189, 90);
            this.txtUserFName.Name = "txtUserFName";
            this.txtUserFName.Size = new System.Drawing.Size(100, 20);
            this.txtUserFName.TabIndex = 1;
            // 
            // txtUserLName
            // 
            this.txtUserLName.Location = new System.Drawing.Point(399, 90);
            this.txtUserLName.Name = "txtUserLName";
            this.txtUserLName.Size = new System.Drawing.Size(100, 20);
            this.txtUserLName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtUserPasswordC
            // 
            this.txtUserPasswordC.Location = new System.Drawing.Point(305, 281);
            this.txtUserPasswordC.Name = "txtUserPasswordC";
            this.txtUserPasswordC.Size = new System.Drawing.Size(100, 20);
            this.txtUserPasswordC.TabIndex = 5;
            // 
            // txtUserNameC
            // 
            this.txtUserNameC.Location = new System.Drawing.Point(305, 187);
            this.txtUserNameC.Name = "txtUserNameC";
            this.txtUserNameC.Size = new System.Drawing.Size(100, 20);
            this.txtUserNameC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "User Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(231, 334);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(478, 334);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 10;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUserNameC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserPasswordC);
            this.Controls.Add(this.txtUserLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserFName);
            this.Controls.Add(this.label1);
            this.Name = "frmCreateUser";
            this.Text = "frmCreateUser";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserFName;
        private System.Windows.Forms.TextBox txtUserLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserPasswordC;
        private System.Windows.Forms.TextBox txtUserNameC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCansel;
    }
}