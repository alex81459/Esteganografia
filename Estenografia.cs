using System;
using System.Drawing;
using System.Windows.Forms;

namespace Esteganografia
{
    public partial class Estenografo : Form
    {
        public Estenografo()
        {
            InitializeComponent();
        }

        //Se estrablecen las variables de ubicacion y estado el form
        private Point posicion = Point.Empty;
        private bool moviendo = false;
        //Se crea la variable BMP donde se procesara la imagen
        Bitmap bmp = null;

        private void btnImagenCargar_Click(object sender, EventArgs e)
        {
            btnMostrarTexto.Enabled = false;
            btnEliminarTextoOculto.Enabled = false;

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    btnOcultarMensaje.Enabled = true;
                    lblEstadoTexto.ForeColor = Color.Lime;
                    lblEstadoTexto.Text = "A Ingresar a la Imagen";

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una Imagen de Formato JPG, PNG o BMP", "Elegir Imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Intentar cargar la Imagen Seleccionada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnOcultarMensaje_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                CrearClaveCifrado fr = new CrearClaveCifrado(textBox1.Text);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    String MensajeCifrado = fr.MensajeCifrado;

                    bmp = (Bitmap)pictureBox1.Image;

                    bmp = Esteganografia.IntroducirTexto(MensajeCifrado, bmp);
                    MessageBox.Show("El Texto fue Ocultado dentro de la Imagen", "Proceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    btnGuardarImagen.Enabled = true;
                    btnMostrarTexto.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Debe de crear una clave para ocultar el texto dento de la imagen", "Clave Necesaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe de ingresar algun texto para ocultar dentro de la imagen","No hata texto",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }


        private void btnImagenMensajeOculto_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPG Imagen|*.jpg|PNG Imagen|*.png|BMP Imagen|*.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    MessageBox.Show("La imagen fue Guardada en la Ubicacion Seleccionada", "Imagen Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    btnOcultarMensaje.Enabled = false;
                    btnGuardarImagen.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Intentar Guardar la Imagen","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            string textoextraido = Esteganografia.ExtraerTexto(bmp);
           
            IngresarClaveCifrado fr2 = new IngresarClaveCifrado(textoextraido);
            if (fr2.ShowDialog() == DialogResult.OK)
            {
                String MensajeDescifrado= fr2.MensajeDesCifrado;

                textBox1.Text = MensajeDescifrado;

                lblEstadoTexto.ForeColor = Color.Red;
                lblEstadoTexto.Text = "Extraido de Imagen";
                btnEliminarTextoOculto.Enabled = true;
                btnOcultarMensaje.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe de ingresar la clave para desencriptar el mensaje oculto dentro de la imagen", "Clave Necesaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnOcultarMensaje.Enabled = false;
            btnGuardarImagen.Enabled = false;

            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                    btnOcultarMensaje.Enabled = true;
                    lblEstadoTexto.ForeColor = Color.Lime;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    lblEstadoTexto.Text = "A Ingresar a la Imagen";
                    btnMostrarTexto.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una Imagen de Formato JPG, PNG o BMP", "Elegir Imagen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar abrir la Imagen con el Texto Oculto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEliminarTextoOculto_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = (Bitmap)pictureBox1.Image;
                string text = textBox1.Text;
                bmp = Esteganografia.IntroducirTexto("", bmp);
                textBox1.Text = "";

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPG Imagen|*.jpg|PNG Imagen|*.png|BMP Imagen|*.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    MessageBox.Show("El oculto Texto de la Imagen a sido Borrado", "Texto Oculto Borrado en la Imagen Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;

                    btnMostrarTexto.Enabled = false;
                    btnEliminarTextoOculto.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Intentar Guardar la Imagen con el Texto Oculto Borrado", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(e.X, e.Y);
            moviendo = true;
        }

        private void Barra_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
        }

        private void Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendo)
            {
                this.Location = new Point((this.Left + e.X - posicion.X),(this.Top + e.Y - posicion.Y));
            }
        }


    }
}
