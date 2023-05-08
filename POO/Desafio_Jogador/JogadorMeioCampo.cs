namespace Desafio_Jogador
{
    public class JogadorMeioCampo : Jogador
    {
         public override void Aposentadoria()
        {
            int DataAtual = DateTime.Now.Year;

            int idade = DataAtual - DataDeNascimento;

            int aposenta = 38 - idade;

            if (aposenta < idade && aposenta != 0) {
                Console.WriteLine(@$"
               Ainda faltam {aposenta} Anos para o jogador se aposentar !!!
                ");
            }
            else {
                Console.WriteLine(@$"
                 O jogador já pode se aposentar !!!
                ");
                
            }
            
        }

        public override void DadosJogador()
        {
            Console.WriteLine(@$"
            -=-=-=-=-=--=-=-=-=-=--=-=-=-=-=--=-=-=-=-=-
                         DADOS DO JOGADOR
            -=-=-=-=-=--=-=-=-=-=--=-=-=-=-=--=-=-=-=-=-
            Nome: {this.Nome}
            Data de Nascimento: {this.DataDeNascimento}
            Nacionalidde: {this.Nacionalidade}
            Altura: {this.Altura}
            Peso: {this.Peso}
            -=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=--=-=-=-=-=-
            ");
            
        }

        public override void IdadeJogador()
        {
            int DataAtual = DateTime.Now.Year;

            int idade = DataAtual - DataDeNascimento;

            Console.WriteLine(@$"
            -=-=-=-=-=-=-=-=-=-=-
            Idade do Jogador: {idade}
            -=-=-=-=-=-=-=-=-=-=-
            ");
            
        }
    }
}