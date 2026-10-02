using System;

public class Partidas : IPartida
{
    public int Id { get; set; }
    public string Modalidade { get; set; }
    public Time Time1 { get; set; }
    public Time Time2 { get; set; }
    public int PlacarTime1 { get; set; }
    public int PlacarTime2 { get; set; }

    public Partidas(Time time1, Time time2, string modalidade)
    {
        Time1 = time1;
        Time2 = time2;
        Modalidade = modalidade;
    }

    public void jogar()
    {
        Console.WriteLine("\n===== RESULTADO =====");

        Console.Write($"Placar do {Time1.Nome}: ");
        PlacarTime1 = int.Parse(Console.ReadLine());

        Console.Write($"Placar do {Time2.Nome}: ");
        PlacarTime2 = int.Parse(Console.ReadLine());

        Time1.jogar(PlacarTime1, PlacarTime2);
        Time2.jogar(PlacarTime2, PlacarTime1);
    }

    public void historico()
    {
        Console.WriteLine(
            $"{Time1.Nome} {PlacarTime1} x {PlacarTime2} {Time2.Nome} - {Modalidade}"
        );
    }
}