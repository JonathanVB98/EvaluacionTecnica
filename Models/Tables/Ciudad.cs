using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Tables
{
    [Table("Ciudad")]

    public partial class Ciudad
    {
        public Ciudad()
        {
            Sucursal = new HashSet<Sucursal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCiudad { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }

        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}