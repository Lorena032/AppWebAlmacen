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
    public partial class RegistrarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClUsuarioEn objDatosUsuario = new ClUsuarioEn();
            objDatosUsuario.documento = txtDocumento.Text;
            objDatosUsuario.nombre = txtNombre.Text;
            objDatosUsuario.apellido = txtApellido.Text;
            objDatosUsuario.email = txtEmail.Text;
            objDatosUsuario.clave = txtClave.Text;

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
