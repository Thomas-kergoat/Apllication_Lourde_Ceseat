
namespace CesEAT
{
    partial class CreateUser_Form
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
            this.FirstName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txtConfirmPassWord = new System.Windows.Forms.TextBox();
            this.Confirm_PassWord = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.Metier = new System.Windows.Forms.Label();
            this.List_Metier = new System.Windows.Forms.ListBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.Phone_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(41, 24);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(89, 21);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "FirstName :";
            this.FirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(172, 26);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(270, 23);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(55, 211);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(59, 21);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email : ";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(172, 245);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(270, 23);
            this.txtPassWord.TabIndex = 9;
            this.txtPassWord.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassWord.Location = new System.Drawing.Point(41, 247);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(85, 21);
            this.PassWord.TabIndex = 8;
            this.PassWord.Text = "PassWord :";
            this.PassWord.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(172, 64);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(270, 23);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(35, 62);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(87, 21);
            this.LastName.TabIndex = 6;
            this.LastName.Text = "LastName :";
            this.LastName.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtConfirmPassWord
            // 
            this.txtConfirmPassWord.Location = new System.Drawing.Point(172, 282);
            this.txtConfirmPassWord.Name = "txtConfirmPassWord";
            this.txtConfirmPassWord.PasswordChar = '*';
            this.txtConfirmPassWord.Size = new System.Drawing.Size(270, 23);
            this.txtConfirmPassWord.TabIndex = 11;
            this.txtConfirmPassWord.TextChanged += new System.EventHandler(this.txtConfirmPassWord_TextChanged);
            // 
            // Confirm_PassWord
            // 
            this.Confirm_PassWord.AutoSize = true;
            this.Confirm_PassWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm_PassWord.Location = new System.Drawing.Point(20, 280);
            this.Confirm_PassWord.Name = "Confirm_PassWord";
            this.Confirm_PassWord.Size = new System.Drawing.Size(146, 21);
            this.Confirm_PassWord.TabIndex = 10;
            this.Confirm_PassWord.Text = "Confirm PassWord :";
            this.Confirm_PassWord.Click += new System.EventHandler(this.label6_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(172, 326);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(155, 33);
            this.Register_button.TabIndex = 12;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Metier
            // 
            this.Metier.AutoSize = true;
            this.Metier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Metier.Location = new System.Drawing.Point(52, 157);
            this.Metier.Name = "Metier";
            this.Metier.Size = new System.Drawing.Size(62, 21);
            this.Metier.TabIndex = 13;
            this.Metier.Text = "Métier :";
            // 
            // List_Metier
            // 
            this.List_Metier.FormattingEnabled = true;
            this.List_Metier.ItemHeight = 15;
            this.List_Metier.Items.AddRange(new object[] {
            "Client",
            "Livreur",
            "Restaurateur",
            "Service_commercial",
            "Service_technique"});
            this.List_Metier.Location = new System.Drawing.Point(172, 142);
            this.List_Metier.Name = "List_Metier";
            this.List_Metier.Size = new System.Drawing.Size(270, 49);
            this.List_Metier.TabIndex = 14;
            this.List_Metier.SelectedIndexChanged += new System.EventHandler(this.List_Metier_SelectedIndexChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(172, 103);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(270, 23);
            this.txtPhoneNumber.TabIndex = 16;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Phone_Number
            // 
            this.Phone_Number.AutoSize = true;
            this.Phone_Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Phone_Number.Location = new System.Drawing.Point(35, 101);
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.Size = new System.Drawing.Size(120, 21);
            this.Phone_Number.TabIndex = 15;
            this.Phone_Number.Text = "Phone number :";
            this.Phone_Number.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.Phone_Number);
            this.Controls.Add(this.List_Metier);
            this.Controls.Add(this.Metier);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.txtConfirmPassWord);
            this.Controls.Add(this.Confirm_PassWord);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Register Form User";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtConfirmPassWord;
        private System.Windows.Forms.Label Confirm_PassWord;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label Metier;
        private System.Windows.Forms.ListBox List_Metier;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label Phone_Number;
    }
}

