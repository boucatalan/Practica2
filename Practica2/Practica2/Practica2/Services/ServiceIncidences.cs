using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Services
{
    class ServiceIncidences
    {
        private List<Incidencia> _incidencias = new List<Incidencia>();
        private DateTime date1 = new DateTime(2019, 3, 1, 7, 0, 0);
        private DateTime date2 = new DateTime(2019, 2, 8, 9, 40, 0);
        private DateTime date2 = new DateTime(2019, 1, 17, 11, 26, 0);
        private DateTime date2 = new DateTime(2018, 12, 15, 16, 15, 0);

        public static void rellenaListaIncidencias()
        {
            _incidencias.Add(new Incidencia(01,28056,25,"Cable pelado", "Un cable se ha deteriorado y debe ser remplazado", date1, user1));
            _incidencias.Add(new Incidencia(02, 30568, 80, "Pantalla Rota", "La pantalla esta en negro y no se enciende", date2, user2));
            _incidencias.Add(new Incidencia(03, 40258, 0, "Ordenador estropeado", "La caja del pc empezó ha arder y ya no va", date3, user1));
            _incidencias.Add(new Incidencia(04, 00056, 50, "Teclas intercambiadas", "El teclado tiene las teclas desordenadas", date4, user2));
        }
    }
}
