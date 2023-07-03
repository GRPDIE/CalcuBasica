using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj1 = new Operaciones();
        

       
        private void txt_valor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_valor1_TextChanged(object sender, EventArgs e)
        {

        }
 


        private void btn_suma_Click(object sender, EventArgs e)
        {
            if (!obj1.ValidacionNumero(txt_valor1.Text) || !obj1.ValidacionNumero(txt_valor2.Text))
            {
                txt_resultado.Text = "Pone numeros";
            }
            else
            {
                int suma = obj1.sumar(Convert.ToInt32(txt_valor1.Text), Convert.ToInt32(txt_valor2.Text));
                txt_resultado.Text = Convert.ToString(suma);
            }
        }

        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            if (!obj1.ValidacionNumero(txt_valor1.Text) || !obj1.ValidacionNumero(txt_valor2.Text))
            {
                txt_resultado.Text = "Pone numeros";
            }
            else
            {
                int multiplicacion = obj1.multiplicar(Convert.ToInt32(txt_valor1.Text), Convert.ToInt32(txt_valor2.Text));
                txt_resultado.Text = Convert.ToString(multiplicacion);
            }

        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            if (!obj1.ValidacionNumero(txt_valor1.Text) || !obj1.ValidacionNumero(txt_valor2.Text))
            {
                txt_resultado.Text = "Pone numeros";
            }
            else
            {
                int resta = obj1.restar(Convert.ToInt32(txt_valor1.Text), Convert.ToInt32(txt_valor2.Text));
                txt_resultado.Text = Convert.ToString(resta);
            }
        }



        private void btn_division_Click(object sender, EventArgs e)
        {
                if (!obj1.ValidacionNumero(txt_valor1.Text) || !obj1.ValidacionNumero(txt_valor2.Text))
                {
                    txt_resultado.Text = "Pone numeros";
                }
                else
                {
                    int division = obj1.dividir(Convert.ToInt32(txt_valor1.Text), Convert.ToInt32(txt_valor2.Text));
                    txt_resultado.Text = Convert.ToString(division);
                }
            }
        }
    }

