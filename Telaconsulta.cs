using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalhoc_
{
    public partial class Telaconsulta : Form
    {
        public Telaconsulta()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numerocep.Text))
            {
                MessageBox.Show("Informe um cp válido...", this.Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string strUrl = string.Format("https://viacep.com.br/ws/{0}/json/",numerocep.Text.Trim());
                try
                {
                    using(HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(strUrl).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;
                            Resultado res = JsonConvert.DeserializeObject<Resultado>(result);

                            estado.Text = res.UF;
                            cidade.Text = res.Localidade;
                            bairro.Text = res.Bairro;
                            rua.Text = res.Logradouro;
                            

                        }
                    }
                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            numerocep.Text = string.Empty;
            estado.Text = string.Empty;
            cidade.Text = string.Empty;
            bairro.Text = string.Empty;
            rua.Text = string.Empty;
            
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
