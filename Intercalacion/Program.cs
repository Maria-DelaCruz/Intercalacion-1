using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Programa37_IntercalaciónSimpleNumerosdeControl
{
    class IntercalaciónSimple
    {
        public long[] A, B, C;
        public int NumI = 0, NumC = 0, NumP = 3, NumIA = 0, NumCA = 0, NumPA = 0, NumIB = 0, NumCB = 0, NumPB = 0;


        public IntercalaciónSimple()
        {

            A = new long[25];
            B = new long[25];
            C = new long[50];
        }
        public void CreacionArregloA()
        {
            Random Rd = new Random();
            for (int x = 0; x < A.Length; x++)
            {
                A[x] = Rd.Next(21210000, 21219999);
            }
        }
        public void CreacionArregloB()
        {
            Random Rd = new Random();
            for (int x = 0; x < B.Length; x++)
            {
                B[x] = Rd.Next(21210000, 21219999);
            }
        }
        public void BurbujaA()
        {
            long Temp;
            for (int K = 1; K <= A.Length - 1; K++)
            {
                for (int L = 0; L <= A.Length - 1 - K; L++)
                {
                    if (A[L] > A[L + 1])
                    {
                        Temp = A[L];
                        A[L] = A[L + 1];
                        A[L + 1] = Temp;
                        NumIA++;
                    }
                    NumCA++;
                }
                NumPA++;
            }
        }
        public void BurbujaB()
        {
            long Temp;
            for (int K = 1; K <= B.Length - 1; K++)
            {
                for (int L = 0; L <= B.Length - 1 - K; L++)
                {
                    if (B[L] > B[L + 1])
                    {
                        Temp = B[L];
                        B[L] = B[L + 1];
                        B[L + 1] = Temp;
                        NumIB++;
                    }
                    NumCB++;
                }
                NumPB++;
            }
        }
        public void DesplejarArregloA()
        {
            for (int n = 0; n < A.Length - 1; n++)
            {
                Console.WriteLine((n + 1) + ". " + A[n]);
            }
        }
        public void DesplejarArregloB()
        {
            for (int n = 0; n < B.Length - 1; n++)
            {
                Console.WriteLine((n + 1) + ". " + B[n]);
            }
        }
        public void IntercalacionSimple()
        {
            int i = 0, j = 0, k = 0;
            while (i <= A.Length - 1 && j <= B.Length - 1)
            {
                NumC++;
                if (A[i] <= B[j])
                {
                    C[k] = A[i];
                    i++;
                    k++;
                    NumI++;
                }
                C[k] = B[j];
                j++;
                k++;
                NumI++;
            }
            if (i > A.Length - 1)
            {
                for (int x = j; x < B.Length - 1; x++)
                {
                    C[k] = B[x];
                    k++;
                    NumI++;
                }
            }
            else
            {
                for (int x = i; x < A.Length - 1; x++)
                {
                    C[k] = A[x];
                    k++;
                    NumI++;
                }
            }

        }
        public void DesplejarArregloC()
        {
            for (int n = 0; n < C.Length; n++)
            {
                Console.WriteLine((n + 1) + ". " + C[n]);
            }
        }
        ~IntercalaciónSimple()
        {
            Console.WriteLine(" Memoria de la Clase Intercalación Simple Numeros de Control Liberada...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long Inicio = System.GC.GetTotalMemory(true);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            char Op;
            IntercalaciónSimple IS = new IntercalaciónSimple();
            do
            {
                Console.Clear();
                Console.WriteLine("*-*MENU Intercalación Simple -Numeros de Control- *-*");
                Console.WriteLine("a) Generar/Inicializar los Arreglos A y B");
                Console.WriteLine("b) Desplegar Arreglos A y B.");
                Console.WriteLine("c) Ordenar Arreglos A y B.");
                Console.WriteLine("d) Intercalar Arreglos A y B..");
                Console.WriteLine("e) Desplegar Arreglo C");
                Console.WriteLine("f) Salir del Programa.");
                Console.Write("Seleccione una Opcion: ");
                Op = char.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 'a':
                        {
                            IS.CreacionArregloA();
                            IS.CreacionArregloB();
                            Console.Write("\nArreglos Generados");
                            Console.ReadKey();
                        }
                        break;
                    case 'b':
                        {
                            Console.Clear();
                            Console.Write("Arreglo A:\n");
                            IS.DesplejarArregloA();
                            Console.Write("\nArreglo B:\n");
                            IS.DesplejarArregloB();
                            Console.ReadKey();
                        }
                        break;
                    case 'c':
                        {
                            Console.WriteLine("\nArreglos Ordenados");
                            IS.BurbujaA();
                            IS.BurbujaB();
                            Console.ReadKey();
                        }
                        break;
                    case 'd':
                        {
                            Console.WriteLine("\nIntercalar Arreglos");
                            IS.IntercalacionSimple();
                            Console.ReadKey();
                        }
                        break;
                    case 'e':
                        {
                            Console.Clear();
                            Console.WriteLine("\nDesplegar Arreglo C");
                            IS.DesplejarArregloC();
                            Console.ReadKey();
                        }
                        break;
                    case 'f':
                        {
                            Console.WriteLine("\n Programa terminado");
                            Console.WriteLine("\n Arreglos Intercalados");
                            Console.WriteLine(" ««Numero de Intercambios: {0} »»", IS.NumI);
                            Console.WriteLine(" ««Numero de Comparaciones: {0} »»", IS.NumC);
                            Console.WriteLine(" ««Numero de Pasadas: {0} »»", IS.NumP);
                            Console.WriteLine("\n Ordenamiento del Arreglo A");
                            Console.WriteLine(" ««Numero de Intercambios: {0} »»", IS.NumIA);
                            Console.WriteLine(" ««Numero de Comparaciones: {0} »»", IS.NumCA);
                            Console.WriteLine(" ««Numero de Pasadas: {0} »»", IS.NumPA);
                            Console.WriteLine("\n Ordenamiento del Arreglo B");
                            Console.WriteLine(" ««Numero de Intercambios: {0} »»", IS.NumIB);
                            Console.WriteLine(" ««Numero de Comparaciones: {0} »»", IS.NumCB);
                            Console.WriteLine(" ««Numero de Pasadas: {0} »»", IS.NumPB);
                            Console.WriteLine("\n\n ««Tiempo tomado: {0}s »»", sw.Elapsed.TotalSeconds);
                            long Fin = System.GC.GetTotalMemory(true);
                            Console.WriteLine(" ««La Cantidad de memoria en bytes utilizada es de: {0} »»\n", Fin - Inicio);
                        }
                        break;
                    default:
                        Console.Write("\nOpcion no encontrada... \nPresione «ENTER» para Volver al Menu___");
                        Console.ReadKey();
                        break;
                }
            } while (Op != 'f');
        }
    }
}
