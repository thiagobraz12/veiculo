
public class Veiculo
{
    public int id;

    public string numeroNiv;
    public string numeroPlaca;
    public string numeroMotor;
    public string renavam;
    public string anoModelo;
    public string situacao;
    public string cor;

    public void SetnumeroNiv(string numeroNiv)
    {
        if (numeroNiv.Length == 17)
        {
            numeroNiv = numeroNiv;

        }
        else 
        {
            throw new Exception("Numero Invalido");
        }

    }
    public string GetnumeroNiv()
    {
        return numeroNiv;
    }
}
