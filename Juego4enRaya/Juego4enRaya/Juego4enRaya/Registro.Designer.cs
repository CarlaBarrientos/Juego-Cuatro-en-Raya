namespace Juego4enRaya
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.buttonJUGAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrimerJugador = new System.Windows.Forms.TextBox();
            this.SegundaJugador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonJUGAR
            // 
            this.buttonJUGAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonJUGAR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJUGAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonJUGAR.Location = new System.Drawing.Point(257, 327);
            this.buttonJUGAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonJUGAR.Name = "buttonJUGAR";
            this.buttonJUGAR.Size = new System.Drawing.Size(125, 42);
            this.buttonJUGAR.TabIndex = 3;
            this.buttonJUGAR.Text = "JUGAR";
            this.buttonJUGAR.UseVisualStyleBackColor = false;
            this.buttonJUGAR.Click += new System.EventHandler(this.buttonJUGAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primer Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segundo Jugador";
            // 
            // PrimerJugador
            // 
            this.PrimerJugador.Location = new System.Drawing.Point(350, 166);
            this.PrimerJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrimerJugador.Name = "PrimerJugador";
            this.PrimerJugador.Size = new System.Drawing.Size(164, 22);
            this.PrimerJugador.TabIndex = 6;
            // 
            // SegundaJugador
            // 
            this.SegundaJugador.Location = new System.Drawing.Point(350, 241);
            this.SegundaJugador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SegundaJugador.Name = "SegundaJugador";
            this.SegundaJugador.Size = new System.Drawing.Size(165, 22);
            this.SegundaJugador.TabIndex = 7;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 427);
            this.Controls.Add(this.SegundaJugador);
            this.Controls.Add(this.PrimerJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonJUGAR);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJUGAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimerJugador;
        private System.Windows.Forms.TextBox SegundaJugador;
    }
}