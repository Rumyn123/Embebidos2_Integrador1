namespace Embebidos2_integrador1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.trkVelocidad = new System.Windows.Forms.TrackBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.lblIzq = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAcercaDe);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.Silver;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnOff.Location = new System.Drawing.Point(91, 203);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(262, 43);
            this.btnOnOff.TabIndex = 1;
            this.btnOnOff.Text = "Encender / Apagar";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(86, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CONTROL DE MOTOR";
            // 
            // btnGiro
            // 
            this.btnGiro.BackColor = System.Drawing.Color.Silver;
            this.btnGiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiro.Location = new System.Drawing.Point(91, 269);
            this.btnGiro.Name = "btnGiro";
            this.btnGiro.Size = new System.Drawing.Size(262, 43);
            this.btnGiro.TabIndex = 3;
            this.btnGiro.Text = "Derecha / Izquierda";
            this.btnGiro.UseVisualStyleBackColor = false;
            this.btnGiro.Click += new System.EventHandler(this.btnGiro_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Embebidos2_integrador1.Properties.Resources.x_mark;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(386, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackgroundImage = global::Embebidos2_integrador1.Properties.Resources.ArduinoIcono;
            this.btnAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Location = new System.Drawing.Point(3, 3);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(35, 35);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // trkVelocidad
            // 
            this.trkVelocidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkVelocidad.LargeChange = 1;
            this.trkVelocidad.Location = new System.Drawing.Point(91, 348);
            this.trkVelocidad.Maximum = 9;
            this.trkVelocidad.Name = "trkVelocidad";
            this.trkVelocidad.Size = new System.Drawing.Size(262, 45);
            this.trkVelocidad.TabIndex = 4;
            this.trkVelocidad.ValueChanged += new System.EventHandler(this.trkVelocidad_ValueChanged);
            this.trkVelocidad.CursorChanged += new System.EventHandler(this.trkVelocidad_CursorChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(162, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ESTADO";
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblOnOff.Location = new System.Drawing.Point(86, 463);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(60, 25);
            this.lblOnOff.TabIndex = 5;
            this.lblOnOff.Text = "OFF";
            // 
            // lblIzq
            // 
            this.lblIzq.AutoSize = true;
            this.lblIzq.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzq.ForeColor = System.Drawing.Color.Cyan;
            this.lblIzq.Location = new System.Drawing.Point(184, 463);
            this.lblIzq.Name = "lblIzq";
            this.lblIzq.Size = new System.Drawing.Size(54, 25);
            this.lblIzq.TabIndex = 6;
            this.lblIzq.Text = "IZQ";
            this.lblIzq.Click += new System.EventHandler(this.lblIzq_Click);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblV.Location = new System.Drawing.Point(286, 463);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(69, 25);
            this.lblV.TabIndex = 7;
            this.lblV.Text = "V = 0";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.BackColor = System.Drawing.Color.Silver;
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(91, 141);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(262, 21);
            this.cmbPuertos.TabIndex = 8;
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbPuertos_SelectedIndexChanged);
            this.cmbPuertos.Click += new System.EventHandler(this.cmbPuertos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(426, 501);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblIzq);
            this.Controls.Add(this.lblOnOff);
            this.Controls.Add(this.trkVelocidad);
            this.Controls.Add(this.btnGiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Motor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trkVelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiro;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TrackBar trkVelocidad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOnOff;
        private System.Windows.Forms.Label lblIzq;
        private System.Windows.Forms.Label lblV;
        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.ComboBox cmbPuertos;
    }
}