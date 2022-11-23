using Recuperatorio2POO.Datos;
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
    public partial class frmCurso : Form
    {

        private Curso Curso;
        private List<Estudiante> Listaestudiantes;
        private Repositorio repositorio;
        public frmCurso()
        {
            InitializeComponent();
        }

        private void CrearEstudianteButton_Click(object sender, EventArgs e)
        {
            frmEstudiante frm = new frmEstudiante() { Text = "nuevo estudiante" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            Estudiante estudiante = frm.GetEstudiante();
            repositorio.Agregar(estudiante);
            MostrarDatosenGrilla();
            
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            MostrarDatosenGrilla();

        }

        private void MostrarDatosenGrilla()
        {
            dataGridView1.Rows.Clear();
            foreach (var estudiantes in Listaestudiantes)
            {
                var r = ConstruirFila();
                SetearFila(r, estudiantes);
                AgregarFila(r);
            }
       

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Estudiante estudiantes)
        {
            r.Cells[0].Value = estudiantes.Nombre1;
            r.Cells[1].Value = estudiantes.Apellido1;
            r.Cells[2].Value = estudiantes.Documento1;
            r.Cells[3].Value = estudiantes.estudiantes;
            r.Tag = estudiantes;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private void CrearProfesorButton_Click(object sender, EventArgs e)
        {
            frmProfesor frm = new frmProfesor() { Text = "nuevo profesor" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Profesor p= frm.GetProfesor();
            repositorio.AgregarProfesor(p);
            MostrarDatosenGrilla();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
