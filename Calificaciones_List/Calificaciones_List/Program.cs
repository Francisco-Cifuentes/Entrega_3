using System;

namespace Calificaciones_List
{
    class Program
    {
        static Texto txt = new Texto();
        static Formato form = new Formato();
        static Metodos metod = new Metodos();
        static Validaciones val = new Validaciones();
        static void Main(string[] args)
        {
            form.Bienvenida();
            string aux;
            int opc;
            do
            {
                bool flag = false;
                form.M_Principal();
                txt.Txt_Principla();
                do
                {
                    Console.SetCursorPosition(85, 21); Console.WriteLine("     ");
                    Console.SetCursorPosition(85, 21); aux = Console.ReadLine();
                    if (val.Vacio(aux))
                    {
                        if (val.V_Numero(aux))
                        {
                            flag = true;
                        }
                    }
                } while (!flag);

                opc = int.Parse(aux);

                switch (opc)
                {
                    case 1:
                        form.M_Agregar();
                        txt.Txt_Agregar();
                        metod.CrearEstudiante();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        form.M_Listar();
                        txt.Txt_Listar();
                        metod.ListarEstudiantes();
                        Console.ReadKey();
                        break;
                    case 3:
                        form.M_Buscar_Borrar();
                        txt.Txt_Buscar();
                        metod.BuscarEstudiante();
                        Console.ReadKey();
                        break;
                    case 4:
                        form.M_Agregar();
                        txt.Txt_Actualizar();
                        metod.ActualizarEstudiante();
                        Console.ReadKey();
                        break;
                    case 5:
                        form.M_Buscar_Borrar();
                        txt.Txt_Borrar();
                        metod.BorrarEstudiante();
                        Console.ReadKey();
                        break;
                    case 8:
                        metod.EscribirXml();
                        Console.SetCursorPosition(45, 19); val.cw("■ «---- Archivo Guardado ----» ■");
                        Console.ReadKey();
                        break;
                    case 9:
                        metod.LeerXml();
                        Console.SetCursorPosition(45, 19); val.cw("■ «---- Archivo  Cargado ----» ■");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.SetCursorPosition(45, 19); val.cw("■ «-- Press enter to Close --» ■");
                        break;
                    default:
                        for (int ind = 65; ind < 90; ind++)
                        {
                            for (int h = 16; h <= 18; h++)
                            {
                                Console.SetCursorPosition(ind, h); val.cw(" ");
                            }
                        }
                        Console.SetCursorPosition(70, 16); val.cw("Seleccione una");
                        Console.SetCursorPosition(70, 17); val.cw("de las opciones");
                        Console.SetCursorPosition(70, 18); val.cw("  indicadas.");
                        form.Error_C();
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            Console.ReadKey();
        }
    }
}
