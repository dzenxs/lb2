using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task_1;

namespace UnitTestTask_1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestInitializeWithDoubleArray()
        {

            double[,] data = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            MyMatrix matrix = new MyMatrix(data);

            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    Assert.AreEqual(data[i, j], matrix[i, j]);
                }
            }
        }

        [TestMethod]

        public void TestInitializeWithJaggedArray()
        {

            double[][] jaggedData = new double[][]
               {
                    new double[] { 1, 2, 3 },
                    new double[] { 4, 5, 6 },
                    new double[] { 7, 8, 9 }
               };
            double[,] expectedData = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            MyMatrix matrix = new MyMatrix(jaggedData);


            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    Assert.AreEqual(expectedData[i, j], matrix[i, j]);
                }
            }
        }
        [TestMethod]
        public void TestInitializeWithStringArray()
        {

            string[] stringData = { "1   2   3", "4 5 6", "7 8 9" };
            double[,] expectedData = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            MyMatrix matrix = new MyMatrix(stringData);


            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    Assert.AreEqual(expectedData[i, j], matrix[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestInitializeWithString()
        {

            string stringData = "1 2   3\n 3  2  5\n 5 6 3";
            double[,] expectedData = { { 1, 2, 3 }, { 3, 2, 5 }, { 5, 6, 3 } };


            MyMatrix matrix = new MyMatrix(stringData);


            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    Assert.AreEqual(expectedData[i, j], matrix[i, j]);
                }
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "matrix can only have number")]
        public void ArrayConstructorExceptionWithLettersTest()
        {

            string[] elements = { "2 n  1", "3  w 4 ", "4 3 1 " };

            new MyMatrix(elements);
        }
        [TestMethod]
        public void TestMatrixAddition()
        {
            double[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] data2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            MyMatrix matrix1 = new MyMatrix(data1);
            MyMatrix matrix2 = new MyMatrix(data2);

            MyMatrix result = matrix1 + matrix2;


            MyMatrix expectedData = new MyMatrix(new double[,] { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } });


            Assert.AreEqual(expectedData.Height, result.Height);
            Assert.AreEqual(expectedData.Width, result.Width);

            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    Assert.AreEqual(expectedData[i, j], result[i, j]);
                }
            }


        }

        [TestMethod]
        public void TestMatrixMultiplication()
        {

            MyMatrix matrix1 = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            MyMatrix matrix2 = new MyMatrix(new double[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } });

            MyMatrix result = matrix1 * matrix2;

            MyMatrix expected = new MyMatrix(new double[,] { { 18, 30, 36 }, { 72, 75, 72 }, { 126, 120, 108 } });

            Assert.AreEqual(expected.Height, result.Height);
            Assert.AreEqual(expected.Width, result.Width);

            for (int i = 0; i < result.Height; i++)
            {
                for (int j = 0; j < result.Width; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
        [TestMethod]
        public void TestGetTransponedCopy()
        {

            MyMatrix matrix = new MyMatrix(new double[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 } 
            });

            MyMatrix transposedCopy = matrix.GetTransponedCopy();

            MyMatrix expected = new MyMatrix(new double[,] 
            { 
                { 1, 4, 7 },
                { 2, 5, 8 },
                { 3, 6, 9 } 
            });
            Assert.AreEqual(matrix.Height, transposedCopy.Width);
            Assert.AreEqual(matrix.Width, transposedCopy.Height);
        }

        [TestMethod]
        public void TestTransponeMe()
        {

            MyMatrix matrix = new MyMatrix(new double[,] 
            { 
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            });

            matrix.TransponeMe();

            MyMatrix expectedData = new MyMatrix(new double[,]
            { 
                { 1, 4, 7 },
                { 2, 5, 8 },
                { 3, 6, 9 } 
            });
            Assert.AreEqual(expectedData.Width, matrix.Height);
            Assert.AreEqual(expectedData.Height, matrix.Width);


        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Error")]
        public void OperatorAdditionThrowsException()
        {

            double[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            double[,] data2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            MyMatrix matrix1 = new MyMatrix(data1);
            MyMatrix matrix2 = new MyMatrix(data2);

            MyMatrix result = matrix1 + matrix2;

        }
        [ExpectedException(typeof(Exception), "Error")]
        public void OperatorMultuplyThrowsException()
        {

            double[,] data1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            double[,] data2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            MyMatrix matrix1 = new MyMatrix(data1);
            MyMatrix matrix2 = new MyMatrix(data2);

            MyMatrix result = matrix1 * matrix2;


        }
    }
}
