using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetLogiciel_CesEAT;
using System.Web;
using System.Security.Cryptography;

namespace CesEAT
{
    public partial class CreateUser_Form : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=tcp:ceseat.database.windows.net,1433;Initial Catalog=Gaia;Persist Security Info=False;User ID=ghost;Password='(-sJ8F;LDMjM#xP<';MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public int role_value;
        public string hash = "f0xle@rn";
        public CreateUser_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void List_Metier_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            GetMetier();
            Cryptage(txtPassWord);
            Cryptage(txtConfirmPassWord);
            string query = "INSERT INTO dbo.users ([user_firstname],[user_lastname],[user_email],[user_password],[user_phone_number],[user_is_supported],[user_support],[user_is_delivery],[fk_role_id]) values('" + txtFullName.Text.Trim() + "', '" + txtUserName.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + txtPassWord.Text.Trim() + "', '" + txtPhoneNumber.Text.Trim() + "', 0, 0, 0, " + role_value +")";
            if (this.txtConfirmPassWord.Text == this.txtPassWord.Text)
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand command = new SqlCommand(query, sqlcon);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("les mots de passes ne correspondent pas !");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
             
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassWord_TextChanged(object sender, EventArgs e)
        {
            
        }

        private int GetMetier()
        {
            if (this.List_Metier.SelectedItem.ToString() == "Client")
            {
                role_value = 1;
            }
            if (this.List_Metier.SelectedItem.ToString() == "Livreur")
            {
                role_value = 2;
            }
            if (this.List_Metier.SelectedItem.ToString() == "Restaurateur")
            {
                role_value = 3;
            }
            if (this.List_Metier.SelectedItem.ToString() == "Service_commercial")
            {
                role_value = 4;
            }
            if (this.List_Metier.SelectedItem.ToString() == "Service_technique")
            {
                role_value = 5;
            }

            return role_value;
        }

        private void Cryptage(TextBox textBox)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(textBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using(TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textBox.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        private void Decryptage(TextBox textBox)
        {
            byte[] data = Convert.FromBase64String(textBox.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textBox.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

    }
}
