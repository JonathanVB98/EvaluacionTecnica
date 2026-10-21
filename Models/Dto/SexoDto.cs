using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Dto
{
    public class SexoDto
    {
        public int IdSexo { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }
    }
}