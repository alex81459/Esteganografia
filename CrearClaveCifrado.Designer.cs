namespace Esteganografia
{
    partial class CrearClaveCifrado
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
            this.txtClave1 = new System.Windows.Forms.TextBox();
            this.txtClave2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelarCifrado = new System.Windows.Forms.Button();
            this.btnContinuarCifrado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClave1
            // 
            this.txtClave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave1.Location = new System.Drawing.Point(130, 12);
            this.txtClave1.MaxLength = 30;
            this.txtClave1.Name = "txtClave1";
            this.txtClave1.PasswordChar = '*';
            this.txtClave1.Size = new System.Drawing.Size(273, 21);
            this.txtClave1.TabIndex = 0;
            // 
            // txtClave2
            // 
            this.txtClave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave2.Location = new System.Drawing.Point(130, 43);
            this.txtClave2.MaxLength = 30;
            this.txtClave2.Name = "txtClave2";
            this.txtClave2.PasswordChar = '*';
            this.txtClave2.Size = new System.Drawing.Size(273, 21);
            this.txtClave2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancelarCifrado);
            this.panel1.Controls.Add(this.btnContinuarCifrado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtClave1);
            this.panel1.Controls.Add(this.txtClave2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 181);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Se Recomienda una clave que contenga minusculas, \r\nmaysuculas, numeros y simbolos" +
    " para que se \r\nmantenga mas segura la informacion";
            // 
            // btnCancelarCifrado
            // 
            this.btnCancelarCifrado.BackColor = System.Drawing.Color.Red;
            this.btnCancelarCifrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCifrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCifrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCifrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCifrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCifrado.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCifrado.Location = new System.Drawing.Point(271, 149);
            this.btnCancelarCifrado.Name = "btnCancelarCifrado";
            this.btnCancelarCifrado.Size = new System.Drawing.Size(123, 22);
            this.btnCancelarCifrado.TabIndex = 6;
            this.btnCancelarCifrado.Text = "Cancelar Cifrado";
            this.btnCancelarCifrado.UseVisualStyleBackColor = false;
            this.btnCancelarCifrado.Click += new System.EventHandler(this.btnCancelarCifrado_Click);
            // 
            // btnContinuarCifrado
            // 
            this.btnContinuarCifrado.BackColor = System.Drawing.Color.Lime;
            this.btnContinuarCifrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuarCifrado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContinuarCifrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContinuarCifrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnContinuarCifrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuarCifrado.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarCifrado.Location = new System.Drawing.Point(136, 149);
            this.btnContinuarCifrado.Name = "btnContinuarCifrado";
            this.btnContinuarCifrado.Size = new System.Drawing.Size(127, 22);
            this.btnContinuarCifrado.TabIndex = 5;
            this.btnContinuarCifrado.Text = "Continuar Cifrado";
            this.btnContinuarCifrado.UseVisualStyleBackColor = false;
            this.btnContinuarCifrado.Click += new System.EventHandler(this.btnContinuarCifrado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repita Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave Cifrado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esteganografia.Properties.Resources.llave;
            this.pictureBox1.Location = new System.Drawing.Point(25, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CrearClaveCifrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(453, 210);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearClaveCifrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaveCifrado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave1;
        private System.Windows.Forms.TextBox txtClave2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarCifrado;
        private System.Windows.Forms.Button btnContinuarCifrado;
        private System.Windows.Forms.Label label3;
    }
}