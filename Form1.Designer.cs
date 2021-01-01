namespace LoginForm
{
    partial class frmLogin
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
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.userNametxtbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Location = new System.Drawing.Point(224, 113);
            this.passwordtxtbox.Multiline = true;
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(381, 43);
            this.passwordtxtbox.TabIndex = 0;
            // 
            // userNametxtbox
            // 
            this.userNametxtbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userNametxtbox.Location = new System.Drawing.Point(224, 51);
            this.userNametxtbox.Multiline = true;
            this.userNametxtbox.Name = "userNametxtbox";
            this.userNametxtbox.Size = new System.Drawing.Size(381, 43);
            this.userNametxtbox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(444, 173);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(161, 45);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Green;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(224, 173);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(161, 45);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.userNameLabel.Location = new System.Drawing.Point(25, 51);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(193, 43);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "USERNAME";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.passwordLabel.Location = new System.Drawing.Point(31, 113);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(187, 43);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "PASSWORD";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(680, 290);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNametxtbox);
            this.Controls.Add(this.passwordtxtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox userNametxtbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

