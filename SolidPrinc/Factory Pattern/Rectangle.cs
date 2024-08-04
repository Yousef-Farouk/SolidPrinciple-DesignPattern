using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Factory_Pattern
{
    public class Rectangle : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
}
