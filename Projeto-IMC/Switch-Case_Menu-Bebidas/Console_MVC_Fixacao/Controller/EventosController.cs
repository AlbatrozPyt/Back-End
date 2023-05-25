using Console_MVC_Fixacao.Model;
using Console_MVC_Fixacao.View;

namespace Console_MVC_Fixacao.Controller
{
    public class EventosController
    {
        EventosModel eventosModel  = new EventosModel();
        EventosView eventosView = new EventosView();

        public void ListarProdutos()
        {
            List<EventosModel> eventos = eventosModel.Ler();
            eventosView.Listar(eventos);
        }

        public void CadastrarProdutos()
        {

            EventosView eventosView = new EventosView();
            EventosModel eventosModel = new EventosModel();

            eventosModel.Inserir(eventosView.Cadastrar());

        }
    }
}