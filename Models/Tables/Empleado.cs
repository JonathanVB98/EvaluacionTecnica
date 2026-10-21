using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Tables
{
    [Table("Empleado")]
    public partial class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public int IdSexo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Salario { get; set; }
        public int IdSucursal { get; set; }

        [ForeignKey("IdSexo")]
        public virtual Sexo Sexo { get; set; }

        [ForeignKey("IdSucursal")]
        public virtual Sucursal Sucursal { get; set; }

    }
}