using System;

public class Esport : Time
{
    public int MapasVencidos { get; private set; }

    public Esport(string nome) : base(nome)
    {
        Modalidade = "eSports";
    }

    public override void jogar(int feitos, int sofridos)
    {
        // Melhor de 3: só pode terminar 2x0, 2x1, 0x2 ou 1x2
        if ((feitos == 2 && (sofridos == 0 || sofridos == 1)) ||
            (sofridos == 2 && (feitos == 0 || feitos == 1)))
        {
            MapasVencidos = feitos;

            if (feitos > sofridos)
            {
                Console.WriteLine($"{Nome} venceu por {feitos} x {sofridos}!");
            }
            else
            {
                Console.WriteLine($"{Nome} perdeu por {feitos} x {sofridos}.");
            }
        }
        else
        {
            Console.WriteLine("Resultado inválido!");
            Console.WriteLine("No eSports, use 2x0, 2x1, 0x2 ou 1x2.");
        }
    }
}