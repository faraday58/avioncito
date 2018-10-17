namespace avioncito
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.tiempojuego = new System.Windows.Forms.Timer(this.components);
            this.btn_detener = new System.Windows.Forms.Button();
            this.btn_arriba = new System.Windows.Forms.Button();
            this.btn_izquierda = new System.Windows.Forms.Button();
            this.btn_derecha = new System.Windows.Forms.Button();
            this.btn_abajo = new System.Windows.Forms.Button();
            this.pc_misil = new System.Windows.Forms.PictureBox();
            this.pc_avion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_misil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_avion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(434, 289);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // tiempojuego
            // 
            this.tiempojuego.Tick += new System.EventHandler(this.tiempojuego_Tick);
            // 
            // btn_detener
            // 
            this.btn_detener.Location = new System.Drawing.Point(515, 289);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 1;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // btn_arriba
            // 
            this.btn_arriba.Location = new System.Drawing.Point(287, 268);
            this.btn_arriba.Name = "btn_arriba";
            this.btn_arriba.Size = new System.Drawing.Size(37, 28);
            this.btn_arriba.TabIndex = 2;
            this.btn_arriba.Text = "Ar";
            this.btn_arriba.UseVisualStyleBackColor = true;
            this.btn_arriba.Click += new System.EventHandler(this.btn_arriba_Click);
            // 
            // btn_izquierda
            // 
            this.btn_izquierda.Location = new System.Drawing.Point(231, 298);
            this.btn_izquierda.Name = "btn_izquierda";
            this.btn_izquierda.Size = new System.Drawing.Size(37, 28);
            this.btn_izquierda.TabIndex = 2;
            this.btn_izquierda.Text = "Iz";
            this.btn_izquierda.UseVisualStyleBackColor = true;
            this.btn_izquierda.Click += new System.EventHandler(this.btn_izquierda_Click);
            // 
            // btn_derecha
            // 
            this.btn_derecha.Location = new System.Drawing.Point(342, 298);
            this.btn_derecha.Name = "btn_derecha";
            this.btn_derecha.Size = new System.Drawing.Size(37, 28);
            this.btn_derecha.TabIndex = 2;
            this.btn_derecha.Text = "derecha";
            this.btn_derecha.UseVisualStyleBackColor = true;
            this.btn_derecha.Click += new System.EventHandler(this.btn_derecha_Click);
            // 
            // btn_abajo
            // 
            this.btn_abajo.Location = new System.Drawing.Point(287, 337);
            this.btn_abajo.Name = "btn_abajo";
            this.btn_abajo.Size = new System.Drawing.Size(37, 28);
            this.btn_abajo.TabIndex = 2;
            this.btn_abajo.Text = "Ab";
            this.btn_abajo.UseVisualStyleBackColor = true;
            this.btn_abajo.Click += new System.EventHandler(this.btn_abajo_Click);
            // 
            // pc_misil
            // 
            this.pc_misil.Image = global::avioncito.Properties.Resources.rocket1;
            this.pc_misil.Location = new System.Drawing.Point(190, 34);
            this.pc_misil.Name = "pc_misil";
            this.pc_misil.Size = new System.Drawing.Size(33, 38);
            this.pc_misil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_misil.TabIndex = 4;
            this.pc_misil.TabStop = false;
            // 
            // pc_avion
            // 
            this.pc_avion.Image = global::avioncito.Properties.Resources.avion;
            this.pc_avion.Location = new System.Drawing.Point(301, 149);
            this.pc_avion.Name = "pc_avion";
            this.pc_avion.Size = new System.Drawing.Size(90, 72);
            this.pc_avion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc_avion.TabIndex = 3;
            this.pc_avion.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 390);
            this.Controls.Add(this.pc_misil);
            this.Controls.Add(this.pc_avion);
            this.Controls.Add(this.btn_izquierda);
            this.Controls.Add(this.btn_abajo);
            this.Controls.Add(this.btn_derecha);
            this.Controls.Add(this.btn_arriba);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pc_misil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_avion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Timer tiempojuego;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.Button btn_arriba;
        private System.Windows.Forms.Button btn_izquierda;
        private System.Windows.Forms.Button btn_derecha;
        private System.Windows.Forms.Button btn_abajo;
        private System.Windows.Forms.PictureBox pc_avion;
        private System.Windows.Forms.PictureBox pc_misil;
    }
}

