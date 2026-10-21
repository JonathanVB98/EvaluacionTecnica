using EvaluacionTecnica.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Filters
{
    public class EmpleadoFilter : BaseFilter
    {
        public EmpleadoFilters EntityFilter { get; set; }
    }
    public class EmpleadoFilters : IFilter
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int? IdSucursal { get; set; }
    }
}