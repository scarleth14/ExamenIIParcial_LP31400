
namespace ExamenIIParcial_ScarlethBaquedano.Vistas
{
    partial class EstadoTicketView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_estadoTicket = new System.Windows.Forms.ComboBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.dtp_fechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(208)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 128);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hello Valentica", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado del ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre cliente";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(64, 194);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(239, 27);
            this.txt_nombreCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccione el estado del ticket";
            // 
            // cb_estadoTicket
            // 
            this.cb_estadoTicket.FormattingEnabled = true;
            this.cb_estadoTicket.Items.AddRange(new object[] {
            "Sin resolver",
            "Abierto",
            "En espera",
            "Cerrado"});
            this.cb_estadoTicket.Location = new System.Drawing.Point(202, 297);
            this.cb_estadoTicket.Name = "cb_estadoTicket";
            this.cb_estadoTicket.Size = new System.Drawing.Size(243, 29);
            this.cb_estadoTicket.TabIndex = 8;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(212, 345);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(107, 42);
            this.btn_aceptar.TabIndex = 9;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // dtp_fechaSolicitud
            // 
            this.dtp_fechaSolicitud.Enabled = false;
            this.dtp_fechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaSolicitud.Location = new System.Drawing.Point(375, 192);
            this.dtp_fechaSolicitud.Name = "dtp_fechaSolicitud";
            this.dtp_fechaSolicitud.Size = new System.Drawing.Size(200, 27);
            this.dtp_fechaSolicitud.TabIndex = 10;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(353, 345);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(107, 42);
            this.btn_limpiar.TabIndex = 11;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // EstadoTicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 409);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.dtp_fechaSolicitud);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.cb_estadoTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EstadoTicketView";
            this.Text = "EstadoTicketView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_nombreCliente;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_estadoTicket;
        public System.Windows.Forms.Button btn_aceptar;
        public System.Windows.Forms.DateTimePicker dtp_fechaSolicitud;
        public System.Windows.Forms.Button btn_limpiar;
    }
}