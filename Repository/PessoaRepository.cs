using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models;
using PrimeiroProjetoBanco.Repository.Interfaces;

namespace PrimeiroProjetoBanco.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;

        public PessoaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Pessoa> ObterTodasPessoasEF()
        {
            return _context.Pessoas.ToList();
        }

        public List<Pessoa> ObterTodasPessoas()
        {
            return _context.Pessoas.
                        FromSqlRaw("SELECT * FROM Pessoa").ToList();
        }

        public int InserirPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
            return pessoa.Id;
        }
    }
}
