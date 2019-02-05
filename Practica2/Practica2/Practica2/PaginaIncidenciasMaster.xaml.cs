using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Practica2.Modelos;
using Practica2.Services;


namespace Practica2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaIncidenciasMaster : MasterDetailPage
	{

        private static List<Incidencia> _incidencias;


        public PaginaIncidenciasMaster ()
		{
			InitializeComponent ();
            _incidencias = ServiceIncidences.getServiceIncidences().getAllIncidencias();
        }
    }
}