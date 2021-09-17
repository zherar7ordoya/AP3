using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    class Persona 
    {
        List<Auto> _listaAuto;
        public Persona()
        {
            _listaAuto = new List<Auto>();
        }
        // TODO Agrgar propiedades de persona
        public void AgregarAuto(Auto pAuto)
        {
            _listaAuto.Add(new Auto(pAuto.Patente,
                                    pAuto.Marca,
                                    pAuto.Modelo,
                                    pAuto.Axo,
                                    pAuto.Precio,
                                    pAuto.Dueno()
                                    ));
        }
        public List<Auto> RetornaListaAutos()
        {
            List<Auto> _aux_listaAuto = new List<Auto>();
            foreach(Auto _a in _listaAuto)
            {
                _aux_listaAuto.Add(new Auto(
                    _a.Patente,
                    _a.Marca,
                    _a.Modelo,
                    _a.Axo,
                    _a.Precio
                    ));
            }
            return _aux_listaAuto;
        }


        // TODO borrar Auto de la lista


        ~Persona()
        {
            _listaAuto = null;
        }
    }
}

