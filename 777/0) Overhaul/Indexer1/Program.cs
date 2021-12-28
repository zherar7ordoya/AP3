using static System.Console;

Concesionaria concesionaria = new();

Automovil automovil_1 = concesionaria[1];
WriteLine("INFO EN CONCESIONARIA[1]");
automovil_1.Info();
WriteLine("FIN INFO\n");

Automovil automovil_2 = new Automovil("Borg", 23500);
concesionaria[1] = automovil_2;

for (int indice = 0; indice < 4; indice++)
{
    concesionaria[indice].Info();
}




class Automovil
{
    string modelo;
    decimal costo;

    // Constructor
    public Automovil(string modelo, decimal costo)
    {
        this.modelo = modelo;
        this.costo = costo;
    }

    public void Info()
    {
        WriteLine($"Modelo:\t{modelo}");
        WriteLine($"Costo: \t{costo}");
        WriteLine("-------------");
    }
}




class Concesionaria
{
    private Automovil[] disponibles;

    public Concesionaria()
    {
        disponibles = new Automovil[4];
        disponibles[0] = new("Soul", 22500);
        disponibles[1] = new("Fiat", 17500);
        disponibles[2] = new("Ford", 26500);
        disponibles[3] = new("Spak", 14500);
    }

    // INDEXER
    public Automovil this[int indice]
    {
        get { return disponibles[indice]; }
        set { disponibles[indice] = value; }
    }

}