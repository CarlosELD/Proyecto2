using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using U3P2.BACKEND;
using U3P2.Modelos;


namespace U3P2
{
    public partial class FrmLibros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            clsDaoLibros objLr = new clsDaoLibros();
            gvLibros.DataSource = objLr.ListaProductos();
            gvLibros.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            clsLibros x = new clsLibros();
            x.ISBN = int.Parse(txtISBN.Text);
            x.TITULO = txtTitulo.Text;
            x.NOEDICION = int.Parse(txtNumEdic.Text);
            x.ANIOPUBLICACION = int.Parse(txtAño.Text);;
            x.AUTORES = txtNumAut.Text;
            x.PAISDEPUBLICACION = txtPaisP.Text;
            x.SINOPSIS= txtSinopsis.Text;
            x.CARRERA= txtCarrera.Text;
            x.MATERIA= txtMateria.Text;
            clsDaoLibros objLibro = new clsDaoLibros();
            objLibro.insertar(x);
        }
    }
}