using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Tables
{
    [Table("Sucursal")]

    public partial class Sucursal
    {
        public Sucursal()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public int IdCiudad { get; set; }
        public bool EsActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        [ForeignKey("IdCiudad")]
        public virtual Ciudad Ciudad { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}