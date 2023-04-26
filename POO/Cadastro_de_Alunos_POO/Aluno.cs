using System.Globalization;

namespace Cadastro_de_Alunos_POO
{
    public class Aluno
    {
        public string nome; 
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista = false;
        public float mediaFinal;
        public float valorMensalidade;

        // Metodos
        public string VerMediaFinal() {
            return $"Media Final: {mediaFinal}";
        }

        public string VerMensalidade() {
            float total;
            if (this.bolsista == true && this.mediaFinal >= 8) {
                total = valorMensalidade / 2;
                return $"Valor da Mensalidade: {total.ToString("C", new CultureInfo("PT-br"))}";
            }

            else if (this.bolsista == true &&  this.mediaFinal > 6 && this.mediaFinal < 8) {
                total = valorMensalidade - (valorMensalidade * 30 / 100);
                return $"Valor da Mensalidade: {total.ToString("C", new CultureInfo("PT-br"))}";
            }

            else {
                return $"Valor da Mensalidade: {this.valorMensalidade.ToString("C", new CultureInfo("PT-br"))}";
            }
        }
    }
}