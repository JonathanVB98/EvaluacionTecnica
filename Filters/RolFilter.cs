using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Filters
{
    public class RolFilter : BaseFilter
    {
        public RolFilters EntityFilter { get; set; }
    }

    public class RolFilters : IFilter
    {
        public string Name { get; set; }
        public byte IsActive { get; set; }
    }
}