using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bisseccao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Le os valores A e B, sendo A o valor com f(x) negativo e B com f(x) positivo
                decimal A = Convert.ToDecimal(textBoxA.Text);
                decimal B = Convert.ToDecimal(textBoxB.Text);

                decimal xA = CalcularFunc(A);
                decimal xB = CalcularFunc(B);

                if ((xA > 0 && xB > 0) | (xA < 0 && xB < 0))
                {
                    labelResultado.Text = "Resultado: Os dois numeros tem como f(x) positivo ou negativo";
                    return;
                }

                int casasDecimais = Convert.ToInt32(numericUpDownCasasDecimais.Value);

                while (Math.Round(A, casasDecimais) != Math.Round(B, casasDecimais)) {
                    //Calcula a media e enquanto o valor de A e B nao forem iguais com o arredondamento em n casas decimais
                    decimal med = (A + B) / 2;

                    decimal xMed = CalcularFunc(med);

                    if (xMed > 0) {
                        B = med;
                    } else if (xMed < 0) {
                        A = med;
                    }
                    else
                    {
                        labelResultado.Text = "Resultado:" + xMed.ToString();
                        return;
                    }


                }

                labelResultado.Text = "Resultado: [ " + A.ToString() + ", " + B.ToString() + "]"  ;

            }
            catch (Exception exc)
            {
                labelResultado.Text = exc.Message;
            }

        }

        private Decimal CalcularFunc(decimal X) {
            //Exemplo f(x) = x**2 -2
            //return (X * X - 2);
            return X + 5 * Convert.ToDecimal( Math.Log(Convert.ToDouble( X))) - 2;
        }

    }
}
