// tipo tipoDado NomeFuncao(parametros ou argumentos) { Corpo da funcao }

static float Soma(float n1, float n2) {
    float t = n1 + n2;
    return t;
}

static float Subtrai(float n1, float n2) {
    float t = n1 - n2;
    return t;
}

static float Dividir(float n1, float n2) {
    float t = n1 / n2;
    return t;
}

static float Multiplica(float n1, float n2) {
    float t = n1 * n2;
    return t;
}

while (true) {
    Console.Write(@$"
    ==========================
    Escolha uma Operacao:
    1 -> Soma
    2 -> Subtracao
    3 -> Multiplicacao
    4 -> Divisao
    ===========================
    ");

    Console.WriteLine($"");

    Console.Write("-> ");
    string calc = Console.ReadLine()!;

    Console.WriteLine($"");

    switch (calc) {
        case "1":
        Console.WriteLine($"---SOMA---");
        
        Console.Write("Digite um numero: ");
        float a = float.Parse(Console.ReadLine()!);

        Console.Write("Digite outro numero: ");
        float b = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"{a} + {b} = {Soma(a,b)}");
        
        break;

        case "2":
        Console.WriteLine($"---SUBTRACAO---");
        
        Console.Write("Digite um numero: ");
        a = float.Parse(Console.ReadLine()!);

        Console.Write("Digite outro numero: ");
        b = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"{a} - {b} = {Subtrai(a,b)}");
        
        break;

        case "3":
        Console.WriteLine($"---MULTIPLICACAO---");
        
        Console.Write("Digite um numero: ");
        a = float.Parse(Console.ReadLine()!);

        Console.Write("Digite outro numero: ");
        b = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"{a} x {b} = {Multiplica(a,b)}");
        
        break;

        case "4":
        Console.WriteLine($"---DIVISAO---");
        
        Console.Write("Digite um numero: ");
        a = float.Parse(Console.ReadLine()!);

        Console.Write("Digite outro numero: ");
        b = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"{a} / {b} = {Dividir(a,b)}");
        
        break;

    }

    Console.WriteLine($"");
    
    Console.Write("Quer fazer mais calculos ? [s/n]");
    string r = Console.ReadLine()!;
    if (r == "n"){
        break;
    }
}