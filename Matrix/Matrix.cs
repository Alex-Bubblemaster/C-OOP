using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMatrix
{
    class Matrix<T>//: IEnumerable<T>
    {
        private T[,] matrix;
        private T element;
        private int rows;
        private int cols;

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
        public void AddElement(T element, int iRows,int iCols)
        {
            this.matrix[this.rows, this.cols] = this.element;
        }
        public Matrix<T> GetCol(int k)
        {
            Matrix<T> m = new Matrix<T>(rows, 1);
            for (int i = 0; i < rows; i++) m[i, 0] = matrix[i, k];
            return m;
        }

        public void SetCol(Matrix<T> v, int k)
        {
            for (int i = 0; i < rows; i++) matrix[i, k] = v[i, 0];
        }
        public override string ToString()                           // Function returns matrix as a string
        {
            string s = string.Empty;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++) s += String.Format("{0,5:0}", matrix[i, j]) + " ";
                s += "\r\n";
            }
            return s;
        }
        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    foreach (var t in this.matrix)
        //    {
        //        yield return t;
        //    }
        //}
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
        
    }
}
