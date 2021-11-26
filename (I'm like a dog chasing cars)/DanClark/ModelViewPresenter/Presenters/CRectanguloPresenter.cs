using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelViewPresenter.Models;
using ModelViewPresenter.Views;
using ModelViewPresenter.Presenters;

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
