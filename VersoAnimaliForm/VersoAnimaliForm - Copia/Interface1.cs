internal interface IVerso
{
    string Verso();
}

internal abstract class CAnimale
{
    private string mNome;
    private int mEta;
    private int mEnergia;
    public string nome { get; set; }
    public int eta { get; set; }
    public int energia { get; set; }
    public CAnimale()
    {
        nome = "";
        eta = 2;
        energia = 100;
    }
    public CAnimale(string Nome, int Eta, int Energia)
    {
        nome = Nome;
        eta = Eta;
        energia = Energia;
    }
}

internal class CCane : CAnimale, IVerso
{
    public CCane(): base()
    { }
    public  CCane(string Nome, int Eta, int Energia):base(Nome, Eta, Energia) { }
    public string Verso()
    {
        return "Bau!";
    }
}

internal class CGatto : CAnimale, IVerso
{
    public CGatto() : base()
    { }
    public CGatto(string Nome, int Eta, int Energia) : base(Nome, Eta, Energia) { }
    private string mColorePelo;

    public string Verso()
    {
        return "Miao!";
    }
}

internal class CMucca : CAnimale, IVerso
{
    public CMucca() : base()
    { }
    public CMucca(string Nome, int Eta, int Energia) : base(Nome, Eta, Energia) { }
    public string Verso()
    {
        return "Muuuu!";
    }
}
