using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentacion
{
    public partial class FormRegistroUsuario : Form
    {
        public FormRegistroUsuario()
        {
            InitializeComponent();
        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "NOMBRE")
            {
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.Black;
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                txtNombreUsuario.Text = "NOMBRE";
                txtNombreUsuario.ForeColor = Color.Black;
            }



        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != "NOMBRE" && txtApellidoUsuario.Text != "APELLIDO" && txtTelefono.Text != "TELEFONO" && txtMailUsuario.Text != "CORREO ELECTRONICO" && txtClaveUsuario.Text != "CONTRASEÑA")
            {
                UserModel objUser = new UserModel();
                int varValidInsert = objUser.InsertUser(txtNombreUsuario.Text,txtApellidoUsuario.Text,txtTelefono.Text,txtMailUsuario.Text,txtClaveUsuario.Text);
                if (varValidInsert == 1)
                {
                    MessageBox.Show("Usuario registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login MenuLogin = new Login();
                    MenuLogin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro registrar el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos requeridos", "Mensaje", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            
        }

        private void txtApellidoUsuario_Enter(object sender, EventArgs e)
        {
            if (txtApellidoUsuario.Text == "APELLIDO")
            {
                txtApellidoUsuario.Text = "";
                txtApellidoUsuario.ForeColor = Color.Black;
            }
        }

        private void txtApellidoUsuario_Leave(object sender, EventArgs e)
        {
            if (txtApellidoUsuario.Text == "")
            {
                txtApellidoUsuario.Text = "APELLIDO";
                txtApellidoUsuario.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_DragLeave(object sender, EventArgs e)
        {
           
        }
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtMailUsuario_Enter(object sender, EventArgs e)
        {
            if (txtMailUsuario.Text == "CORREO ELECTRONICO")
            {
                txtMailUsuario.Text = "";
                txtMailUsuario.ForeColor = Color.Black;
            }
        }

        private void txtMailUsuario_Leave(object sender, EventArgs e)
        {
            if (txtMailUsuario.Text == "")
            {
                txtMailUsuario.Text = "CORREO ELECTRONICO";
                txtMailUsuario.ForeColor = Color.Black;
            }
        }

        private void txtClaveUsuario_Enter(object sender, EventArgs e)
        {
            if (txtClaveUsuario.Text == "CONTRASEÑA")
            {
                txtClaveUsuario.Text = "";
                txtClaveUsuario.ForeColor = Color.Black;
            }
        }

        private void txtClaveUsuario_Leave(object sender, EventArgs e)
        {
            if (txtClaveUsuario.Text == "")
            {
                txtClaveUsuario.Text = "CONTRASEÑA";
                txtClaveUsuario.ForeColor = Color.Black;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login MenuLogin = new Login();
            MenuLogin.Show();
            this.Close();
        }

        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
