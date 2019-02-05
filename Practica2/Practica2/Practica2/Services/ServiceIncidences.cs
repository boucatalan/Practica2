using System;
using System.Collections.Generic;
using Practica2.Modelos;
using System.Text;

namespace Practica2.Services
{
    class ServiceIncidences
    {
        private static List<Incidencia> _incidencias = new List<Incidencia>();
        private static ServiceIncidences serviceIncidences;

        public ServiceIncidences ()
        {
            rellenaListaIncidencias();
        }

        public static ServiceIncidences getServiceIncidences()
        {
            if (serviceIncidences == null)
            {
                serviceIncidences = new ServiceIncidences();
            }
            return serviceIncidences;
        }

        public static void rellenaListaIncidencias()
        {
            Usuario user1 = ServiceUsers.getUserByID(1);
            Usuario user2 = ServiceUsers.getUserByID(2);

            DateTime date1 = new DateTime(2019, 3, 1, 7, 0, 0);
            DateTime date2 = new DateTime(2019, 2, 8, 9, 40, 0);
            DateTime date3 = new DateTime(2019, 1, 17, 11, 26, 0);
            DateTime date4 = new DateTime(2018, 12, 15, 16, 15, 0);

            _incidencias.Add(new Incidencia(01,28056,25,"Cable pelado", "Un cable se ha deteriorado y debe ser remplazado", date1, user1));
            _incidencias.Add(new Incidencia(02, 30568, 80, "Pantalla Rota", "La pantalla esta en negro y no se enciende", date2, user2));
            _incidencias.Add(new Incidencia(03, 40258, 0, "Ordenador estropeado", "La caja del pc empezó ha arder y ya no va", date3, user1));
            _incidencias.Add(new Incidencia(04, 00056, 50, "Teclas intercambiadas", "El teclado tiene las teclas desordenadas", date4, user2));
        }

        public List<Incidencia> getAllIncidencias ()
        {
            return _incidencias;
        }

        public static Incidencia getIncidenciaByID(int ID)
        {
            for (int i = 0; i < _incidencias.Capacity; i++)
            {
                Incidencia inc = _incidencias[i];
                if (inc.getId() == ID)
                {
                    return inc;
                }
            }
            return null;
        }

        public bool addNewIncidencia ( Incidencia ind)
        {
            if (getIncidenciaByID( ind.getId() ) == null)
            {
                _incidencias.Add(ind);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
