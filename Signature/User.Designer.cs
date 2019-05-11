namespace Signature
{
    partial class User
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
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(12, 33);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(211, 23);
            this.buttonChangePass.TabIndex = 0;
            this.buttonChangePass.Text = "Сменить пароль";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            this.buttonChangePass.Click += new System.EventHandler(this.buttonChangePass_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 62);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(211, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Выход";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(110, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Добро пожаловать, ";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 100);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonChangePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelUsername;
    }
}