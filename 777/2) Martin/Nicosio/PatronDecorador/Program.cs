using static System.Console;

IComponente miAuto = new CAuto("2018", "4 puertas", 1000);

WriteLine(miAuto.Costo());
WriteLine(miAuto.Funciona());
WriteLine(miAuto);

WriteLine("-----------------------------");

// Necesitamos typecast para usar un método de CAuto
((CAuto)miAuto).Puertas(true);

WriteLine("-----------------------------");

miAuto = new CSistemaSonido(miAuto);

// Comprobamos adicciones.
WriteLine(miAuto.Costo());
WriteLine(miAuto.Funciona());
WriteLine(miAuto);

WriteLine("-----------------------------");

miAuto = new CNitrogeno(miAuto);

// Comprobamos adicciones.
WriteLine(miAuto.Costo());
WriteLine(miAuto.Funciona());
WriteLine(miAuto);

// Necesitamos typecast para usar un método de CNitrogeno
((CNitrogeno)miAuto).UsaN();

WriteLine("-----------------------------");

miAuto = new CSuspension(miAuto);

// Comprobamos adicciones.
WriteLine(miAuto.Costo());
WriteLine(miAuto.Funciona());
WriteLine(miAuto);

WriteLine("-----------------------------");


public interface IComponente
{
    double Costo();
    string Funciona();
}


public class CAuto : IComponente
{
    private string modelo;
    private string caracteristicas;
    public double costo;

    public CAuto(
        string pModelo,
        string PCaract, 
        double pCosto)
    {
        this.modelo = pModelo;
        this.caracteristicas = PCaract;
        this.costo=pCosto;
    }

    public void Puertas(bool pEstado)
    {
        if (pEstado) { WriteLine("Puertas cerradas"); }
        else { WriteLine("Puertas abiertas"); }
    }

    public override string ToString()
    { return String.Format($"Modelo {modelo}, {caracteristicas}\n"); }

    public double Costo()
    { return costo; }

    public string Funciona()
    { return "Encendí el motor.\n"; }
}


public class CNitrogeno : IComponente
{
    private IComponente decoramosA;

    public CNitrogeno(IComponente pComponente)
    {
        decoramosA = pComponente;
    }

    public override string ToString()
    {
        return "Sistema de Nitrógeno " + decoramosA.ToString();
    }

    public double Costo()
    {
        return decoramosA.Costo() + 300;
    }

    public string Funciona()
    {
        return decoramosA.Funciona() + ", Nitrógeno listo\n";
    }

    public void UsaN()
    {
        WriteLine("Nitrógeno en uso\n");
    }
}


class CSistemaSonido : IComponente
{
    private IComponente decoramosA;

    public CSistemaSonido(IComponente pComponente)
    {
        decoramosA = pComponente;
    }

    public override string ToString()
    {
        return "Radio 350XZ+ " + decoramosA.ToString();
    }

    public double Costo()
    {
        return decoramosA.Costo() + 300;
    }

    public string Funciona()
    {
        return decoramosA.Funciona() + ", Enciendo el radio\n";
    }
}

class CSuspension : IComponente
{
    private IComponente decoramosA;

    public CSuspension(IComponente pComponente)
    {
        decoramosA = pComponente;
    }

    public override string? ToString()
    {
        return "Suspensión de alto desempeño " + decoramosA.ToString();
    }
    public double Costo()
    {
        return decoramosA.Costo() + 400;
    }

    public string Funciona()
    {
        return decoramosA.Funciona() + ", Suspensión elevada\n";
    }
}

