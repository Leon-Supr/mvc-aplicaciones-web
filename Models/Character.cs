using System.ComponentModel.DataAnnotations;

namespace proyectoNuevo.Models
{
    public class Character
    {
        public  int id {get; set;} //Como crear un metodo para get y set individuales
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(20, ErrorMessage = "Debe contener máximo 20 caracters")]
        
        public string name {get; set;}
        
        public string type {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")] 

        public int HP {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int SPEED {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int ATTACK {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int DEFENSE {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int WEIGHT {get; set;}
    }
}