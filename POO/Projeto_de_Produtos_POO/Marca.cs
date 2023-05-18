namespace Projeto_de_Produtos_POO
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeDaMarca { get; set; }
        public DateTime DataDeCadastro { get; set; }

        List<Marca> Marcas = new List<Marca>();

        // Metodos
        public Marca Cadastrar()
        {
            Marca _marca = new Marca();

            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Digite o codigo da marca: ");
            _marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o nome da marca: ");
            _marca.NomeDaMarca = Console.ReadLine()!;
            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            _marca.DataDeCadastro = DateTime.Now;

            Marcas.Add(_marca);
            // foreach (var item in Marcas)
            // {
            //     Console.WriteLine(@$"
            //     -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            //     Marca: {item.NomeDaMarca}
            //     Codigo da Marca: {item.Codigo}
            //     Data de Cadastro ({item.DataDeCadastro})
            //     -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            //     ");
            // }

            // Console.BackgroundColor = ConsoleColor.DarkGreen;
            // Console.WriteLine($"Marca Adicionada...");
            // Console.ResetColor();

            return _marca;
        }

        public void Deletar(int c)
        {
            int mark = Marcas.FindIndex(x => x.Codigo == c);

            if (mark == -1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"ERRO, esse codigo nao existe !!!");
                Console.ResetColor();
            }

            else
            {
                Marcas.RemoveAt(mark);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Marca Removida...");
                Console.ResetColor();
            }
        }

        public void Listar()
        {
            // if (Marcas.Count == 0)
            // {
            //     Console.WriteLine($"");

            //     Console.BackgroundColor = ConsoleColor.White;
            //     Console.ForegroundColor = ConsoleColor.Black;
            //     Console.WriteLine($"Nao tem nada na lista.");
            //     Console.ResetColor();
            // }
            // else
            // {
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
            // }
        }
    }
}