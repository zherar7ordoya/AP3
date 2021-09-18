using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    class Concesionario
    {
        List<Auto> _la;
        List<Persona> _lp;

        public Concesionario()
        {
            _la = new List<Auto>();
            _lp = new List<Persona>();
        }

        public List<Persona> RetornarListaPersonas()
        {
            List<Persona> _aux_lp = new List<Persona>();
            try
            {
                foreach (Persona _p in _lp)
                {
                    _aux_lp.Add(new Persona(
                        _p.DNI,
                        _p.Nombre,
                        _p.Apellido
                        ));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return _aux_lp;
        }

        public void AgregarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    _lp.Add(new Persona(
                        pPersona.DNI,
                        pPersona.Nombre,
                        pPersona.Apellido));
                }
                else
                {
                    throw new Exception("Es NULL");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void BorrarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    Persona _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                    if (_auxPersona != null)
                    {
                        _lp.Remove(_auxPersona);
                    }
                    else
                    {
                        throw new Exception("Es NULL");
                    }
                }
                else
                {
                    throw new Exception("Es NULL");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    Persona _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                    if (_auxPersona != null)
                    {
                        _auxPersona.DNI = pPersona.DNI;
                        _auxPersona.Nombre = pPersona.Nombre;
                        _auxPersona.Apellido = pPersona.Apellido;
                    }
                    else
                    {
                        throw new Exception("Es NULL");
                    }
                }
                else
                {
                    throw new Exception("Es NULL");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
