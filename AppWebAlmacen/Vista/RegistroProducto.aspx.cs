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
    public partial class RegistroProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClCategoriaL objCateg = new ClCategoriaL();
                List<ClCategoriaE> listCat = new List<ClCategoriaE>();
                listCat = objCateg.mdtListar();

                ddlCategoria.DataSource = listCat;
                ddlCategoria.DataTextField = "categoria";
                ddlCategoria.DataValueField = "idCategoria";
                ddlCategoria.DataBind();
                ddlCategoria.Items.Insert(0, new ListItem("Seleccione", "0"));

            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClProductoL objProd = new ClProductoL();
            if (fuImagen.HasFile)
            {
                string verif = txtCodigo.Text;
                int verificar = objProd.mtdVerificar(verif);
                if (verificar > 0)
                {
                    string script = @"<script> swal({ title: '¡Error!', text: 'El codigo con el cual intentas registrar el producto ya existe.',type: 'error',
                            confirmButtonText: 'Aceptar'});
                    </script>";
                    ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", script);
                }
                else
                {
                    string nombreImg = txtCodigo.Text + ".png";
                    string rutaImg = Server.MapPath("~/Vista/Imagenes/ImagenesProducto/"+nombreImg);
                    fuImagen.SaveAs(rutaImg);

                    ClProductoE objPro = new ClProductoE();
                    objPro.codigo = txtCodigo.Text;
                    objPro.nombre = txtNombre.Text;
                    objPro.descripcion = txtDescripcion.Text;
                    objPro.precio = float.Parse(txtPrecio.Text);
                    objPro.imagenProd = nombreImg;
                    objPro.idCategoria = int.Parse(ddlCategoria.SelectedValue.ToString());

                    int registro = objProd.mtdRegistraPro(objPro);
                    if (registro == 1)
                    {
                        string script = @"<script> swal({ title: '¡Registro Exitoso!', text: 'Producto Registrado correctamente.',type: 'success',
                            confirmButtonText: 'Aceptar'});
                        </script>";
                        ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", script);
                    }

                }
            }
        }
    }
}