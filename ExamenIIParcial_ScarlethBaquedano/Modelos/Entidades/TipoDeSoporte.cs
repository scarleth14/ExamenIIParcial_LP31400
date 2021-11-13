using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades
{
    public class TipoDeSoporte
    {
        public int Id { get; set; }

        public string NombreCliente { get; set; }

        public string IdentidadCliente { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoSoporte { get; set; }

        public string SoporteCelular { get; set; }

        public string SoporteComputadora { get; set; }

    }
}
