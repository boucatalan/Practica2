using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuInicial : ContentPage
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        public async void btnIncidencias_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PaginaIncidenciasMaster());
        }

        public async void btnPerfil_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushModalAsync(  );
        }
    }
}