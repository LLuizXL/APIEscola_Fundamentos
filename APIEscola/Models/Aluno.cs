using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Aluno
    {
        public Guid AlunoId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "O nome do aluno é obrigatório.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 dígitos.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter apenas números.")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Email deve ser um endereço de email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é obrigatória.")]
        [DataType(DataType.Date, ErrorMessage = "A Data informada não é válida.")]
        public DateOnly DataNascimento { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O Celular deve conter apenas números.")]
        [Required(ErrorMessage = "O Celular é obrigatório.")]
        [StringLength(11, ErrorMessage = "O Celular deve ter 11 dígitos.")]
        public string? Telefone { get; set; }
        public Guid? UserId { get; set; }
        public IdentityUser? User { get; set; }


    }
}
