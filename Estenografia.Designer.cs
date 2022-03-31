namespace Esteganografia
{
    partial class Estenografo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estenografo));
            this.btnImagenCargarOcultar = new System.Windows.Forms.Button();
            this.btnOcultarMensaje = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstadoTexto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnMostrarTexto = new System.Windows.Forms.Button();
            this.btnEliminarTextoOculto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Barra = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagenCargarOcultar
            // 
            this.btnImagenCargarOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImagenCargarOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagenCargarOcultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImagenCargarOcultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnImagenCargarOcultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnImagenCargarOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagenCargarOcultar.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagenCargarOcultar.Location = new System.Drawing.Point(5, 148);
            this.btnImagenCargarOcultar.Name = "btnImagenCargarOcultar";
            this.btnImagenCargarOcultar.Size = new System.Drawing.Size(96, 22);
            this.btnImagenCargarOcultar.TabIndex = 0;
            this.btnImagenCargarOcultar.Text = "Buscar Imagen";
            this.btnImagenCargarOcultar.UseVisualStyleBackColor = false;
            this.btnImagenCargarOcultar.Click += new System.EventHandler(this.btnImagenCargar_Click);
            // 
            // btnOcultarMensaje
            // 
            this.btnOcultarMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(62)))));
            this.btnOcultarMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarMensaje.Enabled = false;
            this.btnOcultarMensaje.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOcultarMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnOcultarMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnOcultarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcultarMensaje.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcultarMensaje.Location = new System.Drawing.Point(5, 239);
            this.btnOcultarMensaje.Name = "btnOcultarMensaje";
            this.btnOcultarMensaje.Size = new System.Drawing.Size(96, 22);
            this.btnOcultarMensaje.TabIndex = 1;
            this.btnOcultarMensaje.Text = "Ocultar Texto";
            this.btnOcultarMensaje.UseVisualStyleBackColor = false;
            this.btnOcultarMensaje.Click += new System.EventHandler(this.btnOcultarMensaje_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(115, 383);
            this.textBox1.MaxLength = 500;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(473, 90);
            this.textBox1.TabIndex = 5;
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarImagen.Enabled = false;
            this.btnGuardarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarImagen.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarImagen.Location = new System.Drawing.Point(5, 329);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(96, 47);
            this.btnGuardarImagen.TabIndex = 7;
            this.btnGuardarImagen.Text = "Guardar Imagen Con Texto Oculto";
            this.btnGuardarImagen.UseVisualStyleBackColor = false;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnImagenMensajeOculto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Texto ";
            // 
            // lblEstadoTexto
            // 
            this.lblEstadoTexto.AutoSize = true;
            this.lblEstadoTexto.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTexto.ForeColor = System.Drawing.Color.Lime;
            this.lblEstadoTexto.Location = new System.Drawing.Point(218, 360);
            this.lblEstadoTexto.Name = "lblEstadoTexto";
            this.lblEstadoTexto.Size = new System.Drawing.Size(147, 14);
            this.lblEstadoTexto.TabIndex = 9;
            this.lblEstadoTexto.Text = "A Ingresar a la Imagen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnImagenCargarOcultar);
            this.panel1.Controls.Add(this.btnOcultarMensaje);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnGuardarImagen);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 402);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ocultar \r\nTexto \r\nEn Imagen";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Esteganografia.Properties.Resources.discoflexible;
            this.pictureBox5.Location = new System.Drawing.Point(5, 267);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 56);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Esteganografia.Properties.Resources.ojo;
            this.pictureBox3.Location = new System.Drawing.Point(5, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Esteganografia.Properties.Resources.carpeta;
            this.pictureBox2.Location = new System.Drawing.Point(4, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.btnAbrirImagen);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.btnMostrarTexto);
            this.panel2.Controls.Add(this.btnEliminarTextoOculto);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(590, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 402);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Esteganografia.Properties.Resources.caja;
            this.pictureBox4.Location = new System.Drawing.Point(4, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "Extraer \r\nTexto \r\nDe Imagen";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Esteganografia.Properties.Resources.gomaborrar;
            this.pictureBox6.Location = new System.Drawing.Point(4, 275);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 56);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.BackColor = System.Drawing.Color.Peru;
            this.btnAbrirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirImagen.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirImagen.Location = new System.Drawing.Point(4, 150);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(96, 22);
            this.btnAbrirImagen.TabIndex = 0;
            this.btnAbrirImagen.Text = "Abrir Imagen";
            this.btnAbrirImagen.UseVisualStyleBackColor = false;
            this.btnAbrirImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Esteganografia.Properties.Resources.ojover;
            this.pictureBox7.Location = new System.Drawing.Point(4, 180);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 56);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // btnMostrarTexto
            // 
            this.btnMostrarTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.btnMostrarTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTexto.Enabled = false;
            this.btnMostrarTexto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarTexto.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTexto.Location = new System.Drawing.Point(4, 242);
            this.btnMostrarTexto.Name = "btnMostrarTexto";
            this.btnMostrarTexto.Size = new System.Drawing.Size(96, 24);
            this.btnMostrarTexto.TabIndex = 2;
            this.btnMostrarTexto.Text = "Mostrar Texto";
            this.btnMostrarTexto.UseVisualStyleBackColor = false;
            this.btnMostrarTexto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminarTextoOculto
            // 
            this.btnEliminarTextoOculto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(224)))), ((int)(((byte)(195)))));
            this.btnEliminarTextoOculto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTextoOculto.Enabled = false;
            this.btnEliminarTextoOculto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTextoOculto.Font = new System.Drawing.Font("Orbitron", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTextoOculto.Location = new System.Drawing.Point(4, 337);
            this.btnEliminarTextoOculto.Name = "btnEliminarTextoOculto";
            this.btnEliminarTextoOculto.Size = new System.Drawing.Size(96, 42);
            this.btnEliminarTextoOculto.TabIndex = 7;
            this.btnEliminarTextoOculto.Text = "Eliminar Texto Oculto de La Imagen";
            this.btnEliminarTextoOculto.UseVisualStyleBackColor = false;
            this.btnEliminarTextoOculto.Click += new System.EventHandler(this.btnEliminarTextoOculto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 5.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(3, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "A7D22B68F848D3CD\r\nC8D929F82111CF17";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orbitron", 5.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(590, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "EDC44391D23634C5\r\n7E3E3B1B2A50B7AB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(169, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Imagen Selecicionada";
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Barra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Barra.Controls.Add(this.pictureBox12);
            this.Barra.Controls.Add(this.pictureBox10);
            this.Barra.Controls.Add(this.pictureBox11);
            this.Barra.Controls.Add(this.label7);
            this.Barra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(701, 22);
            this.Barra.TabIndex = 21;
            this.Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseDown);
            this.Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseMove);
            this.Barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Barra_MouseUp);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox12.Image = global::Esteganografia.Properties.Resources.ocultar;
            this.pictureBox12.Location = new System.Drawing.Point(5, -4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(28, 28);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 25;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::Esteganografia.Properties.Resources.minimizarlaventana;
            this.pictureBox10.Location = new System.Drawing.Point(649, -4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Image = global::Esteganografia.Properties.Resources.cerrarventana;
            this.pictureBox11.Location = new System.Drawing.Point(673, -4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(28, 28);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "ESTENOGRAFIA v2.1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Esteganografia.Properties.Resources.imagen;
            this.pictureBox9.Location = new System.Drawing.Point(136, 25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(28, 28);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Esteganografia.Properties.Resources.bloc;
            this.pictureBox8.Location = new System.Drawing.Point(139, 353);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Esteganografia.Properties.Resources.pregunta;
            this.pictureBox1.InitialImage = global::Esteganografia.Properties.Resources.pregunta;
            this.pictureBox1.Location = new System.Drawing.Point(115, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Estenografo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(701, 477);
            this.Controls.Add(this.Barra);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstadoTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Estenografo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estenografo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.Barra.ResumeLayout(false);
            this.Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagenCargarOcultar;
        private System.Windows.Forms.Button btnOcultarMensaje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstadoTexto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnMostrarTexto;
        private System.Windows.Forms.Button btnEliminarTextoOculto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel Barra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

