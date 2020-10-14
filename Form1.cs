using System;
using System.Drawing;
using Mapack;
using System.Windows.Forms;

namespace matrix_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            A.Init();
            B.Init();
            RES.Init();
            ars = Convert.ToInt32(A.Rows.Count);
            acs = Convert.ToInt32(A.Columns.Count);
            brs = Convert.ToInt32(B.Rows.Count);
            bcs = Convert.ToInt32(B.Columns.Count);
        }

        private int ars, acs, brs, bcs;

//RESIZING
        private void bcs_ud_ValueChanged(object sender, EventArgs e)
        {
            if (bcs_ud.Value > bcs)
            {
                B.Columns.Add("", "");
                for (int i = 0; i < brs; i++)
                    B[bcs, i].Value = 0;
                bcs++;
            }
            if (bcs_ud.Value < bcs)
            {
                B.Columns.RemoveAt(bcs - 1);
                bcs--;
            }
        }
        private void brs_ud_ValueChanged(object sender, EventArgs e)
        {
            if (brs_ud.Value > brs)
            {
                B.Rows.Add();
                for (int i = 0; i < bcs; i++)
                    B[i, brs].Value = 0;
                brs++;
            }
            if (brs_ud.Value < brs)
            {
                B.Rows.RemoveAt(brs - 1);
                brs--;
            }
        }
        private void acs_ud_ValueChanged(object sender, EventArgs e)
        {
            if (acs_ud.Value > acs)
            {
                A.Columns.Add("", "");
                for (int i = 0; i < ars; i++)
                    A[acs, i].Value = 0;
                acs++;
            }
            if (acs_ud.Value < acs)
            {
                A.Columns.RemoveAt(acs - 1);
                acs--;
            }
        }
        private void ars_ud_ValueChanged(object sender, EventArgs e)
        {
            if (ars_ud.Value > ars)
            {
                A.Rows.Add();
                for (int i = 0; i < acs; i++)
                  A[i, ars].Value = 0;
                ars++;
            }
            if (ars_ud.Value < ars)
            {
                A.Rows.RemoveAt(ars - 1);
                ars--;
            }
        }

//UNARY OPERATIONS
        private Matrix Transpose(DataGridView M)
        {
            try
            {
                Matrix temp = new Matrix(M.ToDoubleArray());
                temp = temp.Transpose();
                return temp;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return new Matrix(RES.ToDoubleArray());
        }
        private void transpositionA_Click(object sender, EventArgs e)
        {
            RES.ToDisplay(Transpose(A));
        }       
        private void transposeB_Click(object sender, EventArgs e)
        {
            RES.ToDisplay(Transpose(B));
        }
        
        private Matrix Inverse(DataGridView M)
        {
            try
            {
                Matrix temp = new Matrix(M.ToDoubleArray());
                temp = temp.Inverse;
                return temp;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return new Matrix(RES.ToDoubleArray());
        }
        private void inverseA_Click(object sender, EventArgs e)
        {
            RES.ToDisplay(Inverse(A));
        }
        private void inverseB_Click(object sender, EventArgs e)
        {
            RES.ToDisplay(Inverse(B));
        }

        private Matrix MultiplyNum(DataGridView M, double n)
        {
            try
            {
                Matrix temp = new Matrix(M.ToDoubleArray());
                temp = temp * n;
                return temp;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return new Matrix(RES.ToDoubleArray());
        }
        private void AmultByNumb_Click(object sender, EventArgs e)
        {
            try
            {
                RES.ToDisplay(MultiplyNum(A, Double.Parse(textBox1.Text)));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void BmultByNumb_Click(object sender, EventArgs e)
        {
            try
            {
                RES.ToDisplay(MultiplyNum(B, Double.Parse(textBox2.Text)));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private double Determinant(DataGridView M)
        {
            try
            {
                Matrix temp = new Matrix(M.ToDoubleArray());
                double det = 0;
                det = temp.Determinant;
                return det;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            return 0;
        }
        private void determinantA_Click(object sender, EventArgs e)
        {
            label1.Text = Determinant(A).ToString();
        }
        private void determinantB_Click(object sender, EventArgs e)
        {
            label2.Text = Determinant(B).ToString();
        }

//BINARY OPERATIONS
        private void Swap_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix L = new Matrix(A.ToDoubleArray());
                Matrix R = new Matrix(B.ToDoubleArray());
                Matrix temp = new Matrix(1, 1);
                int tars = ars;
                ars = brs;
                brs = tars;
                int tacs = acs;
                acs = bcs;
                bcs = tacs;
                ars_ud.Value = ars;
                acs_ud.Value = acs;
                brs_ud.Value = brs;
                bcs_ud.Value = bcs;
                temp = L;
                L = R;
                R = temp;
                A.ToDisplay(L);
                B.ToDisplay(R);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix R = new Matrix(RES.ToDoubleArray());
                A.ToDisplay(R);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix R = new Matrix(RES.ToDoubleArray());
                B.ToDisplay(R);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void addition_Click(object sender, EventArgs e)
        {
                    try
                    {
                        Matrix L = new Matrix(A.ToDoubleArray());
                        Matrix R = new Matrix(B.ToDoubleArray());
                        Matrix res = new Matrix(1, 1);
                        res = L + R;
                        RES.ToDisplay(res);
                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
        }
        private void multiplication_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix L = new Matrix(A.ToDoubleArray());
                Matrix R = new Matrix(B.ToDoubleArray());
                Matrix res = new Matrix(1, 1);
                res = L * R;
                RES.ToDisplay(res);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void substraction_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix L = new Matrix(A.ToDoubleArray());
                Matrix R = new Matrix(B.ToDoubleArray());
                Matrix res = new Matrix(1, 1);
                res = L - R;
                RES.ToDisplay(res);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }

    public static class DTVExtension
    {
        public static void Init(this DataGridView view, int r = 3, int c = 3)
        {
            for (int i = 0; i < c; i++)
            {
                view.Columns.Add("", "");
            }
            view.Rows.Add(r);
            for (int x = 0; x < view.ColumnCount; x++)
            {
                for (int y = 0; y < view.RowCount; y++)
                {
                    view[x, y].Value = 0;
                }
            }
        }
        public static double[][] ToDoubleArray(this DataGridView view)
        {
            double[][] ret = new double[view.Rows.Count][];
            for (int x = 0; x < view.Rows.Count; x++)
            {
                ret[x] = new double[view.Columns.Count];
                for (int y = 0; y < view.Columns.Count; y++)
                    if (!double.TryParse(view.Rows[x].Cells[y].Value.ToString(), out ret[x][y]))
                        throw new Exception($"Isn't numeric value at [{x + 1},{y + 1}]");
            }

            return ret;
        }
        public static void ToDisplay(this DataGridView view, Matrix twoD)
        {
            view.Clear();

            int height = twoD.Rows;
            int width = twoD.Columns;

            view.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(view);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = twoD[r, c].ToString();
                }

                view.Rows.Add(row);
            }
        }
        public static void Clear(this DataGridView view)
        {
            view.Rows.Clear();
            view.Columns.Clear();
        }
    }
}
