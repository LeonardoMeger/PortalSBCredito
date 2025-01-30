using Entities.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TituloController : Controller
    {
        private readonly TituloRepository _repository;

        public TituloController(TituloRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTreasure()
        {
            var treasures = await _repository.GetTitulosAsync();
            return Ok(treasures);
        }

        [HttpPost]
        public async Task<IActionResult> AddTitulo(Titulo titulo)
        {
            await _repository.AddTituloAsync(titulo);
            return Ok(titulo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTreasures(Guid id)
        {
            await _repository.DeleteTituloAsync(id);
            return NoContent();
        }

        [HttpGet("total")]
        public async Task<IActionResult> GetTotalValor()
        {
            var total = await _repository.GetTotalValorAsync();
            return Ok(total);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
