
string mensagemDeBoasVindas = "E aí? Tudo bem? Sejam bem vindos ao meu projeto em C#: Silvers Sound!";
//List<string> ListasDasbandas = new List<string> { "U2", "The Beatles", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());


void LogoDoProjeto()
{
    Console.WriteLine(@"
░██████╗██╗██╗░░░░░██╗░░░██╗███████╗██████╗░░██████╗    ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██║██║░░░░░██║░░░██║██╔════╝██╔══██╗██╔════╝    ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║██║░░░░░╚██╗░██╔╝█████╗░░██████╔╝╚█████╗░    ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║██║░░░░░░╚████╔╝░██╔══╝░░██╔══██╗░╚═══██╗    ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝██║███████╗░░╚██╔╝░░███████╗██║░░██║██████╔╝    ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░╚═╝╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═════╝░    ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

void MensagemInicial()
{
    Console.WriteLine(" ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1: Registrar aquela Banda irada que você curte!");
    Console.WriteLine("Digite 2: Mostrar todas as Bandas que estão registradas!");
    Console.WriteLine("Digite 3: Avaliar com uma nota a Banda que você desejar!");
    Console.WriteLine("Digite 4: Exibir a média de uma Banda!");
    Console.WriteLine("Digite -1: Caso queira sair do Silvers Sound!");

    Console.Write("\nDigite uma das opções acima: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1: Console.WriteLine($"Volte sempre ao Silvers Sound! Até mais!");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    LogoDoProjeto();
    Console.WriteLine("\nMenu: Registrar bandas.\n");
    Console.Write("Digite aqui aquela banda irada que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    LogoDoProjeto();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    LogoDoProjeto();
    Console.WriteLine("\nMenu: Listas das bandas.\n");
    /*for (int i = 0; i < ListasDasbandas.Count; i++)
    {
        Console.WriteLine($"Banda: {ListasDasbandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nQuer voltar ao Menu Principal? É só digitar uma tecla aí.");
    Console.ReadKey();
    Console.Clear();
    LogoDoProjeto();
    ExibirOpcoesMenu();
}

void AvaliarUmaBanda()
{
    //digite qual a banda deseja avaliar
    //se a banda existir no dicionário >> atribuir uma nota
    //senão, volta ao menu principal

    Console.Clear();
    LogoDoProjeto();
    Console.WriteLine("\nMenu: Avaliações em notas das bandas.\n");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add (nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep (4000);
        Console.Clear();
        LogoDoProjeto();
        ExibirOpcoesMenu();

    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        LogoDoProjeto();
        ExibirOpcoesMenu();
    }


}

void ExibirMedia()
{
    Console.Clear();
    LogoDoProjeto();
    Console.WriteLine("\nMenu: Exibição de média de uma banda.\n");
    Console.Write($"Digite o nome da banda que você deseja fazer a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        LogoDoProjeto();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        LogoDoProjeto();
        ExibirOpcoesMenu();
    }

    

}


LogoDoProjeto();
MensagemInicial();
ExibirOpcoesMenu();
