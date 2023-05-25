using Console_MVC.View;

namespace Console_MVC.Model
{
    public class Produto
    {
        // PROPIEDADES
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // CAMINHO DA PASTA E DO ARQUIVO CSV
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            // CRIAR A LOGICA PARA GERAR A PASTA E O ARQUIVO

            string pasta = PATH.Split("/")[0];  // OBTER O CAMINHO DA PASTA

           
            if (!Directory.Exists(pasta))    // VERIFCAR SE NO CAMINHO JA EXISTE UMA PASTA
            {
                Directory.CreateDirectory(pasta);
            }

          
            if (!File.Exists(PATH))  // VERIFICAR SE NO CAMINHO JA EXISTE UM ARQUIVO
            {
                File.Create(PATH);
            }


        }

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);
                p.Nome = atributos[1];
                p.Preco = float.Parse(atributos[2]);

                produtos.Add(p);
            }

            return produtos;
        }

        // METODOS PARA PREPARR AS LINHAS A SEREM INSERIDAS NO CSV
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        public void Inserir(Produto p)
        {
            string[] linhas = { PrepararLinhasCSV(p) }; // ARRAY QUE ARMAZENA AS LINHAS OBTIDAS PELO METODO

            File.AppendAllLines(PATH, linhas);
        }
    }
}