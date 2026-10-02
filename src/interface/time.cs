public interface iTime
{
    string Nome { get; set; }
    string Modalidade { get; set; }

    void jogar(int feitos, int sofridos);
}