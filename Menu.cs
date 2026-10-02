using System;
using System.Collections.Generic;

public class Menu
{
    public static List<Partidas> ListaPartidas = new List<Partidas>();

    public static void ExibirMenu()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine();
            Console.WriteLine("===== LIGA DA TURMA =====");
            Console.WriteLine("1 - Cadastrar equipe");
            Console.WriteLine("2 - Consultar equipes");
            Console.WriteLine("3 - Cadastrar partida");
            Console.WriteLine("4 - Ver histórico");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Clear();
                equipes.Cadastrar();
            }
            else if (opcao == 2)
            {
                Console.Clear();
                equipes.Consultar();
            }
            else if (opcao == 3)
            {
                Console.Clear();
                CadastrarPartida();
            }
            else if (opcao == 4)
            {
                Console.Clear();
                Historico();
            }
            else if (opcao == 5)
            {
                Console.Clear();
                Console.WriteLine("Programa encerrado!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }

    public static void CadastrarPartida()
    {
        Console.WriteLine("\n===== NOVA PARTIDA =====");

        Console.WriteLine("Escolha a modalidade:");
        Console.WriteLine("1 - Futsal");
        Console.WriteLine("2 - eSports");
        Console.Write("Escolha: ");

        string opcao = Console.ReadLine();

        string modalidade;

        if (opcao == "1")
        {
            modalidade = "Futsal";
        }
        else if (opcao == "2")
        {
            modalidade = "eSports";
        }
        else
        {
            Console.WriteLine("Modalidade inválida!");
            return;
        }

        List<Time> timesDisponiveis = new List<Time>();

        for (int i = 0; i < equipes.ListaEquipes.Count; i++)
        {
            if (equipes.ListaEquipes[i].Modalidade == modalidade)
            {
                timesDisponiveis.Add(equipes.ListaEquipes[i]);
            }
        }

        if (timesDisponiveis.Count < 2)
        {
            Console.WriteLine("É necessário ter pelo menos 2 equipes dessa modalidade.");
            return;
        }

        Console.WriteLine("\n===== TIMES DISPONÍVEIS =====");

        for (int i = 0; i < timesDisponiveis.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {timesDisponiveis[i].Nome}");
        }

        Console.Write("Escolha o primeiro time: ");
        int numero1 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Escolha o segundo time: ");
        int numero2 = int.Parse(Console.ReadLine()) - 1;

        if (numero1 < 0 || numero1 >= timesDisponiveis.Count ||
            numero2 < 0 || numero2 >= timesDisponiveis.Count)
        {
            Console.WriteLine("Número de equipe inválido!");
            return;
        }

        if (numero1 == numero2)
        {
            Console.WriteLine("Não pode escolher o mesmo time!");
            return;
        }

        Time time1 = timesDisponiveis[numero1];
        Time time2 = timesDisponiveis[numero2];

        Partidas partida = new Partidas(
            time1,
            time2,
            modalidade
        );

        partida.jogar();

        ListaPartidas.Add(partida);

        Console.WriteLine("Partida cadastrada!");
    }

    public static void Historico()
    {
        Console.WriteLine("\n===== HISTÓRICO =====");

        for (int i = 0; i < ListaPartidas.Count; i++)
        {
            ListaPartidas[i].historico();
        }
    }
}