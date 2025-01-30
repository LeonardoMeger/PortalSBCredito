using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IOperationRepository
    {
        Task AddAsync(Operation operation);
        Task<Operation> GetByIdAsync(Guid Id);
        Task UpdateAsync(Operation operation);
    }
}
