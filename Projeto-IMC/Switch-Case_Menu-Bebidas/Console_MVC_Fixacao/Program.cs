// Criar um programa console Para cadastro de Eventos. Aplique os conceitos MVC aprendidos em sala de aula.
// O evento deve ter Nome, Descrição e Data que o evento ocorrerá.
// As funcionalidades devem ser Cadastrar e Listar.

using Console_MVC_Fixacao.Model;
using Console_MVC_Fixacao.Controller;

EventosModel evento = new EventosModel();
EventosController controller = new EventosController();

Console.WriteLine($"");

controller.CadastrarProdutos();
controller.ListarProdutos();