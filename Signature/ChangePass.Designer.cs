namespace Signature
{
    partial class ChangePass
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
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.textBoxNewPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(15, 67);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(112, 13);
            this.labelPassword2.TabIndex = 14;
            this.labelPassword2.Text = "Подтвердите пароль";
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.Location = new System.Drawing.Point(132, 64);
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.Size = new System.Drawing.Size(171, 20);
            this.textBoxNewPassword2.TabIndex = 10;
            this.textBoxNewPassword2.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonCancel.Location = new System.Drawing.Point(15, 91);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(163, 91);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(140, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Location = new System.Drawing.Point(15, 41);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(80, 13);
            this.labelPassword1.TabIndex = 13;
            this.labelPassword1.Text = "Новый пароль";
            // 
            // textBoxNewPassword1
            // 
            this.textBoxNewPassword1.Location = new System.Drawing.Point(132, 38);
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Size = new System.Drawing.Size(171, 20);
            this.textBoxNewPassword1.TabIndex = 9;
            this.textBoxNewPassword1.UseSystemPasswordChar = true;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(132, 12);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(171, 20);
            this.textBoxOldPassword.TabIndex = 15;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(15, 15);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(84, 13);
            this.labelOldPassword.TabIndex = 16;
            this.labelOldPassword.Text = "Старый пароль";
            // 
            // ChangePass
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(311, 123);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.textBoxNewPassword2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelPassword1);
            this.Controls.Add(this.textBoxNewPassword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сменить пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxNewPassword2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.TextBox textBoxNewPassword1;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label labelOldPassword;
    }
}