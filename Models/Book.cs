using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShelvesAndBooks.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo de um campo Obrigatorio")]
        [MaxLength(255, ErrorMessage = "Campo Titulo deve ter no maximo 255 caracteres.")]
        [MinLength(3, ErrorMessage = "Campo Titulo deve ter no minimo 3 caracateres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Categoria e um campo obrigatorio")]
        [MaxLength(60, ErrorMessage = "Campo Categoria deve ter no maximo 60 caracteres.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Categoria e um campo obrigatorio")]
        [MaxLength(60, ErrorMessage = "Campo Nome do Autor deve ter no maximo 60 caracteres.")]
        public string WriterName { get; set; }

        [MaxLength(1024, ErrorMessage = "Descrição pode conter até no maximo 1024 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Identificador da Prateleira não pode ser invalido.")]
        [Range(1, int.MaxValue, ErrorMessage = "ID Invalido")]
        public Shelve ShelveId { get; set; }


    }
}
