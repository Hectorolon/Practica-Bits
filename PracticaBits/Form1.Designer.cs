namespace PracticaBits
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureS2 = new System.Windows.Forms.PictureBox();
            this.pictureS1 = new System.Windows.Forms.PictureBox();
            this.pictureNivel = new System.Windows.Forms.PictureBox();
            this.pictureDireccion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNvFecha = new System.Windows.Forms.TextBox();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(287, 12);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(181, 14);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(234, 284);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 26);
            this.lblFecha.TabIndex = 2;
            // 
            // pictureS2
            // 
            this.pictureS2.Image = global::PracticaBits.Properties.Resources.prendido;
            this.pictureS2.Location = new System.Drawing.Point(39, 181);
            this.pictureS2.Name = "pictureS2";
            this.pictureS2.Size = new System.Drawing.Size(144, 60);
            this.pictureS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureS2.TabIndex = 6;
            this.pictureS2.TabStop = false;
            // 
            // pictureS1
            // 
            this.pictureS1.Image = global::PracticaBits.Properties.Resources.apagado;
            this.pictureS1.Location = new System.Drawing.Point(39, 98);
            this.pictureS1.Name = "pictureS1";
            this.pictureS1.Size = new System.Drawing.Size(144, 60);
            this.pictureS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureS1.TabIndex = 5;
            this.pictureS1.TabStop = false;
            // 
            // pictureNivel
            // 
            this.pictureNivel.Image = global::PracticaBits.Properties.Resources.vacio;
            this.pictureNivel.Location = new System.Drawing.Point(250, 98);
            this.pictureNivel.Name = "pictureNivel";
            this.pictureNivel.Size = new System.Drawing.Size(100, 143);
            this.pictureNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNivel.TabIndex = 4;
            this.pictureNivel.TabStop = false;
            // 
            // pictureDireccion
            // 
            this.pictureDireccion.Image = global::PracticaBits.Properties.Resources.suroeste;
            this.pictureDireccion.Location = new System.Drawing.Point(409, 98);
            this.pictureDireccion.Name = "pictureDireccion";
            this.pictureDireccion.Size = new System.Drawing.Size(160, 143);
            this.pictureDireccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDireccion.TabIndex = 3;
            this.pictureDireccion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Lectura";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(220, 354);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // txtNvFecha
            // 
            this.txtNvFecha.Location = new System.Drawing.Point(220, 440);
            this.txtNvFecha.Name = "txtNvFecha";
            this.txtNvFecha.Size = new System.Drawing.Size(100, 20);
            this.txtNvFecha.TabIndex = 9;
            // 
            // btnAjustar
            // 
            this.btnAjustar.Location = new System.Drawing.Point(220, 397);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(100, 23);
            this.btnAjustar.TabIndex = 10;
            this.btnAjustar.Text = "Ajustar Fecha";
            this.btnAjustar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nivel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sensores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 472);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.txtNvFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureS2);
            this.Controls.Add(this.pictureS1);
            this.Controls.Add(this.pictureNivel);
            this.Controls.Add(this.pictureDireccion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureDireccion;
        private System.Windows.Forms.PictureBox pictureNivel;
        private System.Windows.Forms.PictureBox pictureS1;
        private System.Windows.Forms.PictureBox pictureS2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNvFecha;
        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

