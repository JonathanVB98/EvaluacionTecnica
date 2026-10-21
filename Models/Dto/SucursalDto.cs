using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Dto
{
    public class SucursalDto
    {
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdCiudad { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}