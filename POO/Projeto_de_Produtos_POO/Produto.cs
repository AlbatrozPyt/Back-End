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
        public Marca _Marca { get; set; }
        List<Produto> Produtos = new List<Produto>();

        //  Metodos
        public void Cadastrar()
        {
            Produto _produto = new Produto();
            Usuario _usuario = new Usuario();
            Marca _marca = new Marca();

            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.Write("Digite o codigo do produto: ");
            _produto.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o nome do produto: ");
            _produto.NomeDoProduto = Console.ReadLine()!;

            Console.Write("Digite o preco do produto: ");
            _produto.Preco = float.Parse(Console.ReadLine()!);


            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            _produto.DataDeCadastro = DateTime.Now;

            _produto.CadastradoPor = _usuario;

           _produto._Marca = _marca.Cadastrar();

            Produtos.Add(_produto);

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Produto Adicionado...");
            Console.ResetColor();
        }

        public void Deletar(int c)
        {
            int mark = Produtos.FindIndex(x => x.Codigo == c);

            if (mark == -1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"ERRO, esse codigo de produto nao existe !!!");
                Console.ResetColor();
            }
            else
            {
                Produtos.RemoveAt(mark);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Produto Removido...");
                Console.ResetColor();
            }
        }


        public void Listar()
        {

            // if (Produtos.Count == 0)
            // {
            //     Console.WriteLine($"");

            //     Console.BackgroundColor = ConsoleColor.White;
            //     Console.ForegroundColor = ConsoleColor.Black;
            //     Console.WriteLine($"Nao tem nada na lista.");
            //     Console.ResetColor();
            // }

            // else
            // {

                foreach (var item in Produtos)
                {
                    Console.WriteLine(@$"
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                Codigo: {item.Codigo}
                Nome do Produto: {item.NomeDoProduto}
                Preço: {item.Preco}
                Marca: {item._Marca.NomeDaMarca}
                Data de Cadastro ({item.DataDeCadastro})
                Cadastrado Por ({item.CadastradoPor.Nome})
                -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                ");
                }
            // }
        }


    }
}