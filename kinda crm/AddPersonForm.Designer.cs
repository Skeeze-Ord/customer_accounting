
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
            this.returnButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
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
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(209, 303);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(120, 32);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Вернуться назад";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(417, 303);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(120, 32);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Готово";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(263, 28);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(68, 18);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Фамилия";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(263, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(36, 18);
            this.name.TabIndex = 3;
            this.name.Text = "Имя";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(263, 93);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(57, 18);
            this.age.TabIndex = 4;
            this.age.Text = "Возраст";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(263, 122);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(118, 18);
            this.phone.TabIndex = 5;
            this.phone.Text = "Номер телефона";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(263, 154);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 18);
            this.address.TabIndex = 6;
            this.address.Text = "Адрес";
            // 
            // lastnameInput
            // 
            this.lastnameInput.Location = new System.Drawing.Point(417, 28);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(100, 23);
            this.lastnameInput.TabIndex = 7;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(417, 61);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 23);
            this.nameInput.TabIndex = 8;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(417, 93);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(100, 23);
            this.ageInput.TabIndex = 9;
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(417, 121);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(100, 23);
            this.phoneInput.TabIndex = 10;
            // 
            // addressInput
            // 
            this.addressInput.Location = new System.Drawing.Point(417, 154);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(100, 23);
            this.addressInput.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(601, 168);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
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
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.returnButton);
            this.Name = "AddPersonForm";
            this.Text = "addPerson";
            this.Load += new System.EventHandler(this.AddPersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button doneButton;
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
        private System.Windows.Forms.Button clearButton;
    }
}