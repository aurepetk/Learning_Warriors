using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors.Weapons;

namespace Warriors
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminCenter adminCenter = new AdminCenter();
            adminCenter.SetAvailablePeopleForSrervice();
            adminCenter.CallToService();
            adminCenter.CheckForService();
        }
    }
}
