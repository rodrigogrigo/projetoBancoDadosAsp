using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models;
using PrimeiroProjetoBanco.Models.Interfaces;

namespace PrimeiroProjetoBanco.Controllers
{
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoa _pessoa;
        private readonly AppDbContext _context;
        //private readonly IEndereco _endereco;

        public PessoaController(IPessoa pessoa, AppDbContext appDbContext)
        {
            _pessoa = pessoa;
            _context = appDbContext;
        }

        [HttpGet("[action]")]
        public List<Pessoa> ObterTodasPessoas()
        {
            //return _pessoa.ObterTodasPessoasEF();
            return _pessoa.ObterTodasPessoas();
        }

        [HttpPost("[action]")]
        public int InserirPessoa([FromBody] Pessoa pessoa)
        {
            return _pessoa.InserirPessoa(pessoa, _context);
        }
    }
}
