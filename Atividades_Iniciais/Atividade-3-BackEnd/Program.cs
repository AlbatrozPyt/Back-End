// Media do Aluno

Console.WriteLine($"Digite a 1º Nota:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 2º Nota:");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 3º Nota:");
float n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 4º Nota:");
float n4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 5º Nota:");
float n5 = float.Parse(Console.ReadLine());

float media = (n1+n2+n3+n4+n5) / 5;

Console.WriteLine($"A media do Aluno foi de {media}");

if (media > 5) {
    Console.WriteLine($"O aluno foi Aprovado");
} else {
    Console.WriteLine($"O aluno foi Reprovado");
    
}
