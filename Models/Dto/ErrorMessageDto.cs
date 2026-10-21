using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Dto
{
    public class ErrorMessageDto
    {
        public int IdErrorMessageCatalog { get; set; }
        public string Description { get; set; }
        public string ErrorName { get; set; }
    }
}