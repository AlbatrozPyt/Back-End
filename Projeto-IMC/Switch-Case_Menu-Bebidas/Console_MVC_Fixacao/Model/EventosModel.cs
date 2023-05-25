namespace Console_MVC_Fixacao.Model
{
    public class EventosModel
    {
        // PROPIEDADES
        public string? Nome {get; set;}
        public string?  Descricao { get; set; }
        public string? Data { get; set; }

        // CAMINHO DA PASTA E ARQUIVO .CSV
        private const string PATH = "Database/Eventos.csv";

        public EventosModel()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        
        }

      public List<EventosModel> Ler()
        {
            List<EventosModel> eventos = new List<EventosModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                string[] atributos = item.Split(";");

                EventosModel evento = new EventosModel();

                evento.Nome = atributos[0];
                evento.Descricao = atributos[1];
                evento.Data = atributos[2];

                eventos.Add(evento);
            }

            return eventos;
        }
    
        public string PrepararLinhasCSV(EventosModel e)
        {
            return $"[{e.Nome}];[{e.Descricao}];[{e.Data}]";
        }

        public void Inserir(EventosModel e)
        {
            string[] linhas = {PrepararLinhasCSV(e)};

            File.AppendAllLines(PATH, linhas);
        }
    }
}