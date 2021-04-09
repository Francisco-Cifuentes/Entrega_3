using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones_List
{
    class Formato
    {
        public void Bienvenida()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.SetCursorPosition(45, 6); Console.WriteLine ("         ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄         ");
            Console.SetCursorPosition(45, 7); Console.WriteLine ("       ▄█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▄       ");
            Console.SetCursorPosition(45, 8); Console.WriteLine ("     ▄█▀       ▄▄▄▄       ▀█▄     ");
            Console.SetCursorPosition(45, 9); Console.WriteLine ("   ▄█▀        ██████        ▀█▄   ");
            Console.SetCursorPosition(45, 10); Console.WriteLine(" ▄█▀          ▀████▀          ▀█▄ ");
            Console.SetCursorPosition(45, 11); Console.WriteLine("██   ╔═══╗ ╔═══╗ ╔═╗  ╗ ╔═══╗   ██");
            Console.SetCursorPosition(45, 12); Console.WriteLine("██   ╚═══╗ ╠══   ║ ╚╗ ║ ╠═══╣   ██");
            Console.SetCursorPosition(45, 13); Console.WriteLine("██   ╚═══╝ ╚═══╝ ╚  ╚═╝ ╚   ╝   ██");
            Console.SetCursorPosition(45, 14); Console.WriteLine("██   ▀▀▀▀▀▀▀▀██▀  ▀██▀▀▀▀▀▀▀▀   ██");
            Console.SetCursorPosition(45, 15); Console.WriteLine("██         ▄█▀ ▄██▄ ▀█▄         ██");
            Console.SetCursorPosition(45, 16); Console.WriteLine("██       ▄█▀ ▄█▀  ▀█▄ ▀█▄       ██");
            Console.SetCursorPosition(45, 17); Console.WriteLine(" ▀█▄   ▄█▀ ▄█▀      ▀█▄ ▀█▄   ▄█▀ ");
            Console.SetCursorPosition(45, 18); Console.WriteLine("   ▀█▄ ▀ ▄█▀          ▀█▄ ▀ ▄█▀   ");
            Console.SetCursorPosition(45, 19); Console.WriteLine("     ▀█▄                  ▄█▀     ");
            Console.SetCursorPosition(45, 20); Console.WriteLine("       ▀██████████████████▀       ");

            Console.SetCursorPosition(40, 22); Console.WriteLine("╔═══╗   ╔═══╗   ╔═╗╔═╗   ╔═     ╔═╦═╗   ╔═╦═╗ ");
            Console.SetCursorPosition(40, 23); Console.WriteLine("║       ║ ╔═╗   ║ ╚╝ ║   ║        ║       ║   ");
            Console.SetCursorPosition(40, 24); Console.WriteLine("╚═══╝ ■ ╚═══╝ ■ ╚    ╝ ■ ╚═══╝ ■  ╩  ■  ╚═╩═╝ ");
            Console.SetCursorPosition(45, 26); cw("■ «-- Press enter to Continue --» ■");

            Console.ReadKey();
        }
        public void M_Principal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            //Horizontal
            for (int i = 32; i <= 90; i++)
            {
                Console.SetCursorPosition(i, 4); cw("═");
                Console.SetCursorPosition(i, 8); cw("═");
                Console.SetCursorPosition(i, 19); cw("═");
                Console.SetCursorPosition(i, 23); cw("═");
            }
            //Vertical
            for (int i = 4; i <= 23; i++)
            {
                Console.SetCursorPosition(32, i); cw("║");
                Console.SetCursorPosition(90, i); cw("║");
            }

            //Vertical
            for (int i = 3; i <= 24; i++)
            {
                Console.SetCursorPosition(30, i); cw("▓");
                Console.SetCursorPosition(31, i); cw("▓");
                Console.SetCursorPosition(91, i); cw("▓");
                Console.SetCursorPosition(92, i); cw("▓");
            }
            //Horizontal
            for (int i = 31; i <= 91; i++)
            {
                Console.SetCursorPosition(i, 3); cw("▓");
                Console.SetCursorPosition(i, 24); cw("▓");
            }

            for (int i = 20; i <= 22; i++)
            {
                Console.SetCursorPosition(80, i); cw("║");
            }
            Console.SetCursorPosition(32, 4); cw("╔");
            Console.SetCursorPosition(90, 4); cw("╗");
            Console.SetCursorPosition(90, 23); cw("╝");
            Console.SetCursorPosition(32, 23); cw("╚");

            Console.SetCursorPosition(90, 8); cw("╣");
            Console.SetCursorPosition(32, 8); cw("╠");

            Console.SetCursorPosition(32, 19); cw("╠");
            Console.SetCursorPosition(90, 19); cw("╣");

            Console.SetCursorPosition(80, 19); cw("╦");
            Console.SetCursorPosition(80, 23); cw("╩");
        }

        public void M_Agregar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();            
            //Horizontal
            for (int i = 5; i <= 115; i++)
            {
                Console.SetCursorPosition(i, 2); cw("═");
                Console.SetCursorPosition(i, 6); cw("═");
                Console.SetCursorPosition(i, 23); cw("═");
                Console.SetCursorPosition(i, 27); cw("═");
            }            
            //Vertical
            for (int i = 2; i <= 27; i++)
            {
                Console.SetCursorPosition(5, i); cw("║");
                Console.SetCursorPosition(115, i); cw("║");
            }
            Console.SetCursorPosition(5, 2); cw("╔");
            Console.SetCursorPosition(115, 2); cw("╗");
            Console.SetCursorPosition(115, 27); cw("╝");
            Console.SetCursorPosition(5, 27); cw("╚");

            Console.SetCursorPosition(5, 6); cw("╠");
            Console.SetCursorPosition(115, 6); cw("╣");
            Console.SetCursorPosition(5, 23); cw("╠");
            Console.SetCursorPosition(115, 23); cw("╣");


            Console.SetCursorPosition(75, 12); cw("▌▓█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▓▌ ▄▄▄▄▄");
            Console.SetCursorPosition(75, 13); cw("▌▓█   █▀▀▀    █▀▀▀    █▓▌ █▄▄▄█");
            Console.SetCursorPosition(75, 14); cw("▌▓█   █▀▀ ▄   █▄▄▄ ▄  █▓▌ █▄▄▄█");
            Console.SetCursorPosition(75, 15); cw("▌▓█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▓▌ █████");
            Console.SetCursorPosition(75, 16); cw("         ▄▄███▄▄          █████");
            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(4, i); cw("▓");
                Console.SetCursorPosition(3, i); cw("▓");
                Console.SetCursorPosition(116, i); cw("▓");
                Console.SetCursorPosition(117, i); cw("▓");
            }
            //Horizontal
            for (int i = 4; i <= 117; i++)
            {
                Console.SetCursorPosition(i, 1); cw("▓");
                Console.SetCursorPosition(i, 28); cw("▓");
            }
            chul();
        }       
        public void Error_C()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(74, 10); cw(" ▄▀▀▀▄ ");
            Console.SetCursorPosition(74, 11); cw(" █   █ ");
            Console.SetCursorPosition(74, 12); cw("███▀███");
            Console.SetCursorPosition(74, 13); cw("██   ██");
            Console.SetCursorPosition(74, 14); cw("███▄███");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public void Error_CB_B()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(59, 10); cw(" ▄▀▀▀▄ ");
            Console.SetCursorPosition(59, 11); cw(" █   █ ");
            Console.SetCursorPosition(59, 12); cw("███▀███");
            Console.SetCursorPosition(59, 13); cw("██   ██");
            Console.SetCursorPosition(59, 14); cw("███▄███");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_Form()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(105, 23); cw("╦═════════╣");
            Console.SetCursorPosition(105, 24); cw("║  ▄▀▀▀▄  ║");
            Console.SetCursorPosition(105, 25); cw("║ ███▀███ ║");
            Console.SetCursorPosition(105, 26); cw("║ ███▄███ ║");
            Console.SetCursorPosition(105, 27); cw("╩═════════╝");
            
            Console.SetCursorPosition(10, 24); cw("╔═══ ╔══╗ ╔══╗ ╔══╗ ╔══╗");
            Console.SetCursorPosition(10, 25); cw("╠══  ╠═╦╝ ╠═╦╝ ║  ║ ╠═╦╝");
            Console.SetCursorPosition(10, 26); cw("╚═══ ╚ ╚  ╚ ╚  ╚══╝ ╚ ╚ ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_00()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(73, 22); cw("■ «-- Press enter to Close --» ■");
            Console.SetCursorPosition(40, 24); cw("╔═╗ ╔═╗");
            Console.SetCursorPosition(40, 25); cw("║ ║ ║ ║");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ╚═╝");
            Console.SetCursorPosition(52, 24); cw("                                                  ");
            Console.SetCursorPosition(52, 25); cw("Este codigo ya existe en la base de datos         ");
            Console.SetCursorPosition(52, 26); cw("                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.ReadKey();
        }
        public void Error_01()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ═╗");
            Console.SetCursorPosition(40, 25); cw("║ ║  ║");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ═╩═");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_02()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ══╗");
            Console.SetCursorPosition(40, 25); cw("║ ║ ╔═╝");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ╚══");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_03()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ══╗");
            Console.SetCursorPosition(40, 25); cw("║ ║ ══╣");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ══╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_04()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ║ ║");
            Console.SetCursorPosition(40, 25); cw("║ ║ ╚═╣");
            Console.SetCursorPosition(40, 26); cw("╚═╝   ║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_05()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ╔══");
            Console.SetCursorPosition(40, 25); cw("║ ║ ╚═╗");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ══╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_06()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(73, 22); cw("■ «-- Press enter to Close --» ■");
            Console.SetCursorPosition(40, 24); cw("╔═╗ ╔══");
            Console.SetCursorPosition(40, 25); cw("║ ║ ╠═╗");
            Console.SetCursorPosition(40, 26); cw("╚═╝ ╚═╝");
            Console.SetCursorPosition(52, 24); cw("                                                  ");
            Console.SetCursorPosition(52, 25); cw("El estudiante buscado no existe                   ");
            Console.SetCursorPosition(52, 26); cw("                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Error_07()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(40, 24); cw("╔═╗ ══╗");
            Console.SetCursorPosition(40, 25); cw("║ ║   ║");
            Console.SetCursorPosition(40, 26); cw("╚═╝   ║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(50, 24); cw("                                                 ");
            Console.SetCursorPosition(50, 25); cw("El valor ingresado mayor a 5.0                   ");
            Console.SetCursorPosition(50, 26); cw("                                                 ");
        }
        public void Correct_Form()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            chul();

            Console.SetCursorPosition(10, 24); cw("╔══╗ ╔══╗ ╔══╗ ╔══╗ ╔══╗ ╔══╗ ═╦═ ╔══╗");
            Console.SetCursorPosition(10, 25); cw("║    ║  ║ ╠═╦╝ ╠═╦╝ ╠══  ║     ║  ║  ║");
            Console.SetCursorPosition(10, 26); cw("╚══╝ ╚══╝ ╚ ╚  ╚ ╚  ╚══╝ ╚══╝  ╩  ╚══╝");

            Console.SetCursorPosition(52, 24); cw("                                                  ");
            Console.SetCursorPosition(52, 25); cw("Datos Ingresados Correctamente añadidos a la lista");
            Console.SetCursorPosition(52, 26); cw("                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Correct_Form_A()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            chul();

            Console.SetCursorPosition(10, 24); cw("╔══╗ ╔══╗ ╔══╗ ╔══╗ ╔══╗ ╔══╗ ═╦═ ╔══╗");
            Console.SetCursorPosition(10, 25); cw("║    ║  ║ ╠═╦╝ ╠═╦╝ ╠══  ║     ║  ║  ║");
            Console.SetCursorPosition(10, 26); cw("╚══╝ ╚══╝ ╚ ╚  ╚ ╚  ╚══╝ ╚══╝  ╩  ╚══╝");

            Console.SetCursorPosition(52, 24); cw("                                                  ");
            Console.SetCursorPosition(52, 25); cw("Datos Actualizados Correctamente");
            Console.SetCursorPosition(52, 26); cw("                                                  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void chul()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(105, 23); cw("╦═════════╣");
            Console.SetCursorPosition(105, 24); cw("║  ▄▀▀▀   ║");
            Console.SetCursorPosition(105, 25); cw("║ ███▀███ ║");
            Console.SetCursorPosition(105, 26); cw("║ ███▄███ ║");
            Console.SetCursorPosition(105, 27); cw("╩═════════╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }        
        public void M_Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 5; i <= 115; i++)
            {
                Console.SetCursorPosition(i, 2); cw("═");
                Console.SetCursorPosition(i, 6); cw("═");
                Console.SetCursorPosition(i, 10); cw("═");
                Console.SetCursorPosition(i, 23); cw("═");
                Console.SetCursorPosition(i, 27); cw("═");
            }
            for (int i = 2; i <= 27; i++)
            {
                Console.SetCursorPosition(5, i); cw("║");
                Console.SetCursorPosition(115, i); cw("║");
            }
            for (int i = 7; i <= 22; i++)
            {
                Console.SetCursorPosition(14, i); cw("║");
                Console.SetCursorPosition(40, i); cw("║");
                Console.SetCursorPosition(79, i); cw("║");
                Console.SetCursorPosition(86, i); cw("║");
                Console.SetCursorPosition(93, i); cw("║");
                Console.SetCursorPosition(100, i); cw("║");
                Console.SetCursorPosition(107, i); cw("║");
            }
            Console.SetCursorPosition(5, 2); cw("╔");
            Console.SetCursorPosition(115, 2); cw("╗");
            Console.SetCursorPosition(115, 27); cw("╝");
            Console.SetCursorPosition(5, 27); cw("╚");

            Console.SetCursorPosition(5, 6); cw("╠");
            Console.SetCursorPosition(115, 6); cw("╣");
            Console.SetCursorPosition(5, 23); cw("╠");
            Console.SetCursorPosition(115, 23); cw("╣");

            Console.SetCursorPosition(5, 10); cw("╠");
            Console.SetCursorPosition(115, 10); cw("╣");

            Console.SetCursorPosition(14, 6); cw("╦");
            Console.SetCursorPosition(40, 6); cw("╦");
            Console.SetCursorPosition(79, 6); cw("╦");
            Console.SetCursorPosition(86, 6); cw("╦");
            Console.SetCursorPosition(93, 6); cw("╦");
            Console.SetCursorPosition(100, 6); cw("╦");
            Console.SetCursorPosition(107, 6); cw("╦");

            Console.SetCursorPosition(14, 10); cw("╬");
            Console.SetCursorPosition(40, 10); cw("╬");
            Console.SetCursorPosition(79, 10); cw("╬");
            Console.SetCursorPosition(86, 10); cw("╬");
            Console.SetCursorPosition(93, 10); cw("╬");
            Console.SetCursorPosition(100, 10); cw("╬");
            Console.SetCursorPosition(107, 10); cw("╬");


            Console.SetCursorPosition(14, 23); cw("╩");
            Console.SetCursorPosition(40, 23); cw("╩");
            Console.SetCursorPosition(79, 23); cw("╩");
            Console.SetCursorPosition(86, 23); cw("╩");
            Console.SetCursorPosition(93, 23); cw("╩");
            Console.SetCursorPosition(100, 23); cw("╩");
            Console.SetCursorPosition(107, 23); cw("╩");
            

            for (int i = 1; i <= 28; i++)
            {
                Console.SetCursorPosition(4, i); cw("▓");
                Console.SetCursorPosition(3, i); cw("▓");
                Console.SetCursorPosition(116, i); cw("▓");
                Console.SetCursorPosition(117, i); cw("▓");
            }
            for (int i = 4; i <= 117; i++)
            {
                Console.SetCursorPosition(i, 1); cw("▓");
                Console.SetCursorPosition(i, 28); cw("▓");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(7, 24); cw(" █▀╔══╗ ╔══╗ ╔══╗ ╔══╗ ╔══╗       ╔══╗ ╔═╗  ╗ ═╦═ ╔══╗ ╔══╗       ═╦═ ╔══╗       ╔══╗ ╔    ╔══╗ ╔══╗ ╔══╗▀█");
            Console.SetCursorPosition(7, 25); cw(" █ ╠══╝ ╠═╦╝ ╠══  ╚══╗ ╚══╗  ■■■  ╠══  ║ ╚╗ ║  ║  ╠══  ╠═╦╝  ■■■   ║  ║  ║  ■■■  ║    ║    ║  ║ ╚══╗ ╠══  █");
            Console.SetCursorPosition(7, 26); cw(" █▄╚    ╚ ╚  ╚══╝ ╚══╝ ╚══╝       ╚══╝ ╚  ╚═╝  ╩  ╚══╝ ╚ ╚         ╩  ╚══╝       ╚══╝ ╚══╝ ╚══╝ ╚══╝ ╚══╝▄█");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public void M_Buscar_Borrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            //Horizontal
            for (int i = 32; i <= 90; i++)
            {
                Console.SetCursorPosition(i, 4); cw("═");
                Console.SetCursorPosition(i, 8); cw("═");
                Console.SetCursorPosition(i, 19); cw("═");
                Console.SetCursorPosition(i, 23); cw("═");
            }
            //Vertical
            for (int i = 4; i <= 23; i++)
            {
                Console.SetCursorPosition(32, i); cw("║");
                Console.SetCursorPosition(90, i); cw("║");
            }

            //Vertical
            for (int i = 3; i <= 24; i++)
            {
                Console.SetCursorPosition(30, i); cw("▓");
                Console.SetCursorPosition(31, i); cw("▓");
                Console.SetCursorPosition(91, i); cw("▓");
                Console.SetCursorPosition(92, i); cw("▓");
            }
            //Horizontal
            for (int i = 31; i <= 91; i++)
            {
                Console.SetCursorPosition(i, 3); cw("▓");
                Console.SetCursorPosition(i, 24); cw("▓");
            }

            for (int i = 20; i <= 22; i++)
            {
                Console.SetCursorPosition(79, i); cw("║");
            }
            Console.SetCursorPosition(32, 4); cw("╔");
            Console.SetCursorPosition(90, 4); cw("╗");
            Console.SetCursorPosition(90, 23); cw("╝");
            Console.SetCursorPosition(32, 23); cw("╚");

            Console.SetCursorPosition(90, 8); cw("╣");
            Console.SetCursorPosition(32, 8); cw("╠");

            Console.SetCursorPosition(32, 19); cw("╠");
            Console.SetCursorPosition(90, 19); cw("╣");

            Console.SetCursorPosition(79, 19); cw("╦");
            Console.SetCursorPosition(79, 23); cw("╩");
        }
        public void Borrar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(52, 10); cw("       ▄▄▀▀▀▄▄       ");
            Console.SetCursorPosition(52, 11); cw("     ▄█▀     ▀█▄     ");
            Console.SetCursorPosition(52, 12); cw("▄  ▄█▀      ▄▀ ▀█▄  ▄");
            Console.SetCursorPosition(52, 13); cw(" ▀▀▀█▄ ▀▄ ▄▀   ▄█▀▀▀ ");
            Console.SetCursorPosition(52, 14); cw("     ▀█▄ ▀   ▄█▀     ");
            Console.SetCursorPosition(52, 15); cw("       ▀▀▄▄▄▀▀       ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Vacio_Actualizar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(105, 23); cw("╦═════════╣");
            Console.SetCursorPosition(105, 24); cw("║    █    ║");
            Console.SetCursorPosition(105, 25); cw("║    █    ║");
            Console.SetCursorPosition(105, 26); cw("║    ▄    ║");
            Console.SetCursorPosition(105, 27); cw("╩═════════╝");

            Console.SetCursorPosition(10, 24); cw("╔══╗ ╔    ╔══╗ ╔══╗ ═╦═ ╔══╗");
            Console.SetCursorPosition(10, 25); cw("╠══╣ ║    ╠══  ╠═╦╝  ║  ╠══╣");
            Console.SetCursorPosition(10, 26); cw("╚  ╝ ╚══╝ ╚══╝ ╚ ╚   ╩  ╚  ╝");

            Console.SetCursorPosition(50, 24); cw("    ¿ Enviara campos vacios desea continuar ?    ");
            Console.SetCursorPosition(50, 25); cw("                      si/no                      ");
            Console.SetCursorPosition(50, 26); cw("                     »     «                     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Alert_Borrar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(43, 11); cw("▀ ▀ ╔══╗ ╔    ╔══╗ ╔══╗ ═╦═ ╔══╗ █ █");
            Console.SetCursorPosition(43, 12); cw("█ █ ╠══╣ ║    ╠══  ╠═╦╝  ║  ╠══╣ █ █");
            Console.SetCursorPosition(43, 13); cw("█ █ ╚  ╝ ╚══╝ ╚══╝ ╚ ╚   ╩  ╚  ╝ ▄ ▄");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void Limpiar()
        {
            for (int ind = 10; ind < 100; ind++)
            {
                for (int h = 24; h <= 26; h++)
                {
                    Console.SetCursorPosition(ind, h); cw(" ");
                }
            }
            chul();
        }

        public void Limpiar_Bo()
        {
            for (int ind = 33; ind < 89; ind++)
            {
                for (int it = 10; it <= 17; it++)
                {
                    Console.SetCursorPosition(ind, it); cw(" ");
                }
            }
        }
        public void cw(string s)
        {
            Console.WriteLine(s);
        }
    }
}