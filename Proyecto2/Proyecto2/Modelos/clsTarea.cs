using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto2.Modelos
{
    public class clsTarea
    {
        private int ID;
        private string ISBN;
        private string TITULO;
       
        private int AÑOPUBLICACION;
        private string NOMBREAUTORES;
        private string PAISPUBLICACION;
        private string SINOPSIS;
        private string CARRERA;
        private string MATERIA;
        private int NumeroDeEdicion;
        public int Id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string Isbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }

        public string Titulo
        {
            get
            {
                return TITULO;
            }
            set
            {
                TITULO = value;
            }
        }

        public int NumerodeEdidicion
        {
            get
            {
                return NumeroDeEdicion;
            }
            set
            {
                NumeroDeEdicion = value;
            }
        }

        public int Anopublicacion
        {
            get
            {
                return AÑOPUBLICACION;
            }
            set
            {
                AÑOPUBLICACION = value;
            }
        }
        public string Nombreautores
        {
            get
            {
                return NOMBREAUTORES;
            }
            set
            {
                NOMBREAUTORES = value;
            }
        }

        public string Paispublicacion
        {
            get
            {
                return PAISPUBLICACION;
            }
            set
            {
                PAISPUBLICACION = value;
            }
        }

        public string Sinopsis
        {
            get
            {
                return SINOPSIS;
            }
            set
            {
                SINOPSIS = value;
            }
        }
        public string Carrera
        {
            get
            {
                return CARRERA;
            }
            set
            {
                CARRERA = value;
            }
        }
        public string Materia
        {
            get
            {
                return MATERIA;
            }
            set
            {
                MATERIA = value;
            }
        }
    }
}