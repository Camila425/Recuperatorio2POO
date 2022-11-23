using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperatorio2POO.Windows
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }

        private Estudiante estudiante;
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkBtton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                estudiante.Nombre1 = NombreTextBox.Text;
                estudiante.Apellido1 = ApellidoTextBox.Text;
                estudiante.Documento1 =int.Parse(DocumentoTextBox.Text);
                DialogResult = DialogResult.OK;

            }
        }

        private bool validarDatos()
        {
            return true;
        }

        public Estudiante GetEstudiante()
        {
            return estudiante;
        }
        Divisiones Divisiones;
        protected override void OnLoad(EventArgs e)
        {
            DivisionesComboBox.DataSource = Enum.GetValues(typeof(Divisiones));
            Enum.TryParse<Divisiones>(DivisionesComboBox.SelectedValue.ToString(), out Divisiones);
            base.OnLoad(e); 
        }
    }
}
