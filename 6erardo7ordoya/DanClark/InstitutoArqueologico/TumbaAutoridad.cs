using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class TumbaAutoridad : Tumba
    {
        private Autoridad autoridad =new Autoridad();
        public Autoridad Autoridad
        {
            get { return autoridad; }
          
        }
    }
}