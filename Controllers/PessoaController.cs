using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models;
using PrimeiroProjetoBanco.Repository.Interfaces;

namespace PrimeiroProjetoBanco.Controllers
{
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoa)
        {
            _pessoaRepository = pessoa;
        }

        [HttpGet("[action]")]
        public List<Pessoa> ObterTodasPessoas()
        {
            //return _pessoa.ObterTodasPessoasEF();
            return _pessoaRepository.ObterTodasPessoas();
        }

        [HttpPost("[action]")]
        public int InserirPessoa([FromBody] Pessoa pessoa)
        {
            return _pessoaRepository.InserirPessoa(pessoa);
        }
    }
}
