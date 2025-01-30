using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public enum OperationStatus
    {
        Enviado = 1,
        InAnalysis = 2,
        ApprovedAnalysis = 3,
        AwaitingSignature = 4,
        Signed = 5,
        AwaitingPayment = 6,
        paid = 7
    }
}
