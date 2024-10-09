using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            txtCep.Mask = "00000-000";
            txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            txtCep.SelectionStart = 0;

            string cep = txtCep.Text.Replace("-", "").Trim();

            if (cep.Length == 8)
            {
                await ConsultarCEPAsync(cep);
            }
            else
            {
                MessageBox.Show("Por favor, insira um CEP válido com 8 dígitos.", "ATENÇÃO");
            }
        }

        private async Task ConsultarCEPAsync(string cep)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        JObject dados = JObject.Parse(json);

                        if (dados["erro"] == null)
                        {
                            txtRua.Text = dados["logradouro"]?.ToString();
                            txtBairro.Text = dados["bairro"]?.ToString();
                            txtCidade.Text = dados["localidade"]?.ToString();
                            txtEstado.Text = dados["uf"]?.ToString();

                            if (!string.IsNullOrWhiteSpace(txtRua.Text) &&
                                !string.IsNullOrWhiteSpace(txtBairro.Text) &&
                                !string.IsNullOrWhiteSpace(txtCidade.Text) &&
                                !string.IsNullOrWhiteSpace(txtEstado.Text))
                            {
                                SalvarDadosEmArquivo("dados_cep.txt");
                            }
                            else
                            {
                                MessageBox.Show("Alguns dados do CEP estão incompletos e não serão salvos.", "ATENÇÃO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("CEP não encontrado. Verifique o número digitado.", "ATENÇÃO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao consultar o CEP.", "ATENÇÃO");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void SalvarDadosEmArquivo(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("----------------");
                    writer.WriteLine($"Dados do CEP: {txtCep.Text}");
                    writer.WriteLine($"Rua: {txtRua.Text}");
                    writer.WriteLine($"Bairro: {txtBairro.Text}");
                    writer.WriteLine($"Cidade: {txtCidade.Text}");
                    writer.WriteLine($"Estado: {txtEstado.Text}");
                    writer.WriteLine("----------------\n");
                }

                MessageBox.Show("Dados salvos automaticamente com sucesso!", "SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
            }
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;

            txtCep.SelectionStart = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCep.SelectionStart = 0;
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
