// See https://aka.ms/new-console-template for more information

List <string> listaDasBandas = new List<string>();




void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗  ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝  ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░  ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗  ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝  ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░  ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝");
}
void OpcoesDoMenu()
{
    int OpcaoNumericaEscolhida;
    do
    {
    
    
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para Sair");

    Console.Write("\n Digite a sua opcao: ");
    string OpcaoEscohida = Console.ReadLine()!;
     OpcaoNumericaEscolhida = int.Parse(OpcaoEscohida);


        ExibirLogo();

        switch (OpcaoNumericaEscolhida)
        {
            case 1:
                
                    RegistarBanda();
                break;
            case 2:
                ExibirBandas();
                break;
            case 3:
                Console.WriteLine("Você escolheu o " + OpcaoNumericaEscolhida);
                break;
            case 4:
                Console.WriteLine("Você escolheu o " + OpcaoNumericaEscolhida);
                break;
            case 0:
                Console.WriteLine("Você escolheu o " + OpcaoNumericaEscolhida);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        } 
    } while (OpcaoNumericaEscolhida != 0);
}
void RegistarBanda()
{
    Console.Clear();
    Console.WriteLine("*******************************+");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("*******************************+");

    Console.Write("Digite o nome da Banda: ");
    //a exclamação no final significa que não trabalhamos com valores nulos.
    string nomeDaBanda = Console.ReadLine()!;
    //adiciona a banda registrada a lista
    listaDasBandas.Add(nomeDaBanda);


    Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso");
    //funciona como um settimeout
    Thread.Sleep(2000);

    int opt;

    do
    {


        Console.WriteLine("Deseja registar outra banda? Digite \n 1-CONTINUAR \n 2-sair ");
        string registarOutraBanda = Console.ReadLine()!;
        opt = int.Parse(registarOutraBanda);

        switch (opt)
        {
            case 1:
                RegistarBanda();
                break;
            case 2:
                OpcoesDoMenu();
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    } while (opt != 2);

    //limpa tudo
    Console.Clear();
    //chama a funcao novamente para voltar as opçoes do menu
    OpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("*******************************+");
    Console.WriteLine("Lista de Bandas");
    Console.WriteLine("*******************************+");

    for(int i = 0; i< listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda : {listaDasBandas[i]}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();

    Console.Clear();
    OpcoesDoMenu();

}

OpcoesDoMenu();