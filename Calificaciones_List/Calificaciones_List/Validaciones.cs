using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calificaciones_List
{
    class Validaciones
    {
        static Formato form = new Formato();
        public bool Vacio (string i)
        {                       
            if (i.Equals(""))
            {
                for (int ind = 65; ind < 90; ind++)
                {
                    for (int h = 16; h <= 18; h++)
                    {
                        Console.SetCursorPosition(ind, h); cw(" ");
                    }
                }
                Console.SetCursorPosition(70, 16); cw("Porfavor ingrese");
                Console.SetCursorPosition(70, 17); cw("    un dato");
                form.Error_C();
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool VacioBuBo(string i)
        {
            for (int ind = 33; ind < 89; ind++)
            {
                for (int it = 10; it <= 17; it++)
                {
                    Console.SetCursorPosition(ind, it); cw(" ");
                }
            }
            if (i.Equals(""))
            {
                Console.SetCursorPosition(50, 16); cw("Porfavor ingrese un dato");
                form.Error_CB_B();
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool V_Numero(string i)
        {
            Regex formato = new Regex(@"^[0-9]*$");

            if (formato.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(65, 16); cw("Debe escribir un numero ");
                Console.SetCursorPosition(65, 17); cw("Formato requerido --» 5");
                form.Error_C();
                return false;
            }
        }

        // Formulario
        public bool Vacio_form(string i)
        {
            for (int ind = 10; ind < 100; ind++)
            {
                for (int h = 24; h <= 26; h++)
                {
                    Console.SetCursorPosition(ind, h); cw(" ");
                }                
            }
            form.chul();
            if (i.Equals(""))
            {
                Console.SetCursorPosition(50, 24); cw("                                                 ");
                Console.SetCursorPosition(50, 25); cw("Porfavor ingrese un dato...                      ");
                Console.SetCursorPosition(50, 26); cw("                                                 ");                
                form.Error_Form();
                form.Error_01();
                return false;
            }
            else
            {                
                return true;
            }
        }
        public bool V_Nota(string i)
        {            
            Regex Formato_N = new Regex(@"\A[0-9]{1},[0-9]{1}\Z");
            if (Formato_N.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(50, 24); cw("El valor ingresado debe ser un numero            ");
                Console.SetCursorPosition(50, 25); cw("Formato requerido --» ×,×                        ");
                Console.SetCursorPosition(50, 26); cw("                                                 ");
                form.Error_Form();
                form.Error_02();
                return false;
            }
        }

        public bool V_Texto(string i)
        {
            Regex Formato_T = new Regex(@"^[a-zA-ZñÑ\s]*$");
            if (Formato_T.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(50, 24); cw("El valor ingresado debe ser de tipo texto        ");
                Console.SetCursorPosition(50, 25); cw("Formato requerido --» Francisco Cifuentes        ");
                Console.SetCursorPosition(50, 26); cw("                                                 ");
                form.Error_Form();
                form.Error_03();
                return false;
            }
        }

        public bool V_Codigo(string i)
        {            
            Regex Formato_Cd = new Regex(@"\A[0-9]{4}\Z");
            if (Formato_Cd.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(50, 24); cw("El valor ingresado no tiene el tamaño adecuado   ");
                Console.SetCursorPosition(50, 25); cw("Formato requerido --» 1234                       ");
                Console.SetCursorPosition(50, 26); cw("                                                 ");
                form.Error_Form();
                form.Error_04();
                return false;
            }
        }

        public bool VB_B_Codigo(string i)
        {
            Regex Formato_Cd = new Regex(@"\A[0-9]{4}\Z");
            if (Formato_Cd.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(38, 16); cw("El valor ingresado no tiene el tamaño adecuado");
                Console.SetCursorPosition(38, 17); cw("          Formato requerido --» 1234          ");
                form.Error_CB_B();
                return false;
            }
        }

        public bool V_Correo(string i)
        {
            Regex Formato_Cr = new Regex(@"\A(\w+\.?\w*\@)(misena.edu.co)\Z");
            if (Formato_Cr.IsMatch(i))
            {
                return true;
            }
            else
            {
                Console.SetCursorPosition(50, 24); cw("El correo ingresado no es correcto               ");
                Console.SetCursorPosition(50, 25); cw("Formato requerido --» example@misena.edu.co      ");
                Console.SetCursorPosition(50, 26); cw("                                                 ");
                form.Error_Form();
                form.Error_05();
                return false;                
            }
        }
        public bool Vacio_B(string i)
        {
            for (int ind = 65; ind < 88; ind++)
            {
                for (int indi = 10; indi >= 17; indi++)
                {
                    Console.SetCursorPosition(ind, indi); cw(" ");
                }
            }
            if (i.Equals(""))
            {
                Console.SetCursorPosition(65, 16); cw("Porfavor ingrese un dato");
                form.Error_CB_B();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Vacio_A(string i)
        {
            for (int ind = 10; ind < 100; ind++)
            {
                for (int h = 24; h <= 26; h++)
                {
                    Console.SetCursorPosition(ind, h); cw(" ");
                }
            }
            form.chul();
            if (i.Equals(""))
            {                
                form.Vacio_Actualizar();
                return true;
            }
            else
            {
                return false;
            }
        }        
        public void cw (string s)
        {
            Console.WriteLine(s);
        }
    }
}