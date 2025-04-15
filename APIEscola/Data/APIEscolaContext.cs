using APIEscola.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIEscola.Data
{
    public class APIEscolaContext : IdentityDbContext
    {
        public APIEscolaContext(DbContextOptions<APIEscolaContext> options)
            : base(options)
        {
        }
        // Propriedade DbSet para cada tabela
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }



        //Sobrecarga do método OnModelCreating para configurar o modelo a partir da IdentityDbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Chama o método da classe base OnModelCreating para a criação das tabelas padrão
            base.OnModelCreating(modelBuilder);
            //
            // Configurações adicionais do modelo, se necessário
            modelBuilder.Entity<Aluno>().ToTable("Alunos"); // Define o nome da tabela no banco de dados
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<Turma>().ToTable("Turmas");
            modelBuilder.Entity<Matricula>().ToTable("Matriculas"); // Define o nome da tabela no banco de dados
            // Define o nome da tabela no banco de dados
            // Define o nome da tabela no banco de dados

        }
    }
}