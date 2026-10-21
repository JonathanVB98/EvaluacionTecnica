using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Tables
{
    [Table("Sexo")]
    public partial class Sexo
    {
        public Sexo()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSexo { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}