
namespace ProjetLogiciel_CesEAT
{
    partial class Log_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Serv_Email = new System.Windows.Forms.Label();
            this.Serv_PWD = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Serv_Email
            // 
            this.Serv_Email.AutoSize = true;
            this.Serv_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_Email.Location = new System.Drawing.Point(38, 150);
            this.Serv_Email.Name = "Serv_Email";
            this.Serv_Email.Size = new System.Drawing.Size(59, 21);
            this.Serv_Email.TabIndex = 1;
            this.Serv_Email.Text = "Email : ";
            this.Serv_Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // Serv_PWD
            // 
            this.Serv_PWD.AutoSize = true;
            this.Serv_PWD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Serv_PWD.Location = new System.Drawing.Point(10, 241);
            this.Serv_PWD.Name = "Serv_PWD";
            this.Serv_PWD.Size = new System.Drawing.Size(89, 21);
            this.Serv_PWD.TabIndex = 2;
            this.Serv_PWD.Text = "PassWord : ";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(105, 148);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(173, 23);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(105, 239);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(173, 23);
            this.txt_password.TabIndex = 4;
            // 
            // btn_Log
            // 
            this.btn_Log.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Log.Location = new System.Drawing.Point(77, 339);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(201, 35);
            this.btn_Log.TabIndex = 5;
            this.btn_Log.Text = "LOG IN";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // Log_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 486);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.Serv_PWD);
            this.Controls.Add(this.Serv_Email);
            this.Controls.Add(this.label1);
            this.Name = "Log_Form";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Serv_Email;
        private System.Windows.Forms.Label Serv_PWD;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Log;
    }
}

