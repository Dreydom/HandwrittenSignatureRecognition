namespace Signature
{
    partial class ListUsers
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonCancel.Location = new System.Drawing.Point(358, 131);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsername,
            this.ColumnBlocked});
            this.dataGridViewUsers.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(339, 141);
            this.dataGridViewUsers.TabIndex = 13;
            this.dataGridViewUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUsers_SelectionChanged);
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnUsername.FillWeight = 194.9239F;
            this.ColumnUsername.HeaderText = "Имя пользователя";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            // 
            // ColumnBlocked
            // 
            this.ColumnBlocked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnBlocked.FillWeight = 5.076142F;
            this.ColumnBlocked.HeaderText = "Запрет доступа";
            this.ColumnBlocked.Name = "ColumnBlocked";
            this.ColumnBlocked.ReadOnly = true;
            this.ColumnBlocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBlocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnBlocked.Width = 102;
            // 
            // buttonBlock
            // 
            this.buttonBlock.Location = new System.Drawing.Point(359, 42);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(139, 23);
            this.buttonBlock.TabIndex = 14;
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(359, 102);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(139, 23);
            this.buttonNewUser.TabIndex = 15;
            this.buttonNewUser.Text = "Новый пользователь";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(358, 13);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(139, 23);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Сбросить пароль";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 167);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список пользователей";
            this.Load += new System.EventHandler(this.ListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnBlocked;
        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonReset;
    }
}