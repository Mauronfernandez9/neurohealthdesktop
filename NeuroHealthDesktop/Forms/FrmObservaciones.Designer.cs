namespace NeuroHealthDesktop.Forms
{
    partial class FrmObservaciones
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblDni;
        private Label lblObservacion;
        private Label lblListado;
        private TextBox txtDni;
        private TextBox txtObservacion;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnCerrar;
        private ListBox lstObservaciones;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDni = new Label();
            lblObservacion = new Label();
            lblListado = new Label();
            txtDni = new TextBox();
            txtObservacion = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnCerrar = new Button();
            lstObservaciones = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(23, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Observaciones";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(27, 126);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(121, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del paciente";
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(27, 184);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(91, 20);
            lblObservacion.TabIndex = 5;
            lblObservacion.Text = "Observación";
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Location = new Point(27, 347);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(176, 20);
            lblListado.TabIndex = 8;
            lblListado.Text = "Listado de observaciones";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(171, 120);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(205, 27);
            txtDni.TabIndex = 3;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(171, 180);
            txtObservacion.Margin = new Padding(3, 4, 3, 4);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(594, 125);
            txtObservacion.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(400, 118);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(171, 40);
            btnBuscar.TabIndex = 4;
            btnBuscar.Tag = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(789, 180);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(171, 51);
            btnAgregar.TabIndex = 7;
            btnAgregar.Tag = "btnAgregar";
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(789, 613);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(171, 47);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstObservaciones
            // 
            lstObservaciones.Location = new Point(27, 380);
            lstObservaciones.Margin = new Padding(3, 4, 3, 4);
            lstObservaciones.Name = "lstObservaciones";
            lstObservaciones.Size = new Size(932, 204);
            lstObservaciones.TabIndex = 9;
            // 
            // FrmObservaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 687);
            Controls.Add(lblTitulo);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(btnBuscar);
            Controls.Add(lblObservacion);
            Controls.Add(txtObservacion);
            Controls.Add(btnAgregar);
            Controls.Add(lblListado);
            Controls.Add(lstObservaciones);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmObservaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Observaciones";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
