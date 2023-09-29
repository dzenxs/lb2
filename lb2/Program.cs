using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] data = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MyMatrix matrixData = new MyMatrix(data);

            Console.WriteLine(matrixData);

            Console.WriteLine("\n\n");




            try
            {

                double[][] jaggedMatrix = new double[][]
                {
                    new double[] { 1, 2, 7 },
                    new double[] { 4, 5, 6 },
                    new double[] { 7, 8, 9 }
                };


                MyMatrix matrixJagged = new MyMatrix(jaggedMatrix);

                Console.WriteLine(matrixJagged);


            }
            catch (ArgumentException ex)
            {

                Console.WriteLine($"{ex.Message}");
            }


            Console.WriteLine("\n\n");

            string[] stringArr = { "1 2    3", "4 5 6", "7 8 9" };

            MyMatrix stringMatrix = new MyMatrix(stringArr);

            Console.WriteLine(stringMatrix);



            string matrix = "1 2   3\n 4  5  6\n 7 8 9";

            MyMatrix line = new MyMatrix(matrix);

            Console.WriteLine(line);

            Console.ReadKey();

        }
    }
}
