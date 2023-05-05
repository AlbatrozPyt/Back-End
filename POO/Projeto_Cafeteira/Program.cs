// 2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar.

// No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.

// a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?

// b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.

// c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!

using Projeto_Cafeteira;

MaquinaCafe cafe = new MaquinaCafe();
string opcao = "";

Console.WriteLine($"");

while (true) {
    do {
        Console.WriteLine(@$"
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
         SUPER CAFETEIRA TABAJARA PLUS++
        -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
         Opcoes:
                 [1] - Fazer Cafe
                 [0] - Desligar Maquina

        ");

        Console.Write("Escolha uma opcao: ");
        opcao = Console.ReadLine()!;
        
        if (opcao != "1" && opcao != "0") {
            Console.WriteLine($"");
            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"ERRO, digite apenas as opcoes do menu !!!");
            Console.ResetColor();
        }
    
    } while (opcao != "1" && opcao != "0");

    if (opcao == "1") {
        cafe.FazerCafe();
    }
    else {
        Console.WriteLine($"Finalizando...");
        Thread.Sleep(1000);

        Console.Clear();
        
    }
}