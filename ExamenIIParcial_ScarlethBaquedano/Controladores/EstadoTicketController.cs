using ExamenIIParcial_ScarlethBaquedano.Modelos.DAO;
using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using ExamenIIParcial_ScarlethBaquedano.Vistas;
using System;
using System.Windows.Forms;

namespace ExamenIIParcial_ScarlethBaquedano.Controladores
{
    public class EstadoTicketController
    {
        EstadoTicketView vista;
        EstadoTicketDAO estadoTicketDAO = new EstadoTicketDAO();
        EstadoTicket estadoTicket = new EstadoTicket();

        public EstadoTicketController(EstadoTicketView view)
        {
            vista = view;
            vista.btn_aceptar.Click += new EventHandler(Aceptar);
            vista.btn_limpiar.Click += new EventHandler(Limpiar);

        }

        private void Limpiar(object sender, EventArgs e)
        {
            vista.txt_nombreCliente.Clear();
            vista.dtp_fechaSolicitud.Value = DateTime.Now;
            vista.cb_estadoTicket.Text = " ";
        }

        private void Aceptar(object sender, EventArgs e)
        {
            if (vista.txt_nombreCliente.Text == " ")
            {
                vista.errorProvider1.SetError(vista.txt_nombreCliente, "Ingrese el nombre del cliente");
                vista.txt_nombreCliente.Focus();
                return;
            }
            else
            {
                vista.errorProvider1.SetError(vista.txt_nombreCliente, null);
            }
            if (vista.cb_estadoTicket.Text == " ")
            {
                vista.errorProvider1.SetError(vista.cb_estadoTicket, "Seleccione el estado del ticket");
                vista.cb_estadoTicket.Focus();
                return;
            }
            else
            {
                vista.errorProvider1.SetError(vista.cb_estadoTicket, null);
            }
            bool inserto = false;

            estadoTicket.NombreCliente = vista.txt_nombreCliente.Text;
            estadoTicket.FechaSolicitud = vista.dtp_fechaSolicitud.Value;
            estadoTicket.Estado = vista.cb_estadoTicket.Text;

            inserto = estadoTicketDAO.InsertarEstadoTicket(estadoTicket);
            if (inserto)
            {
                MessageBox.Show("Agregado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }
    }
}
    
