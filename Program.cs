using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d1 = 0, d2 = 0, determinante;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================");
            Console.WriteLine("         MATRIZ INVERSA          ");
            Console.WriteLine("================================");
            Console.WriteLine();
            Console.WriteLine("qual vai ser o tamanho da matriz (digite N1XN2)");
            Console.ResetColor();
            string teste = Console.ReadLine();
            teste = teste.ToUpper();
            string[] teste2 = teste.Split('X');
            int k = int.Parse(teste2[0]);
            if (teste2[0] != teste2[1])
            {
                Console.WriteLine("a matriz precisa ser quadrada, porfavor volte ao inicio");
            }
            else
            {
                if (teste2[0] == "1")
                {

                    Console.WriteLine("digite o numero dentro da matriz");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("a matriz inversa de " + "[" + b + "]" + " é " + "[1/" + b + "]");
                }
                else if (teste2[0] == "2")
                {
                    double[,] matriz = new double[2, 2];
                    int x1 = 1, x2 = 1;
                    for (int lin = 0; lin < 2; lin++)
                    {
                        for (int col = 0; col < 2; col++)
                        {
                            Console.WriteLine("digite o numero da matriz" + x1 + "," + x2);
                            double oi = double.Parse(Console.ReadLine());
                            matriz[lin, col] = oi;
                            x2++;
                        }
                        x1++;
                        x2 = 1;
                    }
                    d1 = matriz[0, 0] * matriz[1, 1];
                    d2 = matriz[0, 1] * matriz[1, 0];
                    determinante = d1 - d2;
                    while (determinante == 0)
                    {
                        Console.WriteLine("o determinate nao pode ser 0, porfavor digite outros numeros");
                        x1 = 1;
                        x2 = 1;
                        for (int lin = 0; lin < 2; lin++)
                        {
                            for (int col = 0; col < 2; col++)
                            {
                                Console.WriteLine("digite o numero da matriz" + x1 + "," + x2);
                                double oi = double.Parse(Console.ReadLine());
                                matriz[lin, col] = oi;
                                x2++;
                            }
                            x1++;
                            x2 = 1;
                        }
                        d1 = matriz[0, 0] * matriz[1, 1];
                        
                        d2 = matriz[0, 1] * matriz[1, 0];
                        
                        determinante = d1 - d2;
                    }
                    Console.WriteLine("a diagonal principal é " + matriz[0, 0] + "*" + matriz[1, 1] + "= " + d1 );
                    Console.WriteLine("a diagonal segundária é " + matriz[0, 1] + "*" + matriz[1, 0] + "= " + d2);
                    Console.WriteLine("aperte uma qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("sua matriz é:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|"+matriz[0, 0] + "\t" + matriz[0, 1]+"|");
                    Console.WriteLine("|"+matriz[1, 0] + "\t" + matriz[1, 1]+"|");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Para calcular o determinante nós pegamos o valor da diagonal principal: " + d1 + " e subtraimos pelo valor da diagonal secundária: " + d2);
                    Console.ResetColor();
                    Console.Write("o valor do determinante da sua matriz é: ");


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(determinante);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(); 
                    double a1, a2, a3, a4;
                    a1 = matriz[0, 0] / determinante;
                    a2 = matriz[0, 1] / determinante;
                    a3 = matriz[1, 0] / determinante;
                    a4 = matriz[1, 1] / determinante;
                    double[,] matriz2 = new double[2, 2];
                    matriz2[0, 0] = a4;
                    matriz2[0, 1] = a2 * -1;
                    matriz2[1, 0] = a3 * -1;
                    matriz2[1, 1] = a1;
                    Console.WriteLine("aperte qualquer tecla para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("dividimos a sua matriz: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|" + matriz[0, 0] + "\t" + matriz[0, 1] + "|");
                    Console.WriteLine("|" + matriz[1, 0] + "\t" + matriz[1, 1] + "|");
                    Console.ResetColor();
                    Console.WriteLine("pelo determinante = " + determinante);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" a matriz fica assim:");
                    Console.WriteLine("|" + a1 + "\t" + a2 + "|");
                    Console.WriteLine("|" + a3 + "\t" + a4 + "|");
                    Console.ResetColor();
                    Console.WriteLine("aperte qualquer tecla para continuar ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("depois trocamos as posições da diagonal primária e invertemos o sinal da diagona secundária, dando a matriz inversa");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("a matriz inversa é");
                    Console.WriteLine("|" +matriz2[0, 0] + "\t" + matriz2[0, 1] + "|");
                    Console.WriteLine("|" +matriz2[1, 0] + "\t" + matriz2[1, 1] +"|");
                    Console.ResetColor();
                }
                else if (teste2[0] == "3")
                {
                    double[,] matriz = new double[3, 3];
                    int x1 = 1, x2 = 1;
                    for (int lin = 0; lin < 3; lin++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Console.WriteLine("digite o numero da matriz" + x1 + "," + x2);
                            double oi = double.Parse(Console.ReadLine());
                            matriz[lin, col] = oi;
                            x2++;
                        }
                        x1++;
                        x2 = 1;
                    }
                    d1 = matriz[0,0] * matriz[1,1] * matriz[2,2] + matriz[1,0]*matriz[2,1]*matriz[0,2] + matriz[0,1] * matriz[1,2] * matriz[2,0];
                    d2 = matriz[0, 2] * matriz[1, 1] * matriz[2, 0] + matriz[0, 1] * matriz[1, 0] * matriz[2, 2] + matriz[1, 2] * matriz[2, 1] * matriz[0, 0];
                    determinante = d1 - d2;
                    while(determinante == 0)
                    {
                        Console.WriteLine("o determinante da matriz nao pode ser 0 porfavor digite novamente");

                        x1 = 1;
                        x2 = 1;
                        for (int lin = 0; lin < 3; lin++)
                        {
                            for (int col = 0; col < 3; col++)
                            {
                                Console.WriteLine("digite o numero da matriz" + x1 + "," + x2);
                                double oi = double.Parse(Console.ReadLine());
                                matriz[lin, col] = oi;
                                x2++;
                            }
                            x1++;
                            x2 = 1;
                        }
                        d1 = matriz[0, 0] * matriz[1, 1] * matriz[2, 2] + matriz[1, 0] * matriz[2, 1] * matriz[0, 2] + matriz[0, 1] * matriz[1, 2] * matriz[2, 0];
                        d2 = matriz[0, 2] * matriz[1, 1] * matriz[2, 0] + matriz[0, 1] * matriz[1, 0] * matriz[2, 2] + matriz[1, 2] * matriz[2, 1] * matriz[0, 0];
                        determinante = d1 - d2;
                    }
                    Console.Clear();
                    Console.WriteLine("o valor do determinante é igual a: " + determinante);
                    double t11, t12, t13, t21, t22, t23, t31, t32, t33;
                    t11 = Math.Pow(-1,2)*(matriz[1, 1] * matriz[2, 2] - (matriz[1, 2] * matriz[2, 1]));
                    t12 = Math.Pow(-1, 3) * (matriz[1, 0] * matriz[2, 2] - (matriz[1, 2] * matriz[2, 0]));
                    t13 = Math.Pow(-1, 4) * (matriz[1, 0] * matriz[2, 1] - (matriz[1, 1] * matriz[2, 0]));
                    t21 = Math.Pow(-1, 3) * (matriz[0,1] * matriz[2, 2] - (matriz[0, 2] * matriz[2, 1]));
                    t22 = Math.Pow(-1, 4) * (matriz[0,0] * matriz[2, 2] - (matriz[0, 2] * matriz[2, 0]));
                    t23 = Math.Pow(-1, 5) * (matriz[0,0] * matriz[2, 1] - (matriz[0, 1] * matriz[2, 0]));
                    t31 = Math.Pow(-1, 4) * (matriz[0,1] * matriz[1, 2] - (matriz[0, 2] * matriz[1, 1]));
                    t32 = Math.Pow(-1, 5) * (matriz[0,0] * matriz[1, 2] - (matriz[0, 2] * matriz[1, 0]));
                    t33 = Math.Pow(-1, 6) * (matriz[0,0] * matriz[1, 1] - (matriz[0, 1] * matriz[1, 0]));
                    double[,] matriz2 = new double[3,3];
                    matriz2[0, 0] = t11;
                    matriz2[1, 0] = t12;
                    matriz2[2, 0] = t13;
                    matriz2[0, 1] = t21;
                    matriz2[1,1] = t22;
                    matriz2[2, 1] = t23;
                    matriz2[0,2] = t31;
                    matriz2[1,2] = t32;
                    matriz2[2,2] = t33;
                    Console.WriteLine(" a matriz inversa da matriz 3X3 é: ");
                    Console.WriteLine(matriz2[0, 0] + " " + matriz2[0, 1] + " " + matriz2[0, 2]);
                    Console.WriteLine(matriz2[1, 0] + " " + matriz2[1, 1] + " " + matriz2[1, 2] + "  " + "*" + "1/"+determinante);
                    Console.WriteLine(matriz2[2, 0] + " " + matriz2[2, 1] + " " + matriz2[2, 2]);

                }
                else if (k>3)
                {

                }
            }
        }
    }
}