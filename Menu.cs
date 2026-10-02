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

        equipes.Consultar();

        Console.Write("Escolha o número do primeiro time: ");
        int numero1 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Escolha o número do segundo time: ");
        int numero2 = int.Parse(Console.ReadLine()) - 1;

        Time time1 = equipes.ListaEquipes[numero1];
        Time time2 = equipes.ListaEquipes[numero2];

        Partidas partida = new Partidas(
            time1,
            time2,
            time1.Modalidade
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