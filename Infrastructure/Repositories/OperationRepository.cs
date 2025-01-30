using Entities.Entities;
using Entities.Enums;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OperationRepository
    {
        private readonly PortalContext _context;

        public OperationRepository(PortalContext context)
        {
            _context = context;
        }

        public async Task<List<Operation>> GetOperationAsync() => await _context.Operation.ToListAsync();

        public async Task<Operation?> GetOperationByIdAsync(int ordem) => await _context.Operation.FindAsync(ordem);

        public async Task AddOperationAsync(Operation operation)
        {
            await _context.Operation.AddAsync(operation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOperationAsync(Guid operationId, Operation operation)
        {
            // Carrega a entidade existente do banco de dados
            var operacao = await _context.Operation.FindAsync(operationId);
            if (operacao == null)
            {
                throw new ArgumentException("Operation not found");
            }

            // Atualiza apenas o campo necessário
            operacao.Status = operation.Status;

            // Marca apenas o campo "Status" como modificado
            _context.Entry(operacao).Property(o => o.Status).IsModified = true;

            // Salva as alterações no banco de dados
            await _context.SaveChangesAsync();
        }

    }
}
