using System.Windows.Forms;

namespace IntegradorI
{
    class Auto
    {
        private string  Patente;
        private string  Marca;
        private string  Modelo;
        private string  Anio;
        private decimal Precio;
        public Auto(string patente, string marca, string modelo, string anio, decimal precio)
        {
            Patente = patente;
            Marca   = marca;
            Modelo  = modelo;
            Anio    = anio;
            Precio  = precio;
        }
        ~ Auto() { MessageBox.Show(this.Patente); }
        public string Duenio(Persona x) { return x.Apellido + ", " + x.Nombre; }
    }
}
