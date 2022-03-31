using System;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;
using System.Security.Cryptography;

namespace Esteganografia
{
    public partial class CrearClaveCifrado : Form
    {

        public String MensajeCifrado { get; set; }

        public CrearClaveCifrado(String MensajeSinCifrar)
        {
            InitializeComponent();
            MensajeOriginal = MensajeSinCifrar;
        }
        String MensajeOriginal;

        static readonly Encoding Encoding = Encoding.UTF8;

        public string BlowfishEncriptador(string TextoACifrar, string ClaveCifrado)
        {
            try
            {
                BlowfishEngine motorBlowfish = new BlowfishEngine();
                PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(motorBlowfish);
                KeyParameter bytsClave = new KeyParameter(Encoding.GetBytes(ClaveCifrado));
                cipher.Init(true, bytsClave);
                byte[] EntradaTextoACifrar = Encoding.GetBytes(TextoACifrar);
                byte[] SalidaTextoACifrar = new byte[cipher.GetOutputSize(EntradaTextoACifrar.Length)];
                int len1 = cipher.ProcessBytes(EntradaTextoACifrar, 0, EntradaTextoACifrar.Length, SalidaTextoACifrar, 0);
                cipher.DoFinal(SalidaTextoACifrar, len1);
                return BitConverter.ToString(SalidaTextoACifrar).Replace("-", "");
            }
            catch (Exception)
            {
                //Si hay un error durante el proceso de cifrado
                return "ERROR: SE A PRODUCIDO UN ERROR AL INTENTAR CIFRAR EL TEXTO";
            }
        }

        public static string GenerarSHA512String(string TextoAHash)
        {
            var sha512 = new SHA512Managed();
            var bytes = UTF8Encoding.UTF8.GetBytes(TextoAHash);
            var hash = sha512.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }


        private void btnContinuarCifrado_Click(object sender, EventArgs e)
        {
            if (txtClave1.Text == txtClave2.Text)
            {
                if (txtClave1.Text.Length >= 8)
                {

                    String SHA512deClave = GenerarSHA512String(txtClave1.Text);

                    //Se llama a la funcion para cifrar y se envian los datos
                    MensajeCifrado = BlowfishEncriptador(MensajeOriginal, SHA512deClave);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Clave es demasiado corta, debe tener 8 o mas caracteres", "Clave Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La Clave De Cifrado y La Repeticion de la Clave no son iguales por favor reingreselas", "Claves Diferentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave1.Text = "";
                txtClave2.Text = "";
            }
        }

        private void btnCancelarCifrado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
