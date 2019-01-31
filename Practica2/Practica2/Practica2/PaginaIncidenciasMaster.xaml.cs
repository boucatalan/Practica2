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
	public partial class PaginaIncidenciasMaster : ContentPage
	{
		public PaginaIncidenciasMaster ()
		{
			InitializeComponent ();

            incidencias.ItemsSource = new List<Incidencia>
            {
                new Incidencia {Nombre = "Reparar cablejat", Usuario = "Profesor", Fecha = new DateTime(2019, 1, 12) },
                new Incidencia {Nombre = "Pantalla no rep senyal",  Usuario = "Estudiant", Fecha = new DateTime(2018, 12, 2) },
                new Incidencia {Nombre = "Reparar punt de xarxa", Usuario = "Estudiant", Fecha = new DateTime(2019, 1, 3) },
                new Incidencia {Nombre = "Pantalla no rep senyal", Usuario = "Estudiant", Fecha = new DateTime(2018, 6, 23) },
                new Incidencia {Nombre = "Reparar cablejat", Usuario = "Profesor", Fecha = new DateTime(2017, 10, 2) },
                new Incidencia {Nombre = "Pantalla no rep senyal", Usuario = "Profesor", Fecha = new DateTime(2019, 1, 12) },
            };
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
            //return true;
        }
    }
}