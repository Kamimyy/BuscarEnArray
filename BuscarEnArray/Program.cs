using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarEnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool correcto = false;
            int[] array = new int[0];

            do
            {
                Console.WriteLine("Hola! Escriba la longitud de un array de números.\n");

                string stringNumero = Console.ReadLine();

                if (!int.TryParse(stringNumero, out int result))
                {
                    Console.WriteLine("El valor debe de ser un número.");
                }
                else
                {
                    int longArray = int.Parse(stringNumero);
                    correcto = true;
                    array = new int[longArray];
                }

            } while (correcto == false);

            if (correcto == true)
            {

                bool correcto2 = false;

                for (int i = 0; i < array.Length; i++)
                {
                    do
                    {
                        Console.WriteLine($"Escribe el número para la posición {i}");
                        string stringNumero2 = Console.ReadLine();

                        if (!int.TryParse(stringNumero2, out int result))
                        {
                            Console.WriteLine("El valor debe de ser un número.");
                        }
                        else
                        {
                            int numero = int.Parse(stringNumero2);
                            array[i] = numero;
                            correcto2 = true;
                        }

                    } while (correcto2 == false);

                }

                ExisteONo(array);
            }

            Console.ReadLine();
        }

        public static void ExisteONo(int[] array)
        {

            string respuesta = "";
            bool salir = false;
            int numeroElegido;

            do
            {
                bool encontrado = false;
                Console.WriteLine("\nAhora, escribe un número y te diré si está en el array o no. Si quieres finalizar, escribe 'end'. ");

                respuesta = Console.ReadLine();

                if (respuesta == "end")
                {
                    salir = true;
                }
                else
                {
                    if (!int.TryParse(respuesta, out int result))
                    {
                        Console.WriteLine("El valor debe de ser un número.");
                    }
                    else
                    {
                        numeroElegido = int.Parse(respuesta);

                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == numeroElegido)
                            {
                                encontrado = true;
                            }
                        }

                        if (encontrado)
                        {
                            Console.WriteLine($"El número {numeroElegido} se encuentra en el array.");
                        }
                        else
                        {
                            Console.WriteLine($"El número {numeroElegido} no se encuentra en el array.");
                        }
                    }
                }

            } while (salir == false);
        }
    }
}
