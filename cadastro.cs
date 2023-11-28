
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using MySql;

namespace Trabalhoc_
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {


            string nome = textBoxNome.Text;
            string cpf= textBoxCPF.Text;
            string email = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

            string sql = $"insert into usuarioscep(nome,cpf,email,senha) values('{nome}','{cpf}','{email}','{senha}')";
            
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd='';database='cep_consulta'");
            MySqlCommand cmd = new MySqlCommand(sql, con);

            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            con.Dispose();
            cmd.Dispose();
            MessageBox.Show("Dados salvos com sucesso");
            this.Hide();
            Login p = new Login();
            p.ShowDialog();
            this.Close();
        }
    }
}
