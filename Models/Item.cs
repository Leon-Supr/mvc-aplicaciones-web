using System.ComponentModel.DataAnnotations;

namespace proyectoNuevo.Models
{
    public class Item
    {
        public  int id {get; set;} //Como crear un metodo para get y set individuales
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(8, ErrorMessage = "Debe contener máximo 8 caracters")]
        
        public string name {get; set;}
        //[Required(ErrorMessage = "Este campo es requerido")]
        public string type {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]

        public int STR {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int AGI {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int INTE {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int MND {get; set;}
        [Range(-100,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int VIT {get; set;}
    }
}