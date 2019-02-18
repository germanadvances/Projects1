using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Vehiculo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            //Console.Write("Tamaño de la matriz: ");
            int tamaniomatriz = 0;
            tamaniomatriz = 5;
            //int cantidad = int.Parse(Console.ReadLine());
         
            string[,] T = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" } };

            string[,] E = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","X" } };

            string[,] E1 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","X","O" } };

            string[,] E2 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","X","O","O" } };

            string[,] E3 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","X","O","O","O" } };



            string[,] N1 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "X","O","O","O","O" },{ "O", "O","O","O","O","O" } };

            string[,] N2 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "X","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" } };

            string[,] N3 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "O","O","O","O","O" },
                                        { "O", "X","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" } };

            string[,] N4 = new string[6, 6] { { "O", "O","O","O","O","O" }, { "O", "X","O","O","O","O" },
                                        { "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" },{ "O", "O","O","O","O","O" } };

            for (int i = 1; i <= tamaniomatriz; i++)
            {
                for (int j = 1; j <= tamaniomatriz; j++)
                {
                    Console.SetCursorPosition(j * 4, i + 2);
                    Console.Write(T[i, j]);
                }
            }
            //foreach (string f in T)
            //{
            //    System.Console.Write("{0} ", f);
            //}
            //crear primer comando , segundo comando , tercer comando
            Console.WriteLine();
            Console.WriteLine("Digite Comando");
            Console.WriteLine("La 'X' indica el resultado de la posicion Despues de haber ejecutado el comando");
            string c = Console.ReadLine();
            if (c != string.Empty)
            {
                bool ran = false;
                bool rani = false;
                int rang = 0;
                rang = c.Length;

                if (rang > 4)
                    ran = true;


                //if(rang < 1)
                //    rani = true;

                //string EN = "5";

                string S = "S";
                string F = ";";
                string Fa = ",";
                string po = c.Substring(2, 1);
                string e = po.ToUpper();
                string pen = c.Substring(0, 1);


                bool nf = false;
                bool nfa = false;
                bool en = false;
                bool cd = false;
                bool isnum = false;
                bool o = false;
                int num1;
                bool result = int.TryParse(pen, out num1);
                if (result == false)
                {
                    isnum = true;
                    Console.WriteLine("Error en formato de comando");
                }
                else
                {
                    int r = Convert.ToInt32(pen);
                    if (r > 4)
                        en = true;

                    if (r < 1)
                        rani = true;
                }

                string ps = (c.Substring(2, 1));
                string fo = c.Substring(3, 1);
                string fa = c.Substring(1, 1);
               

                //bool en = EN.Contains(pen);
                bool s = S.Contains(ps);

                string cad = "NSEnse";
                if (cad.Contains(ps))
                {
                    cd = false;
                }
                else
                {
                    cd = true;
                }    

                if (cd)
                    Console.WriteLine("Error en formato comando 'o' Se ha detenido el avance por salir de límites");

                if (ran)
                    Console.WriteLine("Digite un solo comando");

                if (rani)
                    Console.WriteLine("Error en formato de comando");

                if (!fo.Contains(F))
                    nf = true;

                if (nf)
                    Console.WriteLine("Error en formato de comando nf");

                if (!fa.Contains(Fa))
                    nfa = true;

                if (nfa)
                    Console.WriteLine("Error en formato de comando nfa");

                if (o)
                    Console.WriteLine("Se ha detenido el avance por salir de los límites");

                if (en)
                    Console.WriteLine("Se ha detenido el avance por salir de los límites");

                if (s)
                    Console.WriteLine("Se ha detenido el avance por salir de los límites");

                if (o == false && en == false && s == false && nf == false && nfa == false && ran == false && isnum == false && rani == false)
                {

                    for (int i = 1; i <= tamaniomatriz; i++)
                    {
                        for (int j = 1; j <= tamaniomatriz; j++)
                        {
                            Console.SetCursorPosition(j * 4, i + 2);
                            if(c == "4,E;")
                            Console.Write(E[i, j]);

                            if (c == "4,e;")
                                Console.Write(E[i, j]);

                            if (c == "3,E;")
                                Console.Write(E1[i, j]);

                            if (c == "3,e;")
                                Console.Write(E1[i, j]);

                            if (c == "2,E;")
                                Console.Write(E2[i, j]);

                            if (c == "2,e;")
                                Console.Write(E2[i, j]);

                            if (c == "1,E;")
                                Console.Write(E3[i, j]);

                            if (c == "1,e;")
                                Console.Write(E3[i, j]);


                            if (c == "1,N;")
                                Console.Write(N1[i, j]);

                            if (c == "1,n;")
                                Console.Write(N1[i, j]);

                            if (c == "2,N;")
                                Console.Write(N2[i, j]);

                            if (c == "2,n;")
                                Console.Write(N2[i, j]);

                            if (c == "3,N;")
                                Console.Write(N3[i, j]);

                            if (c == "3,n;")
                                Console.Write(N3[i, j]);

                            if (c == "4,N;")
                                Console.Write(N4[i, j]);

                            if (c == "4,n;")
                                Console.Write(N4[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
            //5,E;2,N;3,O 
        }
    }
}