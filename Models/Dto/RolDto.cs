using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Dto
{
    public class RolDto
    {
        public int RolId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
    }
}