using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Adapter_Pattern
{
    public class Adaptee
    {
        public string SpecificRequest()
        {
            return "{\"data\": \"This is JSON data\"}";
        }
    }
}
