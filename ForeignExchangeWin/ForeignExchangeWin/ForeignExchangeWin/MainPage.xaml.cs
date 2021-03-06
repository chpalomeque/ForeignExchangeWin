﻿namespace ForeignExchangeWin
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ConverButton.Clicked += ConverButton_Clicked;    
        }

        private void ConverButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value in pesos.", "Acept");
                return;
            }

            decimal pesos = 0;
            if (decimal.TryParse(PesosEntry.Text, out pesos))
            {


                var dollars = pesos / 3003.003M;
                var euros = pesos / 3531.05105M;
                var pounds = pesos / 3907.23724M;

                DollarsEntry.Text = string.Format("{0:C2}", dollars);
                EurosEntry.Text = string.Format("{0:C2}", euros);
                PoundsEntry.Text = string.Format("{0:C2}", pounds);

            }
            else
            {
                DisplayAlert("Error", "You must enter a value numeric in pesos ..", "Accept");
            }
        

        }
    }
}
