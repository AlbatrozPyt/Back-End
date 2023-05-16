namespace Projeto_de_Produtos_POO
{
    public class Marca
    {
        public string Codigo { get;  set; }
        public string NomeDaMarca { get;  set; } 
        public DateTime DataDeCadastro { get;  set; }

        List<Marca> Marcas = new List<Marca>();

        // Metodos
        public void Cadastrar(Marca _marca) {
            Marcas.Add(_marca);
        }

        public void Listar() {
            foreach (var item in Marcas)
            {
                Console.WriteLine(@$"
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                Marca: {item.NomeDaMarca}
                Codigo da Marca: {item.Codigo}
                Data de Cadastro ({item.DataDeCadastro})
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                ");
            }
        }
    }
}