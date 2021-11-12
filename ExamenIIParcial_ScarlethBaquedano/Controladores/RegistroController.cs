using ExamenIIParcial_ScarlethBaquedano.Modelos.DAO;
using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using ExamenIIParcial_ScarlethBaquedano.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIParcial_ScarlethBaquedano.Controladores
{
    public class RegistroController
    {
        RegistroView registro;
        LoginView vista = new LoginView();

        public RegistroController(RegistroView _registro)
        {
            registro = _registro;

            registro.btn_crearUsuario.Click += new EventHandler(CrearUsuario);
            registro.btn_cancelar.Click += new EventHandler(Cancelar);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            registro.Hide();
            vista.Show();
        }

        private void CrearUsuario(object sender, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Nombre = registro.txt_nombre.Text;
            user.Email = registro.txt_correo.Text + "@gmail.com";
            user.Contrasena = EncriptarClave(registro.txt_contrasena.Text);

            bool inserto = userDAO.CrearNuevoUsuario(user);

            if (inserto)
            {
                MessageBox.Show("Usuario agregado con éxito.");
            }
            else
            {
                MessageBox.Show("No se pudo registrar.");
            }
        }

        public static string EncriptarClave(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
