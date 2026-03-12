namespace Fabrica_abstracta
{
    partial class Form1
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
            this.Iniciar = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // Iniciar
            // 
            this.Iniciar.Location = new System.Drawing.Point(507, 429);
            this.Iniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(112, 35);
            this.Iniciar.TabIndex = 0;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.inicio.Image = global::Fabrica_abstracta.Properties.Resources.comida;
            this.inicio.Location = new System.Drawing.Point(382, 82);
            this.inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(350, 315);
            this.inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inicio.TabIndex = 1;
            this.inicio.TabStop = false;
//            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.Iniciar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Menu";
//            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.PictureBox inicio;
    }
}

