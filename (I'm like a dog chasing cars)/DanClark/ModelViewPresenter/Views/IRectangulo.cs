using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenter.Views
{
    public interface IRectangulo
    {
        string TextoLargo { get; set; }
        string TextoAncho { get; set; }
       string TextoArea { get; set; }
    }
}
