using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSimulator
{
    static class MenuManager
    {
        //INICO DEL PROGRAMA
        public static void StartMenu()
        {
            Console.WriteLine("Bienvenido a FarmSimulator");
            while (true)
            {
                Console.WriteLine("Ingresa una de las siguientes opciones:");
                Console.WriteLine("1.- Crear un mapa.");
                Console.WriteLine("2.- Salir.");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Creando nuevo mapa...");

                    TerrainDesign();
                }
                else if (option == "2")
                {
                    Console.WriteLine("Cerrando FarmSimulator.");
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion invalida. Re ingrese otra alternativa.");
                    continue;
                }
            }

        }

        //MENU PARA CREAR EL TERRENO
        public static void TerrainDesign()
        {
            Map NuevoMapa = new Map();
        }
    }
}
