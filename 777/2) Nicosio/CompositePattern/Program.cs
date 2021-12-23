using System.Text;
using static System.Console;



//*----------------------------------> * <----------------------------------*\\



#region THE CLIENT

class PatronComposición
{
    static void Main()
    {
        IComponente<string> album = new Contenedor<string>("Album");
        IComponente<string> point = album;
        string[] s;
        string command, parameter;

        // Create and manipulate a structure
        StreamReader instream = new StreamReader("Composite.dat");
        do
        {
            string? t = instream.ReadLine();

            if (t == null) { break; }

            WriteLine("\t\n" + t);
            s = t.Split(' ');
            command = s[0];
            if (s.Length > 1) parameter = s[1]; else parameter = null;
            switch (command)
            {
                case "AddSet":
                    IComponente<string> c = new Contenedor<string>(parameter);
                    point.Agrega(c);
                    point = c;
                    break;
                case "AddPhoto":
                    point.Agrega(new Componente<string>(parameter));
                    break;
                case "Remove":
                    point = point.Borra(parameter);
                    break;
                case "Find":
                    point = album.Encuentra(parameter);
                    break;
                case "Display":
                    WriteLine(album.Muestra(0));
                    break;
                case "Quit":
                    break;
            }
        } while (!command.Equals("Quit"));
    }
}

#endregion



#region THE INTERFACE

public interface IComponente<T>
{
    // Métodos
    void Agrega(IComponente<T> componente);
    IComponente<T> Borra(T cadena);
    string Muestra(int cantidad);
    IComponente<T>? Encuentra(T cadena);

    // Propiedades
    T Nombre { get; set; }
}

#endregion



#region THE COMPONENT

public class Componente<T> : IComponente<T>
{
    public T Nombre { get; set; }

    public Componente(T nombre)
    {
        this.Nombre = nombre;
    }

    // Solo válido para el Contenedor
    public void Agrega(IComponente<T> componente)
    {
        WriteLine("Cannot add to an item");
    }

    // Solo válido para el Contenedor
    public IComponente<T> Borra(T cadena)
    {
        WriteLine("Cannot remove directly");
        return this;
    }

    public string Muestra(int cantidad)
    {
        return new string('-', cantidad) + Nombre + "\n";
    }

    public IComponente<T>? Encuentra(T cadena)
    {
        if (cadena == null) { return null; }
        if (cadena.Equals(Nombre)) { return this; }
        else { return null; }
    }
}

#endregion



#region THE COMPOSITE

public class Contenedor<T> : IComponente<T>
{
    readonly List<IComponente<T>> listado;
    public T Nombre { get; set; }

    public Contenedor(T nombre)
    {
        Nombre = nombre;
        listado = new List<IComponente<T>>();
    }

    public void Agrega(IComponente<T> c)
    {
        listado.Add(c);
    }

    IComponente<T> holder = null;

    // Finds the item from a particular point in the structure
    // and returns the composite from which it was removed
    // If not found, return the point as given
    public IComponente<T> Borra(T s)
    {
        holder = this;
        IComponente<T> p = holder.Encuentra(s);
        if (holder != null)
        {
            (holder as Contenedor<T>).listado.Remove(p);
            return holder;
        }
        else { return this; }
    }

    // Recursively looks for an item
    // Returns its reference or else null
    public IComponente<T> Encuentra(T s)
    {
        holder = this;

        if (Nombre.Equals(s)) { return this; }

        IComponente<T> found = null;

        foreach (IComponente<T> c in listado)
        {
            found = c.Encuentra(s);
            if (found != null) { break; }
        }

        return found;
    }

    // Displays items in a format indicating their level in the composite structure
    public string Muestra(int depth)
    {
        StringBuilder s = new StringBuilder(new String('-', depth));
        s.Append("Set " + Nombre + " length :" + listado.Count + "\n");
        foreach (IComponente<T> component in listado)
        {
            s.Append(component.Muestra(depth + 2));
        }
        return s.ToString();
    }
}

#endregion