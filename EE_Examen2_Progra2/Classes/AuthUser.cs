using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2.Classes
{
    public class AuthUser
    {
        private static string Username;
        private static string Password;
        private static int Role;

        public AuthUser()
        {
            Username = string.Empty;
            Password = string.Empty;
            Role = 0;
        }
        public AuthUser(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public int login()
        {
            return Proc2BD.validarLogin(Username, Password);
        }

        public void setRole(int role)
        {
            Role = role;
        }

        public int getRole()
        {
            return Role;
        }

        public static int getRoleStatic()
        {
            return Role;
        }

        public static string getUsername() { 
            return Username;
        }

        public string getUsernamePublic()
        {
            return Username;
        }

        public void setUsername(string username)
        {
            Username = username;
        }

        public static bool reporteUsuario(GridView dg)
        {
            int success = Proc2BD.reporteUsuarioPorCorreo(Username, dg);

            return success > 0;
        }

        public static bool reportForAdmin(GridView dg)
        {
            int success = Proc2BD.reporteAdmin(dg);

            return success >= 0;
        }
    }
}