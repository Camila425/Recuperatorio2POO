
namespace Recuperatorio2POO.Windows
{
    partial class frmProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OkBtton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(116, 27);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(288, 20);
            this.NombreTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido:";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(116, 53);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(288, 20);
            this.ApellidoTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fec. Ingreso:";
            // 
            // IngresoDateTimePicker
            // 
            this.IngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IngresoDateTimePicker.Location = new System.Drawing.Point(116, 112);
            this.IngresoDateTimePicker.Name = "IngresoDateTimePicker";
            this.IngresoDateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.IngresoDateTimePicker.TabIndex = 2;
            // 
            // OkBtton
            // 
            this.OkBtton.Location = new System.Drawing.Point(32, 141);
            this.OkBtton.Name = "OkBtton";
            this.OkBtton.Size = new System.Drawing.Size(75, 48);
            this.OkBtton.TabIndex = 3;
            this.OkBtton.Text = "OK";
            this.OkBtton.UseVisualStyleBackColor = true;
            this.OkBtton.Click += new System.EventHandler(this.OkBtton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(329, 141);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 48);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Documento:";
            // 
            // DocumentoTextBox
            // 
            this.DocumentoTextBox.Location = new System.Drawing.Point(116, 79);
            this.DocumentoTextBox.Name = "DocumentoTextBox";
            this.DocumentoTextBox.Size = new System.Drawing.Size(288, 20);
            this.DocumentoTextBox.TabIndex = 1;
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 225);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OkBtton);
            this.Controls.Add(this.IngresoDateTimePicker);
            this.Controls.Add(this.DocumentoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "frmProfesor";
            this.Text = "frmProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IngresoDateTimePicker;
        private System.Windows.Forms.Button OkBtton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DocumentoTextBox;
    }
}