using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG6.Entidades
{
    public class ProgramacionSemanal
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int nroSemana { get; set; }
        public ProgramacionSemanal(DateTime fechaInicio, DateTime fechaFin, int nroSemana)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.nroSemana = nroSemana;
        }
    }
}
