using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp14
{
    public interface ITocable
    {
        string Tocar();

        string Nombre { get; set; }
    }
}