using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_Final_Laboratorio_I
{
    internal class Vector
    {
        public struct RegistroGenero
        {
            public Int32 Codigo;
            public String Nombre;
            public String Descripcion;
        }
        public static RegistroGenero[] genero = new RegistroGenero[10];
        public static Int32 Indice = 0;
        public static String[] meses = new String[12] {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
        public static Int32[,] matriz = new Int32[10,12];
    }
}
