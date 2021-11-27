using ModelViewPresenter.Models;
using ModelViewPresenter.Views;

namespace ModelViewPresenter.Presenters
{
    public class CRectanguloPresenter
    {
        IRectangulo rectanguloView;
        public CRectanguloPresenter(IRectangulo vista)
        { rectanguloView = vista; }

        public void CalculaArea()
        {
            CRectangulo rectangulo = new CRectangulo();
            rectangulo.Largo = double.Parse(rectanguloView.TextoLargo);
            rectangulo.Ancho = double.Parse(rectanguloView.TextoAncho);
            rectanguloView.TextoArea = rectangulo.CalculaArea().ToString();
        }
    }
}
