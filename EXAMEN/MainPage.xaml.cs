using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EXAMEN
{
    public partial class MainPage : ContentPage
    {
        string Operacion = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbResultado.Text))
            {
                
                Operacion = "+";
                
            }
        }

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbResultado.Text))
            {
                
                Operacion = "-";
                
            }
        }

        private void btnDivision_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbResultado.Text))
            {
                
                Operacion = "/";
                
            }
        }

        private void btnMulti_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbResultado.Text))
            { 
                Operacion = "+";
                
            }
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            double numOne = Convert.ToDouble(numUno.Text);
            double numTwo = Convert.ToDouble(numDos.Text);
            double result;
            if (double.TryParse(numUno.Text, out numOne) && double.TryParse(numDos.Text, out numTwo))
            {
                
                switch (Operacion)
                {
                    case "+":
                        result = numOne + numTwo;
                        break;
                    case "-":
                        result = numOne - numTwo;
                        break;
                    case "/":
                        if (numTwo != 0)
                        {
                            result = numOne / numTwo;
                        }
                        else
                        {
                            lbResultado.Text = "Error: División por cero";
                            return;
                        }
                        break;
                    case "*":
                        result = numOne * numTwo;
                        break;
                    default:
                        lbResultado.Text = "Seleccione una operación";
                        return;
                }
                lbResultado.Text = result.ToString();
            }
            else
            {
                lbResultado.Text = "Error: Entrada inválida";
            }
        }
    }
}
