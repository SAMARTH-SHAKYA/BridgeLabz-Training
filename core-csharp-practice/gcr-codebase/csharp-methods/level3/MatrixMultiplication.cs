using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class MatrixMultiplication
    {
        public static void Add(int[,] matrix1, int[,] matrix2,int rows,int cols)
        {
            int[,] add = new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {  
                Console.WriteLine(); 
                for (int j = 0; j < cols; j++)
                {
                    add[i,j] = matrix1[i,j] + matrix2[i,j];
                    Console.Write($"{add[i,j]}   ");
                }
            }
        }

        public static void Subtract(int[,] matrix1, int[,] matrix2, int rows, int cols)
        {
            int[,] sub = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    sub[i, j] = matrix1[i, j] - matrix2[i, j];
                    Console.Write($"{sub[i, j]}   ");
                }
            }
        }

        public static void Multiply(int[,] matrix1, int[,] matrix2, int rows, int cols)
        {
            int[,] mul = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        mul[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    Console.Write($"{mul[i, j]}   ");
                }
            }
        }

        public static void Transpose(int[,] matrix, int rows, int cols)
        {
            int[,] transpose = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            // printing transpose
            for (int i = 0; i < cols; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{transpose[i, j]}   ");
                }
            }
        }
        public static int Determinant2x2(int[,] matrix)
        {
            int ans = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return ans;
        }
        public static double[,] Inverse2x2(int[,] matrix)
        {
            int det = Determinant2x2(matrix);
            double[,] inverse = new double[2, 2];
            if (det == 0)
            {
                Console.WriteLine("Det is zero can not do the inverse");
                return inverse;
            }
            inverse[0, 0] = matrix[1, 1] / (double)det;
            inverse[0, 1] = -matrix[0, 1] / (double)det;
            inverse[1, 0] = -matrix[1, 0] / (double)det;
            inverse[1, 1] = matrix[0, 0] / (double)det;

            return inverse;
        }

        public static int Determinant3x3(int[,] matrix)
        {
            int det = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1])) - matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0])) + matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
            return det;
        }

        public static double[,] Inverse3x3(int[,] matrix)
        {
            int det = Determinant3x3(matrix);
            double[,] inverse = new double[3, 3];

            if (det == 0)
            {
                Console.WriteLine("Determinant is zero, cannot invert the matrix.");
                return inverse;
            }

            // Calculate cofactor matrix
            int[,] cofactor = new int[3, 3];

            cofactor[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            cofactor[0, 1] = -(matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            cofactor[0, 2] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            cofactor[1, 0] = -(matrix[0, 1] * matrix[2, 2] - matrix[0, 2] * matrix[2, 1]);
            cofactor[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]);
            cofactor[1, 2] = -(matrix[0, 0] * matrix[2, 1] - matrix[0, 1] * matrix[2, 0]);

            cofactor[2, 0] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]);
            cofactor[2, 1] = -(matrix[0, 0] * matrix[1, 2] - matrix[0, 2] * matrix[1, 0]);
            cofactor[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            // Transpose cofactor to get adjugate, then divide by determinant
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    inverse[i, j] = cofactor[j, i] / (double)det;
                }
            }

            return inverse;
        }


        public static void main()
        {
            Random rand = new Random();
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows,cols];

            for(int i =0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j=0; j < cols; j++)
                {
                    matrix1[i,j] = rand.Next(1, 51);
                    Console.Write($"{matrix1[i, j]}   ");
                }
            }

            int[,] matrix2 = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = rand.Next(1, 51);
                    Console.Write($"{matrix2[i, j]}   ");
                }
            }

            Add(matrix1,matrix2,rows,cols);
            Subtract(matrix1,matrix2,rows,cols);
            Multiply(matrix1,matrix2,rows,cols);
            Transpose(matrix1, rows, cols);

        }
    }
}
