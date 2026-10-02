public interface IPartida
{
    int Id { get; set; }
    string Modalidade { get; set; }
    Time Time1 { get; set; }
    Time Time2 { get; set; }
    int PlacarTime1 { get; set; }
    int PlacarTime2 { get; set; }

    void jogar();
    void historico();
}