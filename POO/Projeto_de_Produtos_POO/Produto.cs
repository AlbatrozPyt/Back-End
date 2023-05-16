using Projeto_de_Produtos_POO;

namespace Projeto_de_Produtos_POO
{
    public class Produto
    {   
        public string Codigo { get; set; }
        public string NomeDoProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public string CadastradoPor { get; set; }
        public Marca Marca { get; set; }
        List<Produto> Produtos = new List<Produto>();

        //  Metodos
        public void Cadastrar(Produto _produto) {
            Produtos.Add(_produto);
        }

        public void Listar() {
            foreach (var item in Produtos)
            {
                Console.WriteLine(@$"
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                Codigo: {item.Codigo}
                Nome do Produto: {item.NomeDoProduto}
                Preço: {item.Preco}
                Codigo da Marca: {item.Marca.Codigo}
                Marca: {item.Marca.NomeDaMarca}
                Data de Cadastro ({item.DataDeCadastro})
                Cadastrado Por ({item.CadastradoPor})
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                ");
            }
        }
        

    }
}