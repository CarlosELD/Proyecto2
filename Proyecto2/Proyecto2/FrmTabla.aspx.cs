using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto2.BACKEND;
using Proyecto2.Modelos;


namespace Proyecto2
{
    public partial class FrmCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            clsDaoTarea objLr = new clsDaoTarea();

             List<clsTarea> inv= objLr.ListaProductos();

           
            gv.DataSource = inv;
            gv.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTarea x = new clsTarea();
            x.Isbn = txtISBN.Text;
            x.Titulo = txtTitulo.Text;
            x.NumerodeEdidicion = int.Parse(txtNumEdic.Text);
            x.Anopublicacion = int.Parse(txtAño.Text);;
            x.Nombreautores = txtNumAut.Text;
            x.Paispublicacion = txtPaisP.Text;
            x.Sinopsis = txtSinopsis.Text;
            x.Carrera = txtCarrera.Text;
            x.Materia = txtMateria.Text;

            clsDaoTarea objTab = new clsDaoTarea();
            objTab.InsertarCategoria(x);
        }
    }
}