using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;


namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        #region ARRASTRAR

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion

        #region BOTONES
        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "E-MAIL")
            {
                tbxUsuario.Text = "";
                tbxUsuario.ForeColor = Color.LightGray;
            }
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "")
            {
                tbxUsuario.Text = "E-MAIL";
                tbxUsuario.ForeColor = Color.DimGray;
            }
        }



        private void tbxClave_Enter(object sender, EventArgs e)
        {
            if (tbxClave.Text == "CONTRASEÑA")
            {
                tbxClave.Text = "";
                tbxClave.ForeColor = Color.LightGray;
                tbxClave.UseSystemPasswordChar = true;
            }
        }

        private void tbxClave_Leave(object sender, EventArgs e)
        {
            if (tbxClave.Text == "")
            {
                tbxClave.Text = "CONTRASEÑA";
                tbxClave.ForeColor = Color.DimGray;
                tbxClave.UseSystemPasswordChar = false;
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text != "E-MAIL")
            {
                if (tbxClave.Text != "CONTRASEÑA")
                {
                    UserModel objUser = new UserModel();
                    var validLogin = objUser.LoginUser(tbxUsuario.Text, tbxClave.Text);
                    if (validLogin == true)
                    {                        
                        FormMenuPrincipal mainMenu = new FormMenuPrincipal();
                        FormPublicar publicarveh = new FormPublicar(tbxUsuario.Text);
                        FormMiCuenta MiCuenta = new FormMiCuenta(tbxUsuario.Text);
                        FormMisPublicaciones misPublicaciones = new FormMisPublicaciones(tbxUsuario.Text);
                        mainMenu.Show();                        
                        this.Hide();                        
                    }
                    else
                    {
                        msgError("E-mail o contraseña incorrecta. \n Intenta de nuevo");
                        tbxClave.Clear();
                        tbxUsuario.Focus();
                    }
                }
                else
                {
                    msgError("Por favor ingresar contraseña");
                }
            }
            else
            {
                msgError("Por favor ingresar el E-Mail");
            }
        }

        private void msgError(string parMessage)
        {
            lblErrorMessage.Text = "      " + parMessage;
            lblErrorMessage.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistroUsuario MenuRegistro = new FormRegistroUsuario();
            MenuRegistro.Show();
            this.Hide();
        }

        private void linkInvitado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

     
    }
}
