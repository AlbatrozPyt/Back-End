namespace Exemplo_AgendaDeContato
{
    public class ContatoPessoal : Contato , IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCPF(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}