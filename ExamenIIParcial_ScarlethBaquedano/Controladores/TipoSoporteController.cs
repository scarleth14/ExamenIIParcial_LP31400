using ExamenIIParcial_ScarlethBaquedano.Modelos.DAO;
using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using ExamenIIParcial_ScarlethBaquedano.Vistas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIParcial_ScarlethBaquedano.Controladores
{
    public class TipoSoporteController
    {
        TipoSoporteView vista;
        TipoSoporteDAO tipoSoporteDAO = new TipoSoporteDAO();
        TipoDeSoporte tipoDeSoporte = new TipoDeSoporte();

        public TipoSoporteController(TipoSoporteView view)
        {
            vista = view;

            vista.btn_guardar.Click += new EventHandler(Guardar);
            vista.rb_SoporteCelular.Click += new EventHandler(SoporteCelular);
            vista.rb_SoporteComputadora.Click += new EventHandler(SoporteComputadora);
            vista.btn_limpiar.Click += new EventHandler(Limpiar);
        }

        private void Limpiar(object sender, EventArgs e)
        {
            vista.dtp_fecha.Value = DateTime.Now;
            vista.txt_nombre.Clear();
            vista.IdentidadMaskedTextBox.Clear();
            vista.rb_SoporteCelular.Checked = false;
            vista.rb_SoporteComputadora.Checked = false;
            vista.rb_MantenimientoCelular.Checked = false;
            vista.rb_ReparacionCelular.Checked = false;
            vista.rb_desbloqueoCelular.Checked = false;
            vista.rb_MantenimientoPC.Checked = false;
            vista.rb_ReparacionPC.Checked = false;
            vista.rb_LimpiezaPC.Checked = false;
        }

        private void SoporteComputadora(object sender, EventArgs e)
        {
            if (vista.rb_SoporteComputadora.Checked == true)
            {
                vista.ComputadoraPanel.Enabled = true;
                vista.CelularPanel.Enabled = false;
            }
        }

        private void SoporteCelular(object sender, EventArgs e)
        {
            if (vista.rb_SoporteCelular.Checked == true)
            {
                vista.CelularPanel.Enabled = true;
                vista.ComputadoraPanel.Enabled = false;
            }
        }

        private void Guardar(object sender, EventArgs e)
        {
            string tipoServicio = string.Empty;
            string tipoSoporte = string.Empty;
            bool inserto = false;

            if (vista.IdentidadMaskedTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.IdentidadMaskedTextBox, "Ingrese una identidad");
                vista.IdentidadMaskedTextBox.Focus();
                return;
            }
            if (vista.txt_nombre.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_nombre, "Ingrese un nombre");
                vista.txt_nombre.Focus();
                return;
            }

            try
            {
                //-----------------Envía los parámetros a la base de datos del servicio para celular-------------------------
                if (vista.rb_SoporteCelular.Checked == true)
                {
                    tipoSoporte = "Celular ";

                    if (vista.rb_MantenimientoCelular.Checked == true)
                    {
                        tipoServicio = "Mantenimiento de celular";
                        tipoDeSoporte.SoporteCelular = tipoServicio;
                        tipoDeSoporte.SoporteComputadora = string.Empty;
                        vista.pbx_ServicioCelular.Image = Properties.Resources.mantenimiento_web;

                    }
                    if(vista.rb_ReparacionCelular.Checked == true){
                        tipoServicio = "Reparación de celular";
                        tipoDeSoporte.SoporteCelular = tipoServicio;
                        tipoDeSoporte.SoporteComputadora = string.Empty;
                        vista.pbx_ServicioCelular.Image = Properties.Resources.administracion;
                    }

                    if (vista.rb_desbloqueoCelular.Checked == true)
                    {
                        tipoServicio = "Desbloqueo de celular";
                        tipoDeSoporte.SoporteCelular = tipoServicio;
                        tipoDeSoporte.SoporteComputadora = string.Empty;
                        vista.pbx_ServicioCelular.Image = Properties.Resources.desbloquear;
                    }
                }

                //-----------------Envía los parámetros a la base de datos del servicio para computadora-------------------------
                if (vista.rb_SoporteComputadora.Checked == true)
                {
                    tipoSoporte = "Equipo de cómputo";
                    tipoDeSoporte.TipoSoporte = tipoSoporte;

                    if (vista.rb_MantenimientoPC.Checked == true)
                    {
                        tipoServicio = "Mantenimiento de computadora";
                        tipoDeSoporte.SoporteCelular = string.Empty;
                        tipoDeSoporte.SoporteComputadora = tipoServicio;

                        vista.pbx_ServicioCelular.Image = Properties.Resources.mantenimiento_web;

                    }
                    else if (vista.rb_ReparacionPC.Checked == true)
                    {
                        tipoServicio = "Reparación de computadora";
                        tipoDeSoporte.SoporteCelular = string.Empty;
                        tipoDeSoporte.SoporteComputadora = tipoServicio;
                        vista.pbx_ServicioCelular.Image = Properties.Resources.administracion;
                    }
                    else if (vista.rb_LimpiezaPC.Checked == true)
                    {
                        tipoServicio = "Limpieza de computadora";
                        tipoDeSoporte.SoporteCelular = string.Empty;
                        tipoDeSoporte.SoporteComputadora = tipoServicio;
                        vista.pbx_ServicioCelular.Image = Properties.Resources.escritorio_de_oficina;
                    }
                }
                tipoDeSoporte.IdentidadCliente = vista.IdentidadMaskedTextBox.Text;
                tipoDeSoporte.NombreCliente = vista.txt_nombre.Text;
                tipoDeSoporte.Fecha = vista.dtp_fecha.Value;
                tipoDeSoporte.TipoSoporte = tipoSoporte;

                inserto = tipoSoporteDAO.InsertarTipoSoporte(tipoDeSoporte);
                
                if (inserto == true)
                {
                    MessageBox.Show("Guardado con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
