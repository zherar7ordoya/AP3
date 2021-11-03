using static System.Console;
using PhotoApplication;

namespace Delegados3
{
    class Program
    {
        static void Main(string[] args)
        {
            CFoto foto = new CFoto();
            foto.Nombre = "Paisaje.jpg";
            CProcesamiento procesamiento = new CProcesamiento();
            WriteLine("MÉTODOS DE LIBRERÍA");
            procesamiento.Procesar(foto, CFiltro.Contraste);
            procesamiento.Procesar(foto, CFiltro.Saturacion);
            WriteLine("\nMÉTODO FUERA DE LA LIBRERÍA");
            procesamiento.Procesar(foto, Coloracion);
            //******//
            ReadKey();
        }

        /* EXTENDIENDO LA APLICACIÓN
         * El cliente quiere agregar un filtro de color.
         */
        public static void Coloracion(CFoto foto) { WriteLine($"Coloración aplicada a {foto.Nombre}"); }
    }
}
