using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDwebCSD.web.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [DisplayName("Nombre Completo")]
        [Column("NombreCliente", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public int Cargo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Telefono { get; set; }
    }
}
