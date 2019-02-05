using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practica2.Modelos
{
    class Usuario
    {
        private int idUser { get; set; }
        private string nom { get; set; }
        private string cognom1 { get; set; }
        private string cognom2 { get; set; }
        private string DNI { get; set; }
        private string passWord { get; set; }
        private int telefon { get; set; }
        private string eMail { get; set; }
        private string rutaImagenPerfil { get; set; }

        public Usuario(int idUser, string nom, string cognom1, string cognom2, string DNI, int telefon, string eMail) 
        {
            if (isValidDNI(DNI))
            {
                this.idUser = idUser;
                this.nom = nom;
                this.cognom1 = cognom1;
                this.cognom2 = cognom2;
                this.DNI = DNI;
                this.telefon = telefon;
                this.eMail = eMail;
            }
        }

        public static Boolean isValidDNI (string DNI)
        {
            string TABLA_LETRA = "TRWAGMYFPDXBNJZSQVHLCKE";

            if (Regex.IsMatch(DNI, @"^[0-9]{8}[A-Z]$"))
            {
                return false;
            }
            else
            {
                int i = int.Parse(DNI.Substring(0, 8)) % 23;
                return TABLA_LETRA[i] == DNI[8];
            }
        }

        public int getId()
        {
            return idUser;
        }
    }
}
