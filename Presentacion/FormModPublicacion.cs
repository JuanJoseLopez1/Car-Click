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
    public partial class FormPublicar : Form
    {
        public static string CorreoUsuario = string.Empty;
        public FormPublicar()
        {
            InitializeComponent();
        }
        public FormPublicar(string parCorreoUsuario)
        {
            CorreoUsuario = parCorreoUsuario;
            InitializeComponent();            
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (cmbUbicacion.Text != "" && cmbTipoVeh.Text != "" && txtPlaca.Text != "" && cmbMarca.Text != "" && cmbAnio.Text != "" && txtKm.Text != "" && txtVersion.Text != "" && cmbTipoCombustible.Text != "" && txtPuertas.Text != "" && cmbTipoTransmision.Text != "" && cmbColor.Text != "" && cmbTipoDireccion.Text != "" && cmbTraccion.Text != "" && txtCilindraje.Text != "" && cmbTipoCarroceria.Text != "")
            {
                UserModel objUser = new UserModel();
                
                int varValidInsert = objUser.InsertVehicle(cmbUbicacion.Text, cmbTipoVeh.Text, txtPlaca.Text, cmbMarca.Text, cmbAnio.Text, Convert.ToInt32(txtKm.Text), txtVersion.Text, cmbTipoCombustible.Text, Convert.ToInt32(txtPuertas.Text), cmbTipoTransmision.Text, cmbColor.Text, cmbTipoDireccion.Text, cmbTraccion.Text, Convert.ToInt32(txtCilindraje.Text), cmbTipoCarroceria.Text, CorreoUsuario);
                int varValidInsert2 = objUser.InsertPublicacion(CorreoUsuario, txtPlaca.Text, cmbMarca.Text, txtVersion.Text, openFileDialog1.FileName, txtPrecio.Text);
                if ((varValidInsert == 1) && (varValidInsert2 == 1))
                {
                    MessageBox.Show("Vehiculo publicado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    // FormPrincipal publi = new FormPublicar();
                    // publi.Show();
                }
                else
                {
                    MessageBox.Show("Imposible registrar vehiculo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos requeridos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVersion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPuertas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCilindraje_KeyPress(object sender, KeyPressEventArgs e)
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAbrirImg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string asd = openFileDialog1.FileName;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel objUserModel = new UserModel();                

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el dgv" + ex.ToString());
            }
        }
    }
}
