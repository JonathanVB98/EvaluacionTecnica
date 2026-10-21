using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Utils
{
    public class QueryParameter
    {
        const int maxPageSize = 20;

        public int pageNumber { get; set; } = 1;

        [JsonIgnore]
        private int _pageSize { get; set; } = 10;

        public string Sort { get; set; } = "";
        public string Fields { get; set; } = "";
        public bool AllowPaging { get; set; } = true;
        public bool FullResponse { get; set; }
        public virtual int pageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}