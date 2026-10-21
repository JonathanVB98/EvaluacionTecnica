using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models
{
    public class GenericResponse
    {
        public bool Error { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public dynamic Data { get; set; } = null;
    }
}