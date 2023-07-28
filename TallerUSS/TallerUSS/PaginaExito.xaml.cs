using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TallerUSS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaExito : ContentPage
    {
        public PaginaExito()
        {
            InitializeComponent();
        }

        private void btnAtras_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}