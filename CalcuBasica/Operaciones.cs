using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuBasica
{
    class Operaciones
    {
        public bool ValidacionNumero(string num)
        {
            try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int sumar(int a, int b)
        {
            return a + b;
        }
        public int restar(int a, int b)
        {
            return a - b;
        }
        public int multiplicar(int a, int b)
        {
            return a * b;
        }
        public int dividir(int a, int b)
        {
            if (b == 0) {
                MessageBox.Show("no se divide entre 0");
                return 0;
            }
            else
            {
                return a / b;
            }
        }

    }
}
