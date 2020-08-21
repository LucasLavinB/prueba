using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
            Map NewMap = new Map();
           
            while (true)
            {
                Console.WriteLine("1.- Agregar solo rio");
                Console.WriteLine("2.- Agregar solo lago");
                Console.WriteLine("3.- Agregar rio y lago");
                Console.WriteLine("4.- No agregar nada");
                string option2 = Console.ReadLine();
                if (option2=="1")
                {
                    NewMap.GenerateMap(true, false);
                    break;
                }
                else if ( option2=="2")
                {
                     NewMap.GenerateMap(false, true);
                    break;
                }
                else if (option2=="3")
                {
                    NewMap.GenerateMap(true, true);
                    break;
                }
                else if (option2 =="4")
                {
                    NewMap.GenerateMap(false, false);
                    break;
                }
                else
                {
                    Console.WriteLine("Su opcion es invalida, ingrese una nueva opcion valida");
                    continue;
                }
            }
    
        }
    }
}