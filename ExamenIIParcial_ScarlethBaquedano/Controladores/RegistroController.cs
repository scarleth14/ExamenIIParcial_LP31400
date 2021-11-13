using ExamenIIParcial_ScarlethBaquedano.Modelos.DAO;
using ExamenIIParcial_ScarlethBaquedano.Modelos.Entidades;
using ExamenIIParcial_ScarlethBaquedano.Vistas;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
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
            registro.txt_nombre.Enter += new EventHandler(txt_nombre_Enter);
            registro.txt_nombre.Leave += new EventHandler(txt_nombre_Leave);
            registro.txt_correo.Enter += new EventHandler(txt_correo_Enter);
            registro.txt_correo.Leave += new EventHandler(txt_correo_Leave);
            registro.txt_contrasena.Enter += new EventHandler(txt_contrasena_Enter);
            registro.txt_contrasena.Leave += new EventHandler(txt_contrasena_Leave);
        }

        private void txt_nombre_Enter(object sender, EventArgs e)
        {
            if (registro.txt_nombre.Text == "NOMBRE")
            {
                registro.txt_nombre.Text = "";
                registro.txt_nombre.ForeColor = Color.LightGray;
            }

        }

        private void txt_nombre_Leave(object sender, EventArgs e)
        {
            if (registro.txt_nombre.Text == "")
            {
                registro.txt_nombre.Text = "NOMBRE";
                registro.txt_nombre.ForeColor = Color.DimGray;
            }
        }

        private void txt_correo_Enter(object sender, EventArgs e)
        {
            if (registro.txt_correo.Text == "CORREO")
            {
                registro.txt_correo.Text = "";
                registro.txt_correo.ForeColor = Color.LightGray;
            }
        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {
            if (registro.txt_correo.Text == "")
            {
                registro.txt_correo.Text = "CORREO";
                registro.txt_correo.ForeColor = Color.DimGray;
            }
        }

        private void txt_contrasena_Enter(object sender, EventArgs e)
        {
            if (registro.txt_contrasena.Text == "CONTRASEÑA")
            {
                registro.txt_contrasena.Text = "";
                registro.txt_contrasena.ForeColor = Color.LightGray;
                registro.txt_contrasena.UseSystemPasswordChar = true;
            }
        }

        private void txt_contrasena_Leave(object sender, EventArgs e)
        {
            if (registro.txt_contrasena.Text == "")
            {
                registro.txt_contrasena.Text = "CONTRASEÑA";
                registro.txt_contrasena.ForeColor = Color.DimGray;
                registro.txt_contrasena.UseSystemPasswordChar = false;
            }
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
