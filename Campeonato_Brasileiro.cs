using System;

class Campeonato_Brasileiro
{
        static List<string> ListaTimes = new List<string>();
        static void Main(string[] args)
    {
        Console.WriteLine("Campeonato Brasileiro\n");
        MenuPrincipal();
    }


    static void MenuPrincipal(){

        Console.WriteLine("Digite 1 para adicionar um time");
        Console.WriteLine("Digite 2 ver a tabela");
        Console.WriteLine("Digite 3 adicionar a pontuação da rodada");
        Console.WriteLine("Digite 0 para Sair\n");

        Console.Write("Digite a opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);


        switch (opcaoEscolhidaNumerica){
            case 1: AdicionarTime();
                break;
            
            case 2: VerTabela();
                break;

            case 3: AdicionarPontuacao();
                break;

        case 0:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }  
    }   

    static void AdicionarTime() {
        Console.Clear();
        Console.Write("Digite o nome do time para adicionar: ");
        string Time = Console.ReadLine();

        ListaTimes.Add(Time); // Adicionado o time na lista de times.

        Console.WriteLine($"Time '{Time}' foi adicionado com sucesso!\n");
        MenuPrincipal(); // Após adicionar o time, voltamos ao menu principal.
    

    }

    static void VerTabela() {
        Console.Clear();
        Console.WriteLine("Tabela do Campeonato:\n");

        foreach (string Time in ListaTimes){
            Console.WriteLine($"Time: {Time}");
        }
      
        Console.WriteLine("A tabela está vazia.\n");
        MenuPrincipal(); // Após ver a tabela, voltamos ao menu principal.
    
    }

    static void AdicionarPontuacao() {
        Console.Clear();
        Console.WriteLine("Adicionar Pontuação da Rodada:\n");

        // Aqui preciso adicionar a lógica para adicionar a pontuação de uma rodada.
        Console.WriteLine("Pontuação da rodada foi adicionada com sucesso!\n");
        MenuPrincipal(); // Após adicionar a pontuação, voltamos ao menu principal.
    

    }
}