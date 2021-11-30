namespace ModelViewPresenter.Models
{
    public class CRectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public double CalculaArea()
        { return Largo * Ancho; }
    }
}
