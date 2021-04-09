using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using System.Linq;

namespace Calificaciones_List
{
    class Metodos
    {
        static List<Estudiante> ListaEstudiante = new List<Estudiante>();
        static Formato form = new Formato();
        static Validaciones val = new Validaciones();
        static Texto txt = new Texto();

        public void CrearEstudiante()
        {
            string nom, email, cod, nt1, nt2, nt3, aprob;
            bool txt_val = false, email_val = false, cod_val = false, nt1_v = false, nt2_v = false, nt3_v = false;
            double aux_n;
            do
            {                
                Console.SetCursorPosition(43, 9); cw("                   ");
                Console.SetCursorPosition(43, 9); cod = Console.ReadLine();
                if (val.Vacio_form(cod))
                {
                    if (val.V_Codigo(cod))
                    {
                        cod_val = true;
                    }
                }                
            } while (!cod_val);
            int codi = int.Parse(cod);
            if (Existe(codi))
            {
                form.Error_Form();
                form.Error_00();
            }
            else
            {
                do
                {
                    Console.SetCursorPosition(43, 11); cw("                   ");
                    Console.SetCursorPosition(43, 11); nom = Console.ReadLine();
                    if (val.Vacio_form(nom))
                    {
                        if (val.V_Texto(nom))
                        {
                            txt_val = true;
                        }
                    }
                } while (!txt_val);
                do
                {
                    Console.SetCursorPosition(43, 13); cw("                               ");
                    Console.SetCursorPosition(43, 13); email = Console.ReadLine();
                    if (val.Vacio_form(email))
                    {
                        if (val.V_Correo(email))
                        {
                            email_val = true;
                        }
                    }
                } while (!email_val);
                do
                {
                    Console.SetCursorPosition(43, 16); cw("                   ");
                    Console.SetCursorPosition(43, 16); nt1 = Console.ReadLine();
                    if (val.Vacio_form(nt1))
                    {
                        if (val.V_Nota(nt1))
                        {
                            aux_n = double.Parse(nt1);
                            if (aux_n <= 5)
                            {
                                nt1_v = true;
                            }
                            else
                            {
                                form.Error_Form();
                                form.Error_07();
                            }
                        }
                    }
                } while (!nt1_v);
                double not1 = double.Parse(nt1);
                do
                {
                    Console.SetCursorPosition(43, 18); cw("                   ");
                    Console.SetCursorPosition(43, 18); nt2 = Console.ReadLine();
                    if (val.Vacio_form(nt2))
                    {
                        if (val.V_Nota(nt2))
                        {
                            aux_n = double.Parse(nt2);
                            if (aux_n <= 5)
                            {
                                nt2_v = true;
                            }
                            else
                            {
                                form.Error_Form();
                                form.Error_07();
                            }
                        }
                    }
                } while (!nt2_v);
                double not2 = double.Parse(nt2);
                do
                {
                    Console.SetCursorPosition(43, 20); cw("                   ");
                    Console.SetCursorPosition(43, 20); nt3 = Console.ReadLine();
                    if (val.Vacio_form(nt3))
                    {
                        if (val.V_Nota(nt3))
                        {
                            aux_n = double.Parse(nt3);
                            if (aux_n <= 5)
                            {
                                nt3_v = true;
                            }
                            else
                            {
                                form.Error_Form();
                                form.Error_07();
                            }
                        }
                    }
                } while (!nt3_v);
                double not3 = double.Parse(nt3);
                double prome = (not1 + not2 + not3) / 3.0;
                if (prome >= 3.5)
                {
                    aprob = "Aprobo";
                }
                else
                {
                    aprob = "Reprobo";
                }
                Estudiante student = new Estudiante
                {
                    Nombre = nom,
                    Correo = email,
                    Cod = codi,
                    Nota1 = double.Parse(nt1),
                    Nota2 = double.Parse(nt2),
                    Nota3 = double.Parse(nt3),
                    Prome = Math.Round(prome, 1),
                    Aprob = aprob
                };
                form.Correct_Form();
                ListaEstudiante.Add(student);                
            }            
        }
        public void ListarEstudiantes()
        {
            int Y = 10;
            foreach (Estudiante column in ListaEstudiante)
            {
                Y++;
                Console.SetCursorPosition(8, Y); cw("" + column.Cod);
                Console.SetCursorPosition(15, Y); cw("" + column.Nombre);
                Console.SetCursorPosition(42, Y); cw(""+column.Correo);
                Console.SetCursorPosition(82, Y); cw("" + column.Nota1);
                Console.SetCursorPosition(89, Y); cw("" + column.Nota2);
                Console.SetCursorPosition(96, Y); cw("" + column.Nota3);
                Console.SetCursorPosition(103, Y); cw("" + column.Prome);
                Console.SetCursorPosition(108, Y); cw("" + column.Aprob);
            }
        }
        public void BuscarEstudiante()
        {
            string cod;
            bool Cod_V = false;
            do
            {
                Console.SetCursorPosition(83, 21); Console.WriteLine("      ");
                Console.SetCursorPosition(83, 21); cod = Console.ReadLine();
                if (val.VacioBuBo(cod))
                    if (val.VB_B_Codigo(cod))
                        Cod_V = true;
            } while (!Cod_V);
            if (Existe(Convert.ToInt32(cod)))
            {
                txt.TxtD_Buscar();                
                Estudiante MyEstud = ObtenerDatos(Convert.ToInt32(cod));
                Console.SetCursorPosition(58, 10); Console.Write(MyEstud.Cod);
                Console.SetCursorPosition(58, 11); Console.Write(MyEstud.Nombre);
                Console.SetCursorPosition(58, 12); Console.Write(MyEstud.Correo);
                Console.SetCursorPosition(49, 15); Console.Write(MyEstud.Nota1);
                Console.SetCursorPosition(49, 16); Console.Write(MyEstud.Nota2);
                Console.SetCursorPosition(49, 17); Console.Write(MyEstud.Nota3);
                Console.SetCursorPosition(74, 15); Console.Write(MyEstud.Prome);
                Console.SetCursorPosition(74, 16); Console.Write(MyEstud.Aprob);
            }
            else
            {
                Console.SetCursorPosition(42, 16); cw("El estudiante de codigo »" + cod + "« no existe");
                Console.SetCursorPosition(45, 19); cw("■ «-- Press enter to Close --» ■");
                form.Error_CB_B();
            }            
        }
        public void ActualizarEstudiante()
        {
            string aux_cod;
            int cod;
            bool cod_val = false;
            do
            {
                Console.SetCursorPosition(43, 9); cw("                   ");
                Console.SetCursorPosition(43, 9); aux_cod = Console.ReadLine();
                if (val.Vacio_form(aux_cod))
                {
                    if (val.V_Codigo(aux_cod))
                    {
                        cod_val = true;
                    }
                }
            } while (!cod_val);
            cod = Convert.ToInt32(aux_cod);
            if (Existe(cod))
            {                
                for (int ind = 75; ind < 106; ind++)
                {
                    for (int it = 12; it <= 16; it++)
                    {
                        Console.SetCursorPosition(ind, it); cw(" ");
                    }
                }
                txt.Txt_D_Actualizar();
                
                if (Existe(cod))
                {
                    Estudiante MyEstud = ObtenerDatos(cod);
                    Console.SetCursorPosition(89, 12); Console.Write(MyEstud.Nombre);
                    Console.SetCursorPosition(89, 13); Console.Write(MyEstud.Correo);
                    Console.SetCursorPosition(89, 14); Console.Write(MyEstud.Nota1);
                    Console.SetCursorPosition(89, 15); Console.Write(MyEstud.Nota2);
                    Console.SetCursorPosition(89, 16); Console.Write(MyEstud.Nota3);
                    Console.SetCursorPosition(89, 17); Console.Write(MyEstud.Prome);
                    Console.SetCursorPosition(89, 18); Console.Write(MyEstud.Aprob);
                }

                string nom, email, nt1, nt2, nt3, aprob;
                double not1 = 0, not2 = 0, not3 = 0;
                bool txt_val = false;
                bool email_val = false;
                bool nt1_v = false;
                bool nt2_v = false;
                bool nt3_v = false;
                Estudiante student = ObtenerDatos(cod);
                do
                {
                    Console.SetCursorPosition(31, 11); cw("                   ");
                    Console.SetCursorPosition(31, 11); nom = Console.ReadLine();
                    if (val.Vacio_A(nom))
                    {
                        Console.SetCursorPosition(73, 26); string confi = Console.ReadLine();
                        if (confi == "si" || confi == "SI")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(31, 11); cw("×-× Sin cambios ×-×");                            
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            student.Nombre = student.Nombre;
                            txt_val = true;
                            form.Limpiar();
                        }
                    }
                    else
                    {
                        if (val.V_Texto(nom))
                        {
                            student.Nombre = nom;                            
                            txt_val = true;
                        }
                    }
                } while (!txt_val);

                do
                {                    
                    Console.SetCursorPosition(31, 13); cw("                   ");
                    Console.SetCursorPosition(31, 13); email = Console.ReadLine();
                    if (val.Vacio_A(email))
                    {
                        Console.SetCursorPosition(73, 26); string confi = Console.ReadLine();
                        if (confi == "si" || confi == "SI")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(31, 13); cw("×-× Sin cambios ×-×");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            student.Correo = student.Correo;
                            email_val = true;
                            form.Limpiar();
                        }
                    }
                    else
                    {
                        if (val.V_Correo(email))
                        {
                            student.Correo = email;                            
                            email_val = true;
                        }
                    }
                } while (!email_val);

