using System.Windows.Forms;

namespace PARCIAL_1
{
    class CAdelanto : IAdelanto
    {
        private string codigoAlfanumerico;
        private string fechaOtorgamiento;
        private string fechaDevolución;
        private string importeAdelanto;
        private bool bloqueado;

        public string CodigoAlfanumerico { get => codigoAlfanumerico; set => codigoAlfanumerico = value; }
        public string FechaOtorgamiento { get => fechaOtorgamiento; set => fechaOtorgamiento = value; }
        public string FechaDevolución { get => fechaDevolución; set => fechaDevolución = value; }
        public string ImporteAdelanto { get => importeAdelanto; set => importeAdelanto = value; }
        public bool Bloqueado { get => bloqueado; set => bloqueado = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo">Alfanumérico para el adelanto de formato 4 decimales seguido de 4 caracteres.</param>
        /// <param name="otorgamiento">Fecha en que se otorga el adelanto de formato DD/MM/AAAA.</param>
        /// <param name="adelanto">Importe en pesos del adelanto.</param>
        public CAdelanto
            (
            string codigo,
            string otorgamiento,
            string adelanto
            )
        {
            this.codigoAlfanumerico = codigo;
            this.fechaOtorgamiento = otorgamiento;
            this.importeAdelanto = adelanto;
        }

        public void Alta(CAdelanto adelanto, CManejador adelantos)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(CAdelanto adelanto, CManejador adelantos)
        {
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public void Modificacion(CAdelanto adelanto, CManejador adelantos)
        {
            throw new System.NotImplementedException();
        }
    }
}
