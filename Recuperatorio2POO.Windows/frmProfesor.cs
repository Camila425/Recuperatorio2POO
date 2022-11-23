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
    public partial class frmProfesor : Form
    {
        private Profesor Profesor;
        public frmProfesor()
        {
            InitializeComponent();
        }

        public Profesor GetProfesor()
        {
            return Profesor;
        }

        private void OkBtton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                Profesor.Nombre1 = NombreTextBox.Text;
                Profesor.Apellido1 = ApellidoTextBox.Text;
                Profesor.Documento1 = int.Parse(DocumentoTextBox.Text);
                Profesor.FechaIngreso = IngresoDateTimePicker.Value;
                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
