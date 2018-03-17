using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuInteractivoConsola
{
    class Program
    {
        static string[] menu;
        static int posicion = 1;
        static int seleccion = -1;

        static void Main(string[] args)
        {
            LlenarMenu();
            do
            {
                MostrarMenu();
                NavegarEnMenu();
                Console.Clear();
            } while (seleccion!=3);
        }

        private static void NavegarEnMenu()
        {
            ConsoleKeyInfo teclaUsuario =  Console.ReadKey(false);
            ConsoleKey direccion = teclaUsuario.Key;
            switch (direccion)
            {
                case ConsoleKey.UpArrow:
                    ValidarPosicion(-1);
                    break;
                case ConsoleKey.DownArrow:
                    ValidarPosicion(+1);
                    break;
                case ConsoleKey.Enter:
                    seleccion = posicion;
                    Seleccionar();
                    break;
                default:
                    break;
            }
        }

        private static void ValidarPosicion(int direccion)
        {
            if ((direccion+posicion)>0 && (direccion + posicion) < menu.Length)
            {
                posicion = posicion + direccion;
            }
        }

        private static void Seleccionar()
        {
            Console.Clear();
            switch (posicion)
            {
                case 1:
                    Console.WriteLine("Hola");
                    break;
                case 2:
                    Console.WriteLine("adios");
                    break;
                default:
                    break;
            }
            Console.WriteLine("presione una tecla");
            Console.ReadKey();
            Console.Clear();
        }

        private static void LlenarMenu()
        {
            menu = new string[4];
            menu[0] = "***MENU***";
            menu[1] = "1.- decir hola";
            menu[2] = "2.- decir adios";
            menu[3] = "3.- Salir";
        }
        private static void MostrarMenu() {
            for (int i = 0; i < menu.Length; i++)
            {
                if (i==0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (posicion==i)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(menu[i]);
            }
        }
    }
}
