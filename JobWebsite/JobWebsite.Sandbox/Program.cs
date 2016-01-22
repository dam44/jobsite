using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobWebsite.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeTester tester = new InvokeTester();
            tester.TryInvoke(args[0]);
        }
    }
}
