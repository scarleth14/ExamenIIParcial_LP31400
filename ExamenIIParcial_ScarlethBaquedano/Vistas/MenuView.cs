using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIParcial_ScarlethBaquedano.Vistas
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        TipoSoporteView TipoSoporte;
        EstadoTicketView Estado;
        TicketView Ticket;
        DetalleTicketView Detalle;

        private void TiposToolStripButton_Click(object sender, EventArgs e)
        {
            if (TipoSoporte == null)
            {
                TipoSoporte = new TipoSoporteView();
                TipoSoporte.MdiParent = this;
                TipoSoporte.FormClosed += soporte_FormClosed;
                TipoSoporte.Show();
            }
            else
            {
                TipoSoporte.Activate();
            }
        }

        private void soporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            TipoSoporte = null;
        }

        private void EstadoTicketToolStripButton_Click(object sender, EventArgs e)
        {
            if (Estado == null)
            {
                Estado = new EstadoTicketView();
                Estado.MdiParent = this;
                Estado.FormClosed += estado_FormClosed;
                Estado.Show();
            }
            else
            {
                Estado.Activate();
            }
        }

        private void estado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Estado = null;
        }

        private void TicketToolStripButton_Click(object sender, EventArgs e)
        {
            if (Ticket == null)
            {
                Ticket = new TicketView();
                Ticket.MdiParent = this;
                Ticket.FormClosed += ticket_FormClosed;
                Ticket.Show();
            }
            else
            {
                Ticket.Activate();
            }
        }

        private void ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Ticket = null;
        }

        private void DetalleTicketToolStripButton_Click(object sender, EventArgs e)
        {
            if (Detalle == null)
            {
                Detalle = new DetalleTicketView();
                Detalle.MdiParent = this;
                Detalle.FormClosed += detalle_FormClosed;
                Detalle.Show();
            }
            else
            {
                Detalle.Activate();
            }
        }

        private void detalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detalle = null;
        }
    }
}
