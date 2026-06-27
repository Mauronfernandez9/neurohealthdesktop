namespace NeuroHealthDesktop.Forms
{
    partial class FrmEstadisticas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEnEspera;
        private System.Windows.Forms.Label lblAdmitidos;
        private System.Windows.Forms.Label lblVerdes;
        private System.Windows.Forms.Label lblAmarillos;
        private System.Windows.Forms.Label lblRojos;
        private System.Windows.Forms.Label lblEdadPromedio;
        private System.Windows.Forms.Label lblPorcentajeCriticos;
        private System.Windows.Forms.Label lblEnEsperaValor;
        private System.Windows.Forms.Label lblAdmitidosValor;
        private System.Windows.Forms.Label lblVerdesValor;
        private System.Windows.Forms.Label lblAmarillosValor;
        private System.Windows.Forms.Label lblRojosValor;
        private System.Windows.Forms.Label lblEdadPromedioValor;
        private System.Windows.Forms.Label lblPorcentajeCriticosValor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;

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
            lblEnEspera = new Label();
            lblEnEsperaValor = new Label();
            lblAdmitidos = new Label();
            lblAdmitidosValor = new Label();
            lblVerdes = new Label();
            lblVerdesValor = new Label();
            lblAmarillos = new Label();
            lblAmarillosValor = new Label();
            lblRojos = new Label();
            lblRojosValor = new Label();
            lblEdadPromedio = new Label();
            lblEdadPromedioValor = new Label();
            lblPorcentajeCriticos = new Label();
            lblPorcentajeCriticosValor = new Label();
            btnActualizar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Estadísticas";
            // 
            // lblEnEspera
            // 
            lblEnEspera.AutoSize = true;
            lblEnEspera.Location = new Point(40, 133);
            lblEnEspera.Name = "lblEnEspera";
            lblEnEspera.Size = new Size(138, 20);
            lblEnEspera.TabIndex = 2;
            lblEnEspera.Text = "Pacientes en espera";
            // 
            // lblEnEsperaValor
            // 
            lblEnEsperaValor.AutoSize = true;
            lblEnEsperaValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnEsperaValor.Location = new Point(343, 133);
            lblEnEsperaValor.Name = "lblEnEsperaValor";
            lblEnEsperaValor.Size = new Size(18, 20);
            lblEnEsperaValor.TabIndex = 3;
            lblEnEsperaValor.Text = "0";
            // 
            // lblAdmitidos
            // 
            lblAdmitidos.AutoSize = true;
            lblAdmitidos.Location = new Point(40, 179);
            lblAdmitidos.Name = "lblAdmitidos";
            lblAdmitidos.Size = new Size(141, 20);
            lblAdmitidos.TabIndex = 4;
            lblAdmitidos.Text = "Pacientes admitidos";
            // 
            // lblAdmitidosValor
            // 
            lblAdmitidosValor.AutoSize = true;
            lblAdmitidosValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdmitidosValor.Location = new Point(343, 179);
            lblAdmitidosValor.Name = "lblAdmitidosValor";
            lblAdmitidosValor.Size = new Size(18, 20);
            lblAdmitidosValor.TabIndex = 5;
            lblAdmitidosValor.Text = "0";
            // 
            // lblVerdes
            // 
            lblVerdes.AutoSize = true;
            lblVerdes.Location = new Point(40, 224);
            lblVerdes.Name = "lblVerdes";
            lblVerdes.Size = new Size(117, 20);
            lblVerdes.TabIndex = 6;
            lblVerdes.Text = "Pacientes verdes";
            // 
            // lblVerdesValor
            // 
            lblVerdesValor.AutoSize = true;
            lblVerdesValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVerdesValor.Location = new Point(343, 224);
            lblVerdesValor.Name = "lblVerdesValor";
            lblVerdesValor.Size = new Size(18, 20);
            lblVerdesValor.TabIndex = 7;
            lblVerdesValor.Text = "0";
            // 
            // lblAmarillos
            // 
            lblAmarillos.AutoSize = true;
            lblAmarillos.Location = new Point(40, 269);
            lblAmarillos.Name = "lblAmarillos";
            lblAmarillos.Size = new Size(135, 20);
            lblAmarillos.TabIndex = 8;
            lblAmarillos.Text = "Pacientes amarillos";
            // 
            // lblAmarillosValor
            // 
            lblAmarillosValor.AutoSize = true;
            lblAmarillosValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAmarillosValor.Location = new Point(343, 269);
            lblAmarillosValor.Name = "lblAmarillosValor";
            lblAmarillosValor.Size = new Size(18, 20);
            lblAmarillosValor.TabIndex = 9;
            lblAmarillosValor.Text = "0";
            // 
            // lblRojos
            // 
            lblRojos.AutoSize = true;
            lblRojos.Location = new Point(40, 314);
            lblRojos.Name = "lblRojos";
            lblRojos.Size = new Size(107, 20);
            lblRojos.TabIndex = 10;
            lblRojos.Text = "Pacientes rojos";
            // 
            // lblRojosValor
            // 
            lblRojosValor.AutoSize = true;
            lblRojosValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRojosValor.Location = new Point(343, 314);
            lblRojosValor.Name = "lblRojosValor";
            lblRojosValor.Size = new Size(18, 20);
            lblRojosValor.TabIndex = 11;
            lblRojosValor.Text = "0";
            // 
            // lblEdadPromedio
            // 
            lblEdadPromedio.AutoSize = true;
            lblEdadPromedio.Location = new Point(40, 360);
            lblEdadPromedio.Name = "lblEdadPromedio";
            lblEdadPromedio.Size = new Size(113, 20);
            lblEdadPromedio.TabIndex = 12;
            lblEdadPromedio.Text = "Edad promedio";
            // 
            // lblEdadPromedioValor
            // 
            lblEdadPromedioValor.AutoSize = true;
            lblEdadPromedioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdadPromedioValor.Location = new Point(343, 360);
            lblEdadPromedioValor.Name = "lblEdadPromedioValor";
            lblEdadPromedioValor.Size = new Size(18, 20);
            lblEdadPromedioValor.TabIndex = 13;
            lblEdadPromedioValor.Text = "0";
            // 
            // lblPorcentajeCriticos
            // 
            lblPorcentajeCriticos.AutoSize = true;
            lblPorcentajeCriticos.Location = new Point(40, 406);
            lblPorcentajeCriticos.Name = "lblPorcentajeCriticos";
            lblPorcentajeCriticos.Size = new Size(129, 20);
            lblPorcentajeCriticos.TabIndex = 14;
            lblPorcentajeCriticos.Text = "Porcentaje críticos";
            // 
            // lblPorcentajeCriticosValor
            // 
            lblPorcentajeCriticosValor.AutoSize = true;
            lblPorcentajeCriticosValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPorcentajeCriticosValor.Location = new Point(343, 406);
            lblPorcentajeCriticosValor.Name = "lblPorcentajeCriticosValor";
            lblPorcentajeCriticosValor.Size = new Size(18, 20);
            lblPorcentajeCriticosValor.TabIndex = 15;
            lblPorcentajeCriticosValor.Text = "0";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(40, 487);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(183, 51);
            btnActualizar.TabIndex = 16;
            btnActualizar.Tag = "btnActualizar";
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(246, 487);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(183, 51);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 580);
            Controls.Add(lblTitulo);
            Controls.Add(lblEnEspera);
            Controls.Add(lblEnEsperaValor);
            Controls.Add(lblAdmitidos);
            Controls.Add(lblAdmitidosValor);
            Controls.Add(lblVerdes);
            Controls.Add(lblVerdesValor);
            Controls.Add(lblAmarillos);
            Controls.Add(lblAmarillosValor);
            Controls.Add(lblRojos);
            Controls.Add(lblRojosValor);
            Controls.Add(lblEdadPromedio);
            Controls.Add(lblEdadPromedioValor);
            Controls.Add(lblPorcentajeCriticos);
            Controls.Add(lblPorcentajeCriticosValor);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Estadísticas";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
