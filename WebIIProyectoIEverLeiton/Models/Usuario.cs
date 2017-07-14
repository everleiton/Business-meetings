using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebIIProyectoIEverLeiton.Models
{
    [Table("Usuarios")]
    public class Usuario 
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Cliente_al_que_pertenece { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Puesto { get; set; }
        public int Rol { get; set; }
        public string Contrasena { get; set; }
    }
}