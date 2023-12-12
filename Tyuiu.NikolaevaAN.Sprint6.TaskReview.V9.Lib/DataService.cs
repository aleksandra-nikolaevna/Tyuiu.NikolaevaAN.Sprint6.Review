using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NikolaevaAN.Sprint6.TaskReview.V9.Lib
{
    public class DataService
    {
        public int Result(int[,] array, int c, int k, int l)
        {
            int res = 1;
            for (int j = k; j <= l; j++)
            {
                if (array[j, c] % 2 == 0)
                {
                    res = res * array[j, c];
                }
            }
            return res;
        }

        public int[,] GetMatrix(int[,] array, int n1, int n2)
        {
            Random rnd = new Random();
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            if (columns % 2 == 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j = j + 2)
                    {
                        array[i, j] = rnd.Next(n1, n2 + 1);
                        array[i, j + 1] = array[i, j] * array[i, j];
                    }
                }
            }
            else
            {
                int columns2 = columns - 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns2; j = j + 2)
                    {
                        array[i, j] = rnd.Next(n1, n2 + 1);
                        array[i, j + 1] = array[i, j] * array[i, j];
                    }
                    array[i, columns - 1] = rnd.Next(n1, n2 + 1);
                }
            }
            return array;
        }
    }
}
