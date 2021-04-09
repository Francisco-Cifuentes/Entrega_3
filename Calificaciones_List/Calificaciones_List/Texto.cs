using System;
using System.Collections.Generic;
using System.Text;

namespace Calificaciones_List
{
    class Texto
    {        
        public void Txt_Principla()
        {
            Console.SetCursorPosition(41, 6); cw("» » » █        BIENVENIDO        █ « « «");
            Console.SetCursorPosition(35, 9); cw("■  1 «-- Agregar Estudiantes");
            Console.SetCursorPosition(35, 10); cw("■  2 «-- Listar Estudiantes");
            Console.SetCursorPosition(35, 11); cw("■  3 «-- Buscar Estudiantes");
            Console.SetCursorPosition(35, 12); cw("■  4 «-- Actualizar Estudiantes");
            Console.SetCursorPosition(35, 13); cw("■  5 «-- Borrar Estudiantes");
            Console.SetCursorPosition(35, 14); cw(" ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄ ▄");
            Console.SetCursorPosition(35, 15); cw("▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ▀ ");
            Console.SetCursorPosition(35, 16); cw("■  8 «-- Guardar Archivo");
            Console.SetCursorPosition(35, 17); cw("■  9 «-- Leer Archivo");
            Console.SetCursorPosition(35, 18); cw("■  0 «-- Salir ");
            Console.SetCursorPosition(40, 21); cw(" ■ Digite una de las opciones -»");
        }
        
        public void Txt_Agregar()
        {
            Console.SetCursorPosition(42, 4); cw("» » » █        FORMULARIO       █ « « «");
            Console.SetCursorPosition(10, 9); cw("■ «-- Codigo de Estudiante --» ■ ");
            Console.SetCursorPosition(10, 11); cw("■ «--------- Nombre ---------» ■ ");
            Console.SetCursorPosition(10, 13); cw("■ «--------- Correo ---------» ■ ");
            Console.SetCursorPosition(10, 16); cw("■ «--------- Nota 1 ---------» ■ ");
            Console.SetCursorPosition(10, 18); cw("■ «--------- Nota 2 ---------» ■ ");
            Console.SetCursorPosition(10, 20); cw("■ «--------- Nota 3 ---------» ■ ");
        }

        public void Txt_Listar()
        {
            Console.SetCursorPosition(44, 4); cw("» » » █       LISTA       █ « « «");
            Console.SetCursorPosition(7, 8); cw("CODIGO");
            Console.SetCursorPosition(24, 8); cw("NOMBRE");
            Console.SetCursorPosition(58, 8); cw("CORREO");
            Console.SetCursorPosition(81, 8); cw("No#1");
            Console.SetCursorPosition(88, 8); cw("No#2");
            Console.SetCursorPosition(95, 8); cw("No#3");
            Console.SetCursorPosition(102, 8); cw("PROM");
            Console.SetCursorPosition(108, 8); cw("APROBO");
        }

        public void Txt_Buscar()
        {
            Console.SetCursorPosition(44, 6); cw("» » » █        BUSCAR        █ « « «");
            Console.SetCursorPosition(40, 21); cw(" ■ Digite el Codigo   ---------» ■");
        }
        public void TxtD_Buscar()
        {
            Console.SetCursorPosition(37, 10); cw("■ Codigo  ---------»");
            Console.SetCursorPosition(37, 11); cw("■ Nombre  ---------»");
            Console.SetCursorPosition(37, 12); cw("■ Correo  ---------»");
            Console.SetCursorPosition(37, 15); cw("■ No#1 ---»");
            Console.SetCursorPosition(37, 16); cw("■ No#2 ---»");
            Console.SetCursorPosition(37, 17); cw("■ No#3 ---»");
            Console.SetCursorPosition(58, 15); cw("■ Promedio ---»");
            Console.SetCursorPosition(58, 16); cw("■ ---- Ø -----»");
            Console.SetCursorPosition(45, 19); cw("■ «-- Press enter to Close --» ■");
        }
        public void Txt_Borrar()
        {
            Console.SetCursorPosition(44, 6); cw("» » » █        BORRAR        █ « « «");
            Console.SetCursorPosition(40, 21); cw(" ■ Digite el Codigo   ---------» ■");
        }
        public void Txt_Actualizar()
        {
            Console.SetCursorPosition(42, 4); cw("» » » █        ACTUALIZAR       █ « « «");
            Console.SetCursorPosition(10, 9); cw("■ «-- Codigo de Estudiante --» ■ ");            
        }
        public void Txt_D_Actualizar()
        {
            Console.SetCursorPosition(10, 11); cw("■ «---- Nombre ----» ■ ");
            Console.SetCursorPosition(10, 13); cw("■ «---- Correo ----» ■ ");
            Console.SetCursorPosition(10, 16); cw("■ «---- Nota 1 ----» ■ ");
            Console.SetCursorPosition(10, 18); cw("■ «---- Nota 2 ----» ■ ");
            Console.SetCursorPosition(10, 20); cw("■ «---- Nota 3 ----» ■ ");

            Console.SetCursorPosition(68, 10); cw("■ «-- Resultados de la Busqueda --» ■ ");
            Console.SetCursorPosition(68, 12); cw("■ «-- Nombre --» ■ ");
            Console.SetCursorPosition(68, 13); cw("■ «-- Correo --» ■ ");
            Console.SetCursorPosition(68, 14); cw("■ «-- Nota 1 --» ■ ");
            Console.SetCursorPosition(68, 15); cw("■ «-- Nota 2 --» ■ ");
            Console.SetCursorPosition(68, 16); cw("■ «-- Nota 3 --» ■ ");
            Console.SetCursorPosition(68, 17); cw("■ «- Promedio -» ■ ");
            Console.SetCursorPosition(68, 18); cw("■ «-- Aprobo --» ■ ");
        }
        public void cw(string s)
        {
            Console.WriteLine(s);
        }
    }
}