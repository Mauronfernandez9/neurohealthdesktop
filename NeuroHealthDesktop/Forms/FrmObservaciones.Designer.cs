namespace NeuroHealthDesktop.Forms
{
    partial class FrmObservaciones
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblDni;
        private Label lblObservacion;
        private Label lblListado;
        private Label lblAyuda;
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
            lblAyuda = new Label();
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
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Observaciones - Esqueleto";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(24, 107);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(105, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI del paciente";
            // 
            // lblObservacion
            // 
            lblObservacion.AutoSize = true;
            lblObservacion.Location = new Point(24, 156);
            lblObservacion.Name = "lblObservacion";
            lblObservacion.Size = new Size(81, 17);
            lblObservacion.TabIndex = 5;
            lblObservacion.Text = "Observación";
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Location = new Point(24, 295);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(157, 17);
            lblListado.TabIndex = 8;
            lblListado.Text = "Listado de observaciones";
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Location = new Point(24, 62);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(412, 17);
            lblAyuda.TabIndex = 1;
            lblAyuda.Text = "Aquí se deberá buscar un paciente, cargar y listar sus observaciones.";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(150, 102);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 25);
            txtDni.TabIndex = 3;
            // 
            // txtObservacion
            // 
            txtObservacion.Location = new Point(150, 153);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new Size(520, 107);
            txtObservacion.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(350, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Tag = "btnBuscar";
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(690, 153);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 43);
            btnAgregar.TabIndex = 7;
            btnAgregar.Tag = "btnAgregar";
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(690, 521);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 40);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstObservaciones
            // 
            lstObservaciones.ItemHeight = 17;
            lstObservaciones.Location = new Point(24, 323);
            lstObservaciones.Name = "lstObservaciones";
            lstObservaciones.Size = new Size(816, 174);
            lstObservaciones.TabIndex = 9;
            // 
            // FrmObservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 584);
            Controls.Add(lblTitulo);
            Controls.Add(lblAyuda);
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
            MaximizeBox = false;
            Name = "FrmObservaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Observaciones";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
