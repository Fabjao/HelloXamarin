using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            //BindingContext = App.Config;
            InitializeComponent();
        }
        void EnviarEmail(Object sender, EventArgs e)
        {

            DisplayAlert("Alerta", "Você está mudando uma opção", "OK");
        }

    }
}