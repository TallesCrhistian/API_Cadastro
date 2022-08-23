using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Cadastro.Data;
using API_Cadastro.Models;
using AutoMapper;
using API_Cadastro.Data.Dtos.Pessoa;

namespace API_Cadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public PessoaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        {
          if (_context.Pessoas == null)
          {
              return NotFound();
          }
            return await _context.Pessoas.ToListAsync();
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            Pessoa pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);

            if (_context.Pessoas == null)
          {
              return NotFound();
          }
            var pessoas = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }
            ReadPessoaDto pessoaDto = _mapper.Map<ReadPessoaDto>(pessoa);

            return Ok(pessoaDto);
            
        }

        // PUT: api/Pessoa/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoa(int id, UpdatePessoaDto pessoaDto)
        {
            Pessoa pessoa = _context.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                _mapper.Map(pessoaDto, pessoa);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pessoa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(CreatePessoaDto pessoadto)
        {

            if (_context.Pessoas == null)
          {
              return Problem("Entity set 'AppDbContext.Pessoas'  is null.");
          }
            Pessoa pessoa = _mapper.Map<Pessoa>(pessoadto);
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoa", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            if (_context.Pessoas == null)
            {
                return NotFound();
            }
            var pessoa = await _context.Pessoas.FindAsync(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PessoaExists(int id)
        {
            return (_context.Pessoas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
