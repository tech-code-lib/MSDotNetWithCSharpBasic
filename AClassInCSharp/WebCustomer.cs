using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AClassInCSharp
{
    public class WebCustomer: BaseCustomer
    {
        public override int CalculateRewards()
        {
            Random random = new Random();
            return random.Next(5000, 10000);
        }
    }
}
