using Domain;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormWebProducto
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int IDProducto;

        protected void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerRegistro();
            }

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = ObtenerProducto();
            ProductManager.GuardarProducto(producto);
            ObtenerRegistro();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            BtnAgregar.Text = "Agregar";
            IDProducto = 0;
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtPrecio.Text = "";
            TxtStock.Text = "";
            Page.Session["IDProducto"] = IDProducto;
        }

        private Producto ObtenerProducto() //Del formulario
        {
            Producto producto = new Producto();
            IDProducto = Convert.ToInt32(Page.Session["IDProducto"]);

            producto.Id = IDProducto;
            producto.Nombre = TxtNombre.Text;
            producto.Descripcion = TxtDescripcion.Text;
            producto.Precio = TxtPrecio.Text;
            producto.Stock = TxtStock.Text;

            return producto;
        }



        private void RellenarCampos()
        {
            BtnAgregar.Text = "Modificar";
            IDProducto = Convert.ToInt32(GridViewProductos.SelectedRow.Cells[1].Text);
            TxtNombre.Text = Convert.ToString(GridViewProductos.SelectedRow.Cells[2].Text);
            TxtDescripcion.Text = Convert.ToString(GridViewProductos.SelectedRow.Cells[3].Text);
            TxtPrecio.Text = Convert.ToString(GridViewProductos.SelectedRow.Cells[4].Text);
            TxtStock.Text = Convert.ToString(GridViewProductos.SelectedRow.Cells[5].Text);
            Page.Session["IDProducto"] = IDProducto;

        }

        private void ObtenerRegistro()
        {
            List<Producto> lista = ProductManager.ObtenerProducto(); //De la base de datos
            GridViewProductos.DataSource = lista;
            GridViewProductos.DataBind();
        }

        protected void GridViewProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            RellenarCampos();
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Producto producto = ObtenerProducto();
            ProductManager.EliminarProducto(producto.Id);
            ObtenerRegistro();
            LimpiarCampos();
        }
    }
}