using System;

class Time
{
    public string Nome { get; set; }
    public int Pontuacao { get; set; }
    public int QuantidadeJogos { get; set; }

    public Time(string nome)
    {
        Nome = nome;
        Pontuacao = 0;
        QuantidadeJogos = 0;
    }
}


class Campeonato_Brasileiro
{        
        static List<Time> ListaTimes = new List<Time>();
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
        string nomeTime = Console.ReadLine()!;

        Time novoTime = new Time(nomeTime);
        ListaTimes.Add(novoTime);

        Console.WriteLine($"Time '{nomeTime}' foi adicionado com sucesso!\n");
        MenuPrincipal(); // Após adicionar o time, voltamos ao menu principal.
    }
    static void VerTabela()
    {
        Console.Clear();
        Console.WriteLine("Tabela do Campeonato:\n");

        foreach (var time in ListaTimes)
        {
            Console.WriteLine($"Time: {time.Nome}, Pontuação: {time.Pontuacao}, Jogos: {time.QuantidadeJogos}");
        }

        if (ListaTimes.Count == 0)
            Console.WriteLine("A tabela está vazia.\n");

        MenuPrincipal();
    }

    static void AdicionarPontuacao()
{
    Console.Clear();
    Console.Write("Qual time?\n");
    string nomeTime = Console.ReadLine()!;

    Time timeSelecionado = ListaTimes.Find(time => time.Nome == nomeTime);

    if (timeSelecionado != null)
    {
        Console.Write($"O {nomeTime} Ganhou? Perdeu? Empatou? :\n");
        string pontuacao = Console.ReadLine()!;

        switch (pontuacao.ToLower())
        {
            case "ganhou":
                timeSelecionado.Pontuacao += 3;
                Console.WriteLine("Pontuação da rodada foi adicionada com sucesso!\n");
                break;

            case "empatou":
                timeSelecionado.Pontuacao += 1;
                Console.WriteLine("Pontuação da rodada foi adicionada com sucesso!\n");
                break;

            case "perdeu":
                Console.WriteLine("O time perdeu, não houve pontuação!\n");
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }

        timeSelecionado.QuantidadeJogos++;
    }
    else
    {
        Console.WriteLine($"Time '{nomeTime}' não encontrado.\n");
    }

    MenuPrincipal();
}




    }
