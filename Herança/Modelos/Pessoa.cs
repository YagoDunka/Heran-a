namespace Herança.Modelos
{
    public class Pessoa : DadosBase
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, string logradouro, string numero, string bairro, string cidade, string estado, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = new Endereco(logradouro, numero, bairro, cidade, estado);
            Telefone = telefone;
        }
    }
}
