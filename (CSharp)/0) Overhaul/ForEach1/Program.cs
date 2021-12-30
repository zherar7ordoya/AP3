using System.Collections;
using static System.Console;



class Host
{
    [STAThread]
    static void Main(string[] args)
    {
        if (args is null)
        { throw new ArgumentNullException(nameof(args)); }

        Automóviles Coches = new();

        WriteLine("\nInternal Collection\n(Unsorted - IEnumerable, Enumerator)\n");

        foreach (Coche c in Coches) { WriteLine("\t" + c.Año + "\t" + c.Marca); }

        ReadLine();
    }
}



public class Coche
{
    private int año;
    private string marca;

    public Coche(int año, string marca)
    {
        this.año = año;
        this.marca = marca ?? throw new ArgumentNullException(nameof(marca));
    }

    public int Año
    {
        get { return año; }
        set { año = value; }
    }
    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }
}



public class Automóviles : IEnumerable
{
    private readonly Coche[] listado;

    //Create internal array in constructor.
    public Automóviles()
    {
        listado = new Coche[6]
        {
                new Coche(1988, "Fiat" ),
                new Coche(1932, "Buick"),
                new Coche(1932, "Ford" ),
                new Coche(1992, "Ford" ),
                new Coche(1999, "Dodge"),
                new Coche(1977, "Honda")
        };
    }
    //private enumerator class
    private class Enumerador : IEnumerator
    {
        public Coche[] listado;
        int posición = -1;

        //constructor
        public Enumerador(Coche[] lista)
        {
            listado = lista;
        }
        private IEnumerator getEnumerator()
        {
            return (IEnumerator)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            posición++;
            return (posición < listado.Length);
        }
        //IEnumerator
        public void Reset()
        {
            posición = -1;
        }
        //IEnumerator
        public object Current
        {
            get
            {
                try
                {
                    return listado[posición];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }  //end nested class
    public IEnumerator GetEnumerator()
    {
        return new Enumerador(listado);
    }
}
