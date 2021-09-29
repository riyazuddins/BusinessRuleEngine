using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Service.Interface
{
    public interface IPaymentService
    {
        string ProcessOrder(string productType);

        
    }
}
