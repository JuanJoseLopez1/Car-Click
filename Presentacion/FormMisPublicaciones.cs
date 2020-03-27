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
    public partial class FormMisPublicaciones : Form
    {
        public static string MailUsuario;
        public static string PlacaSeleccionada = "";
        public static bool boolActualizar = false;
        public FormMisPublicaciones()
        {
            InitializeComponent();
        }

        public FormMisPublicaciones(string parUsuario)
        {
            MailUsuario = parUsuario;
            InitializeComponent();
        }

        private void dgvPublicacionesP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PlacaSeleccionada = dgvPublicacionesP.CurrentRow.Cells[0].Value.ToString();
        }

        private void FormMisPublicaciones_Load(object sender, EventArgs e)
        {
            try
            {
                UserModel objUserModel = new UserModel();
                dgvPublicacionesP.DataSource = objUserModel.ConsultarPublicaciones("SELECT placaveh, marcaveh, submarcaveh, precio FROM PUBLICACION WHERE ucorreo = " + "'" + MailUsuario + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el dgv" + ex.ToString());
            }
        }

        private void btnModPublicacion_Click(object sender, EventArgs e)
        {
            if (PlacaSeleccionada != "")
            {
                boolActualizar = true;
                FormPublicar obFormPublicar = new FormPublicar(MailUsuario, PlacaSeleccionada, boolActualizar);
                obFormPublicar.Show();
               
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA PUBLICACION", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel objUserModel = new UserModel();
                dgvPublicacionesP.DataSource = objUserModel.ConsultarPublicaciones("SELECT placaveh, marcaveh, submarcaveh, precio FROM PUBLICACION WHERE ucorreo = " + "'" + MailUsuario + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el dgv" + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserModel obUserModel = new UserModel();
            int valid1 = obUserModel.EliminarPulicacion(MailUsuario);
            int valid2 = obUserModel.EliminarVehiculo(PlacaSeleccionada, MailUsuario);
            if ((valid1 == 1) && (valid2 == 1))
            {
                MessageBox.Show("Publicacion eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Publicacion eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
