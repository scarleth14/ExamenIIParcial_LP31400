
namespace ExamenIIParcial_ScarlethBaquedano.Vistas
{
    partial class TicketView
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
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_tipoSoporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_estadoTicket = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_generarTicket = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_numeroTicket = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre cliente";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(34, 232);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.ReadOnly = true;
            this.txt_nombreCliente.Size = new System.Drawing.Size(295, 27);
            this.txt_nombreCliente.TabIndex = 1;
            // 
            // txt_tipoSoporte
            // 
            this.txt_tipoSoporte.Location = new System.Drawing.Point(34, 333);
            this.txt_tipoSoporte.Name = "txt_tipoSoporte";
            this.txt_tipoSoporte.ReadOnly = true;
            this.txt_tipoSoporte.Size = new System.Drawing.Size(295, 27);
            this.txt_tipoSoporte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de soporte solicitado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado del ticket";
            // 
            // txt_estadoTicket
            // 
            this.txt_estadoTicket.Location = new System.Drawing.Point(34, 437);
            this.txt_estadoTicket.Name = "txt_estadoTicket";
            this.txt_estadoTicket.ReadOnly = true;
            this.txt_estadoTicket.Size = new System.Drawing.Size(295, 27);
            this.txt_estadoTicket.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(142)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 99);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hello Valentica", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 75);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ticket";
            // 
            // btn_generarTicket
            // 
            this.btn_generarTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(63)))));
            this.btn_generarTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarTicket.Location = new System.Drawing.Point(39, 492);
            this.btn_generarTicket.Name = "btn_generarTicket";
            this.btn_generarTicket.Size = new System.Drawing.Size(124, 50);
            this.btn_generarTicket.TabIndex = 9;
            this.btn_generarTicket.Text = "Generar ticket";
            this.btn_generarTicket.UseVisualStyleBackColor = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(63)))));
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(210, 492);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(124, 50);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // txt_numeroTicket
            // 
            this.txt_numeroTicket.Location = new System.Drawing.Point(124, 154);
            this.txt_numeroTicket.Name = "txt_numeroTicket";
            this.txt_numeroTicket.ReadOnly = true;
            this.txt_numeroTicket.Size = new System.Drawing.Size(142, 27);
            this.txt_numeroTicket.TabIndex = 11;
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(382, 580);
            this.Controls.Add(this.txt_numeroTicket);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_generarTicket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_estadoTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tipoSoporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketView";
            this.Text = "TicketView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_nombreCliente;
        public System.Windows.Forms.TextBox txt_tipoSoporte;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_estadoTicket;
        public System.Windows.Forms.Button btn_generarTicket;
        public System.Windows.Forms.Button btn_limpiar;
        public System.Windows.Forms.TextBox txt_numeroTicket;
    }
}