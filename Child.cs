using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Child
    {
        public void sum(int x, int y)
        {
            Console.WriteLine(x + y);
            //return x + y;
        }
        public void substract(int x, int y)
        {
            Console.WriteLine(x - y);
          
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine(x * y);
            
        }
        public void division(int x, int y)
        {
            Console.WriteLine(x - y);
           
        }
    }
}
