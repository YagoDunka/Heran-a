namespace Herança.Modelos
{
    public class DadosBase
    {
        public Endereco Endereco { get; set; }

        public string Telefone { get; set; }

        public DadosBase()
        {

        }

        public DadosBase(Endereco endereco, string telefone)
        {
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
