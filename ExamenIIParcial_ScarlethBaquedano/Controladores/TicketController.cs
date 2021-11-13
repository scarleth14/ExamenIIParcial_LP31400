using ExamenIIParcial_ScarlethBaquedano.Modelos.DAO;
using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using ExamenIIParcial_ScarlethBaquedano.Vistas;
using System;
using System.Windows.Forms;

namespace ExamenIIParcial_ScarlethBaquedano.Controladores
{
    public class TicketController
    {
        TicketView vista;
        DetalleTicketView vistaDetalle;
        TicketDAO ticketDAO = new TicketDAO();
        Ticket ticket = new Ticket();

        public TicketController(TicketView view)
        {
            vista = view;
            vista.btn_generarTicket.Click += new EventHandler(GenerarTicket);
            vista.btn_limpiar.Click += new EventHandler(Limpiar);
        }

        private void Limpiar(object sender, EventArgs e)
        {
            vista.txt_numeroTicket.Clear();
            vista.txt_nombreCliente.Clear();
            vista.txt_tipoSoporte.Clear();
            vista.txt_estadoTicket.Clear();
        }

        public TicketController(DetalleTicketView view)
        {
            vistaDetalle = view;
            vistaDetalle.Load += new EventHandler(Load); 
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTickets();
        }

        private void ListarTickets()
        {
            vistaDetalle.DetalleTicketDataGridView.DataSource = ticketDAO.GetTicket();
        }

        private void GenerarTicket(object sender, EventArgs e)
        {
            vista.txt_numeroTicket.Text = GenNumeroTicket();

            ticket.NumeroTicket = vista.txt_numeroTicket.Text;

            bool inserto = ticketDAO.InsertarTicket(ticket);
            vista.txt_nombreCliente.Text = ticketDAO.ConsultaNombre();
            vista.txt_tipoSoporte.Text = ticketDAO.ConsultaTipoSoporte();
            vista.txt_estadoTicket.Text = ticketDAO.ConsultaEstadoTicket();
            if (inserto)
            {
                MessageBox.Show("Agregado con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }

        public string GenNumeroTicket()
        {
            string numTicket;
            char l1, l2, l3;
            int num1, num2, num3, num4;

            Random aleatorio = new Random();
            num1 = aleatorio.Next(65, 91);
            num2 = aleatorio.Next(97, 123);
            num3 = aleatorio.Next(97, 123);
            num4 = aleatorio.Next(1, 100);

            l1 = Convert.ToChar(num1);
            l2 = Convert.ToChar(num2);
            l3 = Convert.ToChar(num3);

            numTicket = l1.ToString() + l2.ToString() + l3.ToString() + num4;

            return numTicket;

        }
    }
}
