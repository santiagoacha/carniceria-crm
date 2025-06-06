using System;

namespace CarniceriaCRM.BE
{
    public class Sesion
    {
        private Usuario _usuario { get; set; }

        public Usuario Usuario
        {
            get
            {
                return _usuario;
            }
        }

        public void Login(Usuario usu)
        {
            if (_usuario == null)
            {
                _usuario = usu;
            }
        }

        public void Logout()
        {
            if (_usuario != null)
            {
                _usuario = null;
            }
        }

        public bool EstaLogueado()
        {
            return _usuario != null;
        }

        public void CerrarSesion()
        {
            Logout();
        }
    }
} 