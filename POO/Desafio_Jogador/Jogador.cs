namespace Desafio_Jogador
{
    public abstract class Jogador
    {
        public string Nome {get; set;}
        public int DataDeNascimento {get; set;}
        public string Nacionalidade {get; set;}
        public string Altura {get; set;}
        public string Peso {get; set;}

        // Metodos
        public abstract void DadosJogador();
        public abstract void IdadeJogador();
        public abstract void Aposentadoria();
    }
}