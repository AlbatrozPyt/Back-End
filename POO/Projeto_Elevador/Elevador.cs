namespace Projeto_Elevador
{
    public class Elevador
    {
        public int AndarAtual {get; set;}
        public int TotalAndares {get; set;}
        public int CapacidadeElevador {get; set;}
        public int NumPessoas {get; set;}

        // Metodos
        public void Inicializar(int capacidade, int totalAnd) {
            Console.WriteLine(@$"
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
                          ELEVADOR
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            Andar Atual: {(this.AndarAtual == 0 ? "(Terreo)" : $"{this.AndarAtual}º Andar")}
            Total de Andares: {totalAnd}
            Capacidade do Elevador: {capacidade}
            Nº de Pessoas: {this.NumPessoas}
            -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            ");
            
        }

        public void Entrar() {
            if (this.NumPessoas >= this.CapacidadeElevador) {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Capacidade MAXIMA Atingida !!!");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Uma pessoa ENTROU no elevador.");
                Console.ResetColor();
                NumPessoas ++;
            }
        }    

        public void Sair() {
            if (this.NumPessoas == 0) {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Nao tem NINGUEM no elevador.");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Uma pessoa SAIU do elevador.");
                Console.ResetColor();
                NumPessoas --;
            }
        }

        public void Subir() {
            if (this.AndarAtual == TotalAndares) {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ja chegamos no ULTIMO andar.");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"O elevador SUBIU um andar.");
                Console.ResetColor();
                this.AndarAtual ++;
            }
        }
    
        public void Descer() {
            if (this.AndarAtual == 0) {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"Ja chegamos no TERREO.");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"O elevador DESCEU um andar.");
                Console.ResetColor();
                this.AndarAtual --;
            }
        }
    
    }
}