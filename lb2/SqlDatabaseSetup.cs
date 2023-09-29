using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;

namespace Task_1
{
    [TestClass()]
    public class MatrixDataTests
    {
        [TestMethod]
        public void TestInitializeWithDoubleArray()
        {

            double[,] data = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            MyMatrix matrix = new MyMatrix(data);


            
            CollectionAssert.AreEqual(data, matrix.matrix);
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
            double[,] expectedData = { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };

            
            MyMatrix matrix = new MyMatrix(jaggedData);

            
            CollectionAssert.AreEqual(expectedData, matrix.matrix);
        }

        [TestMethod]
        public void TestInitializeWithStringArray()
        {
            
            string[] stringData = { "1   2   3", "4 5 6", "7 8 9" };
            double[,] expectedData = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            
            MyMatrix matrix = new MyMatrix(stringData);

            
            CollectionAssert.AreEqual(expectedData, matrix.matrix);
        }

        [TestMethod]
        public void TestInitializeWithString()
        {
            
            string stringData = "1 2   3\n 3  2  5\n 5 6 3";
            double[,] expectedData = { { 1.0, 2.0, 3.0 }, { 3.0, 2.0, 5.0 }, { 5.0, 6.0, 3.0 } };

            
            MyMatrix matrix = new MyMatrix(stringData);

            
            CollectionAssert.AreEqual(expectedData, matrix.matrix);
        }
        
    }
}
