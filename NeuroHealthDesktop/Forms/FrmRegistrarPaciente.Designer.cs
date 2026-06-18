namespace NeuroHealthDesktop.Forms
{
    partial class FrmRegistrarPaciente
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblPulso;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblPresion;
        private System.Windows.Forms.Label lblSaturacion;
        private System.Windows.Forms.Label lblDolor;
        private System.Windows.Forms.Label lblTipoPaciente;
        private System.Windows.Forms.Label lblAdultoResponsable;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.TextBox txtPresion;
        private System.Windows.Forms.TextBox txtAdultoResponsable;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.NumericUpDown nudPulso;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
        private System.Windows.Forms.NumericUpDown nudSaturacion;
        private System.Windows.Forms.NumericUpDown nudDolor;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.ComboBox cmbTipoPaciente;
        private System.Windows.Forms.CheckBox chkRequiereCamilla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;

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
            lblDni = new Label();
            lblNombreApellido = new Label();
            lblEdad = new Label();
            lblMotivo = new Label();
            lblPulso = new Label();
            lblTemperatura = new Label();
            lblPresion = new Label();
            lblSaturacion = new Label();
            lblDolor = new Label();
            lblTipoPaciente = new Label();
            lblAdultoResponsable = new Label();
            lblAyuda = new Label();
            txtDni = new TextBox();
            txtNombreApellido = new TextBox();
            txtPresion = new TextBox();
            txtAdultoResponsable = new TextBox();
            nudEdad = new NumericUpDown();
            nudPulso = new NumericUpDown();
            nudTemperatura = new NumericUpDown();
            nudSaturacion = new NumericUpDown();
            nudDolor = new NumericUpDown();
            cmbMotivo = new ComboBox();
            cmbTipoPaciente = new ComboBox();
            chkRequiereCamilla = new CheckBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPulso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaturacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDolor).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(22, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de paciente - Esqueleto";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(30, 104);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 17);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(30, 143);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(116, 17);
            lblNombreApellido.TabIndex = 4;
            lblNombreApellido.Text = "Apellido y nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(30, 181);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(38, 17);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(30, 220);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(49, 17);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo";
            // 
            // lblPulso
            // 
            lblPulso.AutoSize = true;
            lblPulso.Location = new Point(550, 104);
            lblPulso.Name = "lblPulso";
            lblPulso.Size = new Size(39, 17);
            lblPulso.TabIndex = 15;
            lblPulso.Text = "Pulso";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(550, 143);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(82, 17);
            lblTemperatura.TabIndex = 17;
            lblTemperatura.Text = "Temperatura";
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Location = new Point(550, 181);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(51, 17);
            lblPresion.TabIndex = 19;
            lblPresion.Text = "Presión";
            // 
            // lblSaturacion
            // 
            lblSaturacion.AutoSize = true;
            lblSaturacion.Location = new Point(550, 220);
            lblSaturacion.Name = "lblSaturacion";
            lblSaturacion.Size = new Size(69, 17);
            lblSaturacion.TabIndex = 21;
            lblSaturacion.Text = "Saturación";
            // 
            // lblDolor
            // 
            lblDolor.AutoSize = true;
            lblDolor.Location = new Point(550, 258);
            lblDolor.Name = "lblDolor";
            lblDolor.Size = new Size(41, 17);
            lblDolor.TabIndex = 23;
            lblDolor.Text = "Dolor";
            // 
            // lblTipoPaciente
            // 
            lblTipoPaciente.AutoSize = true;
            lblTipoPaciente.Location = new Point(30, 258);
            lblTipoPaciente.Name = "lblTipoPaciente";
            lblTipoPaciente.Size = new Size(106, 17);
            lblTipoPaciente.TabIndex = 10;
            lblTipoPaciente.Text = "Tipo de paciente";
            // 
            // lblAdultoResponsable
            // 
            lblAdultoResponsable.AutoSize = true;
            lblAdultoResponsable.Location = new Point(30, 335);
            lblAdultoResponsable.Name = "lblAdultoResponsable";
            lblAdultoResponsable.Size = new Size(122, 17);
            lblAdultoResponsable.TabIndex = 13;
            lblAdultoResponsable.Text = "Adulto responsable";
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Location = new Point(25, 62);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(680, 17);
            lblAyuda.TabIndex = 1;
            lblAyuda.Text = "Formulario base. Aquí los alumnos deberán completar validaciones, carga de datos y creación del objeto paciente.";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(190, 101);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(210, 25);
            txtDni.TabIndex = 3;
            txtDni.Tag = "txtDni";
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(190, 139);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(300, 25);
            txtNombreApellido.TabIndex = 5;
            // 
            // txtPresion
            // 
            txtPresion.Location = new Point(700, 178);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(160, 25);
            txtPresion.TabIndex = 20;
            // 
            // txtAdultoResponsable
            // 
            txtAdultoResponsable.Location = new Point(190, 332);
            txtAdultoResponsable.Name = "txtAdultoResponsable";
            txtAdultoResponsable.Size = new Size(300, 25);
            txtAdultoResponsable.TabIndex = 14;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(190, 178);
            nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(120, 25);
            nudEdad.TabIndex = 7;
            // 
            // nudPulso
            // 
            nudPulso.Location = new Point(700, 101);
            nudPulso.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudPulso.Name = "nudPulso";
            nudPulso.Size = new Size(120, 25);
            nudPulso.TabIndex = 16;
            // 
            // nudTemperatura
            // 
            nudTemperatura.DecimalPlaces = 1;
            nudTemperatura.Location = new Point(700, 139);
            nudTemperatura.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudTemperatura.Name = "nudTemperatura";
            nudTemperatura.Size = new Size(120, 25);
            nudTemperatura.TabIndex = 18;
            // 
            // nudSaturacion
            // 
            nudSaturacion.Location = new Point(700, 216);
            nudSaturacion.Name = "nudSaturacion";
            nudSaturacion.Size = new Size(120, 25);
            nudSaturacion.TabIndex = 22;
            // 
            // nudDolor
            // 
            nudDolor.Location = new Point(700, 255);
            nudDolor.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDolor.Name = "nudDolor";
            nudDolor.Size = new Size(120, 25);
            nudDolor.TabIndex = 24;
            // 
            // cmbMotivo
            // 
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Location = new Point(190, 216);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(210, 25);
            cmbMotivo.TabIndex = 9;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Location = new Point(190, 255);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(210, 25);
            cmbTipoPaciente.TabIndex = 11;
            cmbTipoPaciente.SelectedIndexChanged += cmbTipoPaciente_SelectedIndexChanged;
            // 
            // chkRequiereCamilla
            // 
            chkRequiereCamilla.AutoSize = true;
            chkRequiereCamilla.Location = new Point(190, 294);
            chkRequiereCamilla.Name = "chkRequiereCamilla";
            chkRequiereCamilla.Size = new Size(123, 21);
            chkRequiereCamilla.TabIndex = 12;
            chkRequiereCamilla.Tag = "chkRequiereCamilla";
            chkRequiereCamilla.Text = "Requiere camilla";
            chkRequiereCamilla.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(550, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 43);
            btnGuardar.TabIndex = 25;
            btnGuardar.Tag = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(720, 340);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 43);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 419);
            Controls.Add(lblTitulo);
            Controls.Add(lblAyuda);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblNombreApellido);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblEdad);
            Controls.Add(nudEdad);
            Controls.Add(lblMotivo);
            Controls.Add(cmbMotivo);
            Controls.Add(lblTipoPaciente);
            Controls.Add(cmbTipoPaciente);
            Controls.Add(chkRequiereCamilla);
            Controls.Add(lblAdultoResponsable);
            Controls.Add(txtAdultoResponsable);
            Controls.Add(lblPulso);
            Controls.Add(nudPulso);
            Controls.Add(lblTemperatura);
            Controls.Add(nudTemperatura);
            Controls.Add(lblPresion);
            Controls.Add(txtPresion);
            Controls.Add(lblSaturacion);
            Controls.Add(nudSaturacion);
            Controls.Add(lblDolor);
            Controls.Add(nudDolor);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRegistrarPaciente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar paciente";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPulso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTemperatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaturacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDolor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
