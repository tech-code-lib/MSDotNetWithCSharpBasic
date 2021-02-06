using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    public class PremiumCustomer: BaseCustomer
    {
        public override int CalculateRewards()
        {
            //base.CalculateRewards();
            Random random = new Random();
            return random.Next(10000, 15000);
        }
    }
}
