using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Matricula
    {
        public Guid MatriculaId { get; set; }

        [Required(ErrorMessage = "A data da Matrícula é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Insira uma data válida.")]
        public DateOnly DataMatricula { get; set; }

        public Guid AlunoId { get; set; }
        public Guid TurmaId { get; set; }

        public Turma? Turma { get; set; }
        public Aluno? Aluno { get; set; }

    }
}
