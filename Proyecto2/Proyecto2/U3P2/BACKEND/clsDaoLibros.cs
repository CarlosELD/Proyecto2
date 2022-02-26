using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using U3P2.Modelos;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace U3P2.BACKEND
{
    public class clsDaoLibros
    {
        public List<clsLibros> ListaProductos()
        {
            //CREACION Y CONFIGURACION DE LA CONEXION
            //SqlConnection conexion = new SqlConnection();
            //conexion.ConnectionString = "Server=DESKTOP-8KPP9F0;Initial Catalog=U3;" +
                //"Persist Security Info=False;User ID=sa;Password=zamora;";

            // PARA CONECTARSE A MYSQL
            MySqlConnection conexion2 = new MySqlConnection();
            conexion2.ConnectionString = "server=127.0.0.1;database=U3P2;" + "uid=root;pwd=Andy12*";
            conexion2.Open();

            // CODIGO SQL PARA SELECCIONAR TODOS LOS PRODUCTOS
            string cadena = "SELECT * FROM LIBROS";

            //SqlDataAdapter da = new SqlDataAdapter(cadena, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cadena, conexion2);
            DataSet ds = new DataSet();
            da.Fill(ds, "LIBROS");


            // LLENA LA LISTA CON LA TABLA RESULTANTE DE LA CONSULTA 
            List<clsLibros> lstLIBROS = new List<clsLibros>();
            foreach (DataRow dr in ds.Tables["LIBROS"].Rows)
            {
                clsLibros pr = new clsLibros();
                pr.ID = Convert.ToInt32(dr[0].ToString());
                pr.ISBN = Convert.ToInt32(dr[1].ToString());
                pr.TITULO = dr[2].ToString();
                pr.NOEDICION = Convert.ToInt32(dr[3].ToString());
                pr.ANIOPUBLICACION = Convert.ToInt32(dr[4]);
                pr.AUTORES = dr[5].ToString();
                pr.PAISDEPUBLICACION = dr[6].ToString();
                pr.SINOPSIS = dr[7].ToString();
                pr.CARRERA = dr[8].ToString();
                pr.MATERIA = dr[9].ToString();
                lstLIBROS.Add(pr);
            }

            // REGRESA LA LISTA
            return lstLIBROS;
        }
        public bool insertar(clsLibros L)
        {
            MySqlConnection conexion2 = new MySqlConnection();
            conexion2.ConnectionString = "server=127.0.0.1;database=U3P2;" + "uid=root;pwd=Andy12*";
            conexion2.Open();
            string cadena = @"INSERT INTO  LIBROS VALUES(null, @ISBN, @TITULO,
            @NOEDICION,@ANIOPUBLICACION, @AUTORES, @PAISDEPUBLICACION, 
            @SINOPSIS, @CARRERA, @MATERIA)";
            MySqlCommand comando = new MySqlCommand(cadena, conexion2);
            comando.Parameters.AddWithValue("@ISBN", L.ISBN);
            comando.Parameters.AddWithValue("@TITULO", L.TITULO);
            comando.Parameters.AddWithValue("@NOEDICION", L.NOEDICION);
            comando.Parameters.AddWithValue("@AUTORES", L.AUTORES);
            comando.Parameters.AddWithValue("@PAISDEPUBLICACION", L.PAISDEPUBLICACION);
            comando.Parameters.AddWithValue("@SINOPSIS", L.SINOPSIS);
            comando.Parameters.AddWithValue("@CARRERA", L.CARRERA);
            comando.Parameters.AddWithValue("@MATERIA", L.MATERIA);
            comando.Parameters.AddWithValue("@ANIOPUBLICACION", L.ANIOPUBLICACION);
            comando.ExecuteNonQuery();
            conexion2.Close();
            conexion2.Dispose();
            return true;
        }
        //public bool InsertarLibro(clsLibros L)
        //{
        //    // CREACION Y CONFIGURACION DE LA CONEXION

        //    SqlConnection conexion = new SqlConnection();
        //    conexion.ConnectionString = "Server=DESKTOP-8KPP9F0;Initial Catalog=U3;" +
        //        "Persist Security Info=False;User ID=sa;Password=zamora;";
        //    conexion.Open();

        //    // CODIGO SQL PARA INSERTAR EL PRODUCTO
        //    string cadena = @"insert into Libros values(null, @ISBN, @TITULO,
        //    @NUMEROdeEDICION,@NOMBREAUTORES, @PAISPUBLICACION, @SINOPSIS, 
        //    @CARRERA, @MATERIA, @AÑOPUBLICACION)";
        //    SqlCommand comando = new SqlCommand(cadena, conexion);
        //    //comando.Parameters.AddWithValue("@ID", L.Id);
        //    comando.Parameters.AddWithValue("@ISBN", L.Isbn);
        //    comando.Parameters.AddWithValue("@TITULO", L.Titulo);
        //    comando.Parameters.AddWithValue("@NUMEROdeEDICION", L.NumerodeEdidicion);
        //    comando.Parameters.AddWithValue("@NOMBREAUTORES", L.Nombreautores);
        //    comando.Parameters.AddWithValue("@PAISPUBLICACION", L.Paispublicacion);
        //    comando.Parameters.AddWithValue("@SINOPSIS", L.Sinopsis);
        //    comando.Parameters.AddWithValue("@CARRERA", L.Carrera);
        //    comando.Parameters.AddWithValue("@MATERIA", L.Materia);
        //    comando.Parameters.AddWithValue("@AÑOPUBLICACION", L.Añopublicacion);
            

        //    comando.ExecuteNonQuery();
        //    conexion.Close();
        //    conexion.Dispose();
        //    return true;

        //}

    }
}