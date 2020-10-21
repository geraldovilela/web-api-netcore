using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShelvesAndBooks.Models
{
    public class Shelve
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage= "Este Campo é Obrigatorio!")]
        [MaxLength(250, ErrorMessage="Esta Descrição permite até 250 caracteres apenas!")]
        [MinLength(3, ErrorMessage= "Esta Descrição necessita de pelo menos 3 caracteres!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatorio!")]
        [MaxLength(40, ErrorMessage = "Esta Descrição permite até 40 caracteres apenas!")]
        [MinLength(3, ErrorMessage = "Esta Descrição necessita de pelo menos 3 caracteres!")]
        public string Category { get; set; }

    }
}
