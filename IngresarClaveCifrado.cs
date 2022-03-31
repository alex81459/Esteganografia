using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities.Encoders;

namespace Esteganografia
{
    public partial class IngresarClaveCifrado : Form
    {
        public IngresarClaveCifrado(String StringCifrado)
        {
            InitializeComponent();
            MensajeCifrado = StringCifrado;
        }

        String MensajeCifrado;

        public String MensajeDesCifrado { get; set; }

        static readonly Encoding Encoding = Encoding.UTF8;

        public string BlowfishDesencriptador(string TextoCifrado, string ClaveCifrado)
        {
            BlowfishEngine MotoroBlowFish = new BlowfishEngine();
            PaddedBufferedBlockCipher cipher = new PaddedBufferedBlockCipher(MotoroBlowFish);
            StringBuilder Resultado = new StringBuilder();
            cipher.Init(false, new KeyParameter(Encoding.GetBytes(ClaveCifrado)));
            byte[] EntradaTextoACifrado = Hex.Decode(TextoCifrado);
            byte[] SalidaTextoCifrado = new byte[cipher.GetOutputSize(EntradaTextoACifrado.Length)];
            int LargoCifradoTexto = cipher.ProcessBytes(EntradaTextoACifrado, 0, EntradaTextoACifrado.Length, SalidaTextoCifrado, 0);

            try
            {
                cipher.DoFinal(SalidaTextoCifrado, LargoCifradoTexto);
                String s2 = BitConverter.ToString(SalidaTextoCifrado);
                for (int i = 0; i < s2.Length; i++)
                {
                    char c = s2[i];
                    if (c != 0)
                    {
                        Resultado.Append(c.ToString());
                    }
                }
                return Resultado.ToString();
            }
            catch (Exception)
            {
                //Error al intentar decifrar el texto, probablemente por clave erronea o texto dañado, se envia el error en Hexadecimal
                return "45-52-52-4f-52-3a-20-4c-41-20-43-4c-41-56-45-20-49-4e-47-52-45-53-41-44-41-20-4e-4f-20-45-53-20-43-4f-52-52-45-43-54-41-20-50-4f-52-20-46-41-56-4f-52-20-56-55-45-4c-56-41-20-41-20-49-4e-47-52-45-53-41-52-4c-41";
            }
        }

        public static byte[] HexadecimalAByts(string hexadecimal)
        {
            hexadecimal = hexadecimal.Replace("-", "");
            byte[] raw = new byte[hexadecimal.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hexadecimal.Substring(i * 2, 2), 16);
            }
            return raw;
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
            if (txtClave1.Text != "")
            {
                String SHA512deClave = GenerarSHA512String(txtClave1.Text);

                //Se llama a la funcion Descifrar se envian los datos y se paso su resultado de byts a string en ASCII
                String TextoHexadecimal = BlowfishDesencriptador(MensajeCifrado, SHA512deClave);
                byte[] bytsMensaje = HexadecimalAByts(TextoHexadecimal);
                MensajeDesCifrado = Encoding.ASCII.GetString(bytsMensaje);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe de ingresar una clave para comenzar el descifrado del mensaje","Ingrese clave",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelarCifrado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
