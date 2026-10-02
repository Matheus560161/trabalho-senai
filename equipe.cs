using System;
using System.Collections.Generic;

public class equipes
{
    public static List<Time> ListaEquipes = new List<Time>();

    public static void Cadastrar()
    {
        Console.Write("Nome da equipe: ");
        string nome = Console.ReadLine();

        Console.Write("Modalidade (1-Futsal / 2-eSports): ");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            ListaEquipes.Add(new Futsal(nome));
        }
        else if (opcao == "2")
        {
            ListaEquipes.Add(new Esport(nome));
        }
        else
        {
            Console.WriteLine("Modalidade inválida!");
            return;
        }

        Console.WriteLine("Equipe cadastrada!");
    }

    public static void Consultar()
    {
        Console.WriteLine("\n===== EQUIPES =====");

        for (int i = 0; i < ListaEquipes.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1} - {ListaEquipes[i].Nome} - {ListaEquipes[i].Modalidade}"
            );
        }
    }
}