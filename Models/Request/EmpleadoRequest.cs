using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Request
{
    public class EmpleadoRequest
    {
        public int? IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? IdSucursal { get; set; }
    }
}