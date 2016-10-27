using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Domenova
{
    class SessionSingleton
    {

        private Uzivatel loggedUser;
        private static SessionSingleton instance;

        private SessionSingleton()
        {

        }
        public static SessionSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new SessionSingleton();
            }
            return instance;
        }

        public Uzivatel getLoggedUser()
        {
            return loggedUser;
        }

        public void setLoggedUser(Uzivatel loggedUser)
        {
            this.loggedUser = loggedUser;
        }

        public Boolean isLogged()
        {
            return loggedUser != null;
        }
        public Boolean isAdministrator()
        {
            return isLogged() && loggedUser.isAdministrator();
        }
        public void logOut()
        {
            loggedUser = null;
        }
            



    }
}
