using System;

public class Time : iTime
{
    public string Nome { get; set; }
    public string Modalidade { get; set; }

    public Time(string nome)
    {
        Nome = nome;
        Modalidade = "Não definida";
    }

    public virtual void jogar(int feitos, int sofridos)
    {
        Console.WriteLine($"{Nome}: {feitos} x {sofridos}");
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Modalidade: {Modalidade}");
    }
}