namespace Herança.FuncoesAuxiliares
{
    public static class Validacoes
    {
        public static bool TemErro(List<string> listaErros)
        {
            if(listaErros.Count == 0) 
                return false;

            string erros = "";
            foreach (var itemDaLista in listaErros)
                erros = erros + itemDaLista;

            MessageBox.Show(erros, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return true;

        }
    }
}
