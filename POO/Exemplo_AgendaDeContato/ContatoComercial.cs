namespace Exemplo_AgendaDeContato
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj { get; set; }

        public bool ValidarCNPJ(string _cnpj)
        {
            throw new NotImplementedException();
        }
    }
}