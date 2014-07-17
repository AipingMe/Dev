using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aiping.Condition.Interface
{
    public interface IConditionChecker
    {
        bool IsValid(int orderId);
    }
}
