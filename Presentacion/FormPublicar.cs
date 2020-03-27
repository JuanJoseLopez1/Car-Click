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
        public static bool actualizarveh = false;
        public static string vUbicacion = string.Empty;
        public static string vTipoVeh= string.Empty;
        public static string PlacaVeh = string.Empty;
        public static string vMarca = string.Empty;
        public static string vAnio = string.Empty;
        public static int vKM = 0;
        public static string vVersion = string.Empty;
        public static string vTpCombustible = string.Empty;
        public static int vPuertas = 0;
        public static string vTpTransmision = string.Empty;
        public static string vColorVeh = string.Empty;
        public static string vTipoDireccion = string.Empty;
        public static string vTipoTraccion = string.Empty;
        public static int vCilindraje = 0;
        public static string vTipoCarroceria = string.Empty;

        public FormPublicar()
        {
            InitializeComponent();
        }
        public FormPublicar(string parCorreoUsuario)
        {
            CorreoUsuario = parCorreoUsuario;
            InitializeComponent();            
        }

        public FormPublicar(string parCorreoUsuario, string parPlacaveh, bool parActualizar)
        {
            CorreoUsuario = parCorreoUsuario;
            PlacaVeh = parPlacaveh;
            actualizarveh = parActualizar;
            
            InitializeComponent();
        }


        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (cmbUbicacion.Text != "" && cmbTipoVeh.Text != "" && txtPlaca.Text != "" && cmbMarca.Text != "" && cmbAnio.Text != "" && txtKm.Text != "" && txtVersion.Text != "" && cmbTipoCombustible.Text != "" && txtPuertas.Text != "" && cmbTipoTransmision.Text != "" && cmbColor.Text != "" && cmbTipoDireccion.Text != "" && cmbTraccion.Text != "" && txtCilindraje.Text != "" && cmbTipoCarroceria.Text != "" && txtPrecio.Text != "")
            {
                UserModel objUser = new UserModel();                
                int varValidInsert = objUser.InsertVehicle(cmbUbicacion.Text, cmbTipoVeh.Text, txtPlaca.Text, cmbMarca.Text, cmbAnio.Text, Convert.ToInt32(txtKm.Text), txtVersion.Text, cmbTipoCombustible.Text, Convert.ToInt32(txtPuertas.Text), cmbTipoTransmision.Text, cmbColor.Text, cmbTipoDireccion.Text, cmbTraccion.Text, Convert.ToInt32(txtCilindraje.Text), cmbTipoCarroceria.Text, CorreoUsuario);
                int varValidInsert2 = objUser.InsertPublicacion(CorreoUsuario, txtPlaca.Text, cmbMarca.Text, txtVersion.Text, txtPrecio.Text);
                if ((varValidInsert == 1) && (varValidInsert2 == 1))
                {
                    MessageBox.Show("Vehiculo publicado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                    // FormPrincipal publi = new FormPublicar();
                    // publi.Show();
                }
                else
                {
                    MessageBox.Show("Imposible registrar vehiculo, su vehiculo ya se encuentra registrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (actualizarveh == true)
            {
                if ((cmbUbicacion.Text != vUbicacion) || cmbTipoVeh.Text != vTipoVeh || txtPlaca.Text != PlacaVeh || cmbMarca.Text != vMarca || cmbAnio.Text != vAnio || Convert.ToInt32(txtKm.Text) != vKM || txtVersion.Text != vVersion || cmbTipoCombustible.Text != vTpCombustible || Convert.ToInt32(txtPuertas.Text) != vPuertas || cmbTipoTransmision.Text != vTpTransmision || cmbColor.Text != vColorVeh || cmbTipoDireccion.Text != vTipoDireccion || cmbTraccion.Text != vTipoTraccion || Convert.ToInt32(txtCilindraje.Text) != vCilindraje || cmbTipoCarroceria.Text != vTipoCarroceria || txtPrecio.Text != "")
                {
                    string varConsulta = "UPDATE VEHICULO SET" + " UBICACIONVEH = " + "'" + cmbUbicacion.Text + "', TIPOVEH = '" + cmbTipoVeh.Text + "', PLACAVEH = '" + txtPlaca.Text + "', MARCAVEH = '" + cmbMarca.Text + "', ANIOVEH = '" + cmbAnio.Text + "', KMVEH = " + Convert.ToInt32(txtKm.Text) + ", VERSIONVEH = '" + txtVersion.Text + "', TPCOMBUSTIBLE = '" + cmbTipoCombustible.Text + "', PUERTASVEH = " + Convert.ToInt32(txtPuertas.Text) + ", TPTRANSMISION = '" + cmbTipoTransmision.Text + "', COLORVEH = '" + cmbColor.Text + "', TPDIRECCION = '" + cmbTipoDireccion.Text + "', TRACCION = '" + cmbTraccion.Text + "', CILINDRAJE = " + Convert.ToInt32(txtCilindraje.Text) + ", TPCARROCERIA = '" + cmbTipoCarroceria.Text + "' WHERE DUENIO = '" + CorreoUsuario + "' AND PLACAVEH = '" + PlacaVeh + "'";
                    UserModel obUser = new UserModel();
                    int validUptade = obUser.Actualizar(varConsulta);
                    string varConsulta2 = "UPDATE PUBLICACION SET" + " PLACAVEH = '" + txtPlaca.Text + "', MARCAVEH = '" + cmbMarca.Text + "', SUBMARCAVEH = '" + txtVersion.Text + "', PRECIO = " + Convert.ToInt32(txtPrecio.Text) + " WHERE UCORREO = '" + CorreoUsuario + "' AND PLACAVEH = '" + PlacaVeh + "'";
                    int validUptade2 = obUser.Actualizar(varConsulta2);
                    if (validUptade == 1 && validUptade2 == 1)
                    {
                        MessageBox.Show("Datos de la publicacion modificados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("No se logro modificar la publicacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Sin cambios en la informacion de la publicacion.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna publicacion.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void rellenarCampos()
        {
            DataTable obTabla = new DataTable();
            UserModel obUser = new UserModel();
            obTabla = obUser.ConsultarPublicaciones("SELECT UBICACIONVEH, TIPOVEH, PLACAVEH, MARCAVEH, ANIOVEH," +
                " KMVEH, VERSIONVEH, TPCOMBUSTIBLE, PUERTASVEH, TPTRANSMISION, COLORVEH, TPDIRECCION, TRACCION, CILINDRAJE, TPCARROCERIA FROM VEHICULO WHERE DUENIO = " + "'" + CorreoUsuario + "'" + " AND PLACAVEH = " + "'" + PlacaVeh + "'");
            if (obTabla.Rows.Count > 0)
            {
                cmbUbicacion.Text = obTabla.Rows[0][0].ToString();
                cmbTipoVeh.Text = obTabla.Rows[0][1].ToString();
                txtPlaca.Text = obTabla.Rows[0][2].ToString();
                cmbMarca.Text = obTabla.Rows[0][3].ToString();
                cmbAnio.Text = obTabla.Rows[0][4].ToString();
                txtKm.Text = obTabla.Rows[0][5].ToString();
                txtVersion.Text = obTabla.Rows[0][6].ToString();
                cmbTipoCombustible.Text = obTabla.Rows[0][7].ToString();
                txtPuertas.Text = obTabla.Rows[0][8].ToString();
                cmbTipoTransmision.Text = obTabla.Rows[0][9].ToString();
                cmbColor.Text = obTabla.Rows[0][10].ToString();
                cmbTipoDireccion.Text = obTabla.Rows[0][11].ToString();
                cmbTraccion.Text = obTabla.Rows[0][12].ToString();
                txtCilindraje.Text = obTabla.Rows[0][13].ToString();
                cmbTipoCarroceria.Text = obTabla.Rows[0][14].ToString();
                vUbicacion = cmbUbicacion.Text;
                vTipoVeh = cmbTipoVeh.Text;
                PlacaVeh = txtPlaca.Text;
                vMarca = cmbMarca.Text;
                vAnio = cmbAnio.Text;
                vKM = Convert.ToInt32(txtKm.Text);
                vVersion = txtVersion.Text;
                vTpCombustible = cmbTipoCombustible.Text;
                vPuertas = Convert.ToInt32(txtPuertas.Text);
                vTpTransmision = cmbTipoTransmision.Text;
                vColorVeh = cmbColor.Text;
                vTipoDireccion = cmbTipoDireccion.Text;
                vTipoTraccion = cmbTraccion.Text;
                vCilindraje = Convert.ToInt32(txtCilindraje.Text);
                vTipoCarroceria = cmbTipoCarroceria.Text;
            }
            else
            {
                MessageBox.Show("No se encontro la publicacion.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPublicar_Load(object sender, EventArgs e)
        {
            if (actualizarveh == true)
            {
                rellenarCampos();

            }
        }
    }
}
