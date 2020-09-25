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
        public static void GameMenu()
        {
            //INICIO NUEVO JUEGO
            //Game.NewGame();
            
            //game.NewGame();
            Console.WriteLine("Confirmado");
        }

        public static void LoadGameMenu()
        {
            //METODO PARA MOSTRAR Y CARGAR PARTIDAS ANTERIORES
            //DESPUES SE LLAMA A TURNO
        }

        public static void OptionsMenu()
        {

        }
        //INICO DEL PROGRAMA
        public static void StartMenu()
        {
            Console.WriteLine("Bienvenido a FarmSimulator");
            while (true)
            {
                Console.WriteLine("Ingresa una de las siguientes opciones:");
                Console.WriteLine("1.- Iniciar una nueva partida");
                Console.WriteLine("2.- Cargar una partida anterior");
                Console.WriteLine("3.- Salir");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Creando nuevo mapa...");
                    NewGameMenu();
                }
                else if (option == "2")
                {
                    Console.WriteLine("Cargando partida anterior");
                    LoadGameMenu();
                }
                else if (option == "3")
                {
                    Console.WriteLine("Cerrando FarmSimulator");
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion invalida. Re ingrese otra alternativa");
                    continue;
                }
            }

        }

        //MENU PARA CREAR EL TERRENO
        public static void NewGameMenu()
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
                    NewMap.GenerateMap(false, true);
                    PrintMap.Render(NewMap.GetMap());
                    ConfirmMenu();
                    break;
                }
                else if ( option2=="2")
                {
                    NewMap.GenerateMap(true, false);
                    PrintMap.Render(NewMap.GetMap());
                    ConfirmMenu();
                    break;
                }
                else if (option2=="3")
                {
                    NewMap.GenerateMap(true, true);
                    PrintMap.Render(NewMap.GetMap());
                    ConfirmMenu();
                    break;
                }
                else if (option2 =="4")
                {
                    NewMap.GenerateMap(false, false);
                    PrintMap.Render(NewMap.GetMap());
                    ConfirmMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Su opcion es invalida, ingrese una nueva opcion valida");
                    continue;
                }
            }
        }


        public static void ConfirmMenu()
        {
            while (true)
            {
                Console.WriteLine("¿Quiere este mapa?");
                Console.WriteLine("1.- Confirmo");
                Console.WriteLine("2.- Probar otro");

                string option3 = Console.ReadLine();
                if (option3 == "1")
                {
                    GameMenu();
                }
                else if (option3 == "2")
                {
                    NewGameMenu();
                    continue;
                }
                else
                {
                    Console.WriteLine("Su opcion es invalida, ingrese una nueva opción valida");
                    continue;
                }
            }
        }
    }
}