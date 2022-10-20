using Herança.FuncoesAuxiliares;
using Herança.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herança.Telas
{
    public partial class TelaCadastroEmpresa : Form
    {
        public TelaCadastroEmpresa()
        {
            InitializeComponent();
            MontaCombo();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbRazaoSocial.Text))
                listaErros.Add("\nO campo RAZÃO SOCIAL não pode ser vazio!");

            if (string.IsNullOrEmpty(ttbNomeFantasia.Text))
                listaErros.Add("\nO campo NOME FANTASIA não pode ser vazio!");

            if (ttbCNPJ.Text == "  .   .   /    -")
                listaErros.Add("\nO campo CNPJ não pode ser vazio!");

            if (string.IsNullOrEmpty(ttbLogradouro.Text))
                listaErros.Add("\nO campo LOGRADOURO não pode ser vazio!");

            if (string.IsNullOrEmpty(ttbNumero.Text))
                listaErros.Add("\nO campo NUMERO não pode ser vazio!");

            if (string.IsNullOrEmpty(ttbBairro.Text))
                listaErros.Add("\nO campo BAIRRO não pode ser vazio!");

            if (string.IsNullOrEmpty(ttbCidade.Text))
                listaErros.Add("\nO campo CIDADE não pode ser vazio!");

            if (cbbEstado.SelectedItem == "--SELECIONE--")
                listaErros.Add("\nO campo ESTADO deve ser selecionado!");

            if (ttbTelefone.Text == "(  )     -")
                listaErros.Add("\nO campo TELEFONE não pode ser vazio!");

            if (Validacoes.TemErro(listaErros))
            {
                return;
            }
            else
            {
                Empresa empresa = new Empresa(ttbRazaoSocial.Text, ttbNomeFantasia.Text, ttbCNPJ.Text, ttbLogradouro.Text, ttbNumero.Text, ttbBairro.Text, ttbCidade.Text, cbbEstado.SelectedItem.ToString(), ttbTelefone.Text);

                //Teremos a persistência no banco

                MessageBox.Show("dados validados com sucesso!");
            }
        }

        private void MontaCombo()
        {
            cbbEstado.Items.Add("--SELECIONE--");
            cbbEstado.Items.Add("SP");
            cbbEstado.Items.Add("SC");
            cbbEstado.Items.Add("RJ");

            cbbEstado.SelectedItem = "--SELECIONE--";
            cbbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TelaCadastroEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
