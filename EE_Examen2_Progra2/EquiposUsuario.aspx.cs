using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2
{
    public partial class EquiposUsuario : System.Web.UI.Page
    {
        string Usuario = Classes.AuthUser.getUsername();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblUsuario.Text = "Usuario: " + Usuario;
                fillGrid();
            }
            
        }

        protected void fillGrid()
        {
            if (Classes.AuthUser.reporteUsuario(dgEquipos))
            {

            }
        }
    }
}