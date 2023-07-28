using System;
using Xamarin.Forms;

namespace TallerUSS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                DisplayAlert("Error", "El correo no puede ser vacio.", "OK");
            }
            else if (picker.SelectedIndex == -1)
            {
                DisplayAlert("Error", "Seleccione año ingreso.", "OK");
            }
            else if (optFemenino.IsChecked == false && optMasculino.IsChecked == false)
            {
                DisplayAlert("Error", "Seleccione genero.", "OK");

            }
            else if (checkTerminos.IsChecked == false)
            {
                DisplayAlert("Error", "Para crear cuenta debe aceptar terminos.", "OK");
            }
            else
            {
                DisplayAlert("ÉXITO", "SU CUENTA HA SIDO CREADA", "OK");
                Navigation.PushAsync(new PaginaExito());
            }
        }
    }
}
