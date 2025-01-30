using Aplication.DTO;
using Entities.Entities;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : Controller
    {

        private readonly OperationRepository _repository;

        public OperationController(OperationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetOperation()
        {
            var operation = await _repository.GetOperationAsync();
            return Ok(operation);
        }   

        [HttpPost]
        public async Task<IActionResult> AddOperation(Operation operation)
        {
            await _repository.AddOperationAsync(operation);
            return Ok(operation);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOperation(Operation operation )
        {

            await _repository.UpdateOperationAsync(operation.Id, operation);
            return Ok(operation);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
