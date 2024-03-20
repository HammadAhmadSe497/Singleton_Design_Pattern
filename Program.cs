// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Singleton.createinstance();
            Singleton.createinstance();
        }
    }
}