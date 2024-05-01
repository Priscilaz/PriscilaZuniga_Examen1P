using System;

namespace PriscilaZuniga_Examen1P.Models
{
    public class PZClass
    {
        //Creacion de la Clase
        public int ID { get; set; }
        public int Edad { get; set; }
        public decimal PZ_Peso { get; set; }
        public string? PZ_Apodo { get; set; }
        public Boolean PZ_Activo { get; set; }
        public DateTime PZ_FechaNacimiento { get; set; }
    }
}
