using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourProcesses fourProcesses = new FourProcesses();
            fourProcesses.Total(5, 6);

            fourProcesses.Total(6, 9);
        }
    }
}
