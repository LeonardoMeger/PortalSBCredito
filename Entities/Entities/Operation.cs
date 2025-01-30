using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Operation
    {
        public Operation()
        {
            Operations = new List<Operation>();
        }
        public Guid Id { get; set; }
        public int Ordem {  get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public OperationStatus Status { get; set; }

        public List<Operation> Operations;
    }
}
