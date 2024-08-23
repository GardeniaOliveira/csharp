// See https://aka.ms/new-console-template for more information

using System;
using System.Xml;

//o list será substituido pelo dictonary pq queremos adicionar as avaliações das bandas
//List <string> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();




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
                AvaliarBanda();
                break;
            case 4:
                MediaDaBanda();
                break;
            case 0:
                Console.WriteLine("OBRIGADA E ATÉ MAIS");
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
    ExibirTituloDaOpcao("Registro de Bandas");
    

    Console.Write("Digite o nome da Banda: ");
    //a exclamação no final significa que não trabalhamos com valores nulos.
    string nomeDaBanda = Console.ReadLine()!;
    //adiciona a banda registrada a lista
    //listaDasBandas.Add(nomeDaBanda);

    //o dictionry precisa dos dois argumentos, o nome da banda e as notas. No primeiro momento a nota será vazia.
    bandasRegistradas.Add(nomeDaBanda, new List<int>());


    Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso");
    //funciona como um settimeout
    Thread.Sleep(1000);

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
    ExibirTituloDaOpcao("Lista de Bandas");

    //for(int i = 0; i< listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda : {listaDasBandas[i]}");
    //}

    //***********************CODIGO LIST **********************
    //foreach(string banda in listaDasBandas)
    //{
    //    Console.WriteLine($"Banda {banda}");
    //}

    //**********************CODIGO DICTIONARY ******************
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();

    Console.Clear();
    OpcoesDoMenu();

}

void AvaliarBanda()
{
    ExibirTituloDaOpcao("Avaliar banda");

    Console.WriteLine("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\n Digite uma nota para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\n A nota {nota} para a banda {nomeDaBanda}");

        Thread.Sleep(2000);
        Console.Clear() ;

        OpcoesDoMenu() ;

    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();

        OpcoesDoMenu();
    }

}

void MediaDaBanda()
{
    ExibirTituloDaOpcao("Média da banda");

    Console.WriteLine("Digite o nome da banda que deseja ver a média");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas [nomeDaBanda];
        
        Console.WriteLine($"\n A média final da banda {nomeDaBanda} é {notasDaBanda.Average()}");

        Thread.Sleep(2000);
        
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();

        Console.Clear();
        OpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\n A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();

        OpcoesDoMenu();
    }

}
void ExibirTituloDaOpcao(string titulo)
{
    int tamanhoDoTitulo = titulo.Length;
    string caracter = string.Empty.PadLeft(titulo.Length, '*');

    Console.WriteLine(caracter);
    Console.WriteLine(titulo);
    Console.WriteLine(caracter + "\n");

}
OpcoesDoMenu();