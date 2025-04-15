using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Curso
    {
        public Guid CursoId { get; set; }

        [Required(ErrorMessage = "A sigla do curso é obrigatório.")]
        [MaxLength(10, ErrorMessage = "A sigla do curso deve ter no máximo 10 caracteres.")]
        [MinLength(2, ErrorMessage = "A sigla do curso deve ter no mínimo 2 caracteres.")]
        public string? Sigla { get; set; }

        [Required(ErrorMessage = "A descrição do curso é obrigatório.")]
        [MaxLength(255, ErrorMessage = "A descrição do curso deve ter no máximo 255 caracteres.")]
        [MinLength(10, ErrorMessage = "A descrição do curso deve ter no mínimo 10 caracteres.")]
        public string? Descricao { get; set; }

    }
}
