using Entities.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ITituloRepository
    {
        Task AddAsync(Titulo titulo);
        Task DeleteAsync(Guid Id);
    }
}
