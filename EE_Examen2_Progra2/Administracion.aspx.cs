using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EE_Examen2_Progra2
{
    public partial class Administracion : System.Web.UI.Page
    {
        string Usuario = Classes.AuthUser.getUsername();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGrid();
            }

        }

        protected void fillGrid()
        {
            if (Classes.AuthUser.reportForAdmin(dgEquipos))
            {

            }
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Classes.Usuarios user = new Classes.Usuarios();
            user.Nombre = txtClient.Text;

            if (user.reporteUsuarioNombre(dgEquipos))
            {
                fillGrid();
            }

            
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}