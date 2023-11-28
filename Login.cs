using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;


namespace Trabalhoc_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void linkLabelcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastro p = new cadastro();
            p.ShowDialog();
        }

        private void ButtonEntrar(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            string email = campoemail.Text;
            string senha = camposenha.Text;

            
            try
            {
                String sql = $"select * from usuarioscep where email='{email}' and senha='{senha}'";
                con = new MySqlConnection("server=localhost;uid=root;pwd='';database='cep_consulta'");
                cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.Hide();
                    Telaconsulta p = new Telaconsulta();
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou senha errados!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro. Fale com o adm!");
                return;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }

           
       
                
            
        }

        private void camposenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
