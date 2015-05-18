using Aiping.Condition.Interface;

namespace Aiping.Condition.Imp
{
    internal class ConditionCheckerOne : IConditionChecker
    {
        public bool IsValid(int orderId)
        {
            if (orderId > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}