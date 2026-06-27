namespace NeuroHealthDesktop.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblColaEspera;
        private System.Windows.Forms.Label lblPacientesAdmitidos;

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
            lblTitulo.Location = new Point(23, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(325, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NeuroHealth Desktop";
            // 
            // lblColaEspera
            // 
            lblColaEspera.AutoSize = true;
            lblColaEspera.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblColaEspera.Location = new Point(27, 122);
            lblColaEspera.Name = "lblColaEspera";
            lblColaEspera.Size = new Size(165, 23);
            lblColaEspera.TabIndex = 2;
            lblColaEspera.Text = "Pacientes en espera";
            // 
            // lblPacientesAdmitidos
            // 
            lblPacientesAdmitidos.AutoSize = true;
            lblPacientesAdmitidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPacientesAdmitidos.Location = new Point(697, 122);
            lblPacientesAdmitidos.Name = "lblPacientesAdmitidos";
            lblPacientesAdmitidos.Size = new Size(170, 23);
            lblPacientesAdmitidos.TabIndex = 4;
            lblPacientesAdmitidos.Text = "Pacientes admitidos";
            // 
            // dgvColaEspera
            // 
            dgvColaEspera.ColumnHeadersHeight = 29;
            dgvColaEspera.Location = new Point(27, 154);
            dgvColaEspera.Margin = new Padding(3, 4, 3, 4);
            dgvColaEspera.Name = "dgvColaEspera";
            dgvColaEspera.ReadOnly = true;
            dgvColaEspera.RowHeadersWidth = 51;
            dgvColaEspera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvColaEspera.Size = new Size(640, 280);
            dgvColaEspera.TabIndex = 3;
            dgvColaEspera.CellContentClick += dgvColaEspera_CellContentClick;
            // 
            // dgvPacientesAdmitidos
            // 
            dgvPacientesAdmitidos.ColumnHeadersHeight = 29;
            dgvPacientesAdmitidos.Location = new Point(687, 154);
            dgvPacientesAdmitidos.Margin = new Padding(3, 4, 3, 4);
            dgvPacientesAdmitidos.Name = "dgvPacientesAdmitidos";
            dgvPacientesAdmitidos.ReadOnly = true;
            dgvPacientesAdmitidos.RowHeadersWidth = 51;
            dgvPacientesAdmitidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPacientesAdmitidos.Size = new Size(640, 280);
            dgvPacientesAdmitidos.TabIndex = 5;
            dgvPacientesAdmitidos.CellContentClick += dgvPacientesAdmitidos_CellContentClick;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Location = new Point(27, 467);
            btnNuevoPaciente.Margin = new Padding(3, 4, 3, 4);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(166, 51);
            btnNuevoPaciente.TabIndex = 6;
            btnNuevoPaciente.Tag = "btnNuevoPaciente";
            btnNuevoPaciente.Text = "Nuevo paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = true;
            btnNuevoPaciente.Click += btnNuevoPaciente_Click;
            // 
            // btnEvaluarPaciente
            // 
            btnEvaluarPaciente.Location = new Point(209, 467);
            btnEvaluarPaciente.Margin = new Padding(3, 4, 3, 4);
            btnEvaluarPaciente.Name = "btnEvaluarPaciente";
            btnEvaluarPaciente.Size = new Size(171, 51);
            btnEvaluarPaciente.TabIndex = 7;
            btnEvaluarPaciente.Tag = "btnEvaluarPaciente";
            btnEvaluarPaciente.Text = "Evaluar";
            btnEvaluarPaciente.UseVisualStyleBackColor = true;
            btnEvaluarPaciente.Click += btnEvaluarPaciente_Click;
            // 
            // btnObservaciones
            // 
            btnObservaciones.Location = new Point(397, 467);
            btnObservaciones.Margin = new Padding(3, 4, 3, 4);
            btnObservaciones.Name = "btnObservaciones";
            btnObservaciones.Size = new Size(171, 51);
            btnObservaciones.TabIndex = 8;
            btnObservaciones.Tag = "btnObservaciones";
            btnObservaciones.Text = "Observaciones";
            btnObservaciones.UseVisualStyleBackColor = true;
            btnObservaciones.Click += btnObservaciones_Click;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(584, 467);
            btnEstadisticas.Margin = new Padding(3, 4, 3, 4);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(171, 51);
            btnEstadisticas.TabIndex = 9;
            btnEstadisticas.Tag = "btnEstadisticas";
            btnEstadisticas.Text = "Estadísticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(771, 467);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(171, 51);
            btnActualizar.TabIndex = 10;
            btnActualizar.Tag = "btnActualizar";
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1166, 467);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 51);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // progressBarEvaluacion
            // 
            progressBarEvaluacion.Location = new Point(27, 547);
            progressBarEvaluacion.Margin = new Padding(3, 4, 3, 4);
            progressBarEvaluacion.Name = "progressBarEvaluacion";
            progressBarEvaluacion.Size = new Size(1310, 24);
            progressBarEvaluacion.TabIndex = 12;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 647);
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
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
