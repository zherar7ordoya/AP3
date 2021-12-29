







interface IPrototipo
{
    object Clona();
}

class Valores : IPrototipo
{
    private double sumatoria;
    private int m = 1;

    public double Sumatoria { get => sumatoria; set => sumatoria = value; }
    public int M { get => m; set => m = value; }

    public Valores()
    {

    }
    public Valores(int m)
    {
        this.m = m;
        double sumatoria = 0;
        for (int n=0; n < 90; n++)
        {
            sumatoria += Math.Sin(n * 0.0175);
        }
    }

    public override string ToString()
    {
        return string.Format($"{sumatoria * m}");
    }

    public object Clona()
    {
        Valores clon = new();
        clon.M = this.M;
        clon.Sumatoria = this.Sumatoria;
        return clon;
    }
}