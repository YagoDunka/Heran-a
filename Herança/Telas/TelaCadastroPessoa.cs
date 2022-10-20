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
    public partial class TelaCadastroPessoa : Form
    {
        public TelaCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            List<string> listaErros = new List<string>();

            if (string.IsNullOrEmpty(ttbNome.Text))
                listaErros.Add("\nO campo NOME não pode ser vazio!");

            if (ttbCPF.Text == "   .   .   -")
                listaErros.Add("\nO campo CPF não pode ser vazio!");

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

        }
    }
}
