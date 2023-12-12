using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NikolaevaAN.Sprint6.TaskReview.V9.Lib;

namespace Tyuiu.NikolaevaAN.Sprint6.TaskReview.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_NAN_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(textBoxRows_NAN.Text);
                int columns = Convert.ToInt32(textBoxColumns_NAN.Text);
                int n1 = Convert.ToInt32(textBoxMinRnd_NAN.Text);
                int n2 = Convert.ToInt32(textBoxMaxRnd_NAN.Text);
                int c = Convert.ToInt32(textBoxC_NAN.Text);
                int k = Convert.ToInt32(textBoxK_NAN.Text);
                int l = Convert.ToInt32(textBoxL_NAN.Text);
                int[,] array = new int[rows, columns];
                int res = ds.Result(array, c, k, l);
                array = ds.GetMatrix(array, n1, n2);

                dataGridViewMatrix_NAN.ColumnCount = columns;
                dataGridViewMatrix_NAN.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMatrix_NAN.Columns[i].Width = 30;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMatrix_NAN.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                    }
                }

                buttonResult_NAN.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_NAN_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(textBoxRows_NAN.Text);
            int columns = Convert.ToInt32(textBoxColumns_NAN.Text);
            int n1 = Convert.ToInt32(textBoxMinRnd_NAN.Text);
            int n2 = Convert.ToInt32(textBoxMaxRnd_NAN.Text);
            int c = Convert.ToInt32(textBoxC_NAN.Text);
            int k = Convert.ToInt32(textBoxK_NAN.Text);
            int l = Convert.ToInt32(textBoxL_NAN.Text);

            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int col = 0; col < columns; col++)
                {
                    arrayValues[r, col] = Convert.ToInt32(dataGridViewMatrix_NAN.Rows[r].Cells[col].Value);
                }
            }
            int res = ds.Result(arrayValues, c, k, l);
            textBoxDone_NAN.Text = Convert.ToString(res);
        }
    }
}
