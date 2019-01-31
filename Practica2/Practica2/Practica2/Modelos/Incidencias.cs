using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Modelos
{
    class Incidencias
    {
        private int idInstancia { get; set; }
        private int codiEquip { get; set; }
        private int progres { get; set; }
        private String nomIncidencia { get; set; }
        private String desIncidencia { get; set; }
        private DateTime data { get; set; }
        private Usuario usuario { get; set; }

        public Incidencias(int idInstancia, int codiEquip, int progres, String nomIncidencia, String desIncidencia, DateTime data, Usuario usuario)
        {
            this.idInstancia = idInstancia;
            this.codiEquip = codiEquip;
            this.progres = progres;
            this.nomIncidencia = nomIncidencia;
            this.desIncidencia = desIncidencia;
            this.data = data;
            this.usuario = usuario;
        }


    }
}
