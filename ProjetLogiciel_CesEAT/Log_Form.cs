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
using CesEAT;

namespace ProjetLogiciel_CesEAT
{
    public partial class Log_Form : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server=tcp:ceseat.database.windows.net,1433;Initial Catalog=Gaia;Persist Security Info=False;User ID=ghost;Password='(-sJ8F;LDMjM#xP<';MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public Log_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [dbo].[users] WHERE user_email = '" + txt_Email.Text.Trim() + "' AND user_password = '" + txt_password.Text.Trim() + "' AND (fk_role_id = 4 or fk_role_id = 5)";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlcon);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if(dataTable.Rows.Count == 1 )
            {
                CreateUser_Form form_user = new CreateUser_Form();
                this.Visible = false;
                form_user.Show();
            }
            else
            {
                MessageBox.Show("oupss retente avec le bon Email ou mot de passe !");
            }
        }
    }
}
