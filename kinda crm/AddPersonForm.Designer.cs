
namespace kinda_crm
{
    partial class AddPersonForm
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.lastname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(12, 232);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(120, 32);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.Text = "Вернуться назад";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(368, 232);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(120, 32);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Готово";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(115, 26);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(68, 18);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(115, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 18);
            this.name.TabIndex = 3;
            this.name.Text = "Имя";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(115, 91);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(57, 18);
            this.age.TabIndex = 4;
            this.age.Text = "Возраст";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(115, 120);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 18);
            this.phone.TabIndex = 5;
            this.phone.Text = "Номер телефона";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(115, 152);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 18);
            this.address.TabIndex = 6;
            this.address.Text = "Адрес";
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(269, 26);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(100, 23);
            this.lastnameInput.TabIndex = 7;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(269, 59);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 23);
            this.nameInput.TabIndex = 8;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(269, 91);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 23);
            this.ageInput.TabIndex = 9;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(269, 119);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 23);
            this.phoneInput.TabIndex = 10;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(269, 152);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 23);
            this.addressInput.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(294, 181);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 274);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.lastnameInput);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ReturnButton);
            this.Name = "AddPersonForm";
            this.Text = "addPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button ClearButton;
    }
}