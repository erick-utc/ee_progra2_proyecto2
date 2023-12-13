using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2
{
    public partial class Login : System.Web.UI.Page
    {
        Classes.AuthUser user = new Classes.AuthUser();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            user = new Classes.AuthUser(txtUser.Text, txtPass.Text);

            if (!user.login().Equals(string.Empty))
            {
                user.setRole(user.login());
                if(user.getRole() == 1)
                {
                    Response.Redirect("Administracion.aspx");
                }else if(user.getRole() == 2) {
                    
                }else
                {
                    Response.Redirect("EquiposUsuario.aspx");
                } 
            }
        }
    }
}