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
    public partial class AdministracionVotante : Form
    {
        public AdministracionVotante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                int consulta = Logica.MantenimientoVotante.InsertDeVotante(txtCedula.Text, txtCodElec.Text, txtSexo.Text, txtFechaCaduc.Text, txtJunta.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text);

                if (consulta == 1)
                {
                    MessageBox.Show("Registro Ingresado Correctamente");
                }
            }
            catch (Exception ex)
            {
                var d = new ThreadExceptionDialog(ex);
                d.ShowDialog();
            }
            
        }
    }
}
