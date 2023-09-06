using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Ejercicio1
{
    class Impuestos
    {
        double[] desde = { 0.01, 500.01, 1000.01, 2000.01, 3000.01, 8000.01, 18000.01, 30000.01, 60000.01, 100000.01, 200000.01, 300000.01, 400000.01, 500000.01, 1000000.01 };
        double[] hasta = { 500, 1000, 2000, 3000, 8000, 18000, 30000, 60000, 100000, 200000, 300000, 400000, 500000, 1000000, 99999999 };
        double[] precio = { 1.5, 1.5, 3, 6, 9, 15, 39, 63, 93, 125, 195, 255, 300, 340, 490 };
        double[] adicional = { 0, 3, 3, 3, 2, 2, 2, 1, 0.8, 0.7, 0.6, 0.45, 0.4, 0.30, 0.18 };

        public double CalcularImpuesto (double monto)
        {
            double resultado = 0;
            for (int i = 0; i < desde.Length; i++)
            {
                if (monto >= desde[i] && monto <= hasta[i])
                    resultado= (monto - desde[i]) / 1000 * adicional[i] + precio[i];
            }
            return resultado;
        }
    }
}
