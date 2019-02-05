using System;
using System.Collections.Generic;
using System.Text;
using Practica2.Modelos;

namespace Practica2.Services
{
    class ServiceUsers
    {
        private static List<Usuario> _usuarios = new List<Usuario>();

        public static void rellenaListaUsuarios()
        {
            _usuarios.Add(new Usuario(01, "David", "Bou", "Catalán", "45990250W", 660605534, "davidbou1996@gmail.com"));
            _usuarios.Add(new Usuario(02, "Joel", "Caso", "Blanca", "45990251A", 666666666, "joelCB@gmail.com"));
        }

        public List<Usuario> getAllUsers()
        {
            return _usuarios;
        }

        public static Usuario getUserByID (int ID)
        {
            for (int i = 0; i < _usuarios.Capacity; i++)
            {
                Usuario usr = _usuarios[i];
                if (usr.getId() == ID)
                {
                    return usr;
                }
            }
            return null;
        }
    }
}