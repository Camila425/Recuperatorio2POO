
namespace Recuperatorio2POO.Windows
{
    partial class frmCurso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CrearEstudianteButton = new System.Windows.Forms.Button();
            this.CrearProfesorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEsAlumno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GuardarButton);
            this.splitContainer1.Panel1.Controls.Add(this.CrearEstudianteButton);
            this.splitContainer1.Panel1.Controls.Add(this.CrearProfesorButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(866, 670);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 0;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(757, 45);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(84, 55);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CrearEstudianteButton
            // 
            this.CrearEstudianteButton.Location = new System.Drawing.Point(133, 45);
            this.CrearEstudianteButton.Name = "CrearEstudianteButton";
            this.CrearEstudianteButton.Size = new System.Drawing.Size(84, 55);
            this.CrearEstudianteButton.TabIndex = 0;
            this.CrearEstudianteButton.Text = "Crear Estudiante";
            this.CrearEstudianteButton.UseVisualStyleBackColor = true;
            this.CrearEstudianteButton.Click += new System.EventHandler(this.CrearEstudianteButton_Click);
            // 
            // CrearProfesorButton
            // 
            this.CrearProfesorButton.Location = new System.Drawing.Point(30, 45);
            this.CrearProfesorButton.Name = "CrearProfesorButton";
            this.CrearProfesorButton.Size = new System.Drawing.Size(84, 55);
            this.CrearProfesorButton.TabIndex = 0;
            this.CrearProfesorButton.Text = "Crear Profesor";
            this.CrearProfesorButton.UseVisualStyleBackColor = true;
            this.CrearProfesorButton.Click += new System.EventHandler(this.CrearProfesorButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellido,
            this.colDocumento,
            this.colEsAlumno});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(866, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colDocumento
            // 
            this.colDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            // 
            // colEsAlumno
            // 
            this.colEsAlumno.HeaderText = "Es Alumno?";
            this.colEsAlumno.Name = "colEsAlumno";
            this.colEsAlumno.ReadOnly = true;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 670);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCurso";
            this.Text = "Datos del Curso";
            this.Load += new System.EventHandler(this.frmCurso_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CrearProfesorButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CrearEstudianteButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEsAlumno;
    }
}

