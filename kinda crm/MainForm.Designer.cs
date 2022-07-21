
namespace kinda_crm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.AllUsers = new System.Windows.Forms.Label();
            this.AllUsersCount = new System.Windows.Forms.Label();
            this.clearPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIO,
            this.Age,
            this.PhoneNum,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(544, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 60;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Номер телефона";
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(615, 229);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 52);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить нового пользователя";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.Location = new System.Drawing.Point(615, 287);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(130, 52);
            this.delButton.TabIndex = 2;
            this.delButton.Text = "Удалить пользователя";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(577, 30);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(219, 23);
            this.searchInput.TabIndex = 3;
            this.searchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(657, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(53, 24);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(721, 89);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AllUsers
            // 
            this.AllUsers.AutoSize = true;
            this.AllUsers.Location = new System.Drawing.Point(577, 12);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.Size = new System.Drawing.Size(126, 15);
            this.AllUsers.TabIndex = 6;
            this.AllUsers.Text = "Всего пользователей:";
            // 
            // AllUsersCount
            // 
            this.AllUsersCount.AutoSize = true;
            this.AllUsersCount.Location = new System.Drawing.Point(710, 12);
            this.AllUsersCount.Name = "AllUsersCount";
            this.AllUsersCount.Size = new System.Drawing.Size(0, 15);
            this.AllUsersCount.TabIndex = 7;
            // 
            // clearPic
            // 
            this.clearPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearPic.Image = global::kinda_crm.Properties.Resources.premium_icon_close_4013407;
            this.clearPic.Location = new System.Drawing.Point(778, 36);
            this.clearPic.Name = "clearPic";
            this.clearPic.Size = new System.Drawing.Size(12, 12);
            this.clearPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clearPic.TabIndex = 8;
            this.clearPic.TabStop = false;
            this.clearPic.Click += new System.EventHandler(this.ClearPic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.clearPic);
            this.Controls.Add(this.AllUsersCount);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Учет клиентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label AllUsers;
        private System.Windows.Forms.Label AllUsersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.PictureBox clearPic;
    }
}

