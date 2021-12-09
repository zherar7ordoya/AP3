using static System.Console;
using System.Text;

#region MAIN

var dibujo = new ObjetoGrafico { Name = "Gráfico 1" };
dibujo.Hijos.Add(new Cuadrado { Color = "Rojo" });
dibujo.Hijos.Add(new Circunferencia { Color = "Amarillo" });

var grupo = new ObjetoGrafico();
grupo.Hijos.Add(new Circunferencia { Color = "Azul" });
grupo.Hijos.Add(new Cuadrado { Color = "Azul" });

dibujo.Hijos.Add(grupo);

WriteLine(dibujo);

#endregion

public class ObjetoGrafico
{
    public virtual string Name { get; set; } = "Group";
    public string? Color;
    private readonly Lazy<List<ObjetoGrafico>> hijos = new();
    public List<ObjetoGrafico> Hijos => hijos.Value;

    private void Muestra(StringBuilder cmutable, int profundidad)
    {
        cmutable.Append(new string('-', profundidad * 4))
           .Append(string.IsNullOrWhiteSpace(Color) ?
           string.Empty :
           $"{Color} ").AppendLine($"{Name}");

        foreach (var hijo in Hijos) { hijo.Muestra(cmutable, profundidad + 1); }
    }
    public override string ToString()
    {
        var cmutable = new StringBuilder();
        Muestra(cmutable, 0);
        return cmutable.ToString();
    }
}

public class Circunferencia : ObjetoGrafico
{ public override string Name => "Circle"; }

public class Cuadrado : ObjetoGrafico
{ public override string Name => "Square"; }
