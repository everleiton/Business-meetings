using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebIIProyectoIEverLeiton.Models
{
    [Table("Clientes")]
    public class Cliente : System.Data.Entity.DbContext
    {
        [Key]
        public int IdCliente { get; set; }
        public int CedulaJuridica { get; set; }
        public string Nombre { get; set; }
        public string Pagina { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Sector { get; set; }
    }
}