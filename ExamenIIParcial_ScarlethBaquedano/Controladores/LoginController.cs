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
    public class LoginController
    {
        LoginView vista;
        

        public LoginController(LoginView view)
        {
            vista = view;

            vista.btn_aceptar.Click += new EventHandler(ValidarUsuario);
            vista.btn_registrarse.Click += new EventHandler(Registro);
            
        }

        private void Registro(object sender, EventArgs e)
        {
            RegistroView registro = new RegistroView();
            vista.Hide();
            registro.Show();
        }

        private void ValidarUsuario(object sender, EventArgs e)
        {
            bool esValido = false;

            UsuarioDAO userDAO = new UsuarioDAO();

            Usuario user = new Usuario();

            user.Email = vista.txt_email.Text;
            user.Contrasena= vista.txt_contrasena.Text;

            esValido = userDAO.ValidarUsuario(user);

            if (esValido)
            {
                //MessageBox.Show("Usuario correcto");
                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
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
