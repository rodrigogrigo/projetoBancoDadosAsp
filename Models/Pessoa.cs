using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PrimeiroProjetoBanco.Models
{
    [Table("Pessoa")]
    public class Pessoa : IPessoa
    {
        //private readonly AppDbContext _context;

        /*public Pessoa(AppDbContext context)
        {
            _context = context;
        }*/

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("referencia")]
        public string Referencia { get; set; }

        public List<Pessoa> ObterTodasPessoasEF()
        {
            return null;//_context.Pessoas.ToList();
        }

        public List<Pessoa> ObterTodasPessoas()
        {
            return null;//_context.Pessoas.
                //FromSqlRaw("SELECT * FROM Pessoa").ToList();
        }

        public int InserirPessoa(Pessoa pessoa, AppDbContext appDbContext)
        {
            appDbContext.Pessoas.Add(pessoa);
            appDbContext.SaveChanges();
            return pessoa.Id;
        }
    }
}
