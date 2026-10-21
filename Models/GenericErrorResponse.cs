using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models
{
    public class GenericErrorResponse
    {
        public int ErrorType { get; set; }
        public string ErrorName { get; set; }
        public string ErrorMessage { get; set; }
    }
}