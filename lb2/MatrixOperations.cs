﻿using Microsoft.Data.Schema.UnitTesting;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {

            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
            {
                throw new Exception("Error");
            }
            double[,] result = new double[matrix1.Height, matrix1.Width];

            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix1.Width; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }

            }
            return new MyMatrix(result);
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {

            if (matrix1.Height == matrix2.Width)
            {
                double[,] result = new double[matrix1.Height, matrix1.Width];

                for (int i = 0; i < matrix1.Height; i++)
                {
                    for (int j = 0; j < matrix1.Width; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }

                }
                return new MyMatrix(result);

            }
            else
            {
                throw new Exception("Error");
            }

        }
        private double[,] GetTransponedArray()
        {
            double[,] transponedArray = new double[Width, Height];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    transponedArray[i, j] = this.matrix[i, j];

                }

            }
            return transponedArray;
        }
        public MyMatrix GetTransponedCopy()
        {
            double[,] transponedArray = GetTransponedArray();
            return new MyMatrix(transponedArray);
        }
        public void TransponeMe()
        {
            double[,] transponedArray = GetTransponedArray();
            MyMatrix transponedMatrix = new MyMatrix(transponedArray);
            this.matrix = transponedMatrix.matrix;

        }

        //determinant

        /*private double? determinant;

        public double CalcDeterminant()
        { 
            if (Height != Width) 
            {
                throw new Exception("This matrix isn`t square");
            }
            if (!determinant.HasValue)
            {
                double determ = CalculateDeterminant();

            }

            return determinant.Value;
        }
        private double CalculateDeterminant()
        {
            int n = Height;
            double determ = 1.0;
            double[,] tempMatrix = new double[n, n];

            // покищо тимчасова матриця 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tempMatrix[i, j] = matrix[i, j];
                }

            }*/



        }
    }

}
