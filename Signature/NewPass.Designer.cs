namespace Signature
{
    partial class NewPass
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonCancel.Location = new System.Drawing.Point(12, 65);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(160, 65);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(140, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Location = new System.Drawing.Point(12, 15);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(80, 13);
            this.labelPassword1.TabIndex = 4;
            this.labelPassword1.Text = "Новый пароль";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(129, 12);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(171, 20);
            this.textBoxPassword1.TabIndex = 0;
            this.textBoxPassword1.UseSystemPasswordChar = true;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(12, 41);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(112, 13);
            this.labelPassword2.TabIndex = 8;
            this.labelPassword2.Text = "Подтвердите пароль";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(129, 38);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(171, 20);
            this.textBoxPassword2.TabIndex = 1;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // NewPass
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(312, 100);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelPassword1);
            this.Controls.Add(this.textBoxPassword1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.TextBox textBoxPassword2;
    }
}