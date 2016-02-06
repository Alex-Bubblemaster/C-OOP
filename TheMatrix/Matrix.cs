namespace TheMatrix
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Matrix<T> : IEnumerable<T>
    {
        private T[,] matrix;
        private T element; 
        private int rows;
        private int cols;

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2) 
        {
            return Matrix<T>.Add(m1,m2); 
        }
        public static Matrix<T> Add(Matrix<T> m1, Matrix<T> m2) 
        {
            if (typeof(T) == typeof(byte) || typeof(T) == typeof(char) || typeof(T) == typeof(decimal) || typeof(T) == typeof(double) ||
                typeof(T) == typeof(Int16) || typeof(T) == typeof(Int32) || typeof(T) == typeof(Int64) || typeof(T) == typeof(UInt16) || typeof(T) == typeof(UInt32) ||
                typeof(T) == typeof(UInt64))
            {
                Matrix<T> r = new Matrix<T>(m1.rows, m1.cols);
                for (int i = 0; i < r.rows; i++)
                    for (int j = 0; j < r.cols; j++)
                        r[i, j] = (dynamic)m1[i, j] + m2[i, j];
                return r;
            }
            else
            {
                throw new ArgumentException("Matrices of this type cannot be added");
            }
        }
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            return Matrix<T>.Subtract(m1, m2);
        }
        public static Matrix<T> Subtract(Matrix<T> m1, Matrix<T> m2)
        {
            if (typeof(T) == typeof(byte) || typeof(T) == typeof(char) || typeof(T) == typeof(decimal) || typeof(T) == typeof(double) ||
                typeof(T) == typeof(Int16) || typeof(T) == typeof(Int32) || typeof(T) == typeof(Int64) || typeof(T) == typeof(UInt16) || typeof(T) == typeof(UInt32) ||
                typeof(T) == typeof(UInt64))
            {
                Matrix<T> r = new Matrix<T>(m1.rows, m1.cols);
                for (int i = 0; i < r.rows; i++)
                    for (int j = 0; j < r.cols; j++)
                        r[i, j] = (dynamic)m1[i, j] - m2[i, j];
                return r;
            }
            else
            {
                throw new ArgumentException("Matrices of this type cannot be substracted");
            }
        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            return Matrix<T>.Multiply(m1, m2);
        }
        public static Matrix<T> Multiply(Matrix<T> m1, Matrix<T> m2)
        {
            if (typeof(T) == typeof(byte) || typeof(T) == typeof(char) || typeof(T) == typeof(decimal) || typeof(T) == typeof(double) ||
                typeof(T) == typeof(Int16) || typeof(T) == typeof(Int32) || typeof(T) == typeof(Int64) || typeof(T) == typeof(UInt16) || typeof(T) == typeof(UInt32) ||
                typeof(T) == typeof(UInt64))
            {
                Matrix<T> result = new Matrix<T>(m1.rows, m2.cols);
                for (int i = 0; i < result.rows; i++)
                    for (int j = 0; j < result.cols; j++)
                        for (int k = 0; k < m1.cols; k++)
                            result[i, j] += (dynamic)m1[i, k] * m2[k, j];
                return result;
            }
            else
            {
                throw new ArgumentException("Matrices of this type cannot be multiplied");
            }
        }
       public static bool operator true(Matrix<T> matrix)
       {
           for (int row = 0; row < matrix.rows; row++)
           {
               for (int col = 0; col < matrix.cols; col++)
               {
                   if (matrix[row,col] == (dynamic)0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }
       public static bool operator false(Matrix<T> matrix)
       {
           for (int row = 0; row < matrix.rows; row++)
           {
               for (int col = 0; col < matrix.cols; col++)
               {
                   if (matrix[row, col] == (dynamic)0)
                   {
                       return false;
                   }
               }
           }
           return true;
       }
        public int Rows
        {
            get { return this.rows; }
            set 
            {
                if (this.rows < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number for rows");
                }
                this.rows = value; 
            }
        }
        public int Cols
        {
            get { return this.cols; }
            set 
            {
                if (this.cols < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number for columns");
                }
                this.cols = value; 
            }
        }
        public T Element
        {
            get { return element; }
            set { this.element = value; }
        }
        public Matrix(int iRows, int iCols)
        {
            this.rows = iRows;
            this.cols = iCols;
            matrix = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }
        public void AddElement(T element, int iRows, int iCols)
        {
            this.matrix[this.rows, this.cols] = this.element;
        }

        public override string ToString()                           // Function returns matrix as a string
        {
            string s = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) s += String.Format("{0,5:0.00}", matrix[i, j]) + " ";
                s += "\r\n";
            }
            return s;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var t in this.matrix)
            {
                yield return t;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }
        public class MException : Exception
        {
            public MException(string message)
                : base(message)
            { }
        }
     }
}