                do
                {
                    Console.SetCursorPosition(31, 16); cw("                   ");
                    Console.SetCursorPosition(31, 16); nt1 = Console.ReadLine();
                    if (val.Vacio_A(nt1))
                    {
                        Console.SetCursorPosition(73, 26); string confi = Console.ReadLine();
                        if (confi == "si" || confi == "SI")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(31, 16); cw("×-× Sin cambios ×-×");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            student.Nota1 = student.Nota1;
                            nt1_v = true;
                            form.Limpiar();
                        }
                    }
                    else
                    {
                        if (val.V_Nota(nt1))
                        {
                            not1 = double.Parse(nt1);
                            student.Nota1 = not1;                            
                            nt1_v = true;
                        }
                    }
                } while (!nt1_v);
                
                do
                {
                    Console.SetCursorPosition(31, 18); cw("                   ");
                    Console.SetCursorPosition(31, 18); nt2 = Console.ReadLine();
                    if (val.Vacio_A(nt2))
                    {
                        Console.SetCursorPosition(73, 26); string confi = Console.ReadLine();
                        if (confi == "si" || confi == "SI")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(31, 18); cw("×-× Sin cambios ×-×");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            student.Nota2 = student.Nota2;
                            nt2_v = true;
                            form.Limpiar();
                        }
                    }
                    else
                    {
                        if (val.V_Nota(nt2))
                        {
                            not2 = double.Parse(nt2);
                            student.Nota2 = not2;
                            nt2_v = true;
                        }
                    }
                } while (!nt2_v);
                
                do
                {
                    Console.SetCursorPosition(31, 20); cw("                   ");
                    Console.SetCursorPosition(31, 20); nt3 = Console.ReadLine();
                    if (val.Vacio_A(nt3))
                    {
                        Console.SetCursorPosition(73, 26); string confi = Console.ReadLine();
                        if (confi == "si" || confi == "SI")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(31, 20); cw("×-× Sin cambios ×-×");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            student.Nota3 = student.Nota3;
                            nt3_v = true;
                            form.Limpiar();
                        }
                    }
                    else
                    {
                        if (val.V_Nota(nt3))
                        {
                            not3 = double.Parse(nt3);
                            student.Nota3 = not3;                            
                            nt3_v = true;
                        }
                    }
                } while (!nt3_v);
                double prome = (student.Nota1 + student.Nota2 + student.Nota3) / 3.0;
                if (prome >= 3.5)
                {
                    aprob = "Aprobo";
                }
                else
                {
                    aprob = "Reprobo";
                }
                student.Prome = Math.Round(prome, 1);
                student.Aprob = aprob;
                form.Correct_Form();

            }
            else
            {
                form.Error_Form();
                form.Error_06();
            }
                

        }
        public void BorrarEstudiante()
        {
            string cod;
            bool Cod_V = false;
            do
            {
                Console.SetCursorPosition(83, 21); Console.WriteLine("      ");
                Console.SetCursorPosition(83, 21); cod = Console.ReadLine();
                if (val.VacioBuBo(cod))
                    if (val.VB_B_Codigo(cod))
                        Cod_V = true;
            } while (!Cod_V);

            if (Existe(Convert.ToInt32(cod)))
            {
                form.Alert_Borrar();
                Estudiante MyEstud = ObtenerDatos(Convert.ToInt32(cod));
                Console.SetCursorPosition(38, 15); cw("¿ Esta seguro que desea eliminar al estudiante ?");
                Console.SetCursorPosition(52, 16); cw(MyEstud.Nombre);
                Console.SetCursorPosition(59, 17); cw("si/no");
                Console.SetCursorPosition(58, 18); cw("»     «");
                Console.SetCursorPosition(60, 18); string Confirm = Console.ReadLine();
                
                for (int f = 38; f < 89; f++)
                {
                    Console.SetCursorPosition(f, 17); cw("");
                    Console.SetCursorPosition(f, 18); cw("");
                    Console.SetCursorPosition(f, 19); cw("");
                }

                if (Confirm == "si" || Confirm == "SI")
                {
                    form.Limpiar_Bo();
                    form.Borrar();                    
                    Console.SetCursorPosition(52, 16); cw(MyEstud.Nombre);
                    Console.SetCursorPosition(52, 17); cw("Eliminado con exito");
                    ListaEstudiante.Remove(MyEstud);
                }
                else
                {
                    form.Limpiar_Bo();
                    form.Error_CB_B();                    
                    Console.SetCursorPosition(47, 16); cw("El porceso a sido cancelado");
                    Console.SetCursorPosition(45, 19); cw("■ «-- Press enter to Close --» ■");                    
                }
            }
            else
            {
                form.Limpiar_Bo();
                form.Error_CB_B();                
                Console.SetCursorPosition(42, 16); cw("El estudiante de codigo »" + cod + "« no existe");
                Console.SetCursorPosition(45, 19); cw("■ «-- Press enter to Close --» ■");                
            }
        }        
        static bool Existe(int cod)
        {
            bool aux = false;
            foreach (Estudiante obj_estu in ListaEstudiante)
            {
                if (obj_estu.Cod == cod)
                    aux = true;
            }
            return aux;
        }
        static Estudiante ObtenerDatos(int cod)
        {
            foreach (Estudiante obj_estu in ListaEstudiante)
            {
                if (obj_estu.Cod == cod)
                    return obj_estu;
            }
            return null;
        }
        public void EscribirXml()
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
            TextWriter escribirXml = new StreamWriter("C:/datosnet/listaEstudiantes.xml");
            codificador.Serialize(escribirXml, ListaEstudiante);
            escribirXml.Close();
            Console.SetCursorPosition(45, 19); cw("■ «---- Archivo Guardado ----» ■");
        }
        public void LeerXml()
        {
            ListaEstudiante.Clear();
            if (File.Exists("C:/datosnet/listaEstudiantes.xml"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
                FileStream leerXml = File.OpenRead("C:/datosnet/listaEstudiantes.xml");
                ListaEstudiante = (List<Estudiante>)codificador.Deserialize(leerXml);
                leerXml.Close();
                Console.SetCursorPosition(45, 19); cw("■ «---- Archivo  Cargado ----» ■");
            }
            else
            {
                Console.SetCursorPosition(45, 19); cw("■ «- Archivo  No Encontrado -» ■");
            }
        }
        public void cw(string s)
        {
            Console.WriteLine(s);
        }
    }
}