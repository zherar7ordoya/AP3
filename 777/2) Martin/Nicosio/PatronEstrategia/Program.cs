using static System.Console;

string dato = string.Empty, opcion = string.Empty;
double x = 0, y = 0, r = 0;

while (true)
{
    WriteLine("1) Suma || 2) Resta || 3) Multplicación || 4) División || 5) Salir");
    opcion = ReadLine();
    if (opcion.Equals("5")) { break; }

    WriteLine("Valor de A:");
    dato = ReadLine();
    x = Convert.ToDouble(dato);

    WriteLine("Valor de B:");
    dato = ReadLine();
    y = Convert.ToDouble(dato);

    IOperacion operacion = opcion switch
    {
        "1" => operacion = new CSuma(),
        "2" => operacion = new CResta(),
        "3" => operacion = new CMultiplicacion(),
        "4" => operacion = new CDivision(),
        _ => throw new global::System.NotImplementedException()
    };
    r = operacion.Operacion(x, y);
    WriteLine($"Resultado: {r}");
}


#region CLASES E INTERFACES
internal interface IOperacion
{
    double Operacion(double a, double b);
}

class CSuma : IOperacion
{
    public double Operacion(double a, double b)
    {
        return a + b;
    }
}

class CResta : IOperacion
{
    public double Operacion(double a, double b)
    {
        return a - b;
    }
}

class CMultiplicacion : IOperacion
{
    public double Operacion(double a, double b)
    {
        return a * b;
    }
}

class CDivision : IOperacion
{
    public double Operacion(double a, double b)
    {
        return a / b;
    }
}
#endregion