using Exemplo_AgendaDeContato;

List<Contato> agenda = new List<Contato>();

ContatoComercial cc = new ContatoComercial();
ContatoPessoal cp = new ContatoPessoal();

agenda.Add(cc);
agenda.Add(cp);

Console.Clear();
Console.WriteLine($"Quantidade de contatos: {agenda.Count}");