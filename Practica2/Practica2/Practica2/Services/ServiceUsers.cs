using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2.Services
{
    class ServiceUsers
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        Usuario user1 = new Usuario(01, "David", "Bou", "Catalán", "45990250W", 660605534, "davidbou1996@gmail.com");
        Usuario user2 = new Usuario(02, "Joel", "Caso", "Blanca", "45990251A", 666666666, "joelCB@gmail.com");

        public static void rellenaListaUsuarios()
        {
            _usuarios.Add(user1);
            _usuarios.Add(user2);
        }
    }
}