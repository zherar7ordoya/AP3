using System;
using System.Windows.Forms;

namespace PARCIAL_1
{
    class CAdelanto
    {
        private string   codigoAlfanumerico;
        private DateTime fechaOtorgamiento;
        private DateTime fechaCancelacion;
        private decimal  importeOtorgado;
        private decimal  importePagado;
        private decimal  beneficio;
        private decimal  saldoAdeudado;
        private bool     bloqueado;

        public string   CodigoAlfanumerico { get => codigoAlfanumerico; set => codigoAlfanumerico = value; }
        public DateTime FechaOtorgamiento  { get => fechaOtorgamiento;  set => fechaOtorgamiento  = value; }
        public DateTime FechaCancelacion   { get => fechaCancelacion;   set => fechaCancelacion   = value; }
        public decimal  ImporteOtorgado    { get => importeOtorgado;    set => importeOtorgado    = value; }
        public decimal  ImportePagado      { get => importePagado;      set => importePagado      = value; }
        public decimal  Beneficio          { get => beneficio;          set => beneficio          = value; }
        public decimal  SaldoAdeudado      { get => saldoAdeudado;      set => saldoAdeudado      = value; }
        public bool     Bloqueado          { get => bloqueado;          set => bloqueado          = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo">Alfanumérico para el adelanto de formato 4 decimales seguido de 4 caracteres.</param>
        /// <param name="fecha">Fecha en que se otorga el adelanto de formato DD/MM/AAAA.</param>
        /// <param name="importe">Importe en pesos del adelanto.</param>
        public CAdelanto
            (
            string   codigo,
            DateTime fecha,
            decimal  importe
            )
        {
            this.codigoAlfanumerico = codigo;
            this.fechaOtorgamiento  = fecha;
            this.importeOtorgado    = importe;
        }
    }
}
