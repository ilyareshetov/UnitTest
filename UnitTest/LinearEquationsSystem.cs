using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class LinearEquationsSystem
    {
        double[,] my_coeffs;

        public double[] Solve(double[] free, int n)
        {
            double s = 0;
            List<double> res = new List<double>(n);
            for (int i = 0; i < n; i++)
            {
                res.Add(0);
            }

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        my_coeffs[i, j] = my_coeffs[i, j] - my_coeffs[k, j] * (my_coeffs[i, k] / my_coeffs[k, k]);
                    }
                    free[i] = free[i] - free[k] * my_coeffs[i, k] / my_coeffs[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + my_coeffs[k, j] * res[j];
                res[k] = (free[k] - s) / my_coeffs[k, k];
            }

            double[] otvet = res.ToArray();

            return otvet;
        }

        public void SetCoefficients(double[,] coeffs)
        {
            double determ = 0;

            if (coeffs.GetLength(0) == 2 && coeffs.GetLength(1) == 2)
            {
                determ = coeffs[0, 0] * coeffs[1, 1] - coeffs[0, 1] * coeffs[1, 0];
            }
            else if (coeffs.GetLength(0) == 3 || coeffs.GetLength(1) == 3)
            {
                determ = coeffs[0, 0] * coeffs[1, 1] * coeffs[2, 2] - coeffs[0, 0] * coeffs[1, 2] * coeffs[2, 1] - coeffs[0, 1] * coeffs[1, 0] * coeffs[2, 2] - coeffs[0, 1] * coeffs[1, 2] * coeffs[2, 0] - coeffs[0, 2] * coeffs[1, 0] * coeffs[2, 1] - coeffs[0, 2] * coeffs[1, 1] * coeffs[2, 0];
            }
            else throw new System.FormatException();
                              
            if (determ == 0)
            {
                throw new System.ArgumentException();
            }
            my_coeffs = coeffs;
        }
    }
}
