using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5_.Models
{
    public class Secreto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Valor_Moneda { get; set; }
        public string Fecha { get; set; }
        public string Lugar { get; set; }
        public string Lat_y_Long { get; set; }
        public int Usuario { get; set; }
    }
}
