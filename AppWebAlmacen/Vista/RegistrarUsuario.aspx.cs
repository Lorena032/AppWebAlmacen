using AppWebAlmacen.Entidades;
using AppWebAlmacen.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebAlmacen.Vista
{
    public partial class RegistrarUsuario1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClRolL objRol = new ClRolL();
                List<ClRolE> listRol = new List<ClRolE>();
                listRol = objRol.mdtListarRol();

                ddlRol.DataSource = listRol;
                ddlRol.DataTextField = "rol";
                ddlRol.DataValueField = "idRol";
                ddlRol.DataBind();
                ddlRol.Items.Insert(0, new ListItem("Seleccione", "0"));
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClUsuarioEn objDatosUsuario = new ClUsuarioEn();
            objDatosUsuario.documento = txtDocumento.Text;
            objDatosUsuario.nombre = txtNombre.Text;
            objDatosUsuario.apellido = txtApellido.Text;
            objDatosUsuario.email = txtEmail.Text;
            objDatosUsuario.clave = txtClave.Text;
            objDatosUsuario.idRol = int.Parse(ddlRol.SelectedValue.ToString());
            

            ClUsuarioL objUsuarioL = new ClUsuarioL();
            int resultado = objUsuarioL.mtdRegistrar(objDatosUsuario);

            if (resultado == 1)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Usuario Registrado!', 'Su usuario ha Sido Registrado Con Exito', 'success')", true);

            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Usuario Registrado!', 'Su usuario ha Sido Registrado Con Exito', 'success')", true);
            }
        }
    }
}