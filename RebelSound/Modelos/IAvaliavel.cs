namespace RebelSound.Modelos;

internal interface IAvaliavel
{
    double Media { get; }
    void AdicionarNota(Avaliacao nota);
}
