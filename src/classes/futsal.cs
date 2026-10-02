using System;

public class Futsal : Time
{
    public int GolsMarcados { get; private set; }

    public Futsal(string nome) : base(nome)
    {
        Modalidade = "Futsal";
    }

    public override void jogar(int feitos, int sofridos)
    {
        if (feitos >= 0 && feitos <= 99 &&
            sofridos >= 0 && sofridos <= 99)
        {
            GolsMarcados = feitos;

            if (feitos > sofridos)
                Console.WriteLine($"{Nome} venceu por {feitos} x {sofridos}!");
            else if (feitos < sofridos)
                Console.WriteLine($"{Nome} perdeu por {feitos} x {sofridos}.");
            else
                Console.WriteLine($"{Nome} empatou em {feitos} x {sofridos}.");
        }
        else
        {
            Console.WriteLine("Resultado inválido! Os gols devem estar entre 0 e 99.");
        }
    }
}