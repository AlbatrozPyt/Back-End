// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine(@$"
----------------------------
       PLACAR DO JOGO
----------------------------
");
Console.WriteLine($"Qual o nome do 1° time:");
string nTime1 = Console.ReadLine()!;

Console.WriteLine($"Qual o nome do 2° time:");
string nTime2 = Console.ReadLine()!;

Console.WriteLine($"Quantos gols o {nTime1} marcou:");
int time1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols o {nTime2} marcou:");
int time2 = int.Parse(Console.ReadLine()!);

if (time1 > time2) {
    Console.WriteLine($"{nTime1} Ganhou !!! e {nTime2} perdeu. Placar: {time1} x {time2}");
}


else if (time2 > time1){
    Console.WriteLine($"{nTime2} Ganhou !!! e {nTime1} perdeu. Placar: {time2} x {time1}");
}

else {
    Console.WriteLine($"Jogo empatado. Placar: {time1} x {time2}");
}

