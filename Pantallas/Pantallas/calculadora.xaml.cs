using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pantallas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class calculadora : ContentPage
    {
     
        private String number1;
        private String number2;
        private String operation;
        private List<String> operationsList = new List<string>();
       

        public calculadora()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
           // IdNumero.Text = "1";
            String number = "1";
            write(number);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {

            //IdNumero.Text = "2";

            String number = "2";
            write(number);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {

            //IdNumero.Text = "3";
            String number = "3";
            write(number);
        }

        

        private void Button0_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "0";
            String number = "0";
            write(number);

        }

        private void Button_coma_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = ",";
            String number = ",";
            write(number);
        }
        private void Button6_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "6";
            String number = "6";
            write(number);
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "5";
            String number = "5";
            write(number);
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "4";
            String number = "4";
            write(number);
        }

        

        private void Button9_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "9";
            String number = "9";
            write(number);
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "8";
            String number = "8";
            write(number);
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            //IdNumero.Text = "7";
            String number = "7";
            write(number);
        }

        private void ButtonC_Clicked(object sender, EventArgs e)
        {
            IdResultado.Text = "0";
            IdNumero.Text = " ";
        }

        private void deleteFisrTime(String number)
        {

            IdResultado.Text = number;
        }
        private void write(String number)
        {
            if (IdResultado.Text != "0")
            {
                IdResultado.Text += number;
            }
            else
            {
                deleteFisrTime(number);
            }
        }

        private void ButtonSign_Clicked(object sender, EventArgs e)
        {
            double stringNumber = Convert.ToDouble(IdResultado.Text) * -1;
            IdResultado.Text = stringNumber.ToString();
        }

        private void ButtonPercent_Clicked(object sender, EventArgs e)
        {
            number1 = IdResultado.Text;
            operation = "percentaje";
            IdNumero.Text += String.Format("{0:00}", number1) + "%";
            operationsList.Add(number1);
            operationsList.Add(operation);
            IdResultado.Text = "0";

        }

        private void ButtonDiv_Clicked(object sender, EventArgs e)
        {
            number1 = IdResultado.Text;
            operation = "division";
            IdNumero.Text += String.Format("{0:00}", number1) + "/";
            operationsList.Add(number1);
            operationsList.Add(operation);
            IdResultado.Text = "0";
        }

        private void ButtonTimes_Clicked(object sender, EventArgs e)
        {
            number1 = IdResultado.Text;
            operation = "multiplicar";
            IdNumero.Text += String.Format("{0:00}", number1) + "*";
            operationsList.Add(number1);
            operationsList.Add(operation);
            IdResultado.Text = "0";
        }

        private void ButtonMinus_Clicked(object sender, EventArgs e)
        {
            number1 = IdResultado.Text;
            operation = "resta";
            IdNumero.Text += String.Format("{0:00}", number1) + "-";
            operationsList.Add(number1);
            operationsList.Add(operation);
            IdResultado.Text = "0";
        }

        private void ButtonPlus_Clicked(object sender, EventArgs e)
        {
            number1 = IdResultado.Text;
            operation = "suma";
            IdNumero.Text += String.Format("{0:00}", number1) + "+";
            operationsList.Add(number1);
            operationsList.Add(operation);
            IdResultado.Text = "0";
        }

        private void ButtonResult_Clicked(object sender, EventArgs e)
        {
            number2 = IdResultado.Text;
            IdNumero.Text += number2;
            operationsList.Add(number2);
            IdResultado.Text = calcula(operationsList);
        }

        private String calcula(List<String> operationsList)
        {
            double actualNumber = 0;
            for (int i = 0; i < operationsList.Count; i++)
            {

                switch (operationsList[i])
                {
                    case "percentaje":
                        actualNumber = actualNumber * Convert.ToDouble(operationsList[i + 1]) / 100;
                        i++;
                        break;
                    case "division":
                        actualNumber = actualNumber / Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "multiplicar":
                        actualNumber = actualNumber * Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "resta":
                        actualNumber = actualNumber - Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    case "suma":
                        actualNumber = actualNumber + Convert.ToDouble(operationsList[i + 1]);
                        i++;
                        break;
                    default:
                        actualNumber = Convert.ToDouble(operationsList[i]);
                        break;
                }
            }

            return actualNumber.ToString();
        }


        


    }
}