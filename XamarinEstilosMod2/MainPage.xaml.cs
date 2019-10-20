using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinEstilosMod2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool originalState = true;
        public MainPage()
        {
            InitializeComponent();
            Resources["buttonTheme"] = Application.Current.Resources["Light"];
        }

        public void cambiarTema(object sender, EventArgs events)
        {
            if (originalState)
            {
                Resources["buttonTheme"] = Application.Current.Resources["Dark"];
                originalState = false;
            }
            else
            {
                Resources["buttonTheme"] = Application.Current.Resources["Light"];
                originalState = true;
            }
        }
    }
}
