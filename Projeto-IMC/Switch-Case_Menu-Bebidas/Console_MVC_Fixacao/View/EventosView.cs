using Console_MVC_Fixacao.Model;

namespace Console_MVC_Fixacao.View
{
    public class EventosView
    {
        public void Listar(List<EventosModel> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine(@$"
                Nome do Evento: {item.Nome}

                Descricao do Evento: {item.Descricao}

                Data do Evento: {item.Data};
                ");
                
            }
        }
    
        public EventosModel Cadastrar()
        {
            EventosModel novoEvento = new EventosModel();

            Console.Write("Informe o nome do evento: ");
            novoEvento.Nome = Console.ReadLine();
            
            Console.Write("Descricao do evento: ");
            novoEvento.Descricao = Console.ReadLine();
            
            Console.Write("Informe a data do evento: ");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
            
        }

    }
}