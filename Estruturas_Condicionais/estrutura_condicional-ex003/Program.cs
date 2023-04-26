// Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
// Sendo    que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.Write($"Medida do 1° Lado: ");
float lado1 = float.Parse(Console.ReadLine()!);

Console.Write($"Medida do 2° Lado: ");
float lado2 = float.Parse(Console.ReadLine()!);

Console.Write($"Medida do 3° Lado: ");
float lado3 = float.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2 == lado3) {
    Console.WriteLine($"As medidas do triangulo, o tornam um Triângulo Equilátero.");
}

else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {
    Console.Write("As medidas do triangulo, o tornam um Triângulo Isósceles.");
}

else {
    Console.WriteLine($"As medidas do triangulo, o tornam um Triângulo Escaleno.");
}