using Entities.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Repositories;
namespace Infrastructure.Repositories
{
    public class TituloRepository
    {
        private readonly PortalContext _context;

        public TituloRepository(PortalContext context)
        {
            _context = context;
        }

        public async Task<List<Titulo>> GetTitulosAsync() => await _context.Titulo.ToListAsync();

        public async Task<Titulo?> GetTituloByIdAsync(Guid id) => await _context.Titulo.FindAsync(id);

        public async Task AddTituloAsync(Titulo titulo)
        {
            await _context.Titulo.AddAsync(titulo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTituloAsync(Guid id)
        {
            var titulo = await GetTituloByIdAsync(id);
            if (titulo != null)
            {
                _context.Titulo.Remove(titulo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<double> GetTotalValorAsync()
        {
            return await _context.Titulo.SumAsync(t => t.Value);
        }
    }
}
