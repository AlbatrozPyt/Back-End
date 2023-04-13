static float LeaoFaminto(float r) {
    float imposto = 0;

    if (r > 1500 && r <= 3500) {
        imposto = r * 20 / 100;
    }

    else if (r > 3500 && r <= 6000) {
        imposto = r * 25 / 100;
    }

    else if (r > 6000) {
        imposto = r * 35 / 100; 
    }

    return imposto;
}

Console.WriteLine(@$"
-------------------------
    IMPOSTO DE RENDA
-------------------------
");

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Digite sua Renda: ");
float renda = float.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.WriteLine($"");

string porcento = "";

if (renda > 1500 && renda <= 3500) {

       porcento = "20%";
}
else if (renda > 3500 && renda <= 6000) {
        porcento = "25%";
}
else if (renda > 6000) {
        porcento = "35%";
}
else {
    porcento = "0%";
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"O valor do Imposto é de {porcento} - R${Math.Round(LeaoFaminto(renda), 2)}");
Console.ResetColor();