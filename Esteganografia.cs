using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Esteganografia
{
    class Esteganografia
    {
        public enum Estado
        {
            Ocultado,
            Relleno_Con_Ceros
        }

        public static Bitmap IntroducirTexto(string Texto, Bitmap bmp)
        {
            //Inicialmente, ocultaremos los caracteres de la imagen...
            Estado status = Estado.Ocultado;

            //tiene el índice del caracter que se está ocultando
            int indiceCarecteres = 0;

            //mantiene el valor del carácter convertido en entero
            int valorCaracter = 0;

            //contiene el índice del elemento de color (R o G o B) que se está procesando actualmente
            long IndiceElementoPixel = 0;

            //contiene el número de ceros finales que se han añadido al terminar el proceso
            int ceros = 0;

            //mantiene los elementos de los píxeles
            int R = 0, G = 0, B = 0;

            //Pasa por las filas
            for (int i = 0; i < bmp.Height; i++)
            {
                //Pasa por cada fila
                for (int j = 0; j < bmp.Width; j++)
                {
                    //Contiene el píxel que se está procesando actualmente
                    Color pixel = bmp.GetPixel(j, i);

                    //Ahora, borra el bit menos significativo (LSB) de cada elemento del píxel
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    //para cada píxel, pasa a través de sus elementos (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        //comprobar si se han procesado los nuevos 8 bits 
                        if (IndiceElementoPixel % 8 == 0)
                        {
                            //comprobar si todo el proceso ha terminado
                            //Podemos decir que está terminado cuando se añaden 8 ceros.
                            if (status == Estado.Relleno_Con_Ceros && ceros == 8)
                            {
                                //aplicar el último píxel en la imagen
                                //incluso si sólo una parte de sus elementos han sido afectados
                                if ((IndiceElementoPixel - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                //devuelve el mapa de bits con el texto oculto
                                return bmp;
                            }

                            //Comprueba si se han ocultado todos los caracteres
                            if (indiceCarecteres >= Texto.Length)
                            {
                                //Empieza a añadir ceros para marcar el final del texto
                                status = Estado.Relleno_Con_Ceros;
                            }
                            else
                            {
                                //pasa al siguiente caracter y procesa de nuevo
                                valorCaracter = Texto[indiceCarecteres++];
                            }
                        }

                        //Comprueba qué elemento de los píxeles tiene el giro para ocultar un poco en su LSB 
                        switch (IndiceElementoPixel % 3)
                        {
                            case 0:
                                {
                                    if (status == Estado.Ocultado)
                                    {
                                        //el bit más a la derecha del carácter será(charValue % 2)
                                        //para poner este valor en lugar del LSB del elemento pixelado
                                        //Sólo añádelo
                                        //el LSB del elemento pixelado ha sido limpiado
                                        //antes de esta operación
                                        R += valorCaracter % 2;

                                        // elimina el bit más a la derecha del caracter
                                        // para que e la próxima vez podamos llegar al siguiente
                                        valorCaracter /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (status == Estado.Ocultado)
                                    {
                                        G += valorCaracter % 2;

                                        valorCaracter /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (status == Estado.Ocultado)
                                    {
                                        B += valorCaracter % 2;

                                        valorCaracter /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        IndiceElementoPixel++;

                        if (status == Estado.Relleno_Con_Ceros)
                        {
                            //incrementar el valor de los ceros hasta que sea 8
                            ceros++;
                        }
                    }
                }
            }
            return bmp;
        }

        public static string ExtraerTexto(Bitmap bmp)
        {
            int IndiceUnidadColor = 0;
            int ValorCaracter = 0;

            //contiene el texto que será extraído de la imagen 
            string TextoExtraido = String.Empty;

            //Pasa por las Filas 
            for (int i = 0; i < bmp.Height; i++)
            {
                //Pasa por cada fila
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    //para cada píxel, pasar a través de sus elementos (RGB)
                    for (int n = 0; n < 3; n++)
                    {
                        switch (IndiceUnidadColor % 3)
                        {
                            case 0:
                                {
                                    // obtiene el LSB del elemento pixel (será pixel.R % 2)
                                    // luego agregar un bit a la derecha del carácter actual
                                    // esto se puede hacer por (charValue = charValue * 2)
                                    // sustitulle el bit añadido (cuyo valor es por defecto 0) por
                                    // el LSB del elemento pixelado
                                    ValorCaracter = ValorCaracter * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    ValorCaracter = ValorCaracter * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    ValorCaracter = ValorCaracter * 2 + pixel.B % 2;
                                }
                                break;
                        }
                        IndiceUnidadColor++;

                        // si se han añadido 8 bits, entonces añada el carácter actual al texto
                        if (IndiceUnidadColor % 8 == 0)
                        {
                            //Se Hace al revez ya que cada vez que el proceso ocurre a la derecha
                            ValorCaracter = BitsHaciaAtras(ValorCaracter);

                            // sólo puede ser 0 si es el carácter se detine (los 8 ceros)
                            if (ValorCaracter == 0)
                            {
                                return TextoExtraido;
                            }

                            // convertir el valor del carácter de int a char
                            char c = (char)ValorCaracter;

                            // añadir el carácter actual al texto del resultado
                            TextoExtraido += c.ToString();
                        }
                    }
                }
            }
            return TextoExtraido;
        }


        public static int BitsHaciaAtras(int n)
        //Se invierten los bits
        {
            int Resultado = 0;

            for (int i = 0; i < 8; i++)
            {
                Resultado = Resultado * 2 + n % 2;

                n /= 2;
            }

            return Resultado;
        }
    }
}
