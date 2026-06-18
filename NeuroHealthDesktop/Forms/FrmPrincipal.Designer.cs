namespace NeuroHealthDesktop.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblColaEspera;
        private System.Windows.Forms.Label lblPacientesAdmitidos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAyudaPrincipal;

        private System.Windows.Forms.DataGridView dgvColaEspera;
        private System.Windows.Forms.DataGridView dgvPacientesAdmitidos;

        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnEvaluarPaciente;
        private System.Windows.Forms.Button btnObservaciones;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.ProgressBar progressBarEvaluacion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblColaEspera = new Label();
            lblPacientesAdmitidos = new Label();
            lblEstado = new Label();
            lblAyudaPrincipal = new Label();
            dgvColaEspera = new DataGridView();
            dgvPacientesAdmitidos = new DataGridView();
            btnNuevoPaciente = new Button();
            btnEvaluarPaciente = new Button();
            btnObservaciones = new Button();
            btnEstadisticas = new Button();
            btnActualizar = new Button();
            btnSalir = new Button();
            progressBarEvaluacion = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesAdmitidos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(396, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NeuroHealth Desktop - Esqueleto";
            // 
            // lblColaEspera
            // 
            lblColaEspera.AutoSize = true;
            lblColaEspera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColaEspera.Location = new Point(24, 104);
            lblColaEspera.Name = "lblColaEspera";
            lblColaEspera.Size = new Size(141, 19);
            lblColaEspera.TabIndex = 2;
            lblColaEspera.Text = "Pacientes en espera";
            // 
            // lblPacientesAdmitidos
            // 
            lblPacientesAdmitidos.AutoSize = true;
            lblPacientesAdmitidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPacientesAdmitidos.Location = new Point(610, 104);
            lblPacientesAdmitidos.Name = "lblPacientesAdmitidos";
            lblPacientesAdmitidos.Size = new Size(143, 19);
            lblPacientesAdmitidos.TabIndex = 4;
            lblPacientesAdmitidos.Text = "Pacientes admitidos";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 504);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(188, 17);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado del sistema / mensajes.";
            // 
            // lblAyudaPrincipal
            // 
            lblAyudaPrincipal.AutoSize = true;
            lblAyudaPrincipal.Location = new Point(24, 66);
            lblAyudaPrincipal.Name = "lblAyudaPrincipal";
            lblAyudaPrincipal.Size = new Size(620, 17);
            lblAyudaPrincipal.TabIndex = 1;
            lblAyudaPrincipal.Text = "Pantalla principal. Aquí deberán conectarse los servicios, cargar grillas y resolver los eventos principales.";
            // 
            // dgvColaEspera
            // 
            dgvColaEspera.Location = new Point(24, 131);
            dgvColaEspera.Name = "dgvColaEspera";
            dgvColaEspera.Size = new Size(560, 238);
            dgvColaEspera.TabIndex = 3;
            // 
            // dgvPacientesAdmitidos
            // 
            dgvPacientesAdmitidos.Location = new Point(610, 131);
            dgvPacientesAdmitidos.Name = "dgvPacientesAdmitidos";
            dgvPacientesAdmitidos.Size = new Size(560, 238);
            dgvPacientesAdmitidos.TabIndex = 5;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Location = new Point(24, 397);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(145, 43);
            btnNuevoPaciente.TabIndex = 6;
            btnNuevoPaciente.Tag = "btnNuevoPaciente";
            btnNuevoPaciente.Text = "Nuevo paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = true;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;
            // 
            // btnEvaluarPaciente
            // 
            btnEvaluarPaciente.Location = new Point(183, 397);
            btnEvaluarPaciente.Name = "btnEvaluarPaciente";
            btnEvaluarPaciente.Size = new Size(150, 43);
            btnEvaluarPaciente.TabIndex = 7;
            btnEvaluarPaciente.Tag = "btnEvaluarPaciente";
            btnEvaluarPaciente.Text = "Evaluar";
            btnEvaluarPaciente.UseVisualStyleBackColor = true;
            btnEvaluarPaciente.Click += btnEvaluarPaciente_Click;
            // 
            // btnObservaciones
            // 
            btnObservaciones.Location = new Point(347, 397);
            btnObservaciones.Name = "btnObservaciones";
            btnObservaciones.Size = new Size(150, 43);
            btnObservaciones.TabIndex = 8;
            btnObservaciones.Tag = "btnObservaciones";
            btnObservaciones.Text = "Observaciones";
            btnObservaciones.UseVisualStyleBackColor = true;
            btnObservaciones.Click += btnObservaciones_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(511, 397);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(150, 43);
            btnEstadisticas.TabIndex = 9;
            btnEstadisticas.Tag = "btnEstadisticas";
            btnEstadisticas.Text = "Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(675, 397);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 43);
            btnActualizar.TabIndex = 10;
            btnActualizar.Tag = "btnActualizar";
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1020, 397);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 43);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // progressBarEvaluacion
            // 
            progressBarEvaluacion.Location = new Point(24, 465);
            progressBarEvaluacion.Name = "progressBarEvaluacion";
            progressBarEvaluacion.Size = new Size(1146, 20);
            progressBarEvaluacion.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 550);
            Controls.Add(lblEstado);
            Controls.Add(progressBarEvaluacion);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnObservaciones);
            Controls.Add(btnEvaluarPaciente);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(dgvPacientesAdmitidos);
            Controls.Add(lblPacientesAdmitidos);
            Controls.Add(dgvColaEspera);
            Controls.Add(lblColaEspera);
            Controls.Add(lblAyudaPrincipal);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NeuroHealth Desktop - Principal";
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesAdmitidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
