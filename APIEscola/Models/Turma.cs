using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data informada é inválida.")]
        [Required(ErrorMessage = "A data de Início da turma é obrigatório.")]
        public DateOnly DataInicio { get; set; }

        [DataType(DataType.Date, ErrorMessage = "A data informada é inválida.")]
        [Required(ErrorMessage = "A data de Fim da turma é obrigatório.")]
        public DateOnly DataFim { get; set; }

        [Required(ErrorMessage = "A descrição da turma é obrigatória")]
        [MaxLength(255, ErrorMessage = "A descrição da turma deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "A sigla da turma é obrigatória")]
        [MaxLength(10, ErrorMessage = "A sigla da turma deve ter no máximo 10 caracteres")]
        [MinLength(2, ErrorMessage = "A sigla da turma deve ter no mínimo 2 caracteres.")]
        public string? Sigla { get; set; }

        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }

    }
}
