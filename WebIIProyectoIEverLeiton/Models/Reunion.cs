using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebIIProyectoIEverLeiton.Models
{
    [Table("Reuniones")]
    public class Reunion : System.Data.Entity.DbContext
    {
        [Key]
        public int IdReunion { get; set; }
        public string Titulo { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public Usuario UsuarioEncargado { get; set; }
        public bool Virtual { get; set; }
        public Cliente FkIdCliente { get; set; }
    }
}