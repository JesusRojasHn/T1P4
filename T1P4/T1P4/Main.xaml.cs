using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1P4.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T1P4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(txtN1.Text);
            double nr2 = Convert.ToDouble(txtN2.Text);
            double suma = nr1 + nr2;
           
            var op = new Operations
            {
                N1 = nr1,
                N2 = nr2,
                OP = suma
                
            };

            var res = new Result();
            res.BindingContext = op;
            Navigation.PushAsync(res);
        }

        private void btnResta_Clicked(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(txtN1.Text);
            double nr2 = Convert.ToDouble(txtN2.Text);
            double resta = nr1 - nr2;

            var op = new Operations
            {
                N1 = nr1,
                N2 = nr2,
                OP = resta

            };

            var res = new Result();
            res.BindingContext = op;
            Navigation.PushAsync(res);
        }

        private void btnDividir_Clicked(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(txtN1.Text);
            double nr2 = Convert.ToDouble(txtN2.Text);
            double dividir = nr1 / nr2;

            var op = new Operations
            {
                N1 = nr1,
                N2 = nr2,
                OP = dividir

            };

            var res = new Result();
            res.BindingContext = op;
            Navigation.PushAsync(res);
        }

        private void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            double nr1 = Convert.ToDouble(txtN1.Text);
            double nr2 = Convert.ToDouble(txtN2.Text);
            double multi = nr1 * nr2;

            var op = new Operations
            {
                N1 = nr1,
                N2 = nr2,
                OP = multi

            };

            var res = new Result();
            res.BindingContext = op;
            Navigation.PushAsync(res);
        }


   
    }
}