namespace Herança.Modelos
{
    public class Empresa : DadosBase
    {
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Cnpj { get; private set; }

        public Empresa()
        {

        }

        public Empresa(string razaoSocial, string nomeFantasia, string cnpj, string logradouro, string numero, string bairro, string cidade, string estado, string telefone)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            Endereco = new Endereco(logradouro, numero, bairro, cidade, estado);
            Telefone = telefone;
        }
    }
}
