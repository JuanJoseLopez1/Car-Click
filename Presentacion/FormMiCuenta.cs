using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormMiCuenta : Form
    {
        public static string MailUsuario;
        public static string nombre;
        public static string apellido;
        public static string telefono;
        public static string clave;
        public FormMiCuenta()
        {
            InitializeComponent();
        }
        public FormMiCuenta(string parUsuario)
        {
            MailUsuario = parUsuario;
            InitializeComponent();
        }

        private void FormCuenta_Load(object sender, EventArgs e)
        {
            DataTable obTabla = new DataTable();
            UserModel obUser = new UserModel();
            obTabla = obUser.ConsultarPublicaciones("SELECT UNOMBRE, UAPELLIDO, UTELEFONO, UCLAVE FROM USUARIO WHERE UCORREO = " + "'" + MailUsuario + "'");
            if (obTabla.Rows.Count > 0)
            {
                txtModNombre.Text = obTabla.Rows[0][0].ToString();
                txtModApellido.Text = obTabla.Rows[0][1].ToString();
                txtModTelefono.Text = obTabla.Rows[0][2].ToString();
                txtModContra.Text = obTabla.Rows[0][3].ToString();
                nombre = txtModNombre.Text;
                apellido = txtModApellido.Text;
                telefono = txtModTelefono.Text;
                clave = txtModContra.Text;
            }
            else
            {
                MessageBox.Show("No se encontro el registro a eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (txtModNombre.Text != nombre || txtModApellido.Text != apellido || txtModTelefono.Text != telefono || txtModContra.Text != clave)
            {
                string varConsulta = "UPDATE USUARIO SET" + " UNOMBRE = " + "'" + txtModNombre.Text + "', UAPELLIDO = '" + txtModApellido.Text + "', UTELEFONO = '" + txtModTelefono.Text + "', UCLAVE = '" + txtModContra.Text + "' WHERE UCORREO = '" + MailUsuario + "'";
                UserModel obUser = new UserModel();
                int validUptade = obUser.Actualizar(varConsulta);
                if (validUptade == 1)
                {
                    MessageBox.Show("Datos del usuario modificados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se logro modificar el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Sin cambios en la informacion del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
