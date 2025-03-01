using System.ComponentModel.DataAnnotations;

namespace proyectoNuevo.Models
{
    public class Vehicle
    {
        public  int id {get; set;} //Como crear un metodo para get y set individuales
        [Required(ErrorMessage = "Este campo es requerido")]

        public string name {get; set;}
        [StringLength(20, ErrorMessage = "Debe contener máximo 20 caracters")] 
        public string brand {get; set;}
        [StringLength(20, ErrorMessage = "Debe contener máximo 20 caracters")]

        public int TOPSPEED {get; set;}
        [Range(-100,300, ErrorMessage = "El valor debe estar entre 1 y 300")]
        public int WIDTH {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int LENGTH {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int WEIGHT {get; set;}
    }
}