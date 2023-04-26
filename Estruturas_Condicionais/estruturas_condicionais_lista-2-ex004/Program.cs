// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

Console.WriteLine($"");

Console.WriteLine(@$"
==============
Interrogatorio
==============
");

Console.WriteLine($"");

int contador = 0;

Console.Write("Você telefonou para a vítima ? Responda apenas Sim ou Não. ");
string p1 = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

Console.Write("Você esteve no local do crime ? Responda apenas Sim ou Não. ");
string p2 = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

Console.Write("Você mora perto da vítima ? Responda apenas Sim ou Não. ");
string p3 = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

Console.Write("Você devia para a vítima ? Responda apenas Sim ou Não. ");
string p4 = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");

Console.Write("Você já trabalhou com a vítima ? Responda apenas Sim ou Não. ");
string p5 = Console.ReadLine()!.ToUpper();

Console.WriteLine($"");


if (p1 == "SIM") {
    contador ++;
}

if (p2 == "SIM") {
    contador ++;
}

if (p3 == "SIM") {
    contador ++;
}

if (p4 == "SIM") {
    contador ++;
}
 
if (p5 == "SIM") {
    contador ++;
}

if (contador < 2) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Voce foi considerado inocente pode ir embora.");
    Console.ResetColor(); 
}

else if ( contador == 2){
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Voce foi considerado suspeito, mas esta liberado.");
    Console.ResetColor();
}

else if (contador > 2 && contador <= 4) {
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"Voce foi considerado como cumplice e vai ficar aqui.");
    Console.ResetColor();
}

else {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
    |###############################################|
    |Voce foi considerado como culpado e esta PRESO |
    |###############################################|
    ");
    Console.ResetColor();
}



