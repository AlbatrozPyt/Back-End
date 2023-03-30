// string nome = "Matheus";
// const int idade = 16;
// Console.WriteLine("A idade de " + nome + " é " + idade + " anos");

// Tipo de dados
// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.80f;
// bool careca = true;
// string texto = "Olá Mundo";
// char letra = 'C';

//Operadores aritimeticos
// Console.WriteLine(4 + 3); //soma
// Console.WriteLine(4 + "3"); //concatenacao
// Console.WriteLine(100 - 33); //subtracao
// Console.WriteLine(10 / 2); //multiplicacao
// Console.WriteLine(5 % 2); //modular -- resto da divisao


//Operador de comparacao -- resposta True ou False
// Console.WriteLine(5==5); //igual a
// Console.WriteLine( 5 >= 4); //maior ou igual
// Console.WriteLine( 4 <= 4); //menor ou igual
// Console.WriteLine(5 != 8); //diferente de

//Operadores logicos e tabela da verdade
                                      //Tabela da Verdade
// Console.WriteLine(5 == 5 && 7 == 7);  //True && True = True
// Console.WriteLine(5 == 5 && 7 == 6);  //True && False = False
// Console.WriteLine(5 == 4 && 7 == 7);  //False && True = False
// Console.WriteLine(5 == 4 && 7 == 6);  //False && False = False

// Console.WriteLine(2 == 2 || 3 == 3);  //True || True = True
// Console.WriteLine(2 == 2 || 3 == 4);  //True || False = True
// Console.WriteLine(2 == 3 || 3 == 3);  //False || True = True
// Console.WriteLine(2 == 3 || 3 == 4);  //False || False= False

// Console.WriteLine(!(2 == 4 || 3 == 8)); //Operador de negacao -> ! = False


// Programa para calcular IMC

//entradas
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

float peso = 89.9f;
float altura = 1.80f;

//processamento
float imc = peso / (altura*altura);

Console.WriteLine($"O imc do " + nome + " é de: " + Math. Round(imc, 2));
