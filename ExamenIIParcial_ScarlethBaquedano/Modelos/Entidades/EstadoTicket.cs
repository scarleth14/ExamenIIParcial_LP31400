using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades
{
    public class EstadoTicket
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Estado { get; set; }

    }
}
