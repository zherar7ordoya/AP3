using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class ArqueologoDifunto : Arqueologo
    {
        private DateTime desceso;

        public DateTime Desceso
        {
            get { return desceso; }
            set { desceso = value; }
        }

    }
}