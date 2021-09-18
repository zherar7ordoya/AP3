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
        public string DNI      { get; set; }
        public string Nombre   { get; set; }
        public string Apellido { get; set; }
        public Persona()
        {
            _listaAuto = new List<Auto>();
        }
        public Persona(
            string pDNI,
            string pNombre,
            string pApellido) : this()
        {
            DNI      = pDNI;
            Nombre   = pNombre;
            Apellido = pApellido;
        }
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
            try
            {
                foreach (Auto _a in _listaAuto)
                {
                    _aux_listaAuto.Add(new Auto(
                        _a.Patente,
                        _a.Marca,
                        _a.Modelo,
                        _a.Axo,
                        _a.Precio
                        ));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _aux_listaAuto;
        }


        // TODO return bool
        public void BorrarAuto(Auto pAuto)
        {
            try
            {
                Auto _auxAuto = _listaAuto.Find(x => x.Patente == pAuto.Patente);
                if (_auxAuto != null)
                {
                    _listaAuto.Remove(_auxAuto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        ~Persona()
        {
            _listaAuto = null;
        }
    }
}

