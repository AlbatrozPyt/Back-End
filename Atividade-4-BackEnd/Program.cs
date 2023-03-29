Console.WriteLine(@$"
                      Super Quitanda
Produto                        |                       Preço    
_____________________________________________________________

Carne                          |                 R$22,63 (KG)
_____________________________________________________________

Batata                          |                 R$6,00 (KG)
_____________________________________________________________

Cebola                          |                 R$6,00 (KG)
_____________________________________________________________
");

var produtos = new List<string> {"Carne", "Batata", "Cebola"};

Console.WriteLine($"Digite quantos Kg de carne voce comprou:");
float peso = float.Parse(Console.ReadLine());

float valorKg = 22.63f;

float valor = 22.63f * peso;

Console.WriteLine($"Voce vai pagar R${Math.Round(valor, 2)}");




