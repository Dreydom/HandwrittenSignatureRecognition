namespace Signature
{
    partial class Admin
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonListUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 13);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Добро пожаловать, ";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 62);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(211, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Выход";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonListUsers
            // 
            this.buttonListUsers.Location = new System.Drawing.Point(12, 33);
            this.buttonListUsers.Name = "buttonListUsers";
            this.buttonListUsers.Size = new System.Drawing.Size(211, 23);
            this.buttonListUsers.TabIndex = 3;
            this.buttonListUsers.Text = "Список пользователей";
            this.buttonListUsers.UseVisualStyleBackColor = true;
            this.buttonListUsers.Click += new System.EventHandler(this.buttonListUsers_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 100);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonListUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonListUsers;
    }
}