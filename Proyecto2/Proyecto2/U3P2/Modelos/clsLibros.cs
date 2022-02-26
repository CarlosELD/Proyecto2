using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U3P2.Modelos
{
    public class clsLibros
    {
        public int ID { get; set; }
        public int ISBN { get; set; }

        public String TITULO { get; set; }
        public int NOEDICION { get; set; }

        public int ANIOPUBLICACION { get; set; }
        public String AUTORES { get; set; }
        public String PAISDEPUBLICACION { get; set; }
        public String SINOPSIS { get; set; }
        public String CARRERA { get; set; }
        public String MATERIA { get; set; }

    }
}