using static System.Console;

namespace PhotoApplication
{
    public class CFoto
    {
        public string Nombre { get; set; }
    }
    public class CFiltro
    {
        public static void Saturacion(CFoto foto) { WriteLine($"Saturación aplicada a {foto.Nombre}"); }
        public static void Contraste(CFoto foto) { WriteLine($"Contraste aplicado a {foto.Nombre}"); }
    }
    public class CProcesamiento
    {
        public delegate void FotoHandler(CFoto foto);
        public void Procesar(CFoto foto, FotoHandler manejador)
        {
            manejador(foto);
        }
    }
}
