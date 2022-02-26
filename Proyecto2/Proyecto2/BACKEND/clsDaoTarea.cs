using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Proyecto2.Modelos;

namespace Proyecto2.BACKEND
{
    public class clsDaoTarea
    {
        public List<clsTarea> ListaProductos()
        {
            //CREACION Y CONFIGURACION DE LA CONEXION
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Server=LAPTOP-SS13RSNT\\SQLEXPRESS;Initial Catalog=PRO2;" +
                "Persist Security Info=False;User ID=sa;Password=123456789gio;";
            //asi me sale ami el nombre del servidor en sql
            //WIN - 8N5802N6K7T\SQLEXPRESS


            // CODIGO SQL PARA SELECCIONAR TODOS LOS PRODUCTOS
            string equipo = "select * from LIBROS";
          
            SqlDataAdapter sa = new SqlDataAdapter(equipo, conexion);
            //MySqlDataAdapter sa = new MySqlDataAdapter(equipo, conexion);
            DataSet ng = new DataSet();
            sa.Fill(ng, "LIBROS");


            // LLENA LA LISTA CON LA TABLA RESULTANTE DE LA CONSULTA 
            List<clsTarea> lstProduccion = new List<clsTarea>();
            foreach (DataRow dr in ng.Tables["LIBROS"].Rows)
            {
                clsTarea dg = new clsTarea();
                dg.Id = Convert.ToInt32(dr[0]);
                dg.Isbn = dr[1].ToString();
                dg.Titulo = dr[2].ToString();
                dg.NumerodeEdidicion = Convert.ToInt32(dr[3]);
                dg.Nombreautores = dr[4].ToString();
                dg.Paispublicacion = dr[5].ToString();
                dg.Sinopsis = dr[6].ToString();
                dg.Carrera = dr[7].ToString();
                dg.Materia = dr[8].ToString();
                dg.Anopublicacion = Convert.ToInt32(dr[9]);
                lstProduccion.Add(dg);
            }
           

            // REGRESA LA LISTA
            return lstProduccion;
        }

        public bool InsertarCategoria(clsTarea L)
        {
            // CREACION Y CONFIGURACION DE LA CONEXION

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Server=LAPTOP-SS13RSNT\\SQLEXPRESS;Initial Catalog=PRO2;" +
                "Persist Security Info=False;User ID=sa;Password=123456789gio;";
            //asi me sale ami el nombre del servidor en sql
            //WIN - 8N5802N6K7T\\SQLEXPRESS


            conexion.Open();

            // CODIGO SQL PARA INSERTAR EL PRODUCTO
            string cadena = @"insert into Libros (ISBN,TITULO,NUMERODEEDICION,NOMBREAUTORES,PAISPUBLICACION,SINOPSIS,CARRERA,MATERIA,ANIOPUBLICACION)values( @ISBN, @TITULO,
            @NumeroDeEdicion,@NOMBREAUTORES, @PAISPUBLICACION, @SINOPSIS, 
            @CARRERA, @MATERIA, @AÑOPUBLICACION)";

            SqlCommand comando = new SqlCommand(cadena, conexion);

            //comando.Parameters.AddWithValue("@ID", L.Id);

            comando.Parameters.AddWithValue("@ISBN", L.Isbn);
            comando.Parameters.AddWithValue("@TITULO", L.Titulo);
            comando.Parameters.AddWithValue("@AÑOPUBLICACION", L.Anopublicacion);
            comando.Parameters.AddWithValue("@NOMBREAUTORES", L.Nombreautores);
            comando.Parameters.AddWithValue("@PAISPUBLICACION", L.Paispublicacion);
            comando.Parameters.AddWithValue("@SINOPSIS", L.Sinopsis);
            comando.Parameters.AddWithValue("@CARRERA", L.Carrera);
            comando.Parameters.AddWithValue("@MATERIA", L.Materia);
            comando.Parameters.AddWithValue("@NumeroDeEdicion", L.NumerodeEdidicion);
            
            
            
            
            
            
            

            comando.ExecuteNonQuery();
            conexion.Close();
            conexion.Dispose();
            return true;

        }

    }
}