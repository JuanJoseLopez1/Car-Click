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
    public partial class FormPagPrincipal : Form
    {
        public static string MailUsuario = string.Empty;
        public FormPagPrincipal()
        {
            InitializeComponent();
        }
         

        private void dgvPublicacionesPagP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormPagPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                UserModel objUserModel = new UserModel();
                dgvPublicacionesPagP.DataSource = objUserModel.ConsultarPublicaciones("SELECT placaveh, marcaveh, submarcaveh, precio FROM PUBLICACION ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el dgv" + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel objUserModel = new UserModel();
                dgvPublicacionesPagP.DataSource = objUserModel.ConsultarPublicaciones("SELECT placaveh, marcaveh, submarcaveh, precio FROM PUBLICACION ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo llenar el dgv" + ex.ToString());
            }
        }
    }
}
