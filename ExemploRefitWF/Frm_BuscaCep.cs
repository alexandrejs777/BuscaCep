using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCep
{
    public partial class Frm_BuscaCep : Form
    {
        public Task _buscaLogradouro { get; private set; }

        public Frm_BuscaCep()
        {
            InitializeComponent();
        }

        async Task BuscaLogradouro()
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");

                string cepInformado = msk_Cep.Text.ToString().Replace(".", "").Replace("-", "");

                var address = await cepClient.GetAddressAsync(cepInformado);

                txt_Logradouro.Text = address.Logradouro;
                txt_Bairro.Text = address.Bairro;
                txt_Localidade.Text = address.Localidade;
                txt_Uf.Text = address.Uf;
               
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro na consulta de cep: " + error.Message);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            _buscaLogradouro = BuscaLogradouro();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            msk_Cep.Text = "";
            txt_Logradouro.Text = "";
            txt_Bairro.Text = "";
            txt_Localidade.Text = "";
            txt_Uf.Text = "";
        }
    }
}
