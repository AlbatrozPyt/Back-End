using Projeto_de_Produtos_POO;

namespace Projeto_de_Produtos_POO
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeDoProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataDeCadastro { get; set; }
        public Usuario CadastradoPor { get; set; }
        public Marca Marca { get; set; }
        List<Produto> Produtos = new List<Produto>();

        //  Metodos
        public void Cadastrar()
        {
            Produto _produto = new Produto();

            Console.Write("Digite o codigo do produto: ");
            _produto.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o nome do produto: ");
            _produto.NomeDoProduto = Console.ReadLine()!;

             Console.Write("Digite o preco do produto: ");
            _produto.Preco = float.Parse(Console.ReadLine()!);

            _produto.DataDeCadastro = DateTime.Now;

        

            Produtos.Add(_produto);
        }

          public void Deletar(int c)
        {
            int mark = Produtos.FindIndex(x => x.Codigo == c);
            Produtos.RemoveAt(mark);
        }


        public void Listar()
        {
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