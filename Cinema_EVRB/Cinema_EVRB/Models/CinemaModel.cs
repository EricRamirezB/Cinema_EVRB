using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_EVRB.Models
{
    public class CinemaModel
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Genero { get; set; }
        public string Recomendacion { get; set; }
        public int Duracion { get; set; }
        public string Imagen { get; set; }
    }

    public class FuncionesModel
    {
        public int Id { get; set; }
        public string Cinema { get; set; }
        public DateTime Sala { get; set; }
        public string Ciudad { get; set; }
        public string Precio { get; set; }
    }


}
