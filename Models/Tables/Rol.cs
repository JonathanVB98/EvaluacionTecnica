using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Models.Tables
{
    [Table("Rol")]
    public partial class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RolId { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateDate { get; set; }
    }
}