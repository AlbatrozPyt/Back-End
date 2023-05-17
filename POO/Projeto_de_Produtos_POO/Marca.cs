namespace Projeto_de_Produtos_POO
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeDaMarca { get; set; }
        public DateTime DataDeCadastro { get; set; }

        List<Marca> Marcas = new List<Marca>();

        // Metodos
        public void Cadastrar()
        {
            Marca _marca = new Marca();

            Console.Write("Digite o codigo da marca: ");
            _marca.Codigo = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o nome da marca: ");
            _marca.NomeDaMarca = Console.ReadLine()!;

            _marca.DataDeCadastro = DateTime.Now;

            Marcas.Add(_marca);
        }

        public void Deletar(int c)
        {
            int mark = Marcas.FindIndex(x => x.Codigo == c);
            Marcas.RemoveAt(mark);
        }

        public void Listar()
        {
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