using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Governo mySingleton2 = Governo.Eleicao;
            mySingleton2.DoSomething();
        }
    }

}

