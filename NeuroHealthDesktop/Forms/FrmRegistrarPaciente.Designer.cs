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
            lblTitulo.Location = new Point(25, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de paciente";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(34, 122);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Location = new Point(34, 168);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(133, 20);
            lblNombreApellido.TabIndex = 4;
            lblNombreApellido.Text = "Apellido y nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(34, 213);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(34, 259);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(56, 20);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo";
            // 
            // lblPulso
            // 
            lblPulso.AutoSize = true;
            lblPulso.Location = new Point(629, 122);
            lblPulso.Name = "lblPulso";
            lblPulso.Size = new Size(44, 20);
            lblPulso.TabIndex = 15;
            lblPulso.Text = "Pulso";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Location = new Point(629, 168);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(93, 20);
            lblTemperatura.TabIndex = 17;
            lblTemperatura.Text = "Temperatura";
            // 
            // lblPresion
            // 
            lblPresion.AutoSize = true;
            lblPresion.Location = new Point(629, 213);
            lblPresion.Name = "lblPresion";
            lblPresion.Size = new Size(57, 20);
            lblPresion.TabIndex = 19;
            lblPresion.Text = "Presión";
            // 
            // lblSaturacion
            // 
            lblSaturacion.AutoSize = true;
            lblSaturacion.Location = new Point(629, 259);
            lblSaturacion.Name = "lblSaturacion";
            lblSaturacion.Size = new Size(79, 20);
            lblSaturacion.TabIndex = 21;
            lblSaturacion.Text = "Saturación";
            // 
            // lblDolor
            // 
            lblDolor.AutoSize = true;
            lblDolor.Location = new Point(629, 304);
            lblDolor.Name = "lblDolor";
            lblDolor.Size = new Size(47, 20);
            lblDolor.TabIndex = 23;
            lblDolor.Text = "Dolor";
            // 
            // lblTipoPaciente
            // 
            lblTipoPaciente.AutoSize = true;
            lblTipoPaciente.Location = new Point(34, 304);
            lblTipoPaciente.Name = "lblTipoPaciente";
            lblTipoPaciente.Size = new Size(121, 20);
            lblTipoPaciente.TabIndex = 10;
            lblTipoPaciente.Text = "Tipo de paciente";
            // 
            // lblAdultoResponsable
            // 
            lblAdultoResponsable.AutoSize = true;
            lblAdultoResponsable.Location = new Point(34, 394);
            lblAdultoResponsable.Name = "lblAdultoResponsable";
            lblAdultoResponsable.Size = new Size(138, 20);
            lblAdultoResponsable.TabIndex = 13;
            lblAdultoResponsable.Text = "Adulto responsable";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(217, 119);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(239, 27);
            txtDni.TabIndex = 3;
            txtDni.Tag = "txtDni";
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(217, 164);
            txtNombreApellido.Margin = new Padding(3, 4, 3, 4);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(342, 27);
            txtNombreApellido.TabIndex = 5;
            // 
            // txtPresion
            // 
            txtPresion.Location = new Point(800, 209);
            txtPresion.Margin = new Padding(3, 4, 3, 4);
            txtPresion.Name = "txtPresion";
            txtPresion.Size = new Size(182, 27);
            txtPresion.TabIndex = 20;
            // 
            // txtAdultoResponsable
            // 
            txtAdultoResponsable.Location = new Point(217, 391);
            txtAdultoResponsable.Margin = new Padding(3, 4, 3, 4);
            txtAdultoResponsable.Name = "txtAdultoResponsable";
            txtAdultoResponsable.Size = new Size(342, 27);
            txtAdultoResponsable.TabIndex = 14;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(217, 209);
            nudEdad.Margin = new Padding(3, 4, 3, 4);
            nudEdad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(137, 27);
            nudEdad.TabIndex = 7;
            nudEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudPulso
            // 
            nudPulso.Location = new Point(800, 119);
            nudPulso.Margin = new Padding(3, 4, 3, 4);
            nudPulso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudPulso.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudPulso.Name = "nudPulso";
            nudPulso.Size = new Size(137, 27);
            nudPulso.TabIndex = 16;
            nudPulso.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nudTemperatura
            // 
            nudTemperatura.DecimalPlaces = 1;
            nudTemperatura.Location = new Point(800, 164);
            nudTemperatura.Margin = new Padding(3, 4, 3, 4);
            nudTemperatura.Maximum = new decimal(new int[] { 42, 0, 0, 0 });
            nudTemperatura.Minimum = new decimal(new int[] { 34, 0, 0, 0 });
            nudTemperatura.Name = "nudTemperatura";
            nudTemperatura.Size = new Size(137, 27);
            nudTemperatura.TabIndex = 18;
            nudTemperatura.Value = new decimal(new int[] { 34, 0, 0, 0 });
            // 
            // nudSaturacion
            // 
            nudSaturacion.Location = new Point(800, 254);
            nudSaturacion.Margin = new Padding(3, 4, 3, 4);
            nudSaturacion.Minimum = new decimal(new int[] { 70, 0, 0, 0 });
            nudSaturacion.Name = "nudSaturacion";
            nudSaturacion.Size = new Size(137, 27);
            nudSaturacion.TabIndex = 22;
            nudSaturacion.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // nudDolor
            // 
            nudDolor.Location = new Point(800, 300);
            nudDolor.Margin = new Padding(3, 4, 3, 4);
            nudDolor.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDolor.Name = "nudDolor";
            nudDolor.Size = new Size(137, 27);
            nudDolor.TabIndex = 24;
            // 
            // cmbMotivo
            // 
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Location = new Point(217, 254);
            cmbMotivo.Margin = new Padding(3, 4, 3, 4);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(239, 28);
            cmbMotivo.TabIndex = 9;
            // 
            // cmbTipoPaciente
            // 
            cmbTipoPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaciente.Location = new Point(217, 300);
            cmbTipoPaciente.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPaciente.Name = "cmbTipoPaciente";
            cmbTipoPaciente.Size = new Size(239, 28);
            cmbTipoPaciente.TabIndex = 11;
            cmbTipoPaciente.SelectedIndexChanged += cmbTipoPaciente_SelectedIndexChanged;
            // 
            // chkRequiereCamilla
            // 
            chkRequiereCamilla.AutoSize = true;
            chkRequiereCamilla.Location = new Point(217, 346);
            chkRequiereCamilla.Margin = new Padding(3, 4, 3, 4);
            chkRequiereCamilla.Name = "chkRequiereCamilla";
            chkRequiereCamilla.Size = new Size(142, 24);
            chkRequiereCamilla.TabIndex = 12;
            chkRequiereCamilla.Tag = "chkRequiereCamilla";
            chkRequiereCamilla.Text = "Requiere camilla";
            chkRequiereCamilla.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(629, 400);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(171, 51);
            btnGuardar.TabIndex = 25;
            btnGuardar.Tag = "btnGuardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(823, 400);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(171, 51);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 493);
            Controls.Add(lblTitulo);
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
            Margin = new Padding(3, 4, 3, 4);
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
