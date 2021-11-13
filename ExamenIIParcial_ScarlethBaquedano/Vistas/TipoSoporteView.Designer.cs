
namespace ExamenIIParcial_ScarlethBaquedano.Vistas
{
    partial class TipoSoporteView
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_SoporteComputadora = new System.Windows.Forms.RadioButton();
            this.rb_SoporteCelular = new System.Windows.Forms.RadioButton();
            this.CelularPanel = new System.Windows.Forms.Panel();
            this.pbx_ServicioCelular = new System.Windows.Forms.PictureBox();
            this.rb_desbloqueoCelular = new System.Windows.Forms.RadioButton();
            this.rb_ReparacionCelular = new System.Windows.Forms.RadioButton();
            this.rb_MantenimientoCelular = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdentidadMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ComputadoraPanel = new System.Windows.Forms.Panel();
            this.pbx_servicioComputo = new System.Windows.Forms.PictureBox();
            this.rb_LimpiezaPC = new System.Windows.Forms.RadioButton();
            this.rb_ReparacionPC = new System.Windows.Forms.RadioButton();
            this.rb_MantenimientoPC = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CelularPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ServicioCelular)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ComputadoraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_servicioComputo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 110);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hello Valentica", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de soporte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_SoporteComputadora);
            this.groupBox1.Controls.Add(this.rb_SoporteCelular);
            this.groupBox1.Location = new System.Drawing.Point(126, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione tipo de soporte";
            // 
            // rb_SoporteComputadora
            // 
            this.rb_SoporteComputadora.AutoSize = true;
            this.rb_SoporteComputadora.Location = new System.Drawing.Point(32, 105);
            this.rb_SoporteComputadora.Name = "rb_SoporteComputadora";
            this.rb_SoporteComputadora.Size = new System.Drawing.Size(184, 25);
            this.rb_SoporteComputadora.TabIndex = 1;
            this.rb_SoporteComputadora.Text = "Equipo de cómputo";
            this.rb_SoporteComputadora.UseVisualStyleBackColor = true;
            // 
            // rb_SoporteCelular
            // 
            this.rb_SoporteCelular.AutoSize = true;
            this.rb_SoporteCelular.Location = new System.Drawing.Point(32, 46);
            this.rb_SoporteCelular.Name = "rb_SoporteCelular";
            this.rb_SoporteCelular.Size = new System.Drawing.Size(99, 25);
            this.rb_SoporteCelular.TabIndex = 0;
            this.rb_SoporteCelular.Text = "Celulares";
            this.rb_SoporteCelular.UseVisualStyleBackColor = true;
            // 
            // CelularPanel
            // 
            this.CelularPanel.Controls.Add(this.pbx_ServicioCelular);
            this.CelularPanel.Controls.Add(this.rb_desbloqueoCelular);
            this.CelularPanel.Controls.Add(this.rb_ReparacionCelular);
            this.CelularPanel.Controls.Add(this.rb_MantenimientoCelular);
            this.CelularPanel.Controls.Add(this.label5);
            this.CelularPanel.Enabled = false;
            this.CelularPanel.Location = new System.Drawing.Point(528, 134);
            this.CelularPanel.Name = "CelularPanel";
            this.CelularPanel.Size = new System.Drawing.Size(460, 263);
            this.CelularPanel.TabIndex = 3;
            // 
            // pbx_ServicioCelular
            // 
            this.pbx_ServicioCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_ServicioCelular.Location = new System.Drawing.Point(242, 70);
            this.pbx_ServicioCelular.Name = "pbx_ServicioCelular";
            this.pbx_ServicioCelular.Size = new System.Drawing.Size(174, 154);
            this.pbx_ServicioCelular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_ServicioCelular.TabIndex = 4;
            this.pbx_ServicioCelular.TabStop = false;
            // 
            // rb_desbloqueoCelular
            // 
            this.rb_desbloqueoCelular.AutoSize = true;
            this.rb_desbloqueoCelular.Location = new System.Drawing.Point(51, 197);
            this.rb_desbloqueoCelular.Name = "rb_desbloqueoCelular";
            this.rb_desbloqueoCelular.Size = new System.Drawing.Size(121, 25);
            this.rb_desbloqueoCelular.TabIndex = 3;
            this.rb_desbloqueoCelular.Text = "Desbloqueo";
            this.rb_desbloqueoCelular.UseVisualStyleBackColor = true;
            // 
            // rb_ReparacionCelular
            // 
            this.rb_ReparacionCelular.AutoSize = true;
            this.rb_ReparacionCelular.Location = new System.Drawing.Point(53, 137);
            this.rb_ReparacionCelular.Name = "rb_ReparacionCelular";
            this.rb_ReparacionCelular.Size = new System.Drawing.Size(119, 25);
            this.rb_ReparacionCelular.TabIndex = 2;
            this.rb_ReparacionCelular.Text = "Reparación";
            this.rb_ReparacionCelular.UseVisualStyleBackColor = true;
            // 
            // rb_MantenimientoCelular
            // 
            this.rb_MantenimientoCelular.AutoSize = true;
            this.rb_MantenimientoCelular.Location = new System.Drawing.Point(53, 82);
            this.rb_MantenimientoCelular.Name = "rb_MantenimientoCelular";
            this.rb_MantenimientoCelular.Size = new System.Drawing.Size(149, 25);
            this.rb_MantenimientoCelular.TabIndex = 1;
            this.rb_MantenimientoCelular.Text = "Mantenimiento";
            this.rb_MantenimientoCelular.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Servicios para celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdentidadMaskedTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(60, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 183);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // IdentidadMaskedTextBox
            // 
            this.IdentidadMaskedTextBox.Location = new System.Drawing.Point(159, 109);
            this.IdentidadMaskedTextBox.Mask = "####-####-#####";
            this.IdentidadMaskedTextBox.Name = "IdentidadMaskedTextBox";
            this.IdentidadMaskedTextBox.Size = new System.Drawing.Size(225, 27);
            this.IdentidadMaskedTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identidad: ";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(159, 44);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(225, 27);
            this.txt_nombre.TabIndex = 5;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(180, 169);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(179, 27);
            this.dtp_fecha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // ComputadoraPanel
            // 
            this.ComputadoraPanel.Controls.Add(this.pbx_servicioComputo);
            this.ComputadoraPanel.Controls.Add(this.rb_LimpiezaPC);
            this.ComputadoraPanel.Controls.Add(this.rb_ReparacionPC);
            this.ComputadoraPanel.Controls.Add(this.rb_MantenimientoPC);
            this.ComputadoraPanel.Controls.Add(this.label6);
            this.ComputadoraPanel.Enabled = false;
            this.ComputadoraPanel.Location = new System.Drawing.Point(528, 413);
            this.ComputadoraPanel.Name = "ComputadoraPanel";
            this.ComputadoraPanel.Size = new System.Drawing.Size(460, 253);
            this.ComputadoraPanel.TabIndex = 5;
            // 
            // pbx_servicioComputo
            // 
            this.pbx_servicioComputo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_servicioComputo.Location = new System.Drawing.Point(258, 68);
            this.pbx_servicioComputo.Name = "pbx_servicioComputo";
            this.pbx_servicioComputo.Size = new System.Drawing.Size(174, 154);
            this.pbx_servicioComputo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_servicioComputo.TabIndex = 4;
            this.pbx_servicioComputo.TabStop = false;
            // 
            // rb_LimpiezaPC
            // 
            this.rb_LimpiezaPC.AutoSize = true;
            this.rb_LimpiezaPC.Location = new System.Drawing.Point(51, 197);
            this.rb_LimpiezaPC.Name = "rb_LimpiezaPC";
            this.rb_LimpiezaPC.Size = new System.Drawing.Size(95, 25);
            this.rb_LimpiezaPC.TabIndex = 3;
            this.rb_LimpiezaPC.Text = "Limpieza";
            this.rb_LimpiezaPC.UseVisualStyleBackColor = true;
            // 
            // rb_ReparacionPC
            // 
            this.rb_ReparacionPC.AutoSize = true;
            this.rb_ReparacionPC.Location = new System.Drawing.Point(53, 137);
            this.rb_ReparacionPC.Name = "rb_ReparacionPC";
            this.rb_ReparacionPC.Size = new System.Drawing.Size(191, 25);
            this.rb_ReparacionPC.TabIndex = 2;
            this.rb_ReparacionPC.Text = "Reparación software";
            this.rb_ReparacionPC.UseVisualStyleBackColor = true;
            // 
            // rb_MantenimientoPC
            // 
            this.rb_MantenimientoPC.AutoSize = true;
            this.rb_MantenimientoPC.Location = new System.Drawing.Point(53, 82);
            this.rb_MantenimientoPC.Name = "rb_MantenimientoPC";
            this.rb_MantenimientoPC.Size = new System.Drawing.Size(149, 25);
            this.rb_MantenimientoPC.TabIndex = 1;
            this.rb_MantenimientoPC.Text = "Mantenimiento";
            this.rb_MantenimientoPC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Servicios para equipo de cómputo";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(167)))), ((int)(((byte)(251)))));
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(292, 603);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 35);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(167)))), ((int)(((byte)(251)))));
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_limpiar.Location = new System.Drawing.Point(147, 603);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 35);
            this.btn_limpiar.TabIndex = 20;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipoSoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(219)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1013, 678);
            this.Controls.Add(this.CelularPanel);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComputadoraPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TipoSoporteView";
            this.Text = "TipoSoporteView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CelularPanel.ResumeLayout(false);
            this.CelularPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ServicioCelular)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ComputadoraPanel.ResumeLayout(false);
            this.ComputadoraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_servicioComputo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dtp_fecha;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel ComputadoraPanel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel CelularPanel;
        public System.Windows.Forms.RadioButton rb_SoporteComputadora;
        public System.Windows.Forms.RadioButton rb_SoporteCelular;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox IdentidadMaskedTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.RadioButton rb_MantenimientoCelular;
        public System.Windows.Forms.RadioButton rb_ReparacionCelular;
        public System.Windows.Forms.PictureBox pbx_ServicioCelular;
        public System.Windows.Forms.RadioButton rb_desbloqueoCelular;
        public System.Windows.Forms.PictureBox pbx_servicioComputo;
        public System.Windows.Forms.RadioButton rb_LimpiezaPC;
        public System.Windows.Forms.RadioButton rb_ReparacionPC;
        public System.Windows.Forms.RadioButton rb_MantenimientoPC;
    }
}