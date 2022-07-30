
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AllUsers = new System.Windows.Forms.Label();
            this.AllUsersCount = new System.Windows.Forms.Label();
            this.clearPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FIO,
            this.Age,
            this.PhoneNum,
            this.Address});
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FIO
            // 
            resources.ApplyResources(this.FIO, "FIO");
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // Age
            // 
            resources.ApplyResources(this.Age, "Age");
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // PhoneNum
            // 
            resources.ApplyResources(this.PhoneNum, "PhoneNum");
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // Address
            // 
            resources.ApplyResources(this.Address, "Address");
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DelButton
            // 
            resources.ApplyResources(this.DelButton, "DelButton");
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Name = "DelButton";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // searchInput
            // 
            resources.ApplyResources(this.searchInput, "searchInput");
            this.searchInput.Name = "searchInput";
            // 
            // SearchButton
            // 
            resources.ApplyResources(this.SearchButton, "SearchButton");
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateButton
            // 
            resources.ApplyResources(this.UpdateButton, "UpdateButton");
            this.UpdateButton.BackgroundImage = global::kinda_crm.Properties.Resources.premium_icon_redo_3185862;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AllUsers
            // 
            resources.ApplyResources(this.AllUsers, "AllUsers");
            this.AllUsers.Name = "AllUsers";
            // 
            // AllUsersCount
            // 
            resources.ApplyResources(this.AllUsersCount, "AllUsersCount");
            this.AllUsersCount.Name = "AllUsersCount";
            // 
            // clearPic
            // 
            resources.ApplyResources(this.clearPic, "clearPic");
            this.clearPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearPic.Image = global::kinda_crm.Properties.Resources.premium_icon_close_4013407;
            this.clearPic.Name = "clearPic";
            this.clearPic.TabStop = false;
            this.clearPic.Click += new System.EventHandler(this.ClearPic_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearPic);
            this.Controls.Add(this.AllUsersCount);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button UpdateButton;
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

