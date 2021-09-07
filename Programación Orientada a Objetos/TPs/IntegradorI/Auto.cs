using System.Windows.Forms;

namespace IntegradorI
{
    class Auto
    {
        private string  Patente;
        private string  _marca;
        private string  _modelo;
        private string  Anio;
        private decimal Precio;
        public string Marca
        {
            get { return _marca; }
        }
        public string Modelo
        {
            get { return _modelo; }
        }
        public Auto(string patente, string marca, string modelo, string anio, decimal precio)
        {
            Patente = patente;
            _marca  = marca;
            _modelo = modelo;
            Anio    = anio;
            Precio  = precio;
        }
        ~ Auto() { MessageBox.Show(this.Patente); }
        public string Duenio(Persona x) { return x.Apellido + ", " + x.Nombre; }
    }
}
